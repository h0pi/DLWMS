using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_2024_25.API.Data;
using RS1_2024_25.API.Data.Models.TenantSpecificTables.Modul2_Basic;
using RS1_2024_25.API.Helper;
using RS1_2024_25.API.Helper.Api;
using RS1_2024_25.API.Services;
using System.Runtime.CompilerServices;
using static RS1_2024_25.API.Endpoints.SemesterEndpoints.SemesterGetAllEndpoint;
using static RS1_2024_25.API.Endpoints.SemesterEndpoints.SemesterUpdateOrInsertEndpoint;

namespace RS1_2024_25.API.Endpoints.SemesterEndpoints
{
    [Route("students")]
    [MyAuthorization(isAdmin: true, isManager: false)]
    public class SemesterUpdateOrInsertEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
     .WithRequest<SemesterUpdateOrInsertRequest>
     .WithActionResult<int>
    {
        [HttpPost("{studentId}/semesters")]
        public override async Task<ActionResult<int>> HandleAsync([FromBody] SemesterUpdateOrInsertRequest request, CancellationToken cancellationToken = default)
        {
            var studentId = int.Parse(HttpContext.Request.RouteValues["studentId"]!.ToString()!);
            var authInfo = MyAuthServiceHelper.GetAuthInfoFromRequest(db, HttpContext.RequestServices.GetService<IHttpContextAccessor>()!);
            //bool isInsert = request.ID == null || request.ID == 0;

            //Semester? semester;

            //if (isInsert)
            //{
            //    semester = new Semester { };
            //    db.Add(semester);
            //}
            //else { 
            //    semester = await db.Semesters.SingleOrDefaultAsync(x=>x.ID == request.ID, cancellationToken);
            //    if(semester == null) return NotFound("Semester not found");
            //}

            //semester.AcademicYearId = request.AcademicYearId;
            //semester.StudyYear= request.StudyYear;
            //semester.EnrollmentDate = request.EnrollmentDate;
            //semester.RecordedById=authInfo.UserId;
            //semester.TenantId = authInfo.TenantId;
            //semester.StudentId=studentId;

            //var count = await db.Semesters.CountAsync(x => x.StudentId == studentId && x.StudyYear == semester.StudyYear, cancellationToken);
            //if (count == 1)
            //{
            //    semester.IsRenewal = true;
            //    semester.TuitionFee = 400;
            //}
            //else if (count >= 2)
            //{
            //    semester.IsRenewal = true;
            //    semester.TuitionFee = 500;
            //}
            //else
            //{
            //    semester.IsRenewal = false;
            //    semester.TuitionFee = 1800;
            //}

            //bool exists = db.Semesters.ToList().Exists(x => x.StudentId == studentId && x.AcademicYearId == request.AcademicYearId && !x.IsDeleted);
            //if (exists)
            //    throw new Exception("Akademska godina za studenta vec postoji!");

            //await db.SaveChangesAsync(cancellationToken);
            //return Ok(semester.ID);

            if (request.AcademicYearId <= 0 || request.StudyYear <= 0)
                return BadRequest("Neispravni podaci.");

            bool aYExists = await db.Semesters.AnyAsync(x => x.StudentId == studentId && x.AcademicYearId == request.AcademicYearId && !x.IsDeleted, cancellationToken);

            if (aYExists) return BadRequest("Akademska godina za studenta vec postoji.");

            var lastActiveSemester = await db.Semesters.Where(x => x.StudentId == studentId && !x.IsDeleted).OrderByDescending(x => x.EnrollmentDate).FirstOrDefaultAsync(cancellationToken);

            bool isRenewal = lastActiveSemester != null && lastActiveSemester.StudyYear == request.StudyYear;

            float tuitionFee;
            if (isRenewal)
            {
                var renewalCount = await db.Semesters.CountAsync(x => x.StudentId == studentId && x.StudyYear == request.StudyYear && !x.IsDeleted, cancellationToken);
                tuitionFee = renewalCount == 1 ? 400 : 500;
            }
            else tuitionFee = 1800;

            var semester = new Semester
            {
                StudentId = studentId,
                AcademicYearId = request.AcademicYearId,
                StudyYear = request.StudyYear,
                EnrollmentDate = request.EnrollmentDate,

                IsRenewal = isRenewal,
                TuitionFee = tuitionFee,

                RecordedById = authInfo.UserId,
                TenantId = authInfo.TenantId
            };

            db.Semesters.Add(semester);
            await db.SaveChangesAsync(cancellationToken);
            return Ok(semester.ID);
        }

        
        public class SemesterUpdateOrInsertRequest 
        {
            public int? ID { get; set; }
            public int AcademicYearId { get; set; }
            public int StudyYear { get; set; }
            public DateTime EnrollmentDate { get; set; }
        }

        
    }
}


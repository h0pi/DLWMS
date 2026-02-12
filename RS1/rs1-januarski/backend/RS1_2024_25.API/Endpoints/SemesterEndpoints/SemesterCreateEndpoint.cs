using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_2024_25.API.Data;
using RS1_2024_25.API.Data.Enums;
using RS1_2024_25.API.Data.Models.TenantSpecificTables.Modul2_Basic;
using RS1_2024_25.API.Helper.Api;
using RS1_2024_25.API.Services;
using static RS1_2024_25.API.Endpoints.StudentEndpoints.SemesterCreateEndpoint;
using static RS1_2024_25.API.Endpoints.StudentEndpoints.StudentUpdateOrInsertEndpoint;

namespace RS1_2024_25.API.Endpoints.StudentEndpoints;

[Route("students")]
[MyAuthorization(isAdmin: true, isManager: false)]
public class SemesterCreateEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<SemesterCreateRequest>
    .WithActionResult<int>
{
    [HttpPost("{studentId}/semesters")]  // Using POST to support both create and update
    public override async Task<ActionResult<int>> HandleAsync(
        [FromBody] SemesterCreateRequest request,
        CancellationToken cancellationToken = default)
    {
        var studentId = int.Parse(HttpContext.Request.RouteValues["studentId"]!.ToString()!);
        var authInfo = MyAuthServiceHelper.GetAuthInfoFromRequest(db, HttpContext.RequestServices.GetService<IHttpContextAccessor>()!);

        if (request.AcademicYearId <= 0 || request.StudyYear <= 0) return BadRequest("Neispravni podaci");

        var postojeciSemestar = await db.Semesters.FirstOrDefaultAsync(x => x.StudentId == studentId && x.AcademicYearId == request.AcademicYearId, cancellationToken);

        if (postojeciSemestar != null)
        {
            if (postojeciSemestar.isDeleted)
            {
                return BadRequest(new { error = "Akademska godina je obrisana, molimo koristite opciju RESTORE!" });
            }
            else
            {
                return BadRequest(new { error = "Akademska godina za studenta već postoji!" });
            }
        }


        var lastActiveSemester = await db.Semesters.Where(x=>x.StudentId==studentId && !x.isDeleted).OrderByDescending(x=>x.EnrollmentDate).FirstOrDefaultAsync(cancellationToken);

        bool isRenewal = lastActiveSemester != null &&lastActiveSemester.StudyYear==request.StudyYear;

        float tuitionFee;

        if (isRenewal)
        {
            var renewalCount = await db.Semesters.CountAsync(x => x.StudentId == studentId && x.StudyYear == request.StudyYear && !x.isDeleted, cancellationToken);
            tuitionFee = renewalCount == 1 ? 400 : 500;
        }
        else tuitionFee = 1800;

        var semester = new Semester
        {
            StudentId = studentId,
            AcademicYearId = request.AcademicYearId,
            StudyYear = request.StudyYear,
            EnrollmentDate = request.EnrollmentDate,

            isRenewal = isRenewal,
            TuitionFee = tuitionFee,

            RecordedById = authInfo.UserId,
            TenantId = authInfo.TenantId
        };
        db.Semesters.Add(semester);
        await db.SaveChangesAsync(cancellationToken);
        return Ok(semester.ID); 
    }

    public class SemesterCreateRequest
    {
        public int AcademicYearId { get; set; }
        public int StudyYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}

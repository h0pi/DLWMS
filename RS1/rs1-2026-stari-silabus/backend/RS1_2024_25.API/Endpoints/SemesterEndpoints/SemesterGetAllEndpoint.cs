using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_2024_25.API.Data;
using RS1_2024_25.API.Helper;
using RS1_2024_25.API.Helper.Api;
using RS1_2024_25.API.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static RS1_2024_25.API.Endpoints.SemesterEndpoints.SemesterGetAllEndpoint;

namespace RS1_2024_25.API.Endpoints.SemesterEndpoints
{
    [Route("students")]
    [MyAuthorization(isAdmin: true, isManager: false)]
    public class SemesterGetAllEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
     .WithRequest<SemesterGetAllRequest>
     .WithResult<MyPagedList<SemesterGetAllResponse>>
    {
        [HttpGet("{studentId}/semesters/filter")]
        public override async Task<MyPagedList<SemesterGetAllResponse>> HandleAsync([FromQuery] SemesterGetAllRequest request, CancellationToken cancellationToken = default)
        {
            var studentId = int.Parse(HttpContext.Request.RouteValues["studentId"]!.ToString()!);
            

            var query = db.Semesters
                .Include(p => p.AcademicYear)
                .IgnoreQueryFilters()
                .Where(x => x.StudentId == studentId);

            if (request.Status == "active")
            {
                query = query.Where(x => !x.IsDeleted);
            }
            else if (request.Status == "deleted")
            {
                query = query.Where(x => x.IsDeleted);
            }
            var projected = query.Select(p => new SemesterGetAllResponse
            {
                ID = p.ID,
                AcademicYearDesc = p.AcademicYear.Description,
                StudyYear = p.StudyYear,
                EnrollmentDate = p.EnrollmentDate,
                IsRenewal = p.IsRenewal,
                TuitionFee = p.TuitionFee,
                IsDeleted = p.IsDeleted,
            });
            if (!string.IsNullOrEmpty(request.Q))
            {
                projected = projected.Where(u => u.AcademicYearDesc.Contains(request.Q));
            }

                var result = await MyPagedList<SemesterGetAllResponse>.CreateAsync(projected, request, cancellationToken);

            return result;
        }

        // DTO za zahtjev s podrškom za paginaciju i filtriranje
        public class SemesterGetAllRequest : MyPagedRequest
        {
            public string? Q { get; set; } = string.Empty; // Tekstualni upit za pretragu
            public string? Status { get; set; }
        }

        // DTO za odgovor
        public class SemesterGetAllResponse
        {
            public required int ID { get; set; }
            public string AcademicYearDesc { get; set; }
            public int StudyYear { get; set; }
            public DateTime EnrollmentDate { get; set; }
            public float TuitionFee { get; set; }
            public bool IsRenewal { get; set; }
            public bool IsDeleted { get; set; }
        }
    }
}
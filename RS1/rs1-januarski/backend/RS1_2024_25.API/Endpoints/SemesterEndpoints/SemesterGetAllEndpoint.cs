using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_2024_25.API.Data;
using RS1_2024_25.API.Data.Models.SharedTables;
using RS1_2024_25.API.Helper;
using RS1_2024_25.API.Helper.Api;
using RS1_2024_25.API.Services;
using static RS1_2024_25.API.Endpoints.StudentEndpoints.SemesterGetAllEndpoint;
using static RS1_2024_25.API.Endpoints.StudentEndpoints.StudentGetAllEndpoint;
using static System.Net.Mime.MediaTypeNames;

namespace RS1_2024_25.API.Endpoints.StudentEndpoints;

// Endpoint za vraćanje liste studenata s filtriranjem i paginacijom
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
        // Osnovni upit za studente
        var query = db.Semesters.Include(x=>x.AcademicYear).IgnoreQueryFilters()
                   .Where(s => s.StudentId==studentId)
                   .AsQueryable();

        if (request.status == "active")
        {
            query=query.Where(x=>!x.isDeleted);
        }else if (request.status == "deleted")
        {
            query = query.Where(x => x.isDeleted);
        }

            // Projektovanje u DTO tip za rezultat
            var projectedQuery = query.Select(s => new SemesterGetAllResponse
            {
                id = s.ID,
                academicYearDesc=s.AcademicYear.Description,
                studyYear=s.StudyYear,
                EnrollmentDate=s.EnrollmentDate,
                isRenewal=s.isRenewal,
                TuitionFee=s.TuitionFee,
                isDeleted=s.isDeleted,
            });

        if (!string.IsNullOrEmpty(request.Q))
        {
            projectedQuery = projectedQuery.Where(x => x.academicYearDesc.Contains(request.Q));
        }
        // Kreiranje paginiranog rezultata
        var result = await MyPagedList<SemesterGetAllResponse>.CreateAsync(projectedQuery, request, cancellationToken);

        return result;
    }

    // DTO za zahtjev s podrškom za paginaciju i filtriranje
    public class SemesterGetAllRequest : MyPagedRequest
    {
        public string? Q { get; set; } = string.Empty; // Tekstualni upit za pretragu
        public string? status { get; set; }  
    }

    // DTO za odgovor
    public class SemesterGetAllResponse
    {
        public required int id { get; set; }
        public string? academicYearDesc { get; set; }
        public int studyYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool isRenewal { get; set; }
        public float TuitionFee { get; set; }
        public bool isDeleted { get; set; }
    }
}

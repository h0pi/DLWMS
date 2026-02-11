using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_2024_25.API.Data;
using RS1_2024_25.API.Helper.Api;
using RS1_2024_25.API.Services;

namespace RS1_2024_25.API.Endpoints.SemesterEndpoints
{
    [MyAuthorization(isAdmin: true, isManager: false)]
    [Route("students-semesters")]
    public class SmesterDeleteEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<int>
    .WithoutResult
    {
        [HttpDelete("{id}")]
        public override async Task HandleAsync(int id, CancellationToken cancellationToken = default)
        {
            var smester = await db.Semesters.SingleOrDefaultAsync(x => x.ID == id, cancellationToken);

            if (smester == null)
                throw new KeyNotFoundException("Smester not found");

            if (smester.IsDeleted)
                throw new Exception("Smester is already deleted");

            // Soft-delete
            smester.IsDeleted = true;
            await db.SaveChangesAsync(cancellationToken);
        }
    }
}

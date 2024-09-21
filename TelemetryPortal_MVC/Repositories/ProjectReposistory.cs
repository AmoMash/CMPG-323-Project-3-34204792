using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, ProjectRepositoryInterface
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }
    }
}
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientRepository : GenericRepository<Client>, ClientRepositoryInterface
    {
        public ClientRepository(TechtrendsContext context) : base(context)
        {
        }
    }
}
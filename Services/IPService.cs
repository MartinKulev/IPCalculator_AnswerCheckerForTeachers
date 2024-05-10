using IPTestFormASP.Data;
using IPTestFormASP.Models.Entities;
using System.Linq;
using System.Text;

namespace IPTestFormASPTeacherApp.Services
{
    public class IPService
    {
        private IPTestFormASPDbContext context;

        public IPService(IPTestFormASPDbContext context)
        {
            this.context = context;
        }

        public List<IPInfos> GetAllTests()
        {
            return context.IPInfos.OrderByDescending(p => p.ID).ToList();
        }

        public IPInfos GetTestByID(int id)
        {
            IPInfos ipInfos = context.IPInfos.First(p => p.ID == id);
            return ipInfos;
        }
    }
}

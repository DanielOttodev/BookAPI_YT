using BookAPI_YT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_YT.Repositories
{
    public class AmlAlertsRepository : IAmlAlertsRepository
    {
            
        private readonly BookContext _context;

        public AmlAlertsRepository(BookContext context)
        {
            _context = context;
        }
        public async Task<AmlAlerts> GetAlerts(int id)
        {
            
            return await _context.AmlAlerts.FindAsync(id);

        }
    }
}

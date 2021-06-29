using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI_YT.Models;
namespace BookAPI_YT.Repositories
{
    public interface IAmlAlertsRepository
    {
        Task<AmlAlerts> GetAlerts(String client);
    }
}

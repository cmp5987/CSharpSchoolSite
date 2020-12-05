using Project3.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project3.Services
{
    public interface IGetFaculty
    {
        Task<List<Faculty>> GetAllFaculty();
    }
}
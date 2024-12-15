using EmployeeCRUDApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // For List<>
using System.Threading.Tasks;     // For Task<>


namespace EmployeeCRUDApp.Services
{
    public class PositionService
    {
        private readonly AppDbContext _context;

        public PositionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Position>> GetPositionsAsync()
        {
            return await _context.Positions.ToListAsync();
        }
    }
}

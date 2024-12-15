using EmployeeCRUDApp.Data; // Ensure this is the correct namespace for 'Program'
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeCRUDApp.Services
{
    public class ProgramService
    {
        private readonly AppDbContext _context;

        // Ensure the constructor is public
        public ProgramService(AppDbContext context)
        {
            _context = context;
        }

        // Ensure the method is public and it returns the correct Task<List<Program>>
        public async Task<List<Data.Program>> GetProgramsAsync()  // Make sure it's using Data.Program
        {
            return await _context.Programs.ToListAsync();  // Fetch from _context.Programs (which is DbSet<Program>)
        }
    }
}

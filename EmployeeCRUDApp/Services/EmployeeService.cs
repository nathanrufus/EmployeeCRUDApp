using EmployeeCRUDApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // For List<>
using System.Threading.Tasks;     // For Task<>

namespace EmployeeCRUDApp.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        // Retrieve all employees with related Position and Program
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees
                .Include(e => e.Position)
                .Include(e => e.Program)
                .ToListAsync();
        }

        // Retrieve a single employee by ID (for editing)
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.EmployeeID == id);
        }


        // Add a new employee
        public async Task AddEmployeeAsync(Employee employee)
        {
            // Avoid tracking conflicts for Position and Program
            employee.Position = null;
            employee.Program = null;

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        // Update an existing employee
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.EmployeeID);

            if (existingEmployee != null)
            {
                // Update fields explicitly
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.PositionID = employee.PositionID;
                existingEmployee.ProgramID = employee.ProgramID;

                await _context.SaveChangesAsync();
            }
        }

        // Delete an employee by ID
        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
    }
}

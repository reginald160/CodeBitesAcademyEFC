using CodeBitesAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitesAcademyEFC.Service
{
    public class EmployeeRepository : IEmployee
    {
        private readonly DataContext _context ;

        /*   public EmployeeRepository(DataContext context) =>  _context = context*/
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        /* public IEnumerable<EmployeeModel> Employee => return _context.EmployeeTable; the Table in the datacontext has been exposed*/

        public IEnumerable<EmployeeModel> Employee
        {
            get
            {
                return _context.EmployeeTable;
            }
          
        }

      
    public  void AddEmployee (EmployeeModel employee)
        {
            _context.EmployeeTable.Add(employee);
            _context.SaveChanges();
           
        }


        public EmployeeModel Delete(int Id)
        {
            EmployeeModel employee = _context.EmployeeTable.Find(Id);

            if (employee != null)
            {
                _context.EmployeeTable.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }

        public EmployeeModel GetEmployee(int Id)
        {
            return _context.EmployeeTable.Find(Id);
        }
    }
}

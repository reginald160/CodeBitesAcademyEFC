using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitesAcademyEFC.Models;

namespace CodeBitesAcademyEFC.Service
{
   public   interface IEmployee
    {
      public  IEnumerable<EmployeeModel> Employee { get; }
        public void AddEmployee(EmployeeModel employee);

       public EmployeeModel Delete (int id);

        EmployeeModel GetEmployee(int Id);

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TDD_project.Employee;

namespace TDD_project
{
    class EmployeeList
    {
        public List<Employee> empList;  

        public EmployeeList()
        {
            empList = new List<Employee>();
        }


        public void addToList(Employee emp) {empList.Add(emp);}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_project
{
    class Employee
    {
        //fields
        private String firstName, lastName, id, address, email, phone;
        private int salary;
        public static Random rand = new Random(DateTime.Now.Second);

        //test
        String[] fArr = { "aaa", "bbb", "ccc", "ddd", "eee", "fff" };
        String[] lArr = { "zzz", "yyy", "xxx", "www", "vvv", "uuu" };

        //Ctors
        public Employee(string id, string firstName, string lastName, string email, string address, string phone, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.salary = salary;
        }
        
        public Employee()   //empty constructor  will add random elements.
        {
            this.id = rand.Next(100000000,999999999).ToString();
            this.firstName = fArr[rand.Next(6)];
            this.lastName = lArr[rand.Next(6)];
            this.email = "tester@test.com";
            this.address = "test address";
            this.phone = "05" + rand.Next(30000000, 69999999).ToString(); ;
            this.salary = rand.Next(30000, 50000);
        }


    }
}

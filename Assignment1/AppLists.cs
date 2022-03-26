using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class AppLists
    {
        public List<Employee> EmpList { get; set; }
        public List<Payroll> PayList { get; set; }
        public List<VacationDays> VacList { get; set; }

        public AppLists() 
        {
            EmpList = new List<Employee>() { new Employee(1, "John", "123 street", "j@gmail.com", 123456789,"Labour" ),
                                             new Employee(2, "Mike", "876 street", "m@gmail.com", 123456789,"Manager" ),
                                             new Employee(3, "Dive", "455 street", "d@gmail.com", 123456789,"Labour" ),
                                             new Employee(4, "Smith","763 street", "sj@gmail.com", 123456789,"Labour" ),
                                             new Employee(5, "Jack", "825 street", "j@gmail.com", 123456789,"Admin" ),
        };
            PayList = new List<Payroll>() { new Payroll(1,10, 40, 20,"2021-05-22"),
                                            new Payroll(1,10, 40, 20,"2021-05-22"),
                                            new Payroll(2,20, 40, 30,"2021-05-30"),
                                            new Payroll(3,10, 40, 40,"2021-05-11"),
                                            new Payroll(4,10, 40, 20,"2021-05-20")
            };
            VacList = new List<VacationDays>();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1 
{
    class VacationDays 
    {
        
        public int NumberOfDays { get; set; }
        public int EmployeeID { get; set; }
        public int ID { get; set; }

        public VacationDays() { }
        /*
        public VacationDays(int id, string name, string address, string email, int phone, string roll, int employeeID, double hoursWorked, double hourlyRate, string date, int numberOfDays) : base(id, name, address, email, phone, roll, employeeID, hoursWorked, hourlyRate, date)
        {
            NumberOfDays = numberOfDays;
        }
        
       */
            public override string ToString()
        {
            return $" ID: {ID}" + "  "
                + $"Employee ID: {EmployeeID}" + "  "+
                 $"Number of days: {NumberOfDays}" 
                ;
        }
    }
}

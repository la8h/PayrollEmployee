using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Payroll 
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Date{ get; set; }
        /*
        public Payroll(int id, string name, string address, string email, int phone, string roll, int employeeID, double hoursWorked, double hourlyRate, string date) : base(id, name, address, email, phone, roll)
        {
            EmployeeID = employeeID;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            Date = date;
        }
        */
       public Payroll() { }
        public Payroll(int id, int employeeID, double hoursWorked, double hourlyRate, string date)
        {
            ID = id;
            EmployeeID = employeeID;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            Date = date;
        }
        public override string ToString()
        {
            return $" ID: {ID}" + "  "
                + $"Employee ID: {EmployeeID}" +"  " +
                $"Hours Worked: {HoursWorked}" +"  " +
                $"Hourly Rate: {HourlyRate:C}" + "  " +
                $"Date: {Date}"
                ;
        }

    }
}

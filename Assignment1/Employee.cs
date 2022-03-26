using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Employee
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Roll { get; set; }
        public Employee() 
        { }
        public Employee(int id, string name, string address, string email, int phone, string roll)
        {
            ID = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Roll = roll;
        }
     //   List<Employee> empList = new List<Employee>();
        public override string ToString()
        {
            return $"ID: {ID}  " +
                $"Name: {Name}  " +
                $"Address: {Address}  " +
                $"Email: {Email}  " +
                 $"Phone: {Phone}  " +
                $"Roll: {Roll}"
                ; 
        }


    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace Assignment1
{
    class Program
    {
       
        private static readonly string enterChoice;
        private static string choiceOne;
        private static string choiceTwo;
        private static string choiceThree;
        private static string printEmp;
  //      private static Employee emp;
        
      
        static void Main(string[] args)
        {

            AppLists applists = new AppLists() ;

            while (enterChoice != "4" || choiceOne != "5" || choiceTwo != "3" || choiceThree != "3")
            {

                int id = 0;
                string name = "";
                string address = "";
                string email = "";
                int phone = 0;
                string roll = "";
                int employeeID = 0;
                double hoursWorked = 0;
                double hourlyRate = 0;
                string date = "";
             //   int numberOfDays = 0;
                string choiceOne;
                string choiceTwo;
                string choiceThree;
               
                Console.WriteLine("Welcome, please choose a command:");
                Console.WriteLine("Press 1 to modify employees");
                Console.WriteLine("Press 2 to add payroll");
                Console.WriteLine("Press 3 to view vacation days");
                Console.WriteLine("Press 4 to exit program");
                string enterChoice = Console.ReadLine();

                switch (enterChoice)
                {
                    case "1":
                        Console.WriteLine("Press 1 to list all employees");
                        Console.WriteLine("Press 2 to add new employee");
                        Console.WriteLine("Press 3 to update an employee");
                        Console.WriteLine("Press 4 to delete an employee");
                        Console.WriteLine("Press 5 to return to main menu");
                        choiceOne = Console.ReadLine();
                        switch (choiceOne)
                        {
                            case "1":
                                Console.WriteLine("Employee list:");
                                

                                var insertEmp = from emp in applists.EmpList
                                                select emp;
                                foreach (var item in insertEmp)
                                {
                                    Console.WriteLine(item);
                                }

                                break;
                            case "2":
                                do
                                {
                                    Console.WriteLine("Enter employee id:");
                                    id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter employee name:");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Enter employee address:");
                                    address = Console.ReadLine();
                                    Console.WriteLine("Enter employee email:");
                                    email = Console.ReadLine();
                                    Console.WriteLine("Enter employee phone:");
                                    phone = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter employee roll:");
                                    roll = Console.ReadLine();
                                    Employee emp = new Employee(id, name, address, email, phone, roll);
                                    applists.EmpList.Add(emp);
                               
                                     printEmployeeList(applists);
                                   
                                    Console.WriteLine("if you want to add another employee, print y, otherwise press any .");
                                    string printEmp = Console.ReadLine();
                                } while (printEmp == "y");
                                    
                                break;
                            case "3":
                                Console.WriteLine("Update Employee:");
                                Console.WriteLine("Enter employee ID to be updated:");
                               int empUpdate = int.Parse(Console.ReadLine());

                                var empNum = from emp in applists.EmpList
                                             where emp.ID == empUpdate
                                             select emp;
                                foreach (var item in empNum)
                                {
                                    Console.WriteLine(item);
                                }
                                
                                Console.WriteLine("Enter updated data:");
                                Console.WriteLine("Enter employee id:");
                                id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter employee name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter employee address:");
                                address = Console.ReadLine();
                                Console.WriteLine("Enter employee email:");
                                email = Console.ReadLine();
                                Console.WriteLine("Enter employee phone:");
                                phone = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter employee roll:");
                                roll = Console.ReadLine();
                             
                           
                                foreach (var item in empNum)
                                {
                                    item.ID = id;
                                    item.Name = name;
                                    item.Address = address;
                                    item.Email = email;
                                    item.Phone = phone;
                                    item.Roll = roll;

                                }
                                Console.WriteLine("After updated:");

                                var empNumUpdated = from emp in applists.EmpList
                                             where emp.ID == empUpdate
                                             select emp;
                                foreach (var item in empNumUpdated)
                                {
                                    Console.WriteLine(item);
                                }  

                                break;
                            case "4":
                                Console.WriteLine("Delete Employee:");
                                Console.WriteLine("Enter the id of the emplyee to be deleted:");
                                int  empDel= int.Parse(Console.ReadLine());

                                var deleteEmp = from emp in applists.EmpList
                                                where emp.ID != empDel
                                                select emp;
                            


                                foreach (var item in deleteEmp)
                                {
                                    Console.WriteLine(item);
                                }   
                                
                       
                                break;
                            default:
                                Console.WriteLine("");
                                break;

                        }


                        break;

                    case "2":

                        Console.WriteLine("Press 1 to insert new payroll entry");
                        Console.WriteLine("Press 2 to veiw payroll history for an employee");
                        Console.WriteLine("Press 3 to return to main menu");
                        choiceTwo = Console.ReadLine();
                        switch (choiceTwo)
                        {
                            case "1":
                                Console.WriteLine("Enter  id:");
                                id = int.Parse(Console.ReadLine());
                               
                                Console.WriteLine("Enter employee id:");
                                employeeID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Hours worked:");
                                hoursWorked = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Hourly rate:");
                                hourlyRate = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Date:");
                                date = Console.ReadLine();

                                

                                Payroll payRoll = new Payroll(id, employeeID, hoursWorked, hourlyRate, date);
                            
                           
                                applists.PayList.Add(payRoll);
                                printRollList(applists);
                                break;
                            case "2":
                                Console.WriteLine("Payroll History:");

                                var insertPayRoll = from emp in applists.PayList
                                                select emp;
                                foreach (var item in insertPayRoll)
                                {
                                    Console.WriteLine(item);
                                }
                             
                           
                                break;
                            case "3":
                                break;

                        }
                        break;
                    case "3":

                        Console.WriteLine("Press 1 to view vacation days");
                    
                        Console.WriteLine("Press 2 to return to the main menu");
                        choiceThree = Console.ReadLine();
                        switch (choiceThree)
                        {
                            case "1":
                                Console.WriteLine("Enter Employee's ID to see vacation day to employee :");
                               int empId = int.Parse(Console.ReadLine());
                                var payRollNum = from emp in applists.PayList
                                                 where emp.ID == empId
                                                 select emp;

                                foreach (var item in payRollNum)
                                {
                                    Console.WriteLine(item);
                                }
                                var empNum = from emp in applists.EmpList
                                select emp;
                                int empN =   empNum.Count() * 14 ;
                                int payRollNo = payRollNum.Count() ;
                                int sum = empN + payRollNo;
                                Console.WriteLine($"The number of vacation dayes to the employee that has ID number {empId} is {sum}");
                                
                                break;
                            case "2":
                                break;
                            default:
                                Console.WriteLine("Please enter number 1 or 2");
                                break;
                        }
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter one of these numbers 1,2,3, or 4");
                        break;
                }

                   void printEmployeeList(AppLists applists)
                {
                    foreach (var item in applists.EmpList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                void printRollList(AppLists applists)
                {
                    foreach (var item1 in applists.PayList)
                    {
                        Console.WriteLine(item1.ToString());
                    }
                }
            }

        }
        }
    }


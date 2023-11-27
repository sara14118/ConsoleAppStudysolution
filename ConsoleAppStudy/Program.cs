

using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ConsoleAppStudy
{
    internal class Program
    {
        static void Main()
        {

            // في الستاك تخزن الأوبجكت وفي الهيب تخزن الفاليو تبع الأوبجكت 


            //const double TAX = 0.03;

            //object syntax ;
            // Decleration  ----->  <Type>  <objectName> ;
            // Assignment  ------>  <ObjectName>  = new <Type>();
            //initialization ---->  <Type> <ObjectName> = new <Type>();



            Employee[] emps = new Employee[2];

            Console.WriteLine("First Employee");

            Employee e1 = new Employee();

            Console.Write("first name :");
            e1.fname = Console.ReadLine();

            Console.Write("last name : ");
            e1.lname = Console.ReadLine();

            Console.Write("wage : ");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("logged hour : ");
            e1.loggedhours = Convert.ToDouble(Console.ReadLine());


            emps[0] = e1;


            //var netsalary = e1.wage * e1.loggedhours - (e1.wage * e1.loggedhours * Employee.TAX );

            //Console.WriteLine($"first name : {e1.fname}");
            //Console.WriteLine($"last name : {e1.lname}");
            //Console.WriteLine($"wage name : {e1.wage}");
            //Console.WriteLine($"loggedhours : {e1.loggedhours}");
            //Console.WriteLine($"net salary  : {netsalary}");





            // second employee 
            Console.WriteLine("second Employee");

            Employee e2 = new Employee();

            Console.Write("first name :");
            e2.fname = Console.ReadLine();

            Console.Write("last name : ");
            e2.lname = Console.ReadLine();

            Console.Write("wage : ");
            e2.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("logged hour : ");
            e2.loggedhours = Convert.ToDouble(Console.ReadLine());


            emps[1] = e2;

            foreach(var emp in emps)
            {
                var netsalary = emp.wage * emp.loggedhours - (emp.wage * emp.loggedhours * Employee.TAX);

                Console.WriteLine($"first name : {emp.fname}");
                Console.WriteLine($"last name : {emp.lname}");
                Console.WriteLine($"wage  : {emp.wage}");
                Console.WriteLine($"loggedhours : {emp.loggedhours}");
                Console.WriteLine($"net salary  : {netsalary}");

            }


            //var netsalary2 = e2.wage * e2.loggedhours - (e2.wage * e2.loggedhours *Employee.TAX);

            //Console.WriteLine($"first name : {e2.fname}");
            //Console.WriteLine($"last name : {e2.lname}");
            //Console.WriteLine($"wage name : {e2.wage}");
            //Console.WriteLine($"loggedhours : {e2.loggedhours}");
            //Console.WriteLine($"net salary  : {netsalary2}");
        }


            
        }
    }

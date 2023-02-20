using System;

namespace OOPDemo
{
    public class Employee
    { //Data, Properties, Attributes means info being held by the class
        protected string surname;
        protected string firstName;
        protected string NI;
        protected int hours;
        protected double rateOfPay;

        //Methods, behavious (every method has brackets after it)
        public Employee(string fname, string sname, string ni, int hrs, double rop) //Constructor method
        {
            Console.WriteLine("Creating an object of the class Employee");
            surname = sname;
            firstName = fname;
            NI = ni;
            hours= hrs;
            rateOfPay= rop;
        }
        public double calcPay()
        {
            double totalPay;
            totalPay = hours * rateOfPay;
            return (totalPay);
        }

        public void displayEmployee()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(surname);
            Console.WriteLine(rateOfPay);
            Console.WriteLine(hours);
        }
        public void set_hours(int Hours)
        {
            if ((Hours < 0) | (Hours > 48))
            { hours = 35; } //deault vaule
            else
                hours = Hours;
        }
        public int get_hours()
        {
            return hours;
        }
    } //end of Employee Class

    public class Salesperson: Employee
    {
        private double commission;

        public Salesperson(string fname, string sname, string ni, int hrs, double rop, double com): base(fname, sname, ni, hrs, rop)
        { 
            commission=com;
        }
        public double calcPay()
        {
            double totalPay;
            totalPay = get_hours() * rateOfPay + commission;
            return (totalPay);
        }
        public void displayEmployee()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(surname);
            Console.WriteLine(rateOfPay);
            Console.WriteLine(hours);
            Console.WriteLine(commission);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            /* double payOfEmployee;
             Console.WriteLine("Creating the first employee");
             Employee emp1 = new Employee();
             Console.WriteLine("First name?");
             emp1.firstName = Console.ReadLine();
             Console.WriteLine("Surname?");
             emp1.surname = Console.ReadLine();
             Console.WriteLine("Hours?");
             emp1.hours = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Rate of Pay?");
             emp1.rateOfPay = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(emp1.firstName + " " + emp1.surname + " has worked " + emp1.hours);

             Console.WriteLine(emp1.firstName + " " + emp1.surname + " is paid £" + emp1.calcPay());
             emp1.displayEmployee();

            string Fname;
            string Sname;
            int Hours;
            string NatIns;
            double Rate;

            Console.WriteLine("First Name?");
            Fname = Console.ReadLine();
            Sname = Console.ReadLine();
            Hours = 15;
            NatIns = "NUMBERSANDLETTERS";
            Rate = 12.50;
            Employee emp1= new Employee(Fname, Sname, NatIns, Hours, Rate);
            Employee emp2 = new Employee("Joe", "Ahmed", "WJFISJIFS", 25, 15.50);
            emp1.displayEmployee();
            Console.WriteLine("Hours changed. Input new hours");
            emp1.set_hours(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("New hours "+emp1.get_hours());
            Console.WriteLine ("Pay =" + emp1.calcPay());
            emp2.displayEmployee();
            Console.WriteLine ("Pay =" +emp2.calcPay());

            Salesperson sales1 = new Salesperson("Charlie", "Kelly", "ugdfugduujn", 12, 10.10, 200);
            sales1.displayEmployee();*/

            List<Employee> listOfEployees = new List<Employee>();
            Employee emp1 = new Employee("Ahmed", "Khan","Complete gibberish", 20, 12.50);
            listOfEployees.Add(emp1);
            Employee emp2 = new Employee("Sue", "Smith", "More gibberish", 10, 12.00);
            listOfEployees.Add(emp2);
            Employee emp3 = new Employee("Bobby", "Hill", "\"That boy ain't right\"", 10, 13.50);
            listOfEployees.Add(emp3);

            foreach (Employee emp in listOfEployees)
            {
                Console.WriteLine("*************************");
                emp.displayEmployee();
            }
        }
    }
}
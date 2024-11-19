namespace Opplab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Omar Mohamed Elsisi";
            emp.Id = 1;
            emp.Phone = "01064819492";
            emp.Salary = 7000;
            emp.Address = "Cairo";
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);
            emp.IncreaseSalary(1200);
            Console.WriteLine(emp.Salary);
            emp.Display();
            Employee[] EmpArr=new Employee[3] ;
            EmpArr[0] = new Employee();
            EmpArr[1] = new Employee();
            EmpArr[2] = new Employee(); EmpArr[0] = new Employee();
            EmpArr[1] = new Employee();
            EmpArr[2] = new Employee();
            EmpArr[0].Name = "ahmed ali";
            EmpArr[0].Id = 2;
            EmpArr[0].Phone = "01067130897";
            EmpArr[0].Salary = 8500;
            EmpArr[0].Address = "Benha";
            EmpArr[1].Name = "Mohamed Ehab ";
            EmpArr[1].Id = 3;
            EmpArr[1].Phone = "01009642294";
            EmpArr[1].Salary = 9000;
            EmpArr[1].Address = "Alex";
            EmpArr[2].Name = "ebrahim Ehab";
            EmpArr[2].Id = 4;
            EmpArr[2].Phone = "01102204916";
            EmpArr[2].Salary = 10000;
            EmpArr[2].Address = "Tanta";
            foreach(Employee empl in EmpArr)
            {
                empl.Display();
            }
        }
    }
}

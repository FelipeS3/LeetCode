namespace EmpSys
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var employees = new List<Employee>
                {
                    new FullTimeEmployee(1, "João", "IT", 5000.0m),
                    new PartTimeEmployee(2, "Maria", "Sales", 20.0m, 60),
                    new FullTimeEmployee(3, "Pedro", "HR", 4000.0m)
                };

                int fullTimeEmployeeCount = PayrollAnalyzer.CountFullTimeEmployees(employees);
                decimal highestSalary = PayrollAnalyzer.FindHighestSalary(employees);
                decimal fullTimeSalarySum = PayrollAnalyzer.SumFullTimeSalaries(employees);

                Console.WriteLine($"Highest salary among all employees: {highestSalary}");
                Console.WriteLine($"Total salary of full-time employees: {fullTimeSalarySum}");
                Console.WriteLine($"Number of full-time employees: {fullTimeEmployeeCount}");


                Employee foundEmployee = PayrollAnalyzer.FindEmployeeById(employees, 2);
                if (foundEmployee != null)
                {
                    Console.WriteLine($"Employee found: {foundEmployee.Name}, Salary: {foundEmployee.CalculatePay()}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public abstract class Employee
    {
        protected Employee(int id, string name, string department)
        {
            EmployeeValidator.ValidateId(id);
            EmployeeValidator.ValidateName(name);
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Department { get; private set; }

        public abstract decimal CalculatePay();

        public abstract string GetRoleDescription();
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, string department, decimal monthlySalary)
            : base(id, name, department)
        {
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary { get; private set; }

        public override decimal CalculatePay()
        {
            return MonthlySalary;
        }

        public override string GetRoleDescription()
        {
            return $"Full-time employee in the {Department} department";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Department: {Department}, Monthly Salary: {MonthlySalary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name, string department, decimal hourlyRate, int hoursWorked)
            : base(id, name, department)
        {
            EmployeeValidator.ValidateHourlyRate(hourlyRate);
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal HourlyRate { get; private set; }
        public int HoursWorked { get; private set; }

        public override decimal CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }

        public override string GetRoleDescription()
        {
            return $"Part-time employee in the {Department} department.";
        }

        public decimal CalculatePayWithBonus()
        {
            decimal basePay = CalculatePay();
            if (HoursWorked > 50)
            {
                return basePay * 1.05m;
            }
            return basePay;
        }
    }

    public static class EmployeeValidator
    {
        public static void ValidateId(int id)
        {
            if (id < 0) throw new ArgumentException("Employee ID cannot be negative.");
        }

        public static void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Employee name cannot be null or empty.");
        }

        public static void ValidateHourlyRate(decimal hourlyRate)
        {
            if (hourlyRate < 0) throw new ArgumentException("Hourly rate cannot be negative.");
        }
    }

    public static class PayrollAnalyzer
    {
        public static decimal FindHighestSalary(List<Employee> employees)
        {
            if (employees == null || employees.Count == 0)
                throw new ArgumentException("Employee list cannot be null or empty.");

            decimal highestSalary = employees[0].CalculatePay();
            for (int i = 1; i < employees.Count; i++)
            {
                if (highestSalary < employees[i].CalculatePay())
                {
                    highestSalary = employees[i].CalculatePay();
                }
            }
            return highestSalary;
        }

        public static int CountFullTimeEmployees(List<Employee> employees)
        {
            if (employees == null || employees.Count == 0) return 0;

            int count = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is FullTimeEmployee)
                {
                    count++;
                }
            }
            return count;
        }

        public static decimal SumFullTimeSalaries(List<Employee> employees)
        {
            if (employees == null || employees.Count == 0) return 0;

            decimal sum = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is FullTimeEmployee)
                {
                    sum += employees[i].CalculatePay();
                }
            }
            return sum;
        }

        public static Employee FindEmployeeById(List<Employee> employees, int id)
        {
            if (employees == null || employees.Count == 0) return null;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    return employees[i];
                }
            }
            return null;
        }
    }
}
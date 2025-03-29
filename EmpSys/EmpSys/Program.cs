using System.Runtime.CompilerServices;

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
                    new FullTimeEmployee(1, "João", "TI", 5000.0),
                    new PartTimeEmployee(2, "Maria", "Vendas", 20.0, 60),
                    new FullTimeEmployee(3, "Pedro", "RH", 4000.0)
                };

                var fullTimeEmployeer = PayrollAnalyzer.CountFullTimeEmployees(employees);

                double highestSalary = PayrollAnalyzer.FindHighestSalary(employees);
                Console.WriteLine($"Maior salário: {highestSalary}");

                var emptyList = new List<Employee>();
                Console.WriteLine($"Maior salário (lista vazia): {PayrollAnalyzer.FindHighestSalary(emptyList)}");

                Console.WriteLine($"Numero de FullTimeEmployees: {fullTimeEmployeer}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
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

        public abstract double CalculatePay();
        public abstract string GetRoleDescription();
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, string department, double monthlySalary)
            : base(id, name, department)
        {
            MonthlySalary = monthlySalary;
        }

        public double MonthlySalary { get; private set; }

        public override double CalculatePay()
        {
            return MonthlySalary;
        }

        public override string GetRoleDescription()
        {
            return $"Funcionário integral do departamento: {Department}";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {Id}, Nome: {Name}, Departamento: {Department}, Salário mensal: {MonthlySalary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name, string department, double hourlyRate, int hoursWorked)
            : base(id, name, department)
        {
            EmployeeValidator.ValidateHourlyRate(hourlyRate);
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public double HourlyRate { get; private set; }
        public int HoursWorked { get; private set; }

        public override double CalculatePay()
        {
            return HoursWorked * HourlyRate;
        }

        public override string GetRoleDescription()
        {
            return $"Funcionário meio período do departamento: {Department}";
        }

        public double CalculatePayWithBonus()
        {
            var basePay = CalculatePay();
            if (HoursWorked > 50)
            {
                return basePay * 1.05;
            }
            return basePay;
        }
    }
    public class EmployeeValidator
    {
        public static void ValidateId(int id)
        {
            if (id < 0) throw new ArgumentException("O campo Id não pode ser negativo!");
        }

        public static void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("O campo Nome não pode ser vazio ou nulo!");
        }

        public static void ValidateHourlyRate(double hourlyRate)
        {
            if (hourlyRate < 0) throw new ArgumentException("Valor por hora não pode ser negativo!");
        }
    }

    public class PayrollAnalyzer
    {
        public static double FindHighestSalary(List<Employee> employees)
        {
            if (employees == null || employees.Count == 0) throw new ArgumentException("A lista de funcionários não pode ser nula ou vazia.");

            return employees.Max(x => x.CalculatePay());
        }

        public static int CountFullTimeEmployees(List<Employee> employees)
        {
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
    }
}
namespace EmpSys
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fullTime = new FullTimeEmployee(1, "João", "TI", 5000.0);
                Console.WriteLine(fullTime.GetRoleDescription());
                fullTime.ShowDetails();
                Console.WriteLine($"Pagamento: {fullTime.CalculatePay()}");

                var partTime = new PartTimeEmployee(2, "Maria", "Vendas", 20.0, 60);
                Console.WriteLine(partTime.GetRoleDescription());
                Console.WriteLine($"Pagamento: {partTime.CalculatePay()}");
                Console.WriteLine($"Pagamento com bônus: {partTime.CalculatePayWithBonus()}");

                //erro
                var invalid = new FullTimeEmployee(-1, "", "RH", 3000.0);
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
}
using CursoProgramacao.Entities.Enums;

namespace CursoProgramacao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); 
        }

  

        public override string ToString()
        {
            return "Employee Name: " + Name + " "
                + "Level: " + Level + " "
                + "Department: " + Department + " "
                + "Salary: " + BaseSalary + " ";
        }
    }
}

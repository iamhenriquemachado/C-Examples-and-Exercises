using CursoProgramacao.Entities;
using CursoProgramacao.Entities.Enums;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Employees name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Employees level: ");
            int levelInt = int.Parse(Console.ReadLine());
            WorkerLevel level = (WorkerLevel)levelInt;


            Console.WriteLine("Employees salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Employees department: ");
            string dept = Console.ReadLine();



            Department department = new Department { Name = dept };

            Worker worker = new Worker
            (
                name,
                level,
                salary,
                department
            );


            Console.WriteLine("How many contracts to this worker?");
            int contractCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractCount; i++)
            {
                Console.WriteLine($"Enter data for contract #{i + 1}:");

                Console.Write("Hours: ");
                int workerHours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double hourValue = double.Parse(Console.ReadLine());

                var contract = new HourContract
                {
                    date = DateTime.Now,
                    Hours = workerHours,
                    ValuePerHour = hourValue
                };

                worker.AddContract(contract);

                Console.WriteLine("Contract created\n");
                Console.WriteLine(contract.ToString());
            }


            Console.WriteLine(worker.ToString());

        }
    }
}

using System.IO;
using System;

namespace CursoProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\tarefas.txt";


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(@"C:\temp");
            }

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("2. Estudar programação");
                streamWriter.WriteLine("3. Ler livros"); 
            }
            using (StreamReader streamReader = new StreamReader(path))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }
    }
}

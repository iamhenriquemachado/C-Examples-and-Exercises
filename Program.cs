using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FileSystems; 

namespace Program
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();

            string filePath = @"C:\Users\heyhe\Desktop\01. Projetos\01. C#\FileSystems\FileSystems\data.json";


            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {   
                string existingJson = await File.ReadAllTextAsync(filePath);
                try
                {
                    livros = JsonSerializer.Deserialize<List<Livro>>(existingJson);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine("Erro ao ler o JSON existente: " + ex.Message);
                    return;
                }
            }
            var novoLivro = new Livro
            {
                Titulo = "Lord of The Rings",
                Autor = "Tolkien",
                Ano = 2025
            };

            livros.Add(novoLivro);

            string jsonString = JsonSerializer.Serialize(livros, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(filePath, jsonString);

            Console.WriteLine("Livro adicionado com sucesso!");
        }
    }
}

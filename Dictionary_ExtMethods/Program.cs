using Dictionary_ExtMethods.Entities;
using Dictionary_ExtMethods.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary_ExtMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string endereco = @"C:\Users\015238631\Documents\Projetos.net\Dictionary_ExtMethods\File.txt";

                Funcionario funcionario = new Funcionario();
                funcionario.TransformaTxtLista(endereco);

                Dictionary<int, string> dictionaryIdName = new Dictionary<int, string>();

                var funcionarioList = funcionario.Funcionarios;
                foreach (var func in funcionarioList)
                {
                    dictionaryIdName[func.Id] = func.Nome;
                }

                Dictionary<int, string> dictionaryIdMes = new Dictionary<int, string>();

                foreach (var func in funcionarioList)
                {
                    dictionaryIdMes[func.Id] = func.DataNascimento.MesExtenso();
                }

                Console.WriteLine("************* RESULTADO *************");
                Console.WriteLine("Id".PadRight(15) + "Nome".PadRight(20) + "Mes do Nascimento".PadRight(10));
                foreach (var f in funcionarioList)
                {
                    Console.WriteLine($"{f.Id,-15}{dictionaryIdName[f.Id],-20}{dictionaryIdMes[f.Id],-10}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

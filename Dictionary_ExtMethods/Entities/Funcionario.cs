using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_ExtMethods.Entities
{
    class Funcionario : IFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }

        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Funcionario()
        {
        }
        public Funcionario(int id, string nome, DateTime dataNascimento, decimal salario)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
        }

        public void TransformaTxtLista(string endereco)
        {

            using (StreamReader registroFuncionarios = File.OpenText(endereco))
            {
                registroFuncionarios.ReadLine();
                while (!registroFuncionarios.EndOfStream)
                {

                    string[] registro = registroFuncionarios.ReadLine().Split(";");
                    Funcionario funcionario = NovoFuncionarioLinhaTxt(registro);
                    Funcionarios.Add(funcionario);
                }
            }
        }

        public Funcionario NovoFuncionarioLinhaTxt(string[] fileTxt)
        {
            int id = int.Parse(fileTxt[0]);
            string nome = fileTxt[1];
            DateTime dataNascimento = DateTime.Parse(fileTxt[2]);
            decimal salario = decimal.Parse(fileTxt[3]);

            return new Funcionario(id, nome, dataNascimento, salario);
        }
    }
}

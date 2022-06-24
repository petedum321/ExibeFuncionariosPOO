using Dictionary_ExtMethods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_ExtMethods
{
    interface IFuncionario
    {
        public void TransformaTxtLista(string endereco);

        public Funcionario NovoFuncionarioLinhaTxt(string[] fileTxt);

    }
}

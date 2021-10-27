using System;
using System.Collections.Generic;
using System.Text;

namespace Salarios
{
    class Funcionarios
    {
        //Encapsulamento
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //Metodo de incrementar o salario
        public void incrementarSalario(double porcentagem)
        {
            Salario = Salario + (Salario*( porcentagem/100));
        }

        internal static void Add(Funcionarios funcionarios)
        {
            throw new NotImplementedException();
        }

        internal static object Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
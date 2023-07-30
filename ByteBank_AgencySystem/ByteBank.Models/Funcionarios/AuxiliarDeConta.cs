using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Funcionarios
{
    public class AuxiliarDeConta : Funcionario
    {
        public AuxiliarDeConta(string _cpf, double _salario) : base(_cpf, _salario)  { }

        public override double GetBonificacao()
        {
            return Salario *= 0.05;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.10;
        }
    }
}

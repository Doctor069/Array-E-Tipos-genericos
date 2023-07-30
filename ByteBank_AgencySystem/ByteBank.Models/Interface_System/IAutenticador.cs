using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Interface_System
{
    public interface IAutenticador
    {
        bool Autenticar(string _senha);
    }
}

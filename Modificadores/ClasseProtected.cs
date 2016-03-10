using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    public class ClasseProtectedA
    {
        protected string PropriedadeProtegida { get; set; }
    }

    public class ClasseProtectedB : ClasseProtectedA
    {
        public ClasseProtectedB()
        {
            this.PropriedadeProtegida = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class ClasseInternal
    {
    }
}

namespace Modificadores.Internal
{
    internal class ClasseInternal2
    {
        public ClasseInternal2()
        {
            ClasseInternal ci = new ClasseInternal();
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Gerente : Funcionario
    {

        public override double Salario
        {
            get { return base.Salario * 1.2; }
        }

    }
}

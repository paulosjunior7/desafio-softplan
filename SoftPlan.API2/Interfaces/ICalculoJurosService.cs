﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Interfaces
{
    public interface ICalculoJurosService
    {
        decimal CalcularJuros(decimal valorInicial, int meses, decimal taxaJuros);
    }
}

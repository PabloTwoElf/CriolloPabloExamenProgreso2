﻿using CriolloPabloExamenProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriolloPabloExamenProgreso2.Interfaces
{
    public interface ICriolloRecarga
    {
        PCriolloRecarga GetRecarga(string numero);
        bool CreateRecarga(PCriolloRecarga recarga);
        bool UpdateRecarga(PCriolloRecarga recarga);
        bool DeleteRecarga(string numero);



    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Usuario
    {
        protected string contrasena;
        protected string nombre;
        protected bool premium;

        public string GetNombre() => nombre;
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Varietal
    {
        private string descripcion;
        private int? porcentajeComposicion;
        private TipoUva tipoUva;

        public Varietal(string descripcion, int? porcentajeComposicion, TipoUva tipoUva)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
            this.tipoUva = tipoUva;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int? PorcentajeComposicion { get => porcentajeComposicion; set => porcentajeComposicion = value; }
        public TipoUva TipoUva { get => tipoUva; set => tipoUva = value; }
    }

}

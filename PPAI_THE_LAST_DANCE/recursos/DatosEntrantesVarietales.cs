using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DatosEntrantesVarietales
{
    private string descripcion;
    private int? porcentajeVarietal;
    private string tipoUva;

    public DatosEntrantesVarietales(string descripcion, int? porcentajeVarietal, string tipoUva)
    {
        this.descripcion = descripcion;
        this.porcentajeVarietal = porcentajeVarietal;
        this.tipoUva = tipoUva;
    }

    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int? PorcentajeVarietal { get => porcentajeVarietal; set => porcentajeVarietal = value; }
    public string TipoUva { get => tipoUva; set => tipoUva = value; }
}

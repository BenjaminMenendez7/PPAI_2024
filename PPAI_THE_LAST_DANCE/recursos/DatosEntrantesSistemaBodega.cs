using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DatosEntrantesSistemaBodega
{
    private string añada;
    private DateTime fechaActualizacion;
    private string imagenEtiqueta;
    private string nombre;
    private string notaDeCataBodega;
    private int precioARS;
    private List<String> maridaje;
    private List<string[]> varietal;

    public DatosEntrantesSistemaBodega(string añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
    {
        this.añada = añada;
        this.imagenEtiqueta = imagenEtiqueta;
        this.nombre = nombre;
        this.notaDeCataBodega = notaDeCataBodega;
        this.precioARS = precioARS;
        this.maridaje = new List<string>();
        this.varietal = new List<string[]>();
        this.FechaActualizacion = fechaActualizacion;
    }

    public string Añada { get => añada; set => añada = value; }
    public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
    public int PrecioARS { get => precioARS; set => precioARS = value; }
    public List<String> Maridaje { get => maridaje; set => maridaje = value; }
    public List<string[]> Varietal { get => varietal; set => varietal = value; }
    public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
}
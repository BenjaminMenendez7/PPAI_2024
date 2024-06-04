using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DatosEntrantesSistemaBodega
{
    private int id;
    private int añada;
    private string imagenEtiqueta;
    private string nombre;
    private string notaDeCataBodega;
    private int precioARS;
    private List<String>? maridaje;
    private List<DatosEntrantesVarietales>? varietal;

    public DatosEntrantesSistemaBodega(int id, int añada, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS, List<String>? maridaje, List<DatosEntrantesVarietales>? varietal)
    {
        this.id = id;
        this.añada = añada;
        this.imagenEtiqueta = imagenEtiqueta;
        this.nombre = nombre;
        this.notaDeCataBodega = notaDeCataBodega;
        this.precioARS = precioARS;
        this.maridaje = maridaje;
        this.varietal = varietal;
    }

    public int Id { get => id; set => id = value; }
    public int Añada { get => añada; set => añada = value; }
    public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
    public int PrecioARS { get => precioARS; set => precioARS = value; }
    public List<String>? Maridaje { get => maridaje; set => maridaje = value; }
    public List<DatosEntrantesVarietales>? Varietal { get => varietal; set => varietal = value; }
}
using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.boundary
{
    public class InterfazAPIBodega
    {
        public List<Vino> vinos;

        public void NotificarNovedadVinoParaBodega() { }
        
        public void ObtenerActualizacionesBodega() { }

        public InterfazAPIBodega()
        {
            vinos = new List<Vino>
            {
                new Vino(
                    new DateTime(2019, 1, 1),
                    "Bodega Central NY",
                    "1.jpg",
                    "Luna Dorada",
                    new DateTime(2018, 12, 31),
                    1200.00m
                ),
                new Vino(
                    new DateTime(2018, 1, 1),
                    "Bodega LA",
                    "2.jpg",
                    "Cosecha Divina",
                    new DateTime(2017, 12, 31),
                    1500.00m
                ),
                new Vino(
                    new DateTime(2017, 1, 1),
                    "Bodega Londres",
                    "3.jpg",
                    "Susurro de la Noche",
                    new DateTime(2016, 12, 31),
                    1800.00m
                ),
                new Vino(
                    new DateTime(2016, 1, 1),
                    "Bodega Sídney",
                    "4.jpg",
                    "Bruma del Océano",
                    new DateTime(2015, 12, 31),
                    1300.00m
                ),
                new Vino(
                    new DateTime(2015, 1, 1),
                    "Bodega Tokio",
                    "5.jpg",
                    "Tradiciones Japonesas",
                    new DateTime(2014, 12, 31),
                    1700.00m
                ),
                new Vino(
                    new DateTime(2014, 1, 1),
                    "Bodega Central NY",
                    "6.jpg",
                    "Secretos del Viñedo",
                    new DateTime(2013, 12, 31),
                    1400.00m
                )
            };
        }



}

}

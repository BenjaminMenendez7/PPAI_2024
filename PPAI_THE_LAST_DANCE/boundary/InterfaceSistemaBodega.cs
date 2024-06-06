using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InterfaceSistemaBodega
{
    private List<DatosEntrantesSistemaBodega> vinoList;

    // retorna un listado de vinos a actualizar en un formato T definido por nosotros para que no sean directamente los objetos y tengamos
    // que mapear
    public List<DatosEntrantesSistemaBodega> ObtenerActualizacionesBodega()
    {
        
            //Vinos que se actualizan
            DatosEntrantesSistemaBodega v6 = new DatosEntrantesSistemaBodega(6, 2020, "imagen6.jpg", "Torrontés", "Aromático con notas de jazmín y cítricos", 400, null, null);
            DatosEntrantesSistemaBodega v7 = new DatosEntrantesSistemaBodega(7, 2014, "imagen7.jpg", "Pinot Noir", "Elegante con notas de cereza y tierra", 3000, null, null);
            DatosEntrantesSistemaBodega v8 = new DatosEntrantesSistemaBodega(8, 2021, "imagen8.jpg", "Sauvignon Blanc", "Fresco con notas de manzana verde y pasto", 950, null, null);
            DatosEntrantesSistemaBodega v9 = new DatosEntrantesSistemaBodega(9, 2013, "imagen9.jpg", "Malbec Gran Reserva", "Complejo con notas de chocolate y frutos secos", 2500, null, null);
            DatosEntrantesSistemaBodega v10 = new DatosEntrantesSistemaBodega(10, 2012, "imagen10.jpg", "Tempranillo", "Intenso con notas de frambuesa y cuero", 1400, null, null);


            DatosEntrantesVarietales var1 = new DatosEntrantesVarietales("Uva que produce vinos oscuros y ricos, con notas de ciruela, mora y chocolate.", 50, "Malbec");
            DatosEntrantesVarietales var2 = new DatosEntrantesVarietales("Uva aromática que produce vinos blancos dulces o secos, con notas de manzana, melocotón y miel.", 20, "Riesling");
            DatosEntrantesVarietales var3 = new DatosEntrantesVarietales("Uva aromática que produce vinos frescos y ácidos, con notas de hierba y frutas tropicales.", 80, "Sauvignon Blanc");
            DatosEntrantesVarietales var4 = new DatosEntrantesVarietales("Una uva de piel gruesa y tánica, conocida por sus vinos intensos y longevos.", 50, "Cabernet Sauvignon");
            DatosEntrantesVarietales var5 = new DatosEntrantesVarietales("Uva que produce vinos frutales y especiados, con sabores de fresa, zarzamora y pimienta.", 60, "Zinfandel");
            DatosEntrantesVarietales var6 = new DatosEntrantesVarietales("Uva española que produce vinos con sabores de cereza, cuero y tabaco, con buena estructura.", 40, "Tempranillo");
            //Vinos que se crean
            DatosEntrantesSistemaBodega v11 = new DatosEntrantesSistemaBodega(11, 2018, "imagen11.jpg", "Bonarda", "Aromas de frutas maduras y especias", 1000, new List<String>() { "Pasta y Chianti", "Sushi y Sake" }, new List<DatosEntrantesVarietales>() { var1, var4 });
            DatosEntrantesSistemaBodega v12 = new DatosEntrantesSistemaBodega(12, 2020, "imagen12.jpg", "Petit Verdot", "Notas de moras y especias con taninos firmes", 1350, new List<String>() { "Mariscos y Vino Blanco", "Pizza y Lambrusco" }, new List<DatosEntrantesVarietales>() { var3 });
            DatosEntrantesSistemaBodega v13 = new DatosEntrantesSistemaBodega(13, 2016, "imagen13.jpg", "Viognier", "Aromas de melocotón y florales", 950, new List<String>() { "Ensalada y Sauvignon Blanc" }, new List<DatosEntrantesVarietales>() { var2, var5 });
            DatosEntrantesSistemaBodega v14 = new DatosEntrantesSistemaBodega(14, 2019, "imagen14.jpg", "Carmenere", "Sabores de ciruela y chocolate con taninos suaves", 1150, new List<String>() { "Chocolate y Vino de Oporto" }, new List<DatosEntrantesVarietales>() { var6, var5 });
            DatosEntrantesSistemaBodega v15 = new DatosEntrantesSistemaBodega(15, 2017, "imagen15.jpg", "Garnacha", "Aromas de frutos rojos y toques de especias", 1050, new List<String>() { "Pasta y Chianti", "Carne Roja y Cabernet Sauvignon" }, new List<DatosEntrantesVarietales>() { var4 });


            this.vinoList = new List<DatosEntrantesSistemaBodega> { v6, v7, v8, v9, v10, v11, v12, v13, v14, v15 };
            return vinoList;
        
        
    }
}
/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.UsesCases
{
    public class Reporte
    {       
        public static string Imprimir(List<IFormaGeometrica> formas, int idioma)
        {
            if (formas == null || !formas.Any())
            {
                return "<h1>" + Traducciones.ObtenerTraduccion(idioma, "Reporte") + "</h1>" + "<br/>" + Traducciones.ObtenerTraduccion(idioma, "Vacio");
            }

            var sb = new StringBuilder();
            sb.Append("<h1>" + Traducciones.ObtenerTraduccion(idioma, "Reporte") + "</h1>");

            var formasAgrupadas = formas.GroupBy(f => f.Nombre);

            foreach (var grupo in formasAgrupadas)
            {
                sb.Append("<br/>" + Traducciones.ObtenerTraduccion(idioma, grupo.Key) + ": " + grupo.Count());
                sb.Append(" | " + Traducciones.ObtenerTraduccion(idioma, "Area") + ": " + grupo.Sum(f => f.Area).ToString("#.##"));
                sb.Append(" | " + Traducciones.ObtenerTraduccion(idioma, "Perimetro") + ": " + grupo.Sum(f => f.Perimetro).ToString("#.##"));
            }

            sb.Append("<br/>" + Traducciones.ObtenerTraduccion(idioma, "Total") + ": " + formas.Count + "<br/>");
            sb.Append(" | " + Traducciones.ObtenerTraduccion(idioma, "Area") + ": " + formas.Sum(f => f.Area).ToString("#.##"));
            sb.Append(" | " + Traducciones.ObtenerTraduccion(idioma, "Perimetro") + ": " + formas.Sum(f => f.Perimetro).ToString("#.##"));

            return sb.ToString();
        }

    }
}

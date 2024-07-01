using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Negocio
{
    public class Neg_Regions
    {

        Dat_Regions datos = new Dat_Regions();

        public void Crear(Ent_Regions regions)
        {
            Dat_Regions datos = new Dat_Regions();
            datos.Crear(regions);
        }


        public void Eliminar(Ent_Regions regions)
        {
            Dat_Regions datos = new Dat_Regions();
            datos.Eliminar(regions);
        }


        public void Editar(Ent_Regions regions)
        {
            Dat_Regions datos = new Dat_Regions();
            datos.Editar(regions);
        }


        public List<Ent_Regions> Listar(string Nombre)
        {
            List<Ent_Regions> result = new List<Ent_Regions>();

            result = datos.Listar(Nombre);
            return result;
        }

    }
}

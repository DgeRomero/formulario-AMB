using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Altura { get; set; }
    }
    public class  DireccionNegocio
    {
        public List<Direccion> listar()
        {
            List<Direccion> lista = new List<Direccion>();
            lista.Add(new Direccion());
            lista.Add(new Direccion());

            lista[0].Calle = "Montañeses";
            lista[0].Altura = 4913;

            lista[1].Calle = "Cayena";
            lista[1].Altura = 2202;
            

            return lista;
        }
        

    }
}

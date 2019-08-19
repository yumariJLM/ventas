using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();


        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "El Progreso");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");


            var cliente1 = new Cliente(1, "Juan Lopez", 98651243, "Col Moderna", ciudad1);
            var cliente2 = new Cliente(2, "Carlos Mendoza", 99562314, "Col Trejo", ciudad2);
            var cliente3 = new Cliente(3, "Maria Ramirez", 33569300, "Col Paz", ciudad2);


            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
 
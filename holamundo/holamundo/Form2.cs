using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holamundo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            //Ciudades
            var ciudad1= new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "El Progreso";

            var ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Comayagua";



            //Clientes
            Cliente cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan Mendoza" ;
            cliente1.Telefono = 95920124;
            cliente1.Direccion = "12 calle 4 ave.";
            cliente1.Ciudad = ciudad1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Yumari Lopez";
            cliente2.Telefono = 99594012;
            cliente2.Direccion = "1 calle 6 ave.";
            cliente2.Ciudad = ciudad2;

            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Carlos Rodriguez";
            cliente3.Telefono = 99692949;
            cliente3.Direccion = "12 calle 4 ave.";
            cliente3.Ciudad = ciudad3;




            var listaClientes =  new List<Cliente>();
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);

            foreach (var i in listaClientes)
            {
                MessageBox.Show(i.Nombre + " - " + i.Ciudad.Descripcion);
            }
           
        }
    }
}

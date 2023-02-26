using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioC_
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void AceptarBtt_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los campos
            string nombre = NameBx.Text;
            string apellido = ApellidoBx.Text;
            string ident = IdUserBx.Text;
            string telefono = TelfBx.Text;
            string email = EmailBx.Text;

            // Muestra los valores en pantalla
            MessageBox.Show($"Nombre: {nombre}\nApellido: {apellido}\nId: {ident}\nTelefono: {telefono}\nE-Mail: {email}");
        }

        private void IconUser_Click(object sender, EventArgs e)
        {

        }
    }
}

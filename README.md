





## Code.

![image](https://user-images.githubusercontent.com/121737914/221419476-a4812fcf-27f1-4f82-81a0-4d043376be2e.png)


```
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
            int ident = int.Parse(IdUserBx.Text);
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
```



### Running.

Data entry.

![image](https://user-images.githubusercontent.com/121737914/221419838-6e071acf-74a3-42ea-a7fa-8c5ab6cda480.png)

Data output.

![image](https://user-images.githubusercontent.com/121737914/221419797-5c598fba-4c5f-49be-b4a6-af6f5416053f.png)


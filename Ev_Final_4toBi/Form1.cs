using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class LBL1 : Form
    {
        public LBL1()
        {
            InitializeComponent();
        }

       
            private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Ferdy" && TextContraseña.Text == "71")
            {
                this.Hide();

                Form1 app = new Form1();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
    



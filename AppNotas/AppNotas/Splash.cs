using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotas
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbIniciando.Value<100){
                pbIniciando.Value = pbIniciando.Value + 1;
            }else{
                timer1.Enabled = false;
                this.Close();
                //MainForm main = new MainForm();
                //main.Show();
            }
        }
    }
}

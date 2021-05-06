using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AktaslarArsiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                progressBar1.Value += 5;
            }
            catch
            {
                timer1.Enabled = false;



                login_screen ls = new login_screen();

                ls.Show();

                this.Hide();

            }
        }

       
    }
}

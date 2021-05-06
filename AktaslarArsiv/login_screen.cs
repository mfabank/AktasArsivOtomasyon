using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AktaslarArsiv
{

    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        bool dragging;

        Point offset;
        private void login_screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void login_screen_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void login_screen_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        
    }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.Tomato;
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
           
        }

        private void entry_btn_Click(object sender, EventArgs e)
        {
            string id = kadi_text.Text;
            string pass = pass_text.Text;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=aktasDB.accdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            if (calisan_radio.Checked == true)
            {
              
                
                cmd.CommandText = "SELECT * FROM calisan where id='" + kadi_text.Text + "' AND parola='" + pass_text.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                  
                 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }
            }
            else if (admin_radio.Checked == true)
            {

                cmd.CommandText = "SELECT * FROM yonetici where id='" + kadi_text.Text + "' AND parola='" + pass_text.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    yönetici yonetici = new yönetici(kadi_text.Text);
                    yonetici.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("yetkinizi seçmediniz !");
            }
            
          

            con.Close();

        }
    }
    }



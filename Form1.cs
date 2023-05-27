using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_create
{
    public partial class Form1 : Form
    {
        private int posX = 0;
        private int posY = 0;

        int indx = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            AddBtn();
        }
        private void Btn_DEL(object sender, System.EventArgs e)
        {


            delBtn();

        }


        private void AddBtn()
        {
                    posX += 100;
                    if (posX >= this.Width)
                    {
                        posX = 100;
                        posY += 20;
                    }
                    Button btn = new Button();
                    btn.Name = $"btn_{indx.ToString()}";
                    btn.Text = $"{indx.ToString()}";
                    Random r = new Random();
                    btn.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                    btn.Location = new Point(posX, posY);
                    btn.Click += Btn_Click;
                    // add my btn to my form !!!!!
                    this.Controls.Add(btn);
                    indx++;

        }

        private void delBtn()
        {


            DialogResult res = MessageBox.Show("Do you want to deleted button", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                for (int i = indx; i > 1; i--)
                {
                    this.Controls.RemoveAt(i);
                }
                indx = 1;
                posX = 0;
                posY = 0;
                MessageBox.Show("Button is deleted");
            }
            else
            {
                MessageBox.Show("Button is not deleted");
            }

        }

    }
}

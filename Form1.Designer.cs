using System.Drawing;
using System.Windows.Forms;

namespace button_create
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Hello WinForms";

            this.BackColor = Color.FromArgb(255, 96, 130, 230);
            this.Size = new Size(400, 400);
            this.MaximumSize = new Size(400, 400);
            this.MinimumSize = new Size(300, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            //
            //      Button click me
            //
            btn = new Button();
            btn.Text = "Click me";
            btn.Name = $"btn_0";
            btn.ForeColor = Color.Green;
            btn.Size = new Size(90, 100);
            btn.Location = new Point(0, 0);
            btn.BackColor = Color.Aquamarine;
            btn.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn.Click += Btn_Click;


            // add my btn to my form !!!!!
            this.Controls.Add(btn);

            btn_del = new Button();
            btn_del.Text = "Del Button";
            btn_del.Name = $"btn_11";
            btn_del.ForeColor = Color.Green;
            btn_del.Size = new Size(90, 100);
            btn_del.Location = new Point(290, 260);
            btn_del.BackColor = Color.Aquamarine;
            btn_del.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn_del.Click += Btn_DEL;
            this.Controls.Add(btn_del);



        }

        Button btn;
        Button btn_del;
        #endregion
    }
}


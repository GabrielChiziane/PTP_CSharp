using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_1_CSharp
{
    public class Form1 : Form
    {
        private Button button1;

        public Form1()
        {
            Text = "Form1";
            ClientSize = new Size(400, 250);
            StartPosition = FormStartPosition.CenterScreen;

            button1 = new Button();
            button1.Name = "button1";
            button1.Text = "Clica em mim";
            button1.Size = new Size(140, 40);
            button1.Location = new Point(130, 105);
            button1.Click += button1_Click;

            Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, Mundo!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private Button but1; // эта переменная будет содержать ссылку на кнопку button1 из формы Form1

        public SecondForm(Button but) // получаем ссылку на кнопку в переменную but
        {
            but1 = but; // теперь but1 будет ссылкой на кнопку button1
            InitializeComponent();
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlOne1.AddData();
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.button2_Click(sender, e);
            }
        }
    }
}

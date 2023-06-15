using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class ControlOne : UserControl
    {
        public void AddData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DemoBase.accdb"))
                {
                 
                    connection.Open();
                    string sql = $"INSERT INTO Main([Фамилия имя отчество],[ПОО],[НомерУчастника]) VALUES('{textBoxFIO.Text}','{textBoxPOO.Text}',{textBoxNumber.Text})";
                    using (OleDbCommand cmd = new OleDbCommand(sql, connection))
                    {
                        try
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        public ControlOne()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoBaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.baseDataSet.Main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoBaseDataSet.Main". При необходимости она может быть перемещена или удалена.


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = new DialogResult();
                dlgResult = MessageBox.Show("Вы уверены, что хотите безвозвратно удалить данную запись из базы данных?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    this.mainBindingSource.RemoveCurrent();                    
                    this.mainBindingSource.EndEdit();
                    this.mainTableAdapter.Update(this.baseDataSet.Main);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            this.mainTableAdapter.Fill(this.baseDataSet.Main);
            if (buttonAdd.Text == "Add")
            {
                // Добавляем новую строку и меняем надпись на "отмена".
                this.mainBindingSource.AddNew();
                buttonAdd.Text = "Cancel";

            }
            else
            {
                this.mainBindingSource.EndEdit();
                buttonAdd.Text = "Add";
                this.mainTableAdapter.Fill(this.baseDataSet.Main);
                return;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = new DialogResult();
                dlgResult = MessageBox.Show("Вы уверены, что хотите сохранить запись?",
                    "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {

                    this.mainBindingSource.EndEdit();
                    this.mainTableAdapter.Update(this.baseDataSet.Main);
                    MessageBox.Show("Запись сохранена успешно!");
                    buttonAdd.Text = "Add";
                    this.mainTableAdapter.Fill(this.baseDataSet.Main);


                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

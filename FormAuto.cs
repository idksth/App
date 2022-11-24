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

namespace WindowsFormsApp1
{
    public partial class FormAuto : Form
    {
        public string connectionString { get; private set; }
        public string queryString { get; private set; }

        public FormAuto()
        {
            InitializeComponent();
        }

        private void automobileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.automobileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dATABASEDataSet1);

        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dATABASEDataSet1.Automobile". При необходимости она может быть перемещена или удалена.
            //this.automobileTableAdapter.Fill(this.dATABASEDataSet1.Automobile);
            dATABASEDataSet1.Clear();
            this.automobileTableAdapter.Fill(this.dATABASEDataSet1.Automobile);

        }

        private void FormAuto_Deactive(object sender, EventArgs e)
        {
            using (SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter())
            {
                sqlDataAdapter1.Update(dATABASEDataSet1);

            }
        }
        private void automobileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void automobileBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e, string connectionString, string queryString) {
            
        }*/

        private void button1_Click(object sender, EventArgs e)
        { 

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                
                using (SqlCommand sqlInsertCommand1 = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlInsertCommand1.Parameters["@Series_of_the_technical_passport"].Value = Convert.ToInt32(textBox2.Text);
                    sqlInsertCommand1.Parameters["@Number_of_the_technical_passport"].Value = Convert.ToInt32(textBox2.Text);
                    sqlInsertCommand1.Parameters["@Drivers_FIO"].Value = textBox3.Text;
                    sqlInsertCommand1.Parameters["@State_number"].Value = textBox4.Text;
                    sqlInsertCommand1.Parameters["@Drivers_address"].Value = textBox5.Text;
                    sqlInsertCommand1.Parameters["@Brand"].Value = textBox6.Text;
                    sqlInsertCommand1.Parameters["@Engine_number"].Value = textBox7.Text;
                    sqlInsertCommand1.Parameters["@Body_number"].Value = textBox8.Text;
                    sqlInsertCommand1.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }
    }
}

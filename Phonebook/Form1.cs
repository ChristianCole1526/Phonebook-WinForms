using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0AJBLM0\SQLEXPRESS;Initial Catalog=Phonebook;Integrated Security=True");
        FormHelper form_helper = new FormHelper();
        String first_name = "";
        String last_name = "";
        String phone_number = "";

        public Form1()
        {
            InitializeComponent();
            connection.Open();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            form_helper.RefreshDataTable(dataGridView1, connection);

        }

        private void FindRecordBtn_Click(object sender, EventArgs e)
        {
            String select_query = $"SELECT * FROM People WHERE first_name LIKE '{first_name}%' AND last_name LIKE '{last_name}%' AND phone_number LIKE '{phone_number}%'";

            form_helper.ChangeDataSource(select_query, dataGridView1, connection);
        }


        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {

            if (form_helper.AllFieldsCompleted(first_name, last_name, phone_number) && form_helper.ValidateInputs(first_name, last_name, phone_number))
            {
                if (form_helper.PersonExists(dataGridView1, connection, first_name, last_name, phone_number))
                {
                    String delete_query = $"DELETE FROM People WHERE first_name = '{first_name}' AND last_name = '{last_name}' AND phone_number = '{phone_number}'";
                    SqlCommand insert_command = new SqlCommand(delete_query, connection);
                    SqlDataReader sql_reader;

                    sql_reader = insert_command.ExecuteReader();
                    sql_reader.Close();

                    form_helper.RefreshDataTable(dataGridView1, connection);

                    MessageBox.Show($"Person: {first_name} {last_name} Deleted Succesfully");
                }
                else
                {
                    MessageBox.Show("No Such Person In Table");
                }
            }
        }


        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if (form_helper.AllFieldsCompleted(first_name, last_name, phone_number) && form_helper.ValidateInputs(first_name, last_name, phone_number)) 
            {
                if (!form_helper.PersonExists(dataGridView1, connection, first_name, last_name, phone_number))
                {
                    String add_query = $"INSERT INTO People (first_name, last_name, phone_number) VALUES('{first_name}', '{last_name}', '{phone_number}')";
                    SqlCommand insert_command = new SqlCommand(add_query, connection);
                    SqlDataReader sql_reader;

                    sql_reader = insert_command.ExecuteReader();
                    sql_reader.Close();

                    MessageBox.Show($"Person: {first_name} {last_name} Entered Succesfully");
                } 
                else
                {
                    MessageBox.Show("Person Already Exists In Table");
                }

                form_helper.RefreshDataTable(dataGridView1, connection);
            }
        }

        private void PhoneNumberInput_TextChanged(object sender, EventArgs e)
        {
            phone_number = PhoneNumberInput.Text;
        }


        private void LastNameInput_TextChanged(object sender, EventArgs e)
        {
            last_name = LastNameInput.Text;
        }


        private void FirstNameInput_TextChanged(object sender, EventArgs e)
        {
            first_name = FirstNameInput.Text;
        }


        private void RefreshTableBtn_Click(object sender, EventArgs e)
        {
            form_helper.RefreshDataTable(dataGridView1, connection);
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0AJBLM0\SQLEXPRESS;Initial Catalog=Phonebook;Integrated Security=True");
        String first_name = "";
        String last_name = "";
        String phone_number = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshDataTable();

        }

        public void RefreshDataTable()
        {
            DataSet data_set = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM People", connection))
            {
                adapter.Fill(data_set);
                dataGridView1.DataSource = data_set.Tables[0];
            }
        }

        public bool ValidateInputs()
        {
            try
            {
                first_name.ToString();
                last_name.ToString();

                if (phone_number != "")
                {
                    Int64.Parse(phone_number);
                }

                return true;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        private bool PersonExists()
        {
            try
            {
                DataSet data_set = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM People WHERE first_name = '{first_name}' AND last_name = '{last_name}' AND phone_number = '{phone_number}'", connection))
                {
                    adapter.Fill(data_set);
                    dataGridView1.DataSource = data_set.Tables[0].Rows[0];

                    return true;
                }
            } catch {
                MessageBox.Show("No Such Person In Table");

                return false;
            }
        }

        private bool AllFieldsCompleted()
        {
            if (first_name != "" && last_name != "" && phone_number != "")
            {
                return true;
            } 
            MessageBox.Show("All Fields Must Be Completed");

            return false;
            
        }

        private void FindRecordBtn_Click(object sender, EventArgs e)
        {
            String select_query = $"SELECT * FROM People WHERE ";

            
            if (first_name != "")
            {
                select_query += $"first_name = '{first_name}' AND ";
            } 

            if (last_name != "")
            {
                select_query += $"last_name = '{last_name}' AND ";
            }

            if (phone_number != "")
            {
                select_query += $"phone_number = '{phone_number}' AND ";
            }


            select_query = select_query.Trim();
            select_query = select_query.Remove(select_query.LastIndexOf(' '));

            if (this.ValidateInputs())
            {
                DataSet data_set = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(select_query, connection))
                {
                    adapter.Fill(data_set);
                    dataGridView1.DataSource = data_set.Tables[0];
                }
            }
        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {

            if (this.AllFieldsCompleted() && this.ValidateInputs() && this.PersonExists())
            {
                String delete_query = $"DELETE FROM People WHERE first_name = '{first_name}' AND last_name = '{last_name}' AND phone_number = '{phone_number}'";
                SqlCommand insert_command = new SqlCommand(delete_query, connection);
                SqlDataReader sql_reader;

                connection.Open();

                sql_reader = insert_command.ExecuteReader();
                sql_reader.Close();

                this.RefreshDataTable();

                MessageBox.Show($"Person: {first_name} {last_name} Deleted Succesfully");

                connection.Close();
            }

        }

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if (this.AllFieldsCompleted() && this.ValidateInputs()) 
            {
                if (!this.PersonExists())
                {
                    String add_query = $"INSERT INTO People (first_name, last_name, phone_number) VALUES('{first_name}', '{last_name}', '{phone_number}')";
                    SqlCommand insert_command = new SqlCommand(add_query, connection);
                    SqlDataReader sql_reader;

                    connection.Open();

                    sql_reader = insert_command.ExecuteReader();
                    sql_reader.Close();

                    MessageBox.Show($"Person: {first_name} {last_name} Entered Succesfully");

                    connection.Close();
                } else {
                    MessageBox.Show("Person Already Exists In Table");
                }
                this.RefreshDataTable();
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
            this.RefreshDataTable();
        }
    }
}

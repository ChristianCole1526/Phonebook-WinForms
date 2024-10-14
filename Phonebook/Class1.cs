using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

namespace Phonebook
{
    internal class FormHelper
    {

        public void RefreshDataTable(DataGridView data_grid, SqlConnection connection)
        {
            this.ChangeDataSource($"SELECT * FROM People", data_grid, connection);
        }


        public void ChangeDataSource(String query, DataGridView data_grid, SqlConnection conn)
        {
            DataSet data_set = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.Fill(data_set);
                data_grid.DataSource = data_set.Tables[0];
            }
        }

        
        public bool ValidateInputs(String f_name, String l_name, String phone_no)
        {
            if (Regex.IsMatch(f_name.Trim(), @"^[a-zA-Z]+$") & Regex.IsMatch(l_name.Trim(), @"^[a-zA-Z]+$") & Regex.IsMatch(phone_no.Trim(), @"^\d+$"))
            {
                return true;
            }

            MessageBox.Show("Input Data Not In Correct Format");

            return false;
        }

        public bool PersonExists(DataGridView data_grid, SqlConnection conn, string f_name, string l_name, string phone_no)
        {
            try
            {
                DataSet data_set = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM People WHERE first_name = '{f_name}' AND last_name = '{l_name}' AND phone_number = '{phone_no}'", conn))
                {
                    adapter.Fill(data_set);
                    data_grid.DataSource = data_set.Tables[0].Rows[0];

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool AllFieldsCompleted(String f_name, String l_name, String phone_no)
        {
            if (f_name != "" && l_name != "" && phone_no != "")
            {
                return true;
            }

            MessageBox.Show("All Fields Must Be Completed");

            return false;
        }

    }
}

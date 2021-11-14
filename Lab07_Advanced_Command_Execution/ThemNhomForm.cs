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

namespace Lab07_Advanced_Command_Execution
{
    public partial class ThemNhomForm : Form
    {
        public ThemNhomForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "EXEC Category_Insert @id, @name, @type";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters["@name"].Value = txtNameCat.Text;
                if (rdTypeFood.Checked)
                    cmd.Parameters["@type"].Value = "1";
                else
                    cmd.Parameters["@type"].Value = "0";

                connection.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Thành công!", "Thông báo");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo");
                }
                connection.Close();
                connection.Dispose();
                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
    }


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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }
        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            initValues();
        }

        private void initValues()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            connection.Open();
            adapter.Fill(ds, "Category");

            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            connection.Close();
            connection.Dispose();
        }

        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            cbbCatName.ResetText();
            nmrPrice.ResetText();
        }

      

       
      
        private void btnAddNewCategory_Click_1(object sender, EventArgs e)
        {
            ThemNhomForm frm = new ThemNhomForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                initValues();
            }
        }

        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "EXEC InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nmrPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                connection.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm thành công, Mã số = " + foodID, "Thông báo");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                connection.Close();
                connection.Dispose();
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
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nmrPrice.Text = rowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;

                for (int index = 0; index < cbbCatName.Items.Count; index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }


        private void btnUpdateFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "EXEC Food_Update @id, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nmrPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                connection.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại!", "Thông báo");
                }
                connection.Close();
                connection.Dispose();
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbCatName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

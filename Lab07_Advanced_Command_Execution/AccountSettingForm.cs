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
    public partial class AccountSettingForm : Form
    {
        
        private object _AccountName;

        public object AccountName { get; }

        public AccountSettingForm(object p)
        {
            _AccountName = AccountName;
            InitializeComponent();
        }
        private void LoadCombobox()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "SELECT RoleName FROM Role";
            cmd.CommandText = query;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            cbbRole.Items.Clear();
            while (sqlDataReader.Read())
            {
                cbbRole.Items.Add(sqlDataReader["RoleName"].ToString());
            }

            sqlConnection.Close();
        }

        private void InsertAccount()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Account_Insert @AccountName, @Password, @FullName, @Email, @Tell, @Date";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Tell", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Date", SqlDbType.DateTime);

            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Password"].Value = txtPassword.Text;
            cmd.Parameters["@FullName"].Value = txtHoTen.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Tell"].Value = txtSDT.Text;
            cmd.Parameters["@Date"].Value = DateTime.Now.ToShortDateString();

            sqlConnection.Open();
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected > 0)
                MessageBox.Show("Tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lỗi tạo tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InsertRoleAccount();
        }

        private void UpdateAccount()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC Account_Update @AccountName, @Password, @FullName, @Email, @Tell";
            cmd.CommandText = query;

            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Tell", SqlDbType.NVarChar);

            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Password"].Value = txtPassword.Text;
            cmd.Parameters["@FullName"].Value = txtHoTen.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Tell"].Value = txtSDT.Text;

            sqlConnection.Open();
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lỗi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InsertRoleAccount()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            string query = "EXEC RoleAccount_Insert @RoleID, @AccountName, @Actived, @Notes";
            cmd.CommandText = query;

            cmd.Parameters.Add("@RoleID", SqlDbType.Int);
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Actived", SqlDbType.Int);
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar);

            cmd.Parameters["@RoleID"].Value = (cbbRole.SelectedIndex + 1);
            cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
            cmd.Parameters["@Actived"].Value = 1;
            cmd.Parameters["@Notes"].Value = "";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void ShowAccount(SqlDataReader reader)
        {
            while (reader.Read())
            {
                txtAccountName.Text = reader["AccountName"].ToString();
                txtPassword.Text = reader["Password"].ToString();
                txtHoTen.Text = reader["FullName"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtSDT.Text = reader["Tell"].ToString();
                cbbRole.Text = reader["RoleName"].ToString();
            }
        }

        private void AccountSettingForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            if (_AccountName != null)
            {
                txtAccountName.Enabled = false;
                cbbRole.Enabled = false;
                txtPassword.Enabled = true;
                string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand cmd = sqlConnection.CreateCommand();
                string query = "SELECT A.AccountName, Password, FullName, Email, Tell, RoleName "
                         + "FROM Account A, [Role] B, RoleAccount C "
                         + "WHERE A.AccountName = C.AccountName AND B.ID = C.RoleID AND A.AccountName = @AccountName";
                cmd.CommandText = query;

                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar);
                cmd.Parameters["@AccountName"].Value = _AccountName;

                sqlConnection.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                ShowAccount(sqlDataReader);
                sqlConnection.Close();
            }
            else
            {
                txtPassword.Text = "1";
                txtPassword.Enabled = false;
               
            }
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (_AccountName == null)
            {
                if (string.IsNullOrWhiteSpace(txtAccountName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)
                    || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(cbbRole.Text))
                    MessageBox.Show("Chưa nhập đầy đủ điều kiện để tạo tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
                    MessageBox.Show("Chưa nhập đầy đủ điều kiện để tạo tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
    }


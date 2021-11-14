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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        private void LoadListView()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT AccountName, FullName, Email, Tell FROM Account";

            connection.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();
            lvAccount.Items.Clear();
            while (sqlReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlReader["AccountName"].ToString());
                item.SubItems.Add(sqlReader["FullName"].ToString());
                item.SubItems.Add(sqlReader["Email"].ToString());
                item.SubItems.Add(sqlReader["Tell"].ToString());
                lvAccount.Items.Add(item);
            }
            connection.Close();
            connection.Dispose();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

       

        private static AccountSettingForm GetFrm()
        {
            return new 
                AccountSettingForm(null);
        }

        private void lvAccount_DoubleClick(object sender, EventArgs e)
        {
            int count = lvAccount.SelectedItems.Count;
            if (count > 0)
            {
                AccountSettingForm frm = new AccountSettingForm(lvAccount.SelectedItems[0].SubItems[0].Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadListView();
                }
            }
        }

        private void ViewRoleNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvAccount.SelectedItems.Count;
            if (count > 0)
            {
                DSVTForm frm = GetFrm1();
                frm.ShowDialog();
            }
        }

        private DSVTForm GetFrm1()
        {
            return new 
                
                DSVTForm(lvAccount.SelectedItems[0].SubItems[0].Text);
        }

      
        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountSettingForm frm = GetFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadListView();
            }
        }
    }
}

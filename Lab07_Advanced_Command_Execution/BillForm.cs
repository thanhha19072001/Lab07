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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        private void SetTitle()
        {
            dgvBill.Columns["ID"].HeaderText = "Mã";
            dgvBill.Columns["Name"].HeaderText = "Tên món ăn";
            dgvBill.Columns["Quantity"].HeaderText = "Số lượng";
            dgvBill.Columns["Price"].HeaderText = "Đơn giá";
            dgvBill.Columns["Summary"].HeaderText = "Thành tiền";
        }

        public void LoadBillDetails(string BillID)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT A.ID, B.Name, Quantity, B.Price, B.Price * Quantity as Summary FROM BillDetails A, Food B WHERE A.FoodID = B.ID AND A.InvoiceID = @BillID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters["@BillID"].Value = Convert.ToInt32(BillID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillDetailsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillDetailsTable);
            conn.Close();
            conn.Dispose();

            dgvBill.DataSource = BillDetailsTable;
            SetTitle();
        }


        private void dgvBillDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                BillForm billDetail = new BillForm();
                billDetail.Show();
                billDetail.LoadFoods(int.Parse(dgvBill.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void LoadFoods(int v)
        {
            throw new NotImplementedException();
        }

        private void LoadFoods(string BillID)
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT A.ID, B.Name, Quantity, B.Price, B.Price * Quantity as Summary FROM BillDetails A, Food B WHERE A.FoodID = B.ID AND A.InvoiceID = @BillID";

            cmd.Parameters.Add("@BillID", SqlDbType.Int);
            cmd.Parameters["@BillID"].Value = Convert.ToInt32(BillID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillDetailsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillDetailsTable);
            conn.Close();
            conn.Dispose();

            dgvBill.DataSource = BillDetailsTable;
            SetTitle();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }
    }
}

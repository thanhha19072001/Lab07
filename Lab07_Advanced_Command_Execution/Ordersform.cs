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
    public partial class Ordersform : Form
    {
        public Ordersform()
        {
            InitializeComponent();
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            int count = dgvBills.SelectedRows.Count;
            if (count > 0)
            {
                DataGridViewRow row = dgvBills.SelectedRows[0];
                string BillID = row.Cells[0].Value.ToString();
                if (!string.IsNullOrWhiteSpace(BillID))
                {
                    BillForm frm = new BillForm();
                    frm.LoadBillDetails(BillID);
                    frm.ShowDialog();
                }
            }
        }

        private void tsrSummary_Click(object sender, EventArgs e)
        {

        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ordersform_Load(object sender, EventArgs e)
        {
            LoadBills();
        }
        private void LoadBills()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bills WHERE CheckoutDate = @checkoutDate";

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable BillsTable = new DataTable();

            conn.Open();
            adapter.Fill(BillsTable);
            conn.Close();
            conn.Dispose();

            dgvBills.DataSource = BillsTable;
            SetTitles();

        }

        private void SetTitles()
        {
            dgvBills.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBills.Columns[1].HeaderText = "Tên hóa đơn";
            dgvBills.Columns[2].HeaderText = "Mã bàn";
            dgvBills.Columns[3].HeaderText = "Trị giá hóa đơn";
            dgvBills.Columns[4].HeaderText = "Giảm giá %";
            dgvBills.Columns[5].HeaderText = "Thuế";
            dgvBills.Columns[6].HeaderText = "Đã thanh toán";
            dgvBills.Columns[7].HeaderText = "Ngày thanh toán";
            dgvBills.Columns[8].HeaderText = "Tên tài khoản";
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBills();
            CalAmountSummary();
        }
        private void CalAmountSummary()
        {
            string connectionString = @"Data Source=LAPTOP-RMHJJA7H;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSummary = SUM(Amount) FROM Bills WHERE " +
                " CheckoutDate=@checkoutDate";

            cmd.Parameters.Add("@numSummary", SqlDbType.Int);
            cmd.Parameters["@numSummary"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@checkoutDate", SqlDbType.SmallDateTime);
            cmd.Parameters["@checkoutDate"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));


            conn.Open();
            cmd.ExecuteNonQuery();
            int summary = 0;
            for (int i = 0; i < dgvBills.Rows.Count - 1; i++)
            {
                summary += int.Parse(dgvBills.Rows[i].Cells["Amount"].Value.ToString());
            }
            if (string.IsNullOrWhiteSpace(summary.ToString()))
                summary = 0;
            tsrSummary.Text = "Tổng doanh thu trong ngày là: " + summary + "VNĐ";
            conn.Close();
            conn.Dispose();
        }
    }
}

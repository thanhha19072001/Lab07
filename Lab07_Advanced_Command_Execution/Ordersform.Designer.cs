
namespace Lab07_Advanced_Command_Execution
{
    partial class Ordersform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.tsSummary = new System.Windows.Forms.ToolStrip();
            this.tsrSummary = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.tsSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date/time:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(659, 12);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(175, 25);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvBills
            // 
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(42, 56);
            this.dgvBills.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.Size = new System.Drawing.Size(1257, 523);
            this.dgvBills.TabIndex = 4;
            this.dgvBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellContentClick);
            // 
            // tsSummary
            // 
            this.tsSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSummary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrSummary});
            this.tsSummary.Location = new System.Drawing.Point(0, 609);
            this.tsSummary.Name = "tsSummary";
            this.tsSummary.Size = new System.Drawing.Size(1340, 25);
            this.tsSummary.TabIndex = 5;
            this.tsSummary.Text = "Tổng doanh thu:";
            // 
            // tsrSummary
            // 
            this.tsrSummary.ActiveLinkColor = System.Drawing.Color.Blue;
            this.tsrSummary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsrSummary.Name = "tsrSummary";
            this.tsrSummary.Size = new System.Drawing.Size(133, 22);
            this.tsrSummary.Text = "Tổng doanh thu:";
            this.tsrSummary.VisitedLinkColor = System.Drawing.Color.Red;
            this.tsrSummary.Click += new System.EventHandler(this.tsrSummary_Click);
            // 
            // Ordersform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 634);
            this.Controls.Add(this.tsSummary);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Ordersform";
            this.Text = "Ordersform";
            this.Load += new System.EventHandler(this.Ordersform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.tsSummary.ResumeLayout(false);
            this.tsSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.ToolStrip tsSummary;
        private System.Windows.Forms.ToolStripLabel tsrSummary;
    }
}
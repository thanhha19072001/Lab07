
namespace Lab07_Advanced_Command_Execution
{
    partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemDanhSáchCácVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhậtKýHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddAccountToolStripMenuItem
            // 
            this.AddAccountToolStripMenuItem.Name = "AddAccountToolStripMenuItem";
            this.AddAccountToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.AddAccountToolStripMenuItem.Text = "Thêm tài khoản";
            this.AddAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItem_Click_1);
            // 
            // lvAccount
            // 
            this.lvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAccount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.GridLines = true;
            this.lvAccount.HideSelection = false;
            this.lvAccount.Location = new System.Drawing.Point(0, 29);
            this.lvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(800, 434);
            this.lvAccount.TabIndex = 3;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            this.lvAccount.SelectedIndexChanged += new System.EventHandler(this.lvAccount_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên tài khoản";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 225;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tell";
            this.columnHeader4.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchCácVaiTròToolStripMenuItem,
            this.xemNhậtKýHoạtĐộngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 52);
            // 
            // xemDanhSáchCácVaiTròToolStripMenuItem
            // 
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Name = "xemDanhSáchCácVaiTròToolStripMenuItem";
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Text = "Xem danh sách các vai trò";
            // 
            // xemNhậtKýHoạtĐộngToolStripMenuItem
            // 
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Name = "xemNhậtKýHoạtĐộngToolStripMenuItem";
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Text = "Xem nhật ký hoạt động";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lvAccount);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddAccountToolStripMenuItem;
        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchCácVaiTròToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoạtĐộngToolStripMenuItem;
    }
}
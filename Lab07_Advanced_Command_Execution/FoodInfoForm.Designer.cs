
namespace Lab07_Advanced_Command_Execution
{
    partial class FoodInfoForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbCatName = new System.Windows.Forms.ComboBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(347, 339);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.Location = new System.Drawing.Point(184, 339);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(92, 35);
            this.btnUpdateFood.TabIndex = 32;
            this.btnUpdateFood.Text = "Cập Nhật";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click_1);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(19, 340);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(98, 34);
            this.btnAddFood.TabIndex = 31;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click_1);
            // 
            // nmrPrice
            // 
            this.nmrPrice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrPrice.Location = new System.Drawing.Point(166, 215);
            this.nmrPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmrPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(167, 25);
            this.nmrPrice.TabIndex = 30;
            // 
            // cbbCatName
            // 
            this.cbbCatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCatName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCatName.FormattingEnabled = true;
            this.cbbCatName.Location = new System.Drawing.Point(166, 157);
            this.cbbCatName.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCatName.Name = "cbbCatName";
            this.cbbCatName.Size = new System.Drawing.Size(184, 25);
            this.cbbCatName.TabIndex = 29;
            this.cbbCatName.SelectedIndexChanged += new System.EventHandler(this.cbbCatName_SelectedIndexChanged);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(358, 157);
            this.btnAddNewCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(95, 28);
            this.btnAddNewCategory.TabIndex = 28;
            this.btnAddNewCategory.Text = "Thêm mới";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ghi chú";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(165, 275);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(288, 25);
            this.txtNotes.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên nhóm món ăn";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(166, 94);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 25);
            this.txtName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên món";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodID.Location = new System.Drawing.Point(166, 37);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(168, 25);
            this.txtFoodID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã số";
            // 
            // FoodInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.nmrPrice);
            this.Controls.Add(this.cbbCatName);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.label1);
            this.Name = "FoodInfoForm";
            this.Text = "FoodInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.ComboBox cbbCatName;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label1;
    }
}
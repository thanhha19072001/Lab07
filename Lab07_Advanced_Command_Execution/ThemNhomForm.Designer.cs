
namespace Lab07_Advanced_Command_Execution
{
    partial class ThemNhomForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.rdTypeDrink = new System.Windows.Forms.RadioButton();
            this.rdTypeFood = new System.Windows.Forms.RadioButton();
            this.txtNameCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(220, 86);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdTypeDrink
            // 
            this.rdTypeDrink.AutoSize = true;
            this.rdTypeDrink.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTypeDrink.Location = new System.Drawing.Point(403, 55);
            this.rdTypeDrink.Margin = new System.Windows.Forms.Padding(4);
            this.rdTypeDrink.Name = "rdTypeDrink";
            this.rdTypeDrink.Size = new System.Drawing.Size(97, 25);
            this.rdTypeDrink.TabIndex = 9;
            this.rdTypeDrink.TabStop = true;
            this.rdTypeDrink.Text = "Đồ uống";
            this.rdTypeDrink.UseVisualStyleBackColor = true;
            // 
            // rdTypeFood
            // 
            this.rdTypeFood.AutoSize = true;
            this.rdTypeFood.Checked = true;
            this.rdTypeFood.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTypeFood.Location = new System.Drawing.Point(328, 55);
            this.rdTypeFood.Margin = new System.Windows.Forms.Padding(4);
            this.rdTypeFood.Name = "rdTypeFood";
            this.rdTypeFood.Size = new System.Drawing.Size(77, 25);
            this.rdTypeFood.TabIndex = 8;
            this.rdTypeFood.TabStop = true;
            this.rdTypeFood.Text = "Đồ ăn";
            this.rdTypeFood.UseVisualStyleBackColor = true;
            // 
            // txtNameCat
            // 
            this.txtNameCat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCat.Location = new System.Drawing.Point(141, 53);
            this.txtNameCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCat.Name = "txtNameCat";
            this.txtNameCat.Size = new System.Drawing.Size(179, 25);
            this.txtNameCat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhóm món ăn:";
            // 
            // ThemNhomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 130);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdTypeDrink);
            this.Controls.Add(this.rdTypeFood);
            this.Controls.Add(this.txtNameCat);
            this.Controls.Add(this.label1);
            this.Name = "ThemNhomForm";
            this.Text = "ThemNhomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdTypeDrink;
        private System.Windows.Forms.RadioButton rdTypeFood;
        private System.Windows.Forms.TextBox txtNameCat;
        private System.Windows.Forms.Label label1;
    }
}
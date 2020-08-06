namespace DVD_Project
{
    partial class Form_Add
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelQuantity_In_Stock = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(79, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(79, 86);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // labelQuantity_In_Stock
            // 
            this.labelQuantity_In_Stock.AutoSize = true;
            this.labelQuantity_In_Stock.Location = new System.Drawing.Point(79, 131);
            this.labelQuantity_In_Stock.Name = "labelQuantity_In_Stock";
            this.labelQuantity_In_Stock.Size = new System.Drawing.Size(89, 13);
            this.labelQuantity_In_Stock.TabIndex = 2;
            this.labelQuantity_In_Stock.Text = "Quantity In Stock";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(155, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(152, 20);
            this.textName.TabIndex = 3;
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(155, 83);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(152, 20);
            this.textCategory.TabIndex = 4;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(207, 124);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 20);
            this.textQuantity.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(82, 193);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(232, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelQuantity_In_Stock);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Add";
            this.Text = "Stock System";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelQuantity_In_Stock;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
namespace WMSProject
{
    partial class FrmProduct
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
            label3 = new Label();
            txtStocklvl = new TextBox();
            button4 = new Button();
            txtCategory = new TextBox();
            label8 = new Label();
            txtExpiry = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            btnConfirm = new Button();
            txtThreshold = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSerialNo = new TextBox();
            label9 = new Label();
            txtModelNo = new TextBox();
            txtModel = new TextBox();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(332, 256);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 41;
            label3.Text = "Stock Level:";
            // 
            // txtStocklvl
            // 
            txtStocklvl.Anchor = AnchorStyles.None;
            txtStocklvl.BackColor = SystemColors.Control;
            txtStocklvl.Location = new Point(332, 272);
            txtStocklvl.Name = "txtStocklvl";
            txtStocklvl.Size = new Size(110, 23);
            txtStocklvl.TabIndex = 40;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(145, 272);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 39;
            button4.Text = "Set Reorder Threshold";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.None;
            txtCategory.Location = new Point(332, 62);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(110, 23);
            txtCategory.TabIndex = 38;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(332, 45);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 37;
            label8.Text = "Category:";
            // 
            // txtExpiry
            // 
            txtExpiry.Anchor = AnchorStyles.None;
            txtExpiry.Location = new Point(332, 127);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(110, 23);
            txtExpiry.TabIndex = 36;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(332, 109);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 35;
            label7.Text = "Expiry Date:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(332, 329);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Location = new Point(185, 329);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(32, 329);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(82, 22);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtThreshold
            // 
            txtThreshold.Anchor = AnchorStyles.None;
            txtThreshold.BackColor = SystemColors.Control;
            txtThreshold.Location = new Point(32, 273);
            txtThreshold.Margin = new Padding(3, 2, 3, 2);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(110, 23);
            txtThreshold.TabIndex = 31;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Location = new Point(180, 126);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 30;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.None;
            txtQuantity.Location = new Point(32, 126);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 29;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(180, 62);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 28;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.None;
            txtCode.Location = new Point(32, 62);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(110, 23);
            txtCode.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(32, 256);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 26;
            label6.Text = "Reorder Threshold:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(32, 109);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 25;
            label5.Text = "Quantity:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(180, 109);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 24;
            label4.Text = "Unit Price:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(180, 45);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 23;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 22;
            label1.Text = "Product Code";
            // 
            // txtSerialNo
            // 
            txtSerialNo.Anchor = AnchorStyles.None;
            txtSerialNo.Location = new Point(332, 203);
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.Size = new Size(110, 23);
            txtSerialNo.TabIndex = 47;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(332, 185);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 46;
            label9.Text = "Serial Number:";
            // 
            // txtModelNo
            // 
            txtModelNo.Anchor = AnchorStyles.None;
            txtModelNo.Location = new Point(185, 202);
            txtModelNo.Margin = new Padding(3, 2, 3, 2);
            txtModelNo.Name = "txtModelNo";
            txtModelNo.Size = new Size(110, 23);
            txtModelNo.TabIndex = 45;
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.None;
            txtModel.Location = new Point(32, 202);
            txtModel.Margin = new Padding(3, 2, 3, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(110, 23);
            txtModel.TabIndex = 44;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(32, 185);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 43;
            label10.Text = "Model Name:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(185, 185);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 42;
            label11.Text = "Model Number:";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 398);
            Controls.Add(txtSerialNo);
            Controls.Add(label9);
            Controls.Add(txtModelNo);
            Controls.Add(txtModel);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(txtStocklvl);
            Controls.Add(button4);
            Controls.Add(txtCategory);
            Controls.Add(label8);
            Controls.Add(txtExpiry);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(txtThreshold);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduct";
            Text = "FrmProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtStocklvl;
        private Button button4;
        private TextBox txtCategory;
        private Label label8;
        private TextBox txtExpiry;
        private Label label7;
        private Button btnCancel;
        private Button btnClear;
        private Button btnConfirm;
        private TextBox txtThreshold;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private TextBox txtCode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtSerialNo;
        private Label label9;
        private TextBox txtModelNo;
        private TextBox txtModel;
        private Label label10;
        private Label label11;
    }
}
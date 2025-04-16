namespace WMSProject
{
    partial class FrmMain
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
            btnInventory = new Button();
            btnOrder = new Button();
            btnUser = new Button();
            btnLogout = new Button();
            btnAccount = new Button();
            label1 = new Label();
            lblUser = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(56, 115);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(165, 33);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Inventory Management";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(56, 186);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(165, 29);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(56, 259);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(165, 29);
            btnUser.TabIndex = 2;
            btnUser.Text = "User Management";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(261, 298);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(62, 26);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(184, 37);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(139, 33);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Account Management";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Logged in as:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(258, 19);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 97);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 7;
            label3.Text = "Manage inventory and items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 168);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 8;
            label4.Text = "Create and track orders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 241);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 9;
            label5.Text = "Support and manage users";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 336);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(btnAccount);
            Controls.Add(btnLogout);
            Controls.Add(btnUser);
            Controls.Add(btnOrder);
            Controls.Add(btnInventory);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInventory;
        private Button btnOrder;
        private Button btnUser;
        private Button btnLogout;
        private Button btnAccount;
        private Label label1;
        private Label lblUser;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
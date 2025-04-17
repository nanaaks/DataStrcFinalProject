namespace WMSProject
{
    partial class FrmUser
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
            btnReset = new Button();
            btnShow = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            txtUser = new TextBox();
            label3 = new Label();
            txtLname = new TextBox();
            txtFname = new TextBox();
            groupBox1 = new GroupBox();
            rbWorker = new RadioButton();
            rbSupervisor = new RadioButton();
            rbManager = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            dataUsers = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsers).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.Location = new Point(340, 314);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 23);
            btnReset.TabIndex = 31;
            btnReset.Text = "Reset Password";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.None;
            btnShow.Location = new Point(22, 359);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(92, 23);
            btnShow.TabIndex = 30;
            btnShow.Text = "Show All Users";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Location = new Point(502, 359);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(150, 359);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Location = new Point(406, 63);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(164, 23);
            txtUser.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(353, 66);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 25;
            label3.Text = "User ID:";
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.None;
            txtLname.Location = new Point(406, 144);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(164, 23);
            txtLname.TabIndex = 24;
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.None;
            txtFname.Location = new Point(406, 102);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(164, 23);
            txtFname.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(rbWorker);
            groupBox1.Controls.Add(rbSupervisor);
            groupBox1.Controls.Add(rbManager);
            groupBox1.Location = new Point(340, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(138, 100);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Job Title";
            // 
            // rbWorker
            // 
            rbWorker.AutoSize = true;
            rbWorker.Location = new Point(10, 72);
            rbWorker.Name = "rbWorker";
            rbWorker.Size = new Size(63, 19);
            rbWorker.TabIndex = 2;
            rbWorker.TabStop = true;
            rbWorker.Text = "Worker";
            rbWorker.UseVisualStyleBackColor = true;
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(10, 47);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(80, 19);
            rbSupervisor.TabIndex = 1;
            rbSupervisor.TabStop = true;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            rbManager.AutoSize = true;
            rbManager.Location = new Point(10, 22);
            rbManager.Name = "rbManager";
            rbManager.Size = new Size(72, 19);
            rbManager.TabIndex = 0;
            rbManager.TabStop = true;
            rbManager.Text = "Manager";
            rbManager.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(340, 147);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 21;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(339, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 20;
            label1.Text = "First Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Location = new Point(340, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Location = new Point(245, 359);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(421, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataUsers
            // 
            dataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsers.Location = new Point(22, 63);
            dataUsers.Name = "dataUsers";
            dataUsers.Size = new Size(298, 290);
            dataUsers.TabIndex = 32;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 414);
            Controls.Add(dataUsers);
            Controls.Add(btnReset);
            Controls.Add(btnShow);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "FrmUser";
            Text = "FrmUser";
            Load += FrmUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReset;
        private Button btnShow;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtUser;
        private Label label3;
        private TextBox txtLname;
        private TextBox txtFname;
        private GroupBox groupBox1;
        private RadioButton rbWorker;
        private RadioButton rbSupervisor;
        private RadioButton rbManager;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnAdd;
        private DataGridView dataUsers;
    }
}
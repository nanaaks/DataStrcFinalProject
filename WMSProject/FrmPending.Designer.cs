namespace WMSProject
{
    partial class FrmPending
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
            btnExit = new Button();
            listPending = new ListBox();
            btnCancel = new Button();
            btnApprove = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Location = new Point(272, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 23);
            btnExit.TabIndex = 35;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listPending
            // 
            listPending.Anchor = AnchorStyles.None;
            listPending.FormattingEnabled = true;
            listPending.ItemHeight = 15;
            listPending.Location = new Point(39, 43);
            listPending.Name = "listPending";
            listPending.Size = new Size(334, 229);
            listPending.TabIndex = 34;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(157, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 23);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApprove
            // 
            btnApprove.Anchor = AnchorStyles.None;
            btnApprove.Location = new Point(39, 304);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(85, 23);
            btnApprove.TabIndex = 32;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // FrmPending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 354);
            Controls.Add(btnExit);
            Controls.Add(listPending);
            Controls.Add(btnCancel);
            Controls.Add(btnApprove);
            Name = "FrmPending";
            Text = "FrmPending";
            Load += FrmPending_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private ListBox listPending;
        private Button btnCancel;
        private Button btnApprove;
    }
}
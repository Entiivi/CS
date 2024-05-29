namespace _5_Darbas
{
    partial class Pagrindinis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            txtPassword = new TextBox();
            txtUrl = new TextBox();
            txtComment = new TextBox();
            label5 = new Label();
            vv = new Label();
            txtSearchTitle = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 53);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "URL/Application";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 161);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Comment";
            // 
            // txtTitle
            // 
            txtTitle.ImeMode = ImeMode.Off;
            txtTitle.Location = new Point(60, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(383, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(355, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(125, 123);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(318, 23);
            txtUrl.TabIndex = 6;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(92, 158);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(351, 23);
            txtComment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 22);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 8;
            label5.Text = "Sukurimas";
            // 
            // vv
            // 
            vv.AutoSize = true;
            vv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vv.Location = new Point(25, 294);
            vv.Name = "vv";
            vv.Size = new Size(52, 16);
            vv.TabIndex = 9;
            vv.Text = "Search";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(60, 325);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(351, 23);
            txtSearchTitle.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.YellowGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(25, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(229, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(127, 198);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MistyRose;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(25, 366);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 34);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 328);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 15;
            label6.Text = "Title";
            // 
            // Pagrindinis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtSearchTitle);
            Controls.Add(vv);
            Controls.Add(label5);
            Controls.Add(txtComment);
            Controls.Add(txtUrl);
            Controls.Add(txtPassword);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pagrindinis";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtPassword;
        private TextBox txtUrl;
        private TextBox txtComment;
        private Label label5;
        private Label vv;
        private TextBox txtSearchTitle;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Label label6;
    }
}

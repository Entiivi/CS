namespace Praktinis3duomSaug
{
    partial class Form1
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
            prad = new RichTextBox();
            p = new TextBox();
            q = new TextBox();
            label1 = new Label();
            label2 = new Label();
            x = new Label();
            isve = new RichTextBox();
            res = new Label();
            En = new Button();
            De = new Button();
            button1 = new Button();
            CheckIFfile = new CheckBox();
            SuspendLayout();
            // 
            // prad
            // 
            prad.Location = new Point(12, 98);
            prad.Name = "prad";
            prad.Size = new Size(343, 224);
            prad.TabIndex = 0;
            prad.Text = "";
            // 
            // p
            // 
            p.Location = new Point(12, 33);
            p.Name = "p";
            p.Size = new Size(100, 23);
            p.TabIndex = 1;
            // 
            // q
            // 
            q.Location = new Point(124, 33);
            q.Name = "q";
            q.Size = new Size(100, 23);
            q.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 3;
            label1.Text = "p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 9);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 4;
            label2.Text = "q";
            // 
            // x
            // 
            x.AutoSize = true;
            x.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x.Location = new Point(12, 74);
            x.Name = "x";
            x.Size = new Size(131, 21);
            x.TabIndex = 5;
            x.Text = "Pradinis Tekstas";
            // 
            // isve
            // 
            isve.Location = new Point(418, 98);
            isve.Name = "isve";
            isve.Size = new Size(370, 224);
            isve.TabIndex = 6;
            isve.Text = "";
            // 
            // res
            // 
            res.AutoSize = true;
            res.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res.Location = new Point(418, 74);
            res.Name = "res";
            res.Size = new Size(65, 21);
            res.TabIndex = 7;
            res.Text = "Išvestis";
            // 
            // En
            // 
            En.BackColor = Color.LightGreen;
            En.FlatAppearance.BorderSize = 0;
            En.FlatStyle = FlatStyle.Flat;
            En.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            En.Location = new Point(247, 354);
            En.Name = "En";
            En.Size = new Size(108, 36);
            En.TabIndex = 8;
            En.Text = "Šifruoti";
            En.UseVisualStyleBackColor = false;
            En.Click += En_Click;
            // 
            // De
            // 
            De.BackColor = Color.IndianRed;
            De.FlatAppearance.BorderSize = 0;
            De.FlatStyle = FlatStyle.Flat;
            De.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            De.Location = new Point(418, 354);
            De.Name = "De";
            De.Size = new Size(108, 36);
            De.TabIndex = 9;
            De.Text = "Dešifruoti";
            De.UseVisualStyleBackColor = false;
            De.Click += De_Click;
            // 
            // button1
            // 
            button1.Location = new Point(230, 32);
            button1.Name = "button1";
            button1.Size = new Size(125, 24);
            button1.TabIndex = 10;
            button1.Text = "Generuoti Raktus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheckIFfile
            // 
            CheckIFfile.AutoSize = true;
            CheckIFfile.Location = new Point(12, 328);
            CheckIFfile.Name = "CheckIFfile";
            CheckIFfile.Size = new Size(146, 19);
            CheckIFfile.TabIndex = 11;
            CheckIFfile.Text = "Skaityti plain text is file";
            CheckIFfile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CheckIFfile);
            Controls.Add(button1);
            Controls.Add(De);
            Controls.Add(En);
            Controls.Add(res);
            Controls.Add(isve);
            Controls.Add(x);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(q);
            Controls.Add(p);
            Controls.Add(prad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label x;
        private Label res;
        private Button En;
        private Button De;
        internal RichTextBox isve;
        private Button button1;
        public TextBox p;
        public TextBox q;
        public RichTextBox prad;
        private CheckBox CheckIFfile;
    }
}

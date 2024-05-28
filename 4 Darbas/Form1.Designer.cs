namespace CS_4_Darbas
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 191);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 4;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 263);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 5;
            label2.Text = "Signature";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 528);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(776, 191);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(74, 742);
            button1.Name = "button1";
            button1.Size = new Size(257, 66);
            button1.TabIndex = 7;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(473, 742);
            button2.Name = "button2";
            button2.Size = new Size(257, 66);
            button2.TabIndex = 8;
            button2.Text = "Verify";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 504);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 9;
            label3.Text = "Signature verify text";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(776, 191);
            textBox3.TabIndex = 10;
            textBox3.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 841);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private RichTextBox textBox3;
    }
}

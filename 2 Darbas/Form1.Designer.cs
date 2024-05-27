namespace _2_Praktinis_Informacijos_saugumas
{
    partial class Form1
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
            this.Enc = new System.Windows.Forms.Button();
            this.PraT = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.RezT = new System.Windows.Forms.TextBox();
            this.radioButtonECB = new System.Windows.Forms.RadioButton();
            this.radioButtonCBC = new System.Windows.Forms.RadioButton();
            this.radioButtonCFB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enc
            // 
            this.Enc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Enc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Enc.FlatAppearance.BorderSize = 10;
            this.Enc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Enc.Location = new System.Drawing.Point(12, 528);
            this.Enc.Name = "Enc";
            this.Enc.Size = new System.Drawing.Size(413, 39);
            this.Enc.TabIndex = 1;
            this.Enc.Text = "Šifruoti";
            this.Enc.UseVisualStyleBackColor = false;
            this.Enc.Click += new System.EventHandler(this.Enc_Click);
            // 
            // PraT
            // 
            this.PraT.Location = new System.Drawing.Point(12, 99);
            this.PraT.Multiline = true;
            this.PraT.Name = "PraT";
            this.PraT.Size = new System.Drawing.Size(419, 274);
            this.PraT.TabIndex = 2;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(12, 412);
            this.Key.Multiline = true;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(114, 22);
            this.Key.TabIndex = 3;
            // 
            // RezT
            // 
            this.RezT.Location = new System.Drawing.Point(462, 99);
            this.RezT.Multiline = true;
            this.RezT.Name = "RezT";
            this.RezT.ReadOnly = true;
            this.RezT.Size = new System.Drawing.Size(463, 274);
            this.RezT.TabIndex = 4;
            // 
            // radioButtonECB
            // 
            this.radioButtonECB.AutoSize = true;
            this.radioButtonECB.Location = new System.Drawing.Point(12, 489);
            this.radioButtonECB.Name = "radioButtonECB";
            this.radioButtonECB.Size = new System.Drawing.Size(46, 17);
            this.radioButtonECB.TabIndex = 9;
            this.radioButtonECB.TabStop = true;
            this.radioButtonECB.Text = "ECB";
            this.radioButtonECB.UseVisualStyleBackColor = true;
            this.radioButtonECB.CheckedChanged += new System.EventHandler(this.radioButtonECB_CheckedChanged);
            // 
            // radioButtonCBC
            // 
            this.radioButtonCBC.AutoSize = true;
            this.radioButtonCBC.Location = new System.Drawing.Point(64, 489);
            this.radioButtonCBC.Name = "radioButtonCBC";
            this.radioButtonCBC.Size = new System.Drawing.Size(46, 17);
            this.radioButtonCBC.TabIndex = 10;
            this.radioButtonCBC.TabStop = true;
            this.radioButtonCBC.Text = "CBC";
            this.radioButtonCBC.UseVisualStyleBackColor = true;
            this.radioButtonCBC.CheckedChanged += new System.EventHandler(this.radioButtonCBC_CheckedChanged);
            // 
            // radioButtonCFB
            // 
            this.radioButtonCFB.AutoSize = true;
            this.radioButtonCFB.Location = new System.Drawing.Point(116, 489);
            this.radioButtonCFB.Name = "radioButtonCFB";
            this.radioButtonCFB.Size = new System.Drawing.Size(45, 17);
            this.radioButtonCFB.TabIndex = 12;
            this.radioButtonCFB.TabStop = true;
            this.radioButtonCFB.Text = "CFB";
            this.radioButtonCFB.UseVisualStyleBackColor = true;
            this.radioButtonCFB.CheckedChanged += new System.EventHandler(this.radioButtonCFB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Teksto šifravimas naudojant DES algoritmą";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pradinis tekstas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rezultatas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Raktas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(15, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modai";
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.Color.LightSalmon;
            this.Dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dec.FlatAppearance.BorderSize = 10;
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dec.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dec.Location = new System.Drawing.Point(512, 528);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(413, 39);
            this.Dec.TabIndex = 20;
            this.Dec.Text = "Dešifruoti";
            this.Dec.UseVisualStyleBackColor = false;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "DES  algoritmo rakto ilgis turi buti 8 symboliu ilgio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Skaityti faila";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Irasyti faila";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCFB);
            this.Controls.Add(this.radioButtonCBC);
            this.Controls.Add(this.radioButtonECB);
            this.Controls.Add(this.RezT);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.PraT);
            this.Controls.Add(this.Enc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enc;
        private System.Windows.Forms.TextBox PraT;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox RezT;
        private System.Windows.Forms.RadioButton radioButtonECB;
        private System.Windows.Forms.RadioButton radioButtonCBC;
        private System.Windows.Forms.RadioButton radioButtonCFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


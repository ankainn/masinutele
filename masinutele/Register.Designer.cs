namespace masinutele
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserReg = new System.Windows.Forms.TextBox();
            this.PassReg = new System.Windows.Forms.TextBox();
            this.InregistrareBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UserReg);
            this.panel1.Controls.Add(this.PassReg);
            this.panel1.Controls.Add(this.InregistrareBtn);
            this.panel1.Location = new System.Drawing.Point(-65, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 639);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(809, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "INREGISTRARE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(893, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(791, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume de utilizator";
            // 
            // UserReg
            // 
            this.UserReg.Location = new System.Drawing.Point(992, 341);
            this.UserReg.Name = "UserReg";
            this.UserReg.Size = new System.Drawing.Size(134, 27);
            this.UserReg.TabIndex = 2;
            this.UserReg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PassReg
            // 
            this.PassReg.Location = new System.Drawing.Point(992, 387);
            this.PassReg.Name = "PassReg";
            this.PassReg.Size = new System.Drawing.Size(134, 27);
            this.PassReg.TabIndex = 1;
            this.PassReg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InregistrareBtn
            // 
            this.InregistrareBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InregistrareBtn.ForeColor = System.Drawing.Color.Black;
            this.InregistrareBtn.Location = new System.Drawing.Point(992, 440);
            this.InregistrareBtn.Name = "InregistrareBtn";
            this.InregistrareBtn.Size = new System.Drawing.Size(134, 37);
            this.InregistrareBtn.TabIndex = 0;
            this.InregistrareBtn.Text = "INREGISTRARE";
            this.InregistrareBtn.UseVisualStyleBackColor = true;
            this.InregistrareBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(77, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Daca ai cont deja, apasa aici";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(134, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "INAPOI LA LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 588);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox UserReg;
        private TextBox PassReg;
        private Button InregistrareBtn;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}
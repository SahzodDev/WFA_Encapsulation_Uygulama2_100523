namespace WFA_Encapsulation_Uygulama2_100523
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            btnKaydet = new Button();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            txtTC = new TextBox();
            txtEmail = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 75);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyisim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 180);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "TC :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 236);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(rbKadin);
            groupBox1.Location = new Point(12, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(250, 57);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 6;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(67, 57);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 5;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(55, 413);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(256, 63);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(103, 73);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(224, 27);
            txtIsim.TabIndex = 8;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(103, 124);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(224, 27);
            txtSoyisim.TabIndex = 9;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(103, 178);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(224, 27);
            txtTC.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 488);
            Controls.Add(txtEmail);
            Controls.Add(txtTC);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsim);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private Button btnKaydet;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private TextBox txtTC;
        private TextBox txtEmail;
    }
}
namespace newproject
{
    partial class register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tennguoidung = new TextBox();
            password = new TextBox();
            cfmpassword = new TextBox();
            dangki = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 196);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Comfirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 70);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 16);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "ĐĂNG KÝ";
            // 
            // tennguoidung
            // 
            tennguoidung.Location = new Point(215, 67);
            tennguoidung.Name = "tennguoidung";
            tennguoidung.Size = new Size(277, 27);
            tennguoidung.TabIndex = 4;
            // 
            // password
            // 
            password.Location = new Point(216, 127);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(276, 27);
            password.TabIndex = 5;
            // 
            // cfmpassword
            // 
            cfmpassword.Location = new Point(216, 193);
            cfmpassword.Name = "cfmpassword";
            cfmpassword.PasswordChar = '*';
            cfmpassword.Size = new Size(276, 27);
            cfmpassword.TabIndex = 6;
            // 
            // dangki
            // 
            dangki.Location = new Point(215, 259);
            dangki.Name = "dangki";
            dangki.Size = new Size(94, 29);
            dangki.TabIndex = 7;
            dangki.Text = "Register";
            dangki.UseVisualStyleBackColor = true;
            dangki.Click += dangki_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(374, 259);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 8;
            thoat.Text = "EXIT";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 331);
            Controls.Add(thoat);
            Controls.Add(dangki);
            Controls.Add(cfmpassword);
            Controls.Add(password);
            Controls.Add(tennguoidung);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tennguoidung;
        private TextBox password;
        private TextBox cfmpassword;
        private Button dangki;
        private Button exit;
        private Button thoat;
    }
}
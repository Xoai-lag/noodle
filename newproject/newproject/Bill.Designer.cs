﻿namespace newproject
{
    partial class Bill
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvBill = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            tbTotalbill = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Noodle_removebg_preview;
            pictureBox1.Location = new Point(169, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 143);
            label1.Name = "label1";
            label1.Size = new Size(295, 39);
            label1.TabIndex = 1;
            label1.Text = "HÓA ĐƠN THANH TOÁN";
            label1.Click += label1_Click;
            // 
            // dgvBill
            // 
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(26, 210);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.Size = new Size(427, 344);
            dgvBill.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 571);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 3;
            label2.Text = "___________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(335, 571);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Thành tiền";
            // 
            // tbTotalbill
            // 
            tbTotalbill.BackColor = SystemColors.MenuBar;
            tbTotalbill.Location = new Point(328, 602);
            tbTotalbill.Name = "tbTotalbill";
            tbTotalbill.Size = new Size(125, 27);
            tbTotalbill.TabIndex = 5;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 668);
            Controls.Add(tbTotalbill);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvBill);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvBill;
        private Label label2;
        private Label label3;
        private TextBox tbTotalbill;
    }
}
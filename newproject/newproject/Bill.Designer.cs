namespace newproject
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
            label3 = new Label();
            tbTotalbill = new TextBox();
            btnPayment = new Button();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 587);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Thành tiền";
            // 
            // tbTotalbill
            // 
            tbTotalbill.BackColor = SystemColors.MenuBar;
            tbTotalbill.Location = new Point(146, 591);
            tbTotalbill.Name = "tbTotalbill";
            tbTotalbill.Size = new Size(221, 27);
            tbTotalbill.TabIndex = 5;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = SystemColors.ActiveCaptionText;
            btnPayment.Location = new Point(190, 637);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(117, 44);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "THANH TOÁN";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 693);
            Controls.Add(btnPayment);
            Controls.Add(tbTotalbill);
            Controls.Add(label3);
            Controls.Add(dgvBill);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvBill;
        private Label label3;
        private TextBox tbTotalbill;
        private Button btnPayment;
    }
}
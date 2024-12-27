namespace newproject
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            dgvHome = new DataGridView();
            nudHome = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRepair = new Button();
            comboBox1 = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolTip1 = new ToolTip(components);
            btnLogout = new Button();
            btnConfirm = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvHome
            // 
            dgvHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHome.Location = new Point(18, 240);
            dgvHome.Name = "dgvHome";
            dgvHome.RowHeadersWidth = 51;
            dgvHome.Size = new Size(1464, 468);
            dgvHome.TabIndex = 0;
            dgvHome.CellClick += dgvHome_CellClick;
            // 
            // nudHome
            // 
            nudHome.Location = new Point(807, 100);
            nudHome.Name = "nudHome";
            nudHome.Size = new Size(139, 27);
            nudHome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(680, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 41);
            label1.TabIndex = 3;
            label1.Text = "GIAO DIỆN NGƯỜI DÙNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 4;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(651, 96);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 5;
            label3.Text = "Số lượng";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F);
            btnAdd.Location = new Point(1113, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F);
            btnDelete.Location = new Point(1113, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRepair
            // 
            btnRepair.Font = new Font("Segoe UI", 10.2F);
            btnRepair.Location = new Point(1113, 126);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(85, 30);
            btnRepair.TabIndex = 8;
            btnRepair.Text = "REPAIR";
            btnRepair.UseVisualStyleBackColor = true;
            btnRepair.Click += btnRepair_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(196, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 28);
            comboBox1.TabIndex = 12;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 651);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1494, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1287, 89);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 30);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(1287, 160);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 30);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Noodle_removebg_preview;
            pictureBox1.Location = new Point(18, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 673);
            Controls.Add(pictureBox1);
            Controls.Add(btnConfirm);
            Controls.Add(btnLogout);
            Controls.Add(statusStrip1);
            Controls.Add(comboBox1);
            Controls.Add(btnRepair);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudHome);
            Controls.Add(dgvHome);
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHome;
        private NumericUpDown nudHome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRepair;
        private ComboBox comboBox1;
        private StatusStrip statusStrip1;
        private ToolTip toolTip1;
        private Button btnLogout;
        private Button btnConfirm;
        private PictureBox pictureBox1;
    }
}
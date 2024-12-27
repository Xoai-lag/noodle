namespace newproject
{
    partial class admin
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
            tabControl1 = new TabControl();
            tabFood = new TabPage();
            panel1 = new Panel();
            btnRepair = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtGia = new TextBox();
            label3 = new Label();
            nudQuantity = new NumericUpDown();
            label2 = new Label();
            txtFood = new TextBox();
            label1 = new Label();
            dgvFood = new DataGridView();
            taboders = new TabPage();
            dgvOrder = new DataGridView();
            tabListuser = new TabPage();
            btnXoa = new Button();
            dgvUser = new DataGridView();
            tabControl1.SuspendLayout();
            tabFood.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            taboders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            tabListuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFood);
            tabControl1.Controls.Add(taboders);
            tabControl1.Controls.Add(tabListuser);
            tabControl1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1470, 649);
            tabControl1.TabIndex = 0;
            // 
            // tabFood
            // 
            tabFood.Controls.Add(panel1);
            tabFood.Controls.Add(dgvFood);
            tabFood.Location = new Point(4, 32);
            tabFood.Name = "tabFood";
            tabFood.Padding = new Padding(3);
            tabFood.Size = new Size(1462, 613);
            tabFood.TabIndex = 0;
            tabFood.Text = "Food";
            tabFood.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRepair);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFood);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 160);
            panel1.TabIndex = 1;
            // 
            // btnRepair
            // 
            btnRepair.Location = new Point(912, 51);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(130, 58);
            btnRepair.TabIndex = 8;
            btnRepair.Text = "REPAIR";
            btnRepair.UseVisualStyleBackColor = true;
            btnRepair.Click += btnRepair_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1146, 51);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(677, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 58);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(366, 101);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(160, 30);
            txtGia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 108);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 4;
            label3.Text = "Giá";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(213, 101);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(76, 30);
            nudQuantity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 2;
            label2.Text = "Số lượng";
            // 
            // txtFood
            // 
            txtFood.Location = new Point(213, 34);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(313, 30);
            txtFood.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên Món";
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(20, 28);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.Size = new Size(1420, 385);
            dgvFood.TabIndex = 0;
            dgvFood.CellClick += dgvFood_CellClick;
            // 
            // taboders
            // 
            taboders.Controls.Add(dgvOrder);
            taboders.Location = new Point(4, 32);
            taboders.Name = "taboders";
            taboders.Padding = new Padding(3);
            taboders.Size = new Size(1462, 613);
            taboders.TabIndex = 1;
            taboders.Text = "Oders";
            taboders.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(16, 4);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(1428, 603);
            dgvOrder.TabIndex = 0;
            // 
            // tabListuser
            // 
            tabListuser.Controls.Add(btnXoa);
            tabListuser.Controls.Add(dgvUser);
            tabListuser.Location = new Point(4, 32);
            tabListuser.Name = "tabListuser";
            tabListuser.Padding = new Padding(3);
            tabListuser.Size = new Size(1462, 613);
            tabListuser.TabIndex = 2;
            tabListuser.Text = "ListUser";
            tabListuser.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(615, 546);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 46);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "DELETE";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(21, 10);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(1417, 498);
            dgvUser.TabIndex = 0;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 673);
            Controls.Add(tabControl1);
            Name = "admin";
            Text = "ADMIN";
            Load += admin_Load;
            tabControl1.ResumeLayout(false);
            tabFood.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            taboders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            tabListuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFood;
        private TabPage taboders;
        private TabPage tabListuser;
        private Panel panel1;
        private DataGridView dgvFood;
        private TextBox txtFood;
        private Label label1;
        private Label label3;
        private NumericUpDown nudQuantity;
        private Label label2;
        private TextBox txtGia;
        private Button btnRepair;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvOrder;
        private Button btnXoa;
        private DataGridView dgvUser;
    }
}
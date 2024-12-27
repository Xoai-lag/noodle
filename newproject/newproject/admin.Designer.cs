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
            dtgFood = new DataGridView();
            taboders = new TabPage();
            tabListuser = new TabPage();
            label1 = new Label();
            tbFood = new TextBox();
            label2 = new Label();
            nudQuality = new NumericUpDown();
            label3 = new Label();
            tbCost = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRepair = new Button();
            dgvOrder = new DataGridView();
            dataGridView1 = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            tabControl1.SuspendLayout();
            tabFood.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFood).BeginInit();
            taboders.SuspendLayout();
            tabListuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabFood.Controls.Add(dtgFood);
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
            panel1.Controls.Add(tbCost);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nudQuality);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbFood);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 160);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // dtgFood
            // 
            dtgFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFood.Location = new Point(20, 28);
            dtgFood.Name = "dtgFood";
            dtgFood.RowHeadersWidth = 51;
            dtgFood.Size = new Size(1420, 385);
            dtgFood.TabIndex = 0;
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
            // tabListuser
            // 
            tabListuser.Controls.Add(btnXoa);
            tabListuser.Controls.Add(btnSua);
            tabListuser.Controls.Add(dataGridView1);
            tabListuser.Location = new Point(4, 32);
            tabListuser.Name = "tabListuser";
            tabListuser.Padding = new Padding(3);
            tabListuser.Size = new Size(1462, 613);
            tabListuser.TabIndex = 2;
            tabListuser.Text = "ListUser";
            tabListuser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "Thêm món";
            // 
            // tbFood
            // 
            tbFood.Location = new Point(213, 34);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(313, 30);
            tbFood.TabIndex = 1;
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
            // nudQuality
            // 
            nudQuality.Location = new Point(213, 101);
            nudQuality.Name = "nudQuality";
            nudQuality.Size = new Size(76, 30);
            nudQuality.TabIndex = 3;
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
            // tbCost
            // 
            tbCost.Location = new Point(366, 101);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(160, 30);
            tbCost.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(677, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 58);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1146, 51);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // btnRepair
            // 
            btnRepair.Location = new Point(912, 51);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(130, 58);
            btnRepair.TabIndex = 8;
            btnRepair.Text = "REPAIR";
            btnRepair.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1417, 498);
            dataGridView1.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(478, 546);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 46);
            btnSua.TabIndex = 1;
            btnSua.Text = "REPAIR";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(883, 546);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 46);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "DELETE";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnSua_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 673);
            Controls.Add(tabControl1);
            Name = "admin";
            Text = "ADMIN";
            tabControl1.ResumeLayout(false);
            tabFood.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFood).EndInit();
            taboders.ResumeLayout(false);
            tabListuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFood;
        private TabPage taboders;
        private TabPage tabListuser;
        private Panel panel1;
        private DataGridView dtgFood;
        private TextBox tbFood;
        private Label label1;
        private Label label3;
        private NumericUpDown nudQuality;
        private Label label2;
        private TextBox tbCost;
        private Button btnRepair;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvOrder;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dataGridView1;
    }
}
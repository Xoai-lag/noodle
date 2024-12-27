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
            taboders = new TabPage();
            tabListuser = new TabPage();
            dtgFood = new DataGridView();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFood).BeginInit();
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
            // taboders
            // 
            taboders.Location = new Point(4, 29);
            taboders.Name = "taboders";
            taboders.Padding = new Padding(3);
            taboders.Size = new Size(1462, 616);
            taboders.TabIndex = 1;
            taboders.Text = "Oders";
            taboders.UseVisualStyleBackColor = true;
            // 
            // tabListuser
            // 
            tabListuser.Location = new Point(4, 32);
            tabListuser.Name = "tabListuser";
            tabListuser.Padding = new Padding(3);
            tabListuser.Size = new Size(1462, 613);
            tabListuser.TabIndex = 2;
            tabListuser.Text = "ListUser";
            tabListuser.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Location = new Point(20, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 160);
            panel1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)dtgFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFood;
        private TabPage taboders;
        private TabPage tabListuser;
        private Panel panel1;
        private DataGridView dtgFood;
    }
}
namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    partial class Form4
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
            dtgvLocation = new DataGridView();
            LocationID = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            LocationAddress = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnExit = new Button();
            btnAdd = new Button();
            txbAddress = new TextBox();
            lbAddress = new Label();
            lbCapacity = new Label();
            txbName = new TextBox();
            lbName = new Label();
            txbID = new TextBox();
            lbID = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvLocation).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvLocation
            // 
            dtgvLocation.BackgroundColor = Color.FromArgb(225, 237, 237);
            dtgvLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLocation.Columns.AddRange(new DataGridViewColumn[] { LocationID, LocationName, LocationAddress });
            dtgvLocation.Location = new Point(12, 206);
            dtgvLocation.Name = "dtgvLocation";
            dtgvLocation.RowHeadersWidth = 51;
            dtgvLocation.Size = new Size(776, 232);
            dtgvLocation.TabIndex = 0;
            // 
            // LocationID
            // 
            LocationID.DataPropertyName = "id";
            LocationID.HeaderText = "ID";
            LocationID.MinimumWidth = 6;
            LocationID.Name = "LocationID";
            LocationID.Width = 125;
            // 
            // LocationName
            // 
            LocationName.DataPropertyName = "name";
            LocationName.HeaderText = "Địa điểm";
            LocationName.MinimumWidth = 6;
            LocationName.Name = "LocationName";
            LocationName.Width = 200;
            // 
            // LocationAddress
            // 
            LocationAddress.DataPropertyName = "address";
            LocationAddress.HeaderText = "Địa chỉ";
            LocationAddress.MinimumWidth = 6;
            LocationAddress.Name = "LocationAddress";
            LocationAddress.Width = 400;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txbAddress);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(lbCapacity);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(lbID);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 181);
            panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(657, 88);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(225, 237, 237);
            btnAdd.Location = new Point(541, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(90, 45);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(666, 23);
            txbAddress.TabIndex = 7;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(12, 49);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(67, 19);
            lbAddress.TabIndex = 6;
            lbAddress.Text = "Địa chỉ:";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCapacity.Location = new Point(427, 18);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(0, 19);
            lbCapacity.TabIndex = 4;
            // 
            // txbName
            // 
            txbName.Location = new Point(392, 14);
            txbName.Name = "txbName";
            txbName.Size = new Size(364, 23);
            txbName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(274, 18);
            lbName.Name = "lbName";
            lbName.Size = new Size(112, 19);
            lbName.TabIndex = 2;
            lbName.Text = "Tên địa điểm:";
            // 
            // txbID
            // 
            txbID.Location = new Point(90, 14);
            txbID.Name = "txbID";
            txbID.Size = new Size(118, 23);
            txbID.TabIndex = 1;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(12, 18);
            lbID.Name = "lbID";
            lbID.Size = new Size(31, 19);
            lbID.TabIndex = 0;
            lbID.Text = "ID:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(225, 237, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dtgvLocation);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách địa điểm tiêm";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLocation).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLocation;
        private DataGridViewTextBoxColumn LocationID;
        private DataGridViewTextBoxColumn LocationName;
        private DataGridViewTextBoxColumn LocationAddress;
        private Panel panel1;
        private Button btnExit;
        private Button btnAdd;
        private TextBox txbAddress;
        private Label lbAddress;
        private Label lbCapacity;
        private TextBox txbName;
        private Label lbName;
        private TextBox txbID;
        private Label lbID;
    }
}
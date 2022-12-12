namespace QLQUANCF
{
    partial class fCustomer
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
            this.txbNameCustomer = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSumBill = new System.Windows.Forms.TextBox();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.txbSearchCus = new System.Windows.Forms.TextBox();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNameCustomer
            // 
            this.txbNameCustomer.Location = new System.Drawing.Point(414, 233);
            this.txbNameCustomer.Name = "txbNameCustomer";
            this.txbNameCustomer.Size = new System.Drawing.Size(345, 27);
            this.txbNameCustomer.TabIndex = 0;
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.White;
            this.account.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.account.Location = new System.Drawing.Point(414, 196);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(180, 24);
            this.account.TabIndex = 2;
            this.account.Text = "Tên Khách Hàng :";
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateCus);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnAddCus);
            this.panel1.Controls.Add(this.txbSearchCus);
            this.panel1.Controls.Add(this.btnSearchCus);
            this.panel1.Controls.Add(this.txbSumBill);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbCustomerAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbPhoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbIdBill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgvCustomer);
            this.panel1.Controls.Add(this.account);
            this.panel1.Controls.Add(this.txbNameCustomer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 3;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(14, 43);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 29;
            this.dtgvCustomer.Size = new System.Drawing.Size(390, 350);
            this.dtgvCustomer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Hóa Đơn :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbIdBill
            // 
            this.txbIdBill.Location = new System.Drawing.Point(414, 166);
            this.txbIdBill.Name = "txbIdBill";
            this.txbIdBill.Size = new System.Drawing.Size(140, 27);
            this.txbIdBill.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(414, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Điện Thoại Khách :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(414, 290);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(345, 27);
            this.txbPhoneNumber.TabIndex = 7;
            this.txbPhoneNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(414, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa Chỉ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbCustomerAddress
            // 
            this.txbCustomerAddress.Location = new System.Drawing.Point(414, 347);
            this.txbCustomerAddress.Name = "txbCustomerAddress";
            this.txbCustomerAddress.Size = new System.Drawing.Size(345, 27);
            this.txbCustomerAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(598, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng Hóa Đơn :";
            // 
            // txbSumBill
            // 
            this.txbSumBill.Location = new System.Drawing.Point(598, 166);
            this.txbSumBill.Name = "txbSumBill";
            this.txbSumBill.Size = new System.Drawing.Size(140, 27);
            this.txbSumBill.TabIndex = 11;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCus.Location = new System.Drawing.Point(410, -1);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(124, 38);
            this.btnSearchCus.TabIndex = 4;
            this.btnSearchCus.Text = "Tìm Khách :";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnViewCus_Click);
            // 
            // txbSearchCus
            // 
            this.txbSearchCus.Location = new System.Drawing.Point(414, 43);
            this.txbSearchCus.Name = "txbSearchCus";
            this.txbSearchCus.Size = new System.Drawing.Size(345, 27);
            this.txbSearchCus.TabIndex = 12;
            // 
            // btnAddCus
            // 
            this.btnAddCus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCus.Location = new System.Drawing.Point(18, -1);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(96, 38);
            this.btnAddCus.TabIndex = 13;
            this.btnAddCus.Text = "Thêm";
            this.btnAddCus.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(120, -1);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(96, 38);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCus.Location = new System.Drawing.Point(222, -1);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(96, 38);
            this.btnUpdateCus.TabIndex = 15;
            this.btnUpdateCus.Text = "Sửa";
            this.btnUpdateCus.UseVisualStyleBackColor = true;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txbNameCustomer;
        private Label account;
        private Panel panel1;
        private Label label1;
        private DataGridView dtgvCustomer;
        private Label label2;
        private TextBox txbIdBill;
        private Label label3;
        private TextBox txbPhoneNumber;
        private TextBox txbSumBill;
        private Label label4;
        private TextBox txbCustomerAddress;
        private Button btnSearchCus;
        private TextBox txbSearchCus;
        private Button btnUpdateCus;
        private Button btnDeleteCustomer;
        private Button btnAddCus;
    }
}
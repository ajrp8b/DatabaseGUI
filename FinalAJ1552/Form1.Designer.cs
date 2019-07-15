namespace FinalAJ1552
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.firstTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lastTB = new System.Windows.Forms.TextBox();
            this.shipTB = new System.Windows.Forms.TextBox();
            this.customerNumberDS = new System.Data.DataSet();
            this.customerDS = new System.Data.DataSet();
            this.detailsDS = new System.Data.DataSet();
            this.customerDataDGV = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Shipping:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "State:";
            // 
            // customerCB
            // 
            this.customerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(90, 20);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(121, 21);
            this.customerCB.TabIndex = 10;
            this.customerCB.SelectedIndexChanged += new System.EventHandler(this.customerCB_SelectedIndexChanged);
            // 
            // firstTB
            // 
            this.firstTB.Location = new System.Drawing.Point(90, 56);
            this.firstTB.Name = "firstTB";
            this.firstTB.ReadOnly = true;
            this.firstTB.Size = new System.Drawing.Size(172, 20);
            this.firstTB.TabIndex = 11;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(90, 84);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.ReadOnly = true;
            this.phoneTB.Size = new System.Drawing.Size(172, 20);
            this.phoneTB.TabIndex = 12;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(90, 111);
            this.addressTB.Name = "addressTB";
            this.addressTB.ReadOnly = true;
            this.addressTB.Size = new System.Drawing.Size(420, 20);
            this.addressTB.TabIndex = 13;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(90, 137);
            this.cityTB.Name = "cityTB";
            this.cityTB.ReadOnly = true;
            this.cityTB.Size = new System.Drawing.Size(151, 20);
            this.cityTB.TabIndex = 14;
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(288, 137);
            this.stateTB.Name = "stateTB";
            this.stateTB.ReadOnly = true;
            this.stateTB.Size = new System.Drawing.Size(72, 20);
            this.stateTB.TabIndex = 15;
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(410, 137);
            this.zipTB.Name = "zipTB";
            this.zipTB.ReadOnly = true;
            this.zipTB.Size = new System.Drawing.Size(100, 20);
            this.zipTB.TabIndex = 16;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(321, 80);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(189, 20);
            this.emailTB.TabIndex = 17;
            // 
            // lastTB
            // 
            this.lastTB.Location = new System.Drawing.Point(321, 53);
            this.lastTB.Name = "lastTB";
            this.lastTB.ReadOnly = true;
            this.lastTB.Size = new System.Drawing.Size(189, 20);
            this.lastTB.TabIndex = 18;
            // 
            // shipTB
            // 
            this.shipTB.Location = new System.Drawing.Point(352, 350);
            this.shipTB.Name = "shipTB";
            this.shipTB.ReadOnly = true;
            this.shipTB.Size = new System.Drawing.Size(158, 20);
            this.shipTB.TabIndex = 19;
            // 
            // customerNumberDS
            // 
            this.customerNumberDS.DataSetName = "NewDataSet";
            // 
            // customerDS
            // 
            this.customerDS.DataSetName = "NewDataSet";
            // 
            // detailsDS
            // 
            this.detailsDS.DataSetName = "NewDataSet";
            // 
            // customerDataDGV
            // 
            this.customerDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.orderDate,
            this.dateShipped,
            this.shippingFee});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataDGV.Location = new System.Drawing.Point(26, 163);
            this.customerDataDGV.Name = "customerDataDGV";
            this.customerDataDGV.ReadOnly = true;
            this.customerDataDGV.Size = new System.Drawing.Size(484, 183);
            this.customerDataDGV.TabIndex = 20;
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "Order Number";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // dateShipped
            // 
            this.dateShipped.HeaderText = "Date Shipped";
            this.dateShipped.Name = "dateShipped";
            this.dateShipped.ReadOnly = true;
            // 
            // shippingFee
            // 
            this.shippingFee.HeaderText = "Shipping Fee";
            this.shippingFee.Name = "shippingFee";
            this.shippingFee.ReadOnly = true;
            this.shippingFee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 377);
            this.Controls.Add(this.customerDataDGV);
            this.Controls.Add(this.shipTB);
            this.Controls.Add(this.lastTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.zipTB);
            this.Controls.Add(this.stateTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.firstTB);
            this.Controls.Add(this.customerCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox customerCB;
        private System.Windows.Forms.TextBox firstTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox lastTB;
        private System.Windows.Forms.TextBox shipTB;
        private System.Data.DataSet customerNumberDS;
        private System.Data.DataSet customerDS;
        private System.Data.DataSet detailsDS;
        private System.Windows.Forms.DataGridView customerDataDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingFee;
    }
}


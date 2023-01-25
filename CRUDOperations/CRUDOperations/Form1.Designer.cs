namespace CRUDOperations
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.empID = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.empSalary = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmpSalary = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(297, 224);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(297, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 20);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(61, 230);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(18, 13);
            this.empID.TabIndex = 4;
            this.empID.Text = "ID";
            this.empID.Click += new System.EventHandler(this.label1_Click);
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(61, 268);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(35, 13);
            this.empName.TabIndex = 5;
            this.empName.Text = "Name";
            this.empName.Click += new System.EventHandler(this.label2_Click);
            // 
            // empSalary
            // 
            this.empSalary.AutoSize = true;
            this.empSalary.Location = new System.Drawing.Point(61, 321);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(36, 13);
            this.empSalary.TabIndex = 6;
            this.empSalary.Text = "Salary";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(131, 227);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(100, 20);
            this.txtEmpNo.TabIndex = 7;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(131, 265);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 8;
            // 
            // textEmpSalary
            // 
            this.textEmpSalary.Location = new System.Drawing.Point(131, 318);
            this.textEmpSalary.Name = "textEmpSalary";
            this.textEmpSalary.Size = new System.Drawing.Size(100, 20);
            this.textEmpSalary.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 206);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textEmpSalary);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empSalary;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmpSalary;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


namespace TDD_project
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowEmployeeList = new System.Windows.Forms.Button();
            this.btnSortByPay = new System.Windows.Forms.Button();
            this.btnAddManyEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblSorting = new System.Windows.Forms.Label();
            this.lblHeaderAddEmployees = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSalary);
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.lblLastName);
            this.splitContainer1.Panel1.Controls.Add(this.lblFirstName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnShowEmployeeList);
            this.splitContainer1.Panel2.Controls.Add(this.btnSortByPay);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddManyEmployee);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddEmployee);
            this.splitContainer1.Panel2.Controls.Add(this.lblSorting);
            this.splitContainer1.Panel2.Controls.Add(this.lblHeaderAddEmployees);
            this.splitContainer1.Size = new System.Drawing.Size(575, 421);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(310, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "שם פרטי";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(147, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnShowEmployeeList
            // 
            this.btnShowEmployeeList.Location = new System.Drawing.Point(32, 242);
            this.btnShowEmployeeList.Name = "btnShowEmployeeList";
            this.btnShowEmployeeList.Size = new System.Drawing.Size(133, 23);
            this.btnShowEmployeeList.TabIndex = 5;
            this.btnShowEmployeeList.Text = "הצגת רשימת עובדים";
            this.btnShowEmployeeList.UseVisualStyleBackColor = true;
            // 
            // btnSortByPay
            // 
            this.btnSortByPay.Location = new System.Drawing.Point(42, 161);
            this.btnSortByPay.Name = "btnSortByPay";
            this.btnSortByPay.Size = new System.Drawing.Size(109, 23);
            this.btnSortByPay.TabIndex = 4;
            this.btnSortByPay.Text = "מיון לפי משכורת";
            this.btnSortByPay.UseVisualStyleBackColor = true;
            // 
            // btnAddManyEmployee
            // 
            this.btnAddManyEmployee.Location = new System.Drawing.Point(30, 64);
            this.btnAddManyEmployee.Name = "btnAddManyEmployee";
            this.btnAddManyEmployee.Size = new System.Drawing.Size(138, 35);
            this.btnAddManyEmployee.TabIndex = 3;
            this.btnAddManyEmployee.Text = "הוספת 10,000 עובדים";
            this.btnAddManyEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(56, 35);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(95, 23);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "הוספת עובד";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Location = new System.Drawing.Point(53, 136);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(91, 13);
            this.lblSorting.TabIndex = 1;
            this.lblSorting.Text = "סדר לפי אופציה";
            // 
            // lblHeaderAddEmployees
            // 
            this.lblHeaderAddEmployees.AutoSize = true;
            this.lblHeaderAddEmployees.Location = new System.Drawing.Point(63, 9);
            this.lblHeaderAddEmployees.Name = "lblHeaderAddEmployees";
            this.lblHeaderAddEmployees.Size = new System.Drawing.Size(81, 13);
            this.lblHeaderAddEmployees.TabIndex = 0;
            this.lblHeaderAddEmployees.Text = "הוספת עובדים";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(220, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "שם משפחה";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(141, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ת\"ז";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(48, 9);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "משכורת";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Label lblHeaderAddEmployees;
        private System.Windows.Forms.Button btnAddManyEmployee;
        private System.Windows.Forms.Button btnSortByPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowEmployeeList;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSalary;
    }
}


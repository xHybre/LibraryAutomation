namespace WindowsFormsApp1
{
    partial class ManagerPage
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
            this.dataGridView_manager = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_managerAmount = new System.Windows.Forms.GroupBox();
            this.btn_clearAmount = new System.Windows.Forms.Button();
            this.btn_addAmount = new System.Windows.Forms.Button();
            this.txt_raiseAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_currentSalary1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_currentSalary2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_currentSalary3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_raisePercentage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_newSalary = new System.Windows.Forms.TextBox();
            this.btn_addPercentage = new System.Windows.Forms.Button();
            this.btn_clearPercentage = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_clearNew = new System.Windows.Forms.Button();
            this.groupBox_percentage = new System.Windows.Forms.GroupBox();
            this.groupBox_new = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manager)).BeginInit();
            this.groupBox_managerAmount.SuspendLayout();
            this.groupBox_percentage.SuspendLayout();
            this.groupBox_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_manager
            // 
            this.dataGridView_manager.AllowUserToAddRows = false;
            this.dataGridView_manager.AllowUserToResizeColumns = false;
            this.dataGridView_manager.AllowUserToResizeRows = false;
            this.dataGridView_manager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_manager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.creationDate,
            this.username,
            this.password,
            this.authority,
            this.salary});
            this.dataGridView_manager.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_manager.Name = "dataGridView_manager";
            this.dataGridView_manager.RowHeadersVisible = false;
            this.dataGridView_manager.RowHeadersWidth = 51;
            this.dataGridView_manager.RowTemplate.Height = 24;
            this.dataGridView_manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_manager.Size = new System.Drawing.Size(1102, 303);
            this.dataGridView_manager.TabIndex = 0;
            this.dataGridView_manager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_manager_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "Date";
            this.creationDate.MinimumWidth = 6;
            this.creationDate.Name = "creationDate";
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // authority
            // 
            this.authority.HeaderText = "Authority";
            this.authority.MinimumWidth = 6;
            this.authority.Name = "authority";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            // 
            // groupBox_managerAmount
            // 
            this.groupBox_managerAmount.Controls.Add(this.btn_clearAmount);
            this.groupBox_managerAmount.Controls.Add(this.btn_addAmount);
            this.groupBox_managerAmount.Controls.Add(this.txt_raiseAmount);
            this.groupBox_managerAmount.Controls.Add(this.label2);
            this.groupBox_managerAmount.Controls.Add(this.txt_currentSalary1);
            this.groupBox_managerAmount.Controls.Add(this.label1);
            this.groupBox_managerAmount.Location = new System.Drawing.Point(12, 321);
            this.groupBox_managerAmount.Name = "groupBox_managerAmount";
            this.groupBox_managerAmount.Size = new System.Drawing.Size(334, 304);
            this.groupBox_managerAmount.TabIndex = 1;
            this.groupBox_managerAmount.TabStop = false;
            this.groupBox_managerAmount.Text = "Change Salary Based on Amount";
            // 
            // btn_clearAmount
            // 
            this.btn_clearAmount.Location = new System.Drawing.Point(9, 165);
            this.btn_clearAmount.Name = "btn_clearAmount";
            this.btn_clearAmount.Size = new System.Drawing.Size(309, 32);
            this.btn_clearAmount.TabIndex = 3;
            this.btn_clearAmount.Text = "Clear";
            this.btn_clearAmount.UseVisualStyleBackColor = true;
            this.btn_clearAmount.Click += new System.EventHandler(this.btn_clearAmount_Click);
            // 
            // btn_addAmount
            // 
            this.btn_addAmount.Location = new System.Drawing.Point(9, 127);
            this.btn_addAmount.Name = "btn_addAmount";
            this.btn_addAmount.Size = new System.Drawing.Size(309, 32);
            this.btn_addAmount.TabIndex = 2;
            this.btn_addAmount.Text = "Add";
            this.btn_addAmount.UseVisualStyleBackColor = true;
            this.btn_addAmount.Click += new System.EventHandler(this.btn_addAmount_Click);
            // 
            // txt_raiseAmount
            // 
            this.txt_raiseAmount.Location = new System.Drawing.Point(109, 87);
            this.txt_raiseAmount.Name = "txt_raiseAmount";
            this.txt_raiseAmount.Size = new System.Drawing.Size(209, 22);
            this.txt_raiseAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Raise Amount:";
            // 
            // txt_currentSalary1
            // 
            this.txt_currentSalary1.Location = new System.Drawing.Point(109, 49);
            this.txt_currentSalary1.Name = "txt_currentSalary1";
            this.txt_currentSalary1.Size = new System.Drawing.Size(209, 22);
            this.txt_currentSalary1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Current Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = " Current Salary:";
            // 
            // txt_currentSalary2
            // 
            this.txt_currentSalary2.Location = new System.Drawing.Point(153, 48);
            this.txt_currentSalary2.Name = "txt_currentSalary2";
            this.txt_currentSalary2.Size = new System.Drawing.Size(209, 22);
            this.txt_currentSalary2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = " Current Salary:";
            // 
            // txt_currentSalary3
            // 
            this.txt_currentSalary3.Location = new System.Drawing.Point(124, 45);
            this.txt_currentSalary3.Name = "txt_currentSalary3";
            this.txt_currentSalary3.Size = new System.Drawing.Size(209, 22);
            this.txt_currentSalary3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Raise Percentage:";
            // 
            // txt_raisePercentage
            // 
            this.txt_raisePercentage.Location = new System.Drawing.Point(153, 86);
            this.txt_raisePercentage.Name = "txt_raisePercentage";
            this.txt_raisePercentage.Size = new System.Drawing.Size(209, 22);
            this.txt_raisePercentage.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Salary:";
            // 
            // txt_newSalary
            // 
            this.txt_newSalary.Location = new System.Drawing.Point(124, 83);
            this.txt_newSalary.Name = "txt_newSalary";
            this.txt_newSalary.Size = new System.Drawing.Size(209, 22);
            this.txt_newSalary.TabIndex = 1;
            this.txt_newSalary.TextChanged += new System.EventHandler(this.txt_newSalary_TextChanged);
            // 
            // btn_addPercentage
            // 
            this.btn_addPercentage.Location = new System.Drawing.Point(53, 126);
            this.btn_addPercentage.Name = "btn_addPercentage";
            this.btn_addPercentage.Size = new System.Drawing.Size(309, 32);
            this.btn_addPercentage.TabIndex = 2;
            this.btn_addPercentage.Text = "Add";
            this.btn_addPercentage.UseVisualStyleBackColor = true;
            this.btn_addPercentage.Click += new System.EventHandler(this.btn_addPercentage_Click);
            // 
            // btn_clearPercentage
            // 
            this.btn_clearPercentage.Location = new System.Drawing.Point(53, 164);
            this.btn_clearPercentage.Name = "btn_clearPercentage";
            this.btn_clearPercentage.Size = new System.Drawing.Size(309, 32);
            this.btn_clearPercentage.TabIndex = 3;
            this.btn_clearPercentage.Text = "Clear";
            this.btn_clearPercentage.UseVisualStyleBackColor = true;
            this.btn_clearPercentage.Click += new System.EventHandler(this.btn_clearPercentage_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(24, 123);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(309, 32);
            this.btn_addNew.TabIndex = 2;
            this.btn_addNew.Text = "Add";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_clearNew
            // 
            this.btn_clearNew.Location = new System.Drawing.Point(24, 161);
            this.btn_clearNew.Name = "btn_clearNew";
            this.btn_clearNew.Size = new System.Drawing.Size(309, 32);
            this.btn_clearNew.TabIndex = 3;
            this.btn_clearNew.Text = "Clear";
            this.btn_clearNew.UseVisualStyleBackColor = true;
            this.btn_clearNew.Click += new System.EventHandler(this.btn_clearNew_Click);
            // 
            // groupBox_percentage
            // 
            this.groupBox_percentage.Controls.Add(this.txt_currentSalary2);
            this.groupBox_percentage.Controls.Add(this.txt_raisePercentage);
            this.groupBox_percentage.Controls.Add(this.label5);
            this.groupBox_percentage.Controls.Add(this.btn_clearPercentage);
            this.groupBox_percentage.Controls.Add(this.btn_addPercentage);
            this.groupBox_percentage.Controls.Add(this.label3);
            this.groupBox_percentage.Location = new System.Drawing.Point(352, 321);
            this.groupBox_percentage.Name = "groupBox_percentage";
            this.groupBox_percentage.Size = new System.Drawing.Size(410, 304);
            this.groupBox_percentage.TabIndex = 3;
            this.groupBox_percentage.TabStop = false;
            this.groupBox_percentage.Text = "Change Salary Based on Percentage";
            // 
            // groupBox_new
            // 
            this.groupBox_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_new.Controls.Add(this.txt_currentSalary3);
            this.groupBox_new.Controls.Add(this.label6);
            this.groupBox_new.Controls.Add(this.btn_clearNew);
            this.groupBox_new.Controls.Add(this.txt_newSalary);
            this.groupBox_new.Controls.Add(this.label4);
            this.groupBox_new.Controls.Add(this.btn_addNew);
            this.groupBox_new.Location = new System.Drawing.Point(768, 321);
            this.groupBox_new.Name = "groupBox_new";
            this.groupBox_new.Size = new System.Drawing.Size(346, 304);
            this.groupBox_new.TabIndex = 0;
            this.groupBox_new.TabStop = false;
            this.groupBox_new.Text = "Set New Salary";
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1126, 637);
            this.Controls.Add(this.groupBox_new);
            this.Controls.Add(this.groupBox_percentage);
            this.Controls.Add(this.groupBox_managerAmount);
            this.Controls.Add(this.dataGridView_manager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Page";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manager)).EndInit();
            this.groupBox_managerAmount.ResumeLayout(false);
            this.groupBox_managerAmount.PerformLayout();
            this.groupBox_percentage.ResumeLayout(false);
            this.groupBox_percentage.PerformLayout();
            this.groupBox_new.ResumeLayout(false);
            this.groupBox_new.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority;
        private System.Windows.Forms.GroupBox groupBox_managerAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_currentSalary1;
        private System.Windows.Forms.TextBox txt_raiseAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_raisePercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_currentSalary3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_currentSalary2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clearNew;
        private System.Windows.Forms.Button btn_clearPercentage;
        private System.Windows.Forms.Button btn_clearAmount;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_addPercentage;
        private System.Windows.Forms.Button btn_addAmount;
        private System.Windows.Forms.GroupBox groupBox_percentage;
        private System.Windows.Forms.GroupBox groupBox_new;
    }
}
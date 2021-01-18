namespace PrisonDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCells = new System.Windows.Forms.TabPage();
            this.btAddTable = new System.Windows.Forms.Button();
            this.btEditTable = new System.Windows.Forms.Button();
            this.btDeleteTable = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.dvgPrisoner = new System.Windows.Forms.DataGridView();
            this.tabCells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrisoner)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCells
            // 
            this.tabCells.Controls.Add(this.btAddTable);
            this.tabCells.Controls.Add(this.btEditTable);
            this.tabCells.Controls.Add(this.btDeleteTable);
            this.tabCells.Controls.Add(this.dgvTable);
            this.tabCells.Location = new System.Drawing.Point(4, 25);
            this.tabCells.Margin = new System.Windows.Forms.Padding(4);
            this.tabCells.Name = "tabCells";
            this.tabCells.Padding = new System.Windows.Forms.Padding(4);
            this.tabCells.Size = new System.Drawing.Size(1095, 599);
            this.tabCells.TabIndex = 2;
            this.tabCells.Text = "Камеры";
            this.tabCells.UseVisualStyleBackColor = true;
            this.tabCells.Click += new System.EventHandler(this.tabTable_Click);
            // 
            // btAddTable
            // 
            this.btAddTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddTable.Location = new System.Drawing.Point(565, 7);
            this.btAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.btAddTable.Name = "btAddTable";
            this.btAddTable.Size = new System.Drawing.Size(167, 75);
            this.btAddTable.TabIndex = 3;
            this.btAddTable.Text = "Добавить";
            this.btAddTable.UseVisualStyleBackColor = true;
            this.btAddTable.Click += new System.EventHandler(this.BtAddTable_Click);
            // 
            // btEditTable
            // 
            this.btEditTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditTable.Location = new System.Drawing.Point(740, 7);
            this.btEditTable.Margin = new System.Windows.Forms.Padding(4);
            this.btEditTable.Name = "btEditTable";
            this.btEditTable.Size = new System.Drawing.Size(167, 75);
            this.btEditTable.TabIndex = 2;
            this.btEditTable.Text = "Изменить";
            this.btEditTable.UseVisualStyleBackColor = true;
            this.btEditTable.Click += new System.EventHandler(this.BtEditTable_Click);
            // 
            // btDeleteTable
            // 
            this.btDeleteTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteTable.Location = new System.Drawing.Point(915, 7);
            this.btDeleteTable.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteTable.Name = "btDeleteTable";
            this.btDeleteTable.Size = new System.Drawing.Size(167, 75);
            this.btDeleteTable.TabIndex = 1;
            this.btDeleteTable.Text = "Удалить";
            this.btDeleteTable.UseVisualStyleBackColor = true;
            this.btDeleteTable.Click += new System.EventHandler(this.BtDeleteTable_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(11, 90);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1071, 496);
            this.dgvTable.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Controls.Add(this.tabCells);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1275, 853);
            this.tabControl.TabIndex = 1;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btAddUser);
            this.tabUser.Controls.Add(this.btEditUser);
            this.tabUser.Controls.Add(this.btDeleteUser);
            this.tabUser.Controls.Add(this.dvgPrisoner);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabUser.Size = new System.Drawing.Size(1267, 824);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "Заключённые";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btAddUser
            // 
            this.btAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddUser.Location = new System.Drawing.Point(737, 7);
            this.btAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(167, 75);
            this.btAddUser.TabIndex = 3;
            this.btAddUser.Text = "Добавить";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.BtAddUser_Click);
            // 
            // btEditUser
            // 
            this.btEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditUser.Location = new System.Drawing.Point(912, 7);
            this.btEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(167, 75);
            this.btEditUser.TabIndex = 2;
            this.btEditUser.Text = "Изменить";
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.BtEditUser_Click);
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteUser.Location = new System.Drawing.Point(1087, 7);
            this.btDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(167, 75);
            this.btDeleteUser.TabIndex = 1;
            this.btDeleteUser.Text = "Удалить";
            this.btDeleteUser.UseVisualStyleBackColor = true;
            this.btDeleteUser.Click += new System.EventHandler(this.BtDeleteUser_Click);
            // 
            // dvgPrisoner
            // 
            this.dvgPrisoner.AllowUserToAddRows = false;
            this.dvgPrisoner.AllowUserToDeleteRows = false;
            this.dvgPrisoner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgPrisoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPrisoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPrisoner.Location = new System.Drawing.Point(11, 90);
            this.dvgPrisoner.Margin = new System.Windows.Forms.Padding(4);
            this.dvgPrisoner.MultiSelect = false;
            this.dvgPrisoner.Name = "dvgPrisoner";
            this.dvgPrisoner.ReadOnly = true;
            this.dvgPrisoner.RowHeadersWidth = 51;
            this.dvgPrisoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPrisoner.Size = new System.Drawing.Size(1243, 721);
            this.dvgPrisoner.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 853);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(567, 481);
            this.Name = "MainForm";
            this.Text = "Работа с базой данных";
            this.tabCells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrisoner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabCells;
        private System.Windows.Forms.Button btAddTable;
        private System.Windows.Forms.Button btEditTable;
        private System.Windows.Forms.Button btDeleteTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btEditUser;
        private System.Windows.Forms.Button btDeleteUser;
        private System.Windows.Forms.DataGridView dvgPrisoner;
    }
}


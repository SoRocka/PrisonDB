namespace KostrubaDB.Forms
{
    partial class TableForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(226, 112);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 39);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(119, 112);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(92, 39);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(14, 112);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(92, 39);
            this.btOK.TabIndex = 18;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(304, 20);
            this.tbName.TabIndex = 17;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(11, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 13);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Имя таблицы";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(12, 56);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(80, 13);
            this.lbUser.TabIndex = 13;
            this.lbUser.Text = "Пользователь";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(15, 72);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(303, 21);
            this.cbUser.TabIndex = 21;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 172);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbUser);
            this.Name = "TableForm";
            this.Text = "Добавление таблицы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ComboBox cbUser;
    }
}
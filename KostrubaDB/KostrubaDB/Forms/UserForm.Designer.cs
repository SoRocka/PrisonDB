namespace KostrubaDB.Forms
{
    partial class UserForm
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
            this.dtpReg = new System.Windows.Forms.DateTimePicker();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.cbNow = new System.Windows.Forms.CheckBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpReg
            // 
            this.dtpReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReg.Location = new System.Drawing.Point(15, 115);
            this.dtpReg.Name = "dtpReg";
            this.dtpReg.Size = new System.Drawing.Size(307, 20);
            this.dtpReg.TabIndex = 0;
            this.dtpReg.Value = new System.DateTime(2020, 1, 7, 3, 40, 26, 0);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата и время регистрации";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(15, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(307, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(15, 76);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(307, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 60);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Пароль";
            // 
            // cbNow
            // 
            this.cbNow.AutoSize = true;
            this.cbNow.Location = new System.Drawing.Point(15, 150);
            this.cbNow.Name = "cbNow";
            this.cbNow.Size = new System.Drawing.Size(150, 17);
            this.cbNow.TabIndex = 8;
            this.cbNow.Text = "Нынешнее дата и время";
            this.cbNow.UseVisualStyleBackColor = true;
            this.cbNow.CheckedChanged += new System.EventHandler(this.CbNow_CheckedChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(15, 179);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(92, 39);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btClear.Location = new System.Drawing.Point(120, 179);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(92, 39);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(227, 179);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 39);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbNow);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dtpReg);
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(350, 275);
            this.Name = "UserForm";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReg;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox cbNow;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}
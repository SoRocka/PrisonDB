namespace KostrubaDB.Forms
{
    partial class ColumnForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbDefault = new System.Windows.Forms.TextBox();
            this.lbDefault = new System.Windows.Forms.Label();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.cbNull = new System.Windows.Forms.CheckBox();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.cbPrimary = new System.Windows.Forms.CheckBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(73, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Имя столбца";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(303, 20);
            this.tbName.TabIndex = 7;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(9, 68);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(74, 13);
            this.lbType.TabIndex = 8;
            this.lbType.Text = "Тип атрибута";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 84);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(303, 21);
            this.cbType.TabIndex = 9;
            // 
            // tbDefault
            // 
            this.tbDefault.Location = new System.Drawing.Point(12, 140);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.Size = new System.Drawing.Size(303, 20);
            this.tbDefault.TabIndex = 11;
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.Location = new System.Drawing.Point(9, 124);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(129, 13);
            this.lbDefault.TabIndex = 10;
            this.lbDefault.Text = "Значение по умолчанию";
            // 
            // tbCheck
            // 
            this.tbCheck.Location = new System.Drawing.Point(12, 194);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(303, 20);
            this.tbCheck.TabIndex = 13;
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(9, 178);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(107, 13);
            this.lbCheck.TabIndex = 12;
            this.lbCheck.Text = "Проверка значения";
            // 
            // cbNull
            // 
            this.cbNull.AutoSize = true;
            this.cbNull.Location = new System.Drawing.Point(12, 230);
            this.cbNull.Name = "cbNull";
            this.cbNull.Size = new System.Drawing.Size(169, 17);
            this.cbNull.TabIndex = 14;
            this.cbNull.Text = "Значение может быть NULL";
            this.cbNull.UseVisualStyleBackColor = true;
            // 
            // cbUnique
            // 
            this.cbUnique.AutoSize = true;
            this.cbUnique.Location = new System.Drawing.Point(12, 253);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(209, 17);
            this.cbUnique.TabIndex = 15;
            this.cbUnique.Text = "Значение должно быть уникальным";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // cbPrimary
            // 
            this.cbPrimary.AutoSize = true;
            this.cbPrimary.Location = new System.Drawing.Point(12, 276);
            this.cbPrimary.Name = "cbPrimary";
            this.cbPrimary.Size = new System.Drawing.Size(220, 17);
            this.cbPrimary.TabIndex = 16;
            this.cbPrimary.Text = "Столбец является первичным ключем";
            this.cbPrimary.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 300);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(93, 39);
            this.btOK.TabIndex = 17;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(222, 300);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(93, 39);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(111, 300);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(105, 39);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // ColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 351);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbPrimary);
            this.Controls.Add(this.cbUnique);
            this.Controls.Add(this.cbNull);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.tbDefault);
            this.Controls.Add(this.lbDefault);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "ColumnForm";
            this.Text = "ColumnForm";
            this.Load += new System.EventHandler(this.ColumnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbDefault;
        private System.Windows.Forms.Label lbDefault;
        private System.Windows.Forms.TextBox tbCheck;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.CheckBox cbNull;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.CheckBox cbPrimary;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClear;
    }
}
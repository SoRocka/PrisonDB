namespace KostrubaDB.Forms
{
    partial class Type_AttributeForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 20);
            this.tbName.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(131, 13);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Название типа атрибута";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(208, 68);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 39);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(110, 68);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(92, 39);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 67);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(92, 39);
            this.btOK.TabIndex = 13;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // Type_AttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 119);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "Type_AttributeForm";
            this.Text = "Добавление типа атрибута";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;
    }
}
namespace PrisonDB.Forms
{
    partial class PrisonerForm
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
            this.components = new System.ComponentModel.Container();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.articleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prisonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCamNum = new System.Windows.Forms.ComboBox();
            this.bDCellBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDCellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonDataSet = new KostrubaDB.prisonDataSet();
            this.genderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new KostrubaDB.prisonDataSetTableAdapters.GenderTableAdapter();
            this.prisonDataSet1 = new KostrubaDB.prisonDataSet1();
            this.articleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.articleTableAdapter = new KostrubaDB.prisonDataSet1TableAdapters.ArticleTableAdapter();
            this.prisonDataSet2 = new KostrubaDB.prisonDataSet2();
            this.bDCellBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDCellTableAdapter = new KostrubaDB.prisonDataSet2TableAdapters.BDCellTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirth
            // 
            this.dtpBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBirth.Location = new System.Drawing.Point(20, 435);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(406, 22);
            this.dtpBirth.TabIndex = 0;
            this.dtpBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(16, 22);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(20, 42);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSurname.Location = new System.Drawing.Point(20, 95);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(406, 22);
            this.tbSurname.TabIndex = 6;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(16, 74);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 17);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Фамилия";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(20, 478);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(123, 48);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btClear.Location = new System.Drawing.Point(159, 478);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(123, 48);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(301, 478);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(123, 48);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPatronymic.Location = new System.Drawing.Point(20, 144);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(406, 22);
            this.tbPatronymic.TabIndex = 15;
            this.tbPatronymic.TextChanged += new System.EventHandler(this.textPatronyicTextChanged);
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(14, 124);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(71, 17);
            this.lbSurname.TabIndex = 14;
            this.lbSurname.Text = "Отчество";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.genderBindingSource2;
            this.cbGender.DisplayMember = "Name";
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(19, 189);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(404, 24);
            this.cbGender.TabIndex = 16;
            this.cbGender.ValueMember = "Gender_id";
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Пол";
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Location = new System.Drawing.Point(19, 288);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(406, 22);
            this.tbComment.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Статья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Комментарий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Номер камеры";
            // 
            // cbArticle
            // 
            this.cbArticle.DataSource = this.articleBindingSource2;
            this.cbArticle.DisplayMember = "Article";
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(19, 236);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(404, 24);
            this.cbArticle.TabIndex = 25;
            this.cbArticle.ValueMember = "Article_id";
            // 
            // articleBindingSource1
            // 
            this.articleBindingSource1.DataMember = "Article";
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            // 
            // cbCamNum
            // 
            this.cbCamNum.DataSource = this.bDCellBindingSource2;
            this.cbCamNum.DisplayMember = "Cell_id";
            this.cbCamNum.FormattingEnabled = true;
            this.cbCamNum.Location = new System.Drawing.Point(19, 345);
            this.cbCamNum.Name = "cbCamNum";
            this.cbCamNum.Size = new System.Drawing.Size(404, 24);
            this.cbCamNum.TabIndex = 26;
            this.cbCamNum.ValueMember = "Cell_id";
            this.cbCamNum.SelectedIndexChanged += new System.EventHandler(this.cbCamNum_SelectedIndexChanged);
            // 
            // bDCellBindingSource1
            // 
            this.bDCellBindingSource1.DataMember = "BDCell";
            // 
            // bDCellBindingSource
            // 
            this.bDCellBindingSource.DataMember = "BDCell";
            // 
            // prisonDataSet
            // 
            this.prisonDataSet.DataSetName = "prisonDataSet";
            this.prisonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderBindingSource2
            // 
            this.genderBindingSource2.DataMember = "Gender";
            this.genderBindingSource2.DataSource = this.prisonDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // prisonDataSet1
            // 
            this.prisonDataSet1.DataSetName = "prisonDataSet1";
            this.prisonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articleBindingSource2
            // 
            this.articleBindingSource2.DataMember = "Article";
            this.articleBindingSource2.DataSource = this.prisonDataSet1;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // prisonDataSet2
            // 
            this.prisonDataSet2.DataSetName = "prisonDataSet2";
            this.prisonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDCellBindingSource2
            // 
            this.bDCellBindingSource2.DataMember = "BDCell";
            this.bDCellBindingSource2.DataSource = this.prisonDataSet2;
            // 
            // bDCellTableAdapter
            // 
            this.bDCellTableAdapter.ClearBeforeFill = true;
            // 
            // PrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 553);
            this.Controls.Add(this.cbCamNum);
            this.Controls.Add(this.cbArticle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dtpBirth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(461, 600);
            this.Name = "PrisonerForm";
            this.Text = "Добавление заключённого";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCellBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.BindingSource prisonDataSetBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.ComboBox cbCamNum;
        private System.Windows.Forms.BindingSource bDCellBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource1;
        private System.Windows.Forms.BindingSource articleBindingSource1;
        private System.Windows.Forms.BindingSource bDCellBindingSource1;
        private KostrubaDB.prisonDataSet prisonDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource2;
        private KostrubaDB.prisonDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private KostrubaDB.prisonDataSet1 prisonDataSet1;
        private System.Windows.Forms.BindingSource articleBindingSource2;
        private KostrubaDB.prisonDataSet1TableAdapters.ArticleTableAdapter articleTableAdapter;
        private KostrubaDB.prisonDataSet2 prisonDataSet2;
        private System.Windows.Forms.BindingSource bDCellBindingSource2;
        private KostrubaDB.prisonDataSet2TableAdapters.BDCellTableAdapter bDCellTableAdapter;
    }
}
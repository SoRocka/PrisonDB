using KostrubaDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostrubaDB.Forms
{
    public partial class Type_AttributeForm : Form
    {
        public Type_Attribute type;
        public Type_AttributeForm(Type_Attribute type = null) 
        {
            InitializeComponent();
            if (type != null)
            {
                this.type = type;
                tbName.Text = type.name;
                this.Text = "Изменение атрибута " + type.name;
                btOK.Text = "Изменить";
                return;
            }
            this.type = new Type_Attribute();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != "")
            {
                type.name = tbName.Text.Trim();
                DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Введите название типа атрибута");
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
        }
    }
}

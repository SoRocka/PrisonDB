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
    public partial class ColumnForm : Form
    {
        public Column column;
        public ColumnForm(Column column = null, int id_table = 0)
        {
            InitializeComponent();
            var list = DAL.GetAll<Type_Attribute>();
            list.Insert(0, new Type_Attribute
            {
                id_type_attribute = 0,
                name = "Не выбрано"
            });
            cbType.DataSource = list;
            cbType.DisplayMember = "name";
            if (column != null)
            {
                this.Text = "Изменение столбца " + column.name;
                btOK.Text = "Изменить";
                this.column = column;
                tbName.Text = column.name;
                cbType.SelectedIndex = cbType.FindString(column.type_attribute_name.Trim());
                tbCheck.Text = column.CH;
                tbDefault.Text = column.DEF;
                cbNull.Checked = column.NN;
                cbUnique.Checked = column.UNI;
                cbPrimary.Checked = column.is_primary_key;
            }
            else
            {
                this.column = new Column()
                {
                    id_table = id_table
                };
            }
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Введите название столбца");
                return;
            }
            column.name = tbName.Text.Trim();
            column.id_type_attribute = (cbType.SelectedItem as Type_Attribute).id_type_attribute;
            column.CH = tbCheck.Text.Trim();
            column.DEF = tbDefault.Text.Trim();
            column.NN = cbNull.Checked;
            column.UNI = cbUnique.Checked;
            column.is_primary_key = cbPrimary.Checked;
            DialogResult = DialogResult.OK;
        }

        private void ColumnForm_Load(object sender, EventArgs e)
        {

        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbCheck.Clear();
            tbDefault.Clear();
            cbNull.Checked = false;
            cbUnique.Checked = false;
            cbPrimary.Checked = false;
            cbType.SelectedIndex = 0;
        }
    }
}

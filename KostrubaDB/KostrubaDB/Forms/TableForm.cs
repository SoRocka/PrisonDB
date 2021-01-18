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
    public partial class TableForm : Form
    {
        public Table table;
        public TableForm(Table table = null)
        {
            InitializeComponent();
            List<User> list = DAL.GetAll<User>();
            list.Insert(0, new User
            {
                id_user = 0,
                name = "Не выбрано"
            });
            cbUser.DataSource = list;
            cbUser.DisplayMember = "name";
            if (table != null)
            {
                this.table = table;
                tbName.Text = table.name;
                cbUser.SelectedIndex = cbUser.FindString(table.user_name.Trim());
                this.Text = "Изменение таблицы " + table.name;
                btOK.Text = "Изменить";
            }
            else
            {
                this.table = new Table();
            }
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Введите название таблицы");
                return;
            }
            if (cbUser.SelectedIndex == 0)
            {
                MessageBox.Show("Выберите пользователя таблицы");
                return;
            }
            table.name = tbName.Text.Trim();
            table.id_user = (cbUser.SelectedItem as User).id_user;
            DialogResult = DialogResult.OK;
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            cbUser.SelectedIndex = 0;
            tbName.Clear();
        }
    }
}

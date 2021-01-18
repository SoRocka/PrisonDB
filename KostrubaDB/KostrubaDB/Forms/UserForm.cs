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
    public partial class UserForm : Form
    {
        public User user;
        public UserForm(User user = null)
        {
            InitializeComponent();
            if (user != null)
            {
                this.user = user;
                btOK.Text = "Изменить";
                this.Text = "Изменение пользователя " + user.name;
                tbName.Text = user.name;
                tbPassword.Text = user.ppassword;
                dtpReg.Value = user.registration_DATE;
            }
            else
            {
                this.user = new User();
            }
        }

        private void CbNow_CheckedChanged(object sender, EventArgs e)
        {
            dtpReg.Enabled = !dtpReg.Enabled;
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbPassword.Clear();
            dtpReg.Value = DateTime.Now;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }
            user.name = tbName.Text.Trim();
            user.ppassword = tbPassword.Text;
            if (cbNow.Checked)
            {
                user.registration_DATE = DateTime.Now.Date;
            }
            else
            {
                user.registration_DATE = dtpReg.Value;
            }
            DialogResult = DialogResult.OK;
        }
    }
}

using PrisonDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB.Forms
{
    public partial class PrisonerForm : Form
    {
        public Prisoner prisoner;
        public PrisonerForm(Prisoner prisoner = null)
        {
            InitializeComponent();
            if (prisoner != null)
            {
                this.prisoner = prisoner;
                btOK.Text = "Изменить";
                this.Text = "Изменение данные о заключённом" + prisoner.Name;
                tbName.Text = prisoner.Name;
                tbSurname.Text = prisoner.Surname;
                tbPatronymic.Text = prisoner.Patronymic;
                dtpBirth.Value = prisoner.Birthday;
                tbArticle.Text = prisoner.ArticleNum.ToString();
                cbGender.SelectedItem = prisoner.Gender.ToString();
                tbComment.Text = prisoner.Comment;
                tbCamNum.Text = prisoner.Cell_id.ToString();
            }
            else
            {
                this.prisoner = new Prisoner();
            }
        }


        private void BtClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbSurname.Clear();
            tbPatronymic.Clear();
            tbArticle.Clear();
            cbGender.SelectedIndex = -1;
            tbComment.Clear();
            tbCamNum.Clear();
            dtpBirth.Value = DateTime.Now;
            
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Введите имя заключённого");
                return;
            }
            prisoner.Name = tbName.Text.Trim();
            prisoner.Surname = tbSurname.Text.Trim();
            prisoner.Patronymic = tbPatronymic.Text.Trim();
            prisoner.Gender = cbGender.SelectedItem.ToString();
            prisoner.Article_id = int.Parse(tbArticle.Text);
            prisoner.Comment= tbComment.Text.Trim();
            DialogResult = DialogResult.OK;
            prisoner.Birthday= dtpBirth.Value;
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textPatronyicTextChanged(object sender, EventArgs e)
        {

        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prisonDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.prisonDataSet.Gender);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

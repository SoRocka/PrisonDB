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
            var list = DAL.GetAll<Gender>();
            list.Insert(0, new Gender
            {
                Gender_id = 0,
                Name = "Не выбрано"
            });
            cbGender.DataSource = list;
            cbGender.DisplayMember = "Name";

            if (prisoner != null)
            {
                this.prisoner = prisoner;
                btOK.Text = "Изменить";
                this.Text = "Изменение данные о заключённом" + prisoner.Name;
                tbName.Text = prisoner.Name;
                tbSurname.Text = prisoner.Surname;
                tbPatronymic.Text = prisoner.Patronymic;
                dtpBirth.Value = prisoner.Birthday;
                cbArticle.SelectedItem = prisoner.Article_id;
                //cbGender.SelectedItem = prisoner.Gender_id;
                tbComment.Text = prisoner.Comment;
                cbCamNum.SelectedItem = prisoner.Cell_id;
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
            cbGender.SelectedIndex = -1;
            cbArticle.SelectedIndex = -1;
            cbCamNum.SelectedIndex = -1;
            tbComment.Clear();
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
            prisoner.Gender_id = cbGender.SelectedIndex; 
            prisoner.Article_id = cbArticle.SelectedIndex; 
            prisoner.Cell_id = cbCamNum.SelectedIndex; 
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prisonDataSet2.BDCell". При необходимости она может быть перемещена или удалена.
            this.bDCellTableAdapter.Fill(this.prisonDataSet2.BDCell);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prisonDataSet1.Article". При необходимости она может быть перемещена или удалена.
            this.articleTableAdapter.Fill(this.prisonDataSet1.Article);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prisonDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.prisonDataSet.Gender);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCamNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

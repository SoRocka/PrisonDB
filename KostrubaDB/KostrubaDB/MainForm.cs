using PrisonDB.DBUtils;
using PrisonDB.Forms;
using PrisonDB.Helpers;
using PrisonDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            DAL.LoadToDGV<Prisoner>(dvgPrisoner);
            DAL.LoadToDGV<Cell>(dgvTable);
            var list = DAL.GetAll<Cell>();
            list.Insert(0, new Cell
            {
                Cell_id= 0,
                Capacity= 0
            });
        }

        #region User

        private void BtAddUser_Click(object sender, EventArgs e)
        {
            using (PrisonerForm form = new PrisonerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DAL.ExecQuery(QueryType.INSERT, form.prisoner);
                    LoadAll();
                }
            }
        }

        private void BtEditUser_Click(object sender, EventArgs e)
        {
            if (dvgPrisoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для редактирования");
                return;
            }
            using (PrisonerForm form = new PrisonerForm((Prisoner)dvgPrisoner.SelectedRows[0].DataBoundItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DAL.ExecQuery(QueryType.UPDATE, form.prisoner);
                    LoadAll();
                }
            }
        }

        private void BtDeleteUser_Click(object sender, EventArgs e)
        {
            if (dvgPrisoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления");
                return;
            }
            DAL.ExecQuery(QueryType.DELETE, (Prisoner)dvgPrisoner.SelectedRows[0].DataBoundItem);
            LoadAll();
        }

        #endregion


        #region Table
        private void BtAddTable_Click(object sender, EventArgs e)
        {
            
        }

        private void BtEditTable_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите таблицу для редактирования");
                return;
            }    
        }

        private void BtDeleteTable_Click(object sender, EventArgs e)
        {
            if (dvgPrisoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите таблицу для удаления");
                return;
            }
            DAL.ExecQuery(QueryType.DELETE, (Cell)dgvTable.SelectedRows[0].DataBoundItem);
            LoadAll();
        }

        private void tabTable_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btDeleteColumn_Click(object sender, EventArgs e)
        {

        }
    }
}

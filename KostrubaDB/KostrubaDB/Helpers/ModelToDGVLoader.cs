using PrisonDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB.Helpers
{
    class ModelToDGVLoader
    {
        public static void LoadListToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            if (typeof(T) == typeof(Prisoner))
            {
                LoadPrisonerToDGV(list, dgv);
            }
            else if (typeof(T) == typeof(Cell))
            {
                LoadCellsToDGV(list, dgv);
            }
        }



        private static void LoadPrisonerToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            dgv.DataSource = list;
            dgv.Columns["Prisoner_id"].Visible = false;
            dgv.Columns["Name"].HeaderText = "Имя";
            dgv.Columns["Surname"].HeaderText = "Фамилия";
            dgv.Columns["Patronymic"].HeaderText = "Отчество";
            dgv.Columns["Birthday"].HeaderText = "Дата Рождения";
            dgv.Columns["Gender_id"].Visible = false;
            dgv.Columns["Comment_id"].Visible = false;
            dgv.Columns["Article_id"].Visible = false;
            dgv.Columns["Cell_id"].HeaderText = "Номер камеры";
            dgv.Columns["Gender"].HeaderText = "Пол";
            dgv.Columns["ArticleNum"].HeaderText = "Номер статьи";
            dgv.Columns["ArtName"].HeaderText = "Название статьи";
            dgv.Columns["CorpsName"].HeaderText = "Блок";
            dgv.Columns["Comment"].HeaderText = "Комментарий";
        }
        private static void LoadCellsToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            dgv.DataSource = list;
            dgv.Columns["Cell_id"].HeaderText = "Номер";
            dgv.Columns["Capacity"].HeaderText = "Вместительность";
            dgv.Columns["Corps_name"].HeaderText = "Блок";
        }
    }
}

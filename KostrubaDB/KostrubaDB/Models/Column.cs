using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostrubaDB.Models
{
    public class Column : IModel
    {
        public int id_column { get; set; }
        public int id_type_attribute { get; set; }
        public string type_attribute_name { get; set; }
        public int id_table { get; set; }
        public string table_name { get; set; }
        public string name { get; set; }
        public bool NN { get; set; }
        public bool UNI { get; set; }
        public string DEF { get; set; }
        public string CH { get; set; }
        public bool is_primary_key { get; set; }

        public string DeleteQuery()
        {
            return "DELETE FROM [Meta01].[dbo].[CColumns] " +
                "   WHERE id_column = @id_column";
        }

        public string GetAllQuery()
        {
            return "SELECT COL.id_column, COL.id_table, COL.id_type_attribute, COL.name, COL.NN, COL.CH, COL.DEF, COL.UNI, " +
                "          COL.is_primary_key, TA.name AS type_attribute_name, TT.name as table_name " +
                "   FROM [Meta01].[dbo].[CColumns] COL JOIN " +
                "        [Meta01].[dbo].[TType_Attribute] TA ON " +
                "        COL.id_type_attribute = TA.id_type_attribute JOIN " +
                "        [Meta01].[dbo].[TTables] TT ON TT.id_table = COL.id_table";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id_column", id_column);
            hashtable.Add("id_type_attribute", id_type_attribute);
            hashtable.Add("id_table", id_table);
            hashtable.Add("name", name);
            hashtable.Add("NN", NN);
            hashtable.Add("UNI", UNI);
            hashtable.Add("DEF", DEF);
            hashtable.Add("CH", CH);
            hashtable.Add("is_primary_key", is_primary_key);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [Meta01].[dbo].[CColumns](id_table, NN, UNI, name, CH, DEF, is_primary_key, id_type_attribute) " +
                "   VALUES (@id_table, @NN, @UNI, @name, @CH, @DEF, @is_primary_key, @id_type_attribute)";
        }

        public void LoadListToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            if (typeof(T) != typeof(Column))
            {
                throw new Exception("Тип задаваемого списка не соответствует ");
            }
            dgv.DataSource = list;
            dgv.Columns["id_column"].Visible = false;
            dgv.Columns["id_type_attribute"].Visible = false;
            dgv.Columns["id_table"].Visible = false;
            dgv.Columns["name"].HeaderText = "Название столбца";
            dgv.Columns["type_attribute_name"].HeaderText = "Тип атрибута";
            dgv.Columns["table_name"].HeaderText = "Название таблицы";
            dgv.Columns["NN"].HeaderText = "Может быть NULL";
            dgv.Columns["CH"].HeaderText = "Проверка значения";
            dgv.Columns["UNI"].HeaderText = "Уникальное значение";
            dgv.Columns["DEF"].HeaderText = "Значение по умолчанию";
            dgv.Columns["is_primary_key"].HeaderText = "Является первичным ключем";
        }

        public override string ToString()
        {
            return
                "id_column = " + id_column.ToString() + "\n" +
                "name = " + name;
        }

        public string UpdateQuery()
        {
            return "UPDATE [Meta01].[dbo].[CColumns] " +
                "   SET id_table = @id_table, NN = @NN, UNI = @UNI, name = @name, CH = @CH, DEF = @DEF, " +
                "       is_primary_key = @is_primary_key, id_type_attribute = @id_type_attribute " +
                "   WHERE id_column = @id_column";
        }
    }
}

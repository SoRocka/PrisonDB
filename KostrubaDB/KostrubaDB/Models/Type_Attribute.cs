using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostrubaDB.Models
{
    public class Type_Attribute : IModel
    {
        public int id_type_attribute { get; set; }
        public string name { get; set; }

        public string DeleteQuery()
        {
            return "DELETE FROM [Meta01].[dbo].[TType_Attribute] " +
                "   WHERE id_type_attribute = @id_type_attribute";
        }

        public string GetAllQuery()
        {
            return "SELECT * " +
                "   FROM [Meta01].[dbo].[TType_Attribute]";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id_type_attribute", id_type_attribute);
            hashtable.Add("name", name);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [Meta01].[dbo].[TType_Attribute](name) " +
                "   VALUES (@name)";
        }

        public void LoadListToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            dgv.DataSource = list;
            dgv.Columns["id_type_attribute"].Visible = false;
            dgv.Columns["name"].HeaderText = "Название";
        }

        public string UpdateQuery()
        {
            return "UPDATE [Meta01].[dbo].[TType_Attribute] " +
                "   SET name = @name WHERE " +
                "   id_type_attribute = @id_type_attribute";
        }
    }
}

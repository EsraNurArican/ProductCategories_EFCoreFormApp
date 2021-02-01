using ProductCategories_EFCoreFormApp.Data;
using ProductCategories_EFCoreFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategories_EFCoreFormApp.Forms
{
    public partial class CategoryActions : Form
    {
        DBContext db = new DBContext();
        public CategoryActions()
        {
            InitializeComponent();
        }

        void GetCategories()
        {
            dataGridViewCategories.DataSource = db.Categories.ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            newCategory.Name = catName.Text;
            newCategory.Description = catDefn.Text;

            db.Categories.Add(newCategory);
            int effectedRow = db.SaveChanges();

            if (effectedRow > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                GetCategories();
            }
            else
            {
                MessageBox.Show("Ekleme Başarısız Oldu!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CategoryActions_Load(object sender, EventArgs e)
        {
            GetCategories();
        }
    }
}

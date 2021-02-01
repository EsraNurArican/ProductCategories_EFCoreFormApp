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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_CategoryOp_Click(object sender, EventArgs e)
        {
            CategoryActions categoryActions = new CategoryActions();
            categoryActions.Show();
        }

        private void button2_ProductOp_Click(object sender, EventArgs e)
        {
            ProductActions productActions = new ProductActions();
            productActions.Show();
        }
    }
}

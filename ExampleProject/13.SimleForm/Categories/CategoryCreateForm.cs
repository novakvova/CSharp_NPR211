using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.SimleForm.Categories
{
    public partial class CategoryCreateForm : Form
    {
        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void CategoryCreateForm_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "images","no-image.jpg");
            pbImage.Image = Image.FromFile(imagePath);
        }
    }
}

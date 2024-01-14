using _13.SimleForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.SimleForm
{
    public partial class TabelsForm : Form
    {
        public string DatabaseName { get; set; }
        private TabelManager _tabelManager;

        public TabelsForm()
        {
            InitializeComponent();
        }

        private void TabelsForm_Load(object sender, EventArgs e)
        {
            _tabelManager = new TabelManager(DatabaseName);
            LoadListTabels();
        }

        private void LoadListTabels()
        {
            dgvTabels.Rows.Clear();
            var list = _tabelManager.GetAllTabels();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvTabels.Rows.Add(row);
            }
        }

        private void btnGenareateTabels_Click(object sender, EventArgs e)
        {
            _tabelManager.CreateTabels();
            LoadListTabels();
        }
    }
}

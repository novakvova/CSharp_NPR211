using _13.SimleForm.Options;
using _13.SimleForm.Services;
using System.Windows.Forms;

namespace _13.SimleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsConnectionDB_Click(object sender, EventArgs e)
        {
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadListDatabase();
        }

        private void LoadListDatabase()
        {
            dgvDatabases.Rows.Clear();
            DatabaseManager databaseManager = new DatabaseManager();
            var list = databaseManager.GetListDatabases();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvDatabases.Rows.Add(row);
            }
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            int index = dgvDatabases.CurrentCell.RowIndex;
            string name = (string)dgvDatabases.Rows[index].Cells[0].Value;
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.DeleteDatabase(name);
            //MessageBox.Show("Row index", name);
            LoadListDatabase();
        }

        /// <summary>
        /// Додати нову БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager databaseManager = new DatabaseManager();
                databaseManager.CraateDatabase(txtDbName.Text);
                LoadListDatabase();
                txtDbName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Щось пішло не так");
            }

        }

        private void dgvDatabases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the double-click event
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the double-clicked cell
                string dataBaseName = (string)dgvDatabases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                TabelsForm dlg = new TabelsForm();
                dlg.DatabaseName = dataBaseName;
                dlg.ShowDialog();
            }
        }
    }
}

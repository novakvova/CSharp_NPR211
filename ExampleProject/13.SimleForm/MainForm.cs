using _13.SimleForm.Options;
using _13.SimleForm.Services;

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
            dgvDatabases.Rows.Clear();
            DatabaseManager databaseManager = new DatabaseManager();
            var list = databaseManager.GetListDatabases();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvDatabases.Rows.Add(row);
            }
        }
    }
}

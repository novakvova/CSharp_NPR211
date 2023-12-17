namespace _13.SimleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            MessageBox.Show("Привіт "+name);
        }
    }
}

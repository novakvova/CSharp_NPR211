using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace _13.SimleForm.Options
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            txtServerHost.Text = configuration.GetConnectionString("host");
            txtUserName.Text = configuration.GetConnectionString("user");
            txtUserPasssword.Text = configuration.GetConnectionString("password");
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string host = txtServerHost.Text;
            string userName = txtUserName.Text;
            string password = txtUserPasssword.Text;
            string conStr = $"Data Source={host};User ID={userName};Password={password};MultipleActiveResultSets=true;";
            try
            {
                var con = new SqlConnection(conStr);
                con.Open();
                MessageBox.Show("Успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! "+ex.Message);
            }

        }
    }
}

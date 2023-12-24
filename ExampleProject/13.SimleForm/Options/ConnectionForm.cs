using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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

            txtServerHost.Text = configuration.GetConnectionString("Host");
            txtUserName.Text = configuration.GetConnectionString("User");
            txtUserPasssword.Text = configuration.GetConnectionString("Password");
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
                MessageBox.Show("Помилка підключення!!! " + ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingOptions opt = new SettingOptions();
            opt.ConnectionStrings = new ConnectionStrings()
            {
                Host = txtServerHost.Text,
                User = txtUserName.Text,
                Password = txtUserPasssword.Text
            };
            string path = Path.Combine(Directory.GetCurrentDirectory(),
                "appsettings.json");

            using StreamWriter file = File.CreateText(path);
            JsonSerializer serializer = new JsonSerializer { Formatting = Formatting.Indented };
            serializer.Serialize(file, opt);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System.Data.SqlClient;

namespace _13.SimleForm.Options
{
    public class ConnectionStrings
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }

    public class SettingOptions
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }
}

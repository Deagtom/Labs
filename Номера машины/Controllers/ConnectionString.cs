using System.Configuration;

namespace Номера_машины.Controllers
{
    internal class ConnectionString
    {
        public static string Connection { get { return ConfigurationManager.ConnectionStrings["Номера_машины.Properties.Settings.Connection"].ConnectionString; } }
    }
}

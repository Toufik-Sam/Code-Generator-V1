
namespace DataAccessLayer
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = "Data Source=.; Integrated Security=True;";
        public static string GetDataBaseConnectionStringByName(string DataBaseName)
        {
            return "Server=.;Database=" + DataBaseName + ";User Id=sa;Password=sa123456;";
        }

    }
}

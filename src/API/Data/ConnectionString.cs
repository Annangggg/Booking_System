namespace Data
{
    public static class ConnectionString
    {

        private static string cName = "Data Source=.; Initial Catalog=Lodges;Integrated Security=True";

        public static string CName { get => cName; }
    }
}

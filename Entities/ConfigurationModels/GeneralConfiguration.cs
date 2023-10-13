namespace Entities.ConfigurationModels
{
    public enum TypeOfActions
    {
        Create, Update, Delete
    }

    public static class Constants
    {
        public static class Status
        {
            public const string Actived = "A";
            public const string Deactivated = "D";
        }
    }

    public class GeneralConfiguration
    {
        public string Section { get; set; } = "GeneralConstants";
        public string? CorsPolicyName { get; set; }
        public string? ConnectionStringName { get; set; }
    }
    public class NoSqlConfiguration
    {
        public string Section { get; set; } = "NoSqlConstants";
        public string? ConnectionStringName { get; set; }
        public string? MongoDatabase { get; set; }
    }
    public static class MongoCollectionNames
    {
        public const string Audits = "Audits";
    }
}

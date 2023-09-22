using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static class Mongo
        {
            public const string DatabaseName = "bluelife";
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
    }
}

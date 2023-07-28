using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "Mongo":
                    return new MongoDataAccess();
                case "SQL":
                    return new SQLDataAccess();
                case "List":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
            }
        }

    }
}

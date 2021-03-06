// ReSharper disable once CheckNamespace
namespace NEventStore
{
    using NEventStore.Persistence.Sql;

    public static class SqlPersistenceWireupExtensions
    {
#if HAVE_CONNECTIONSTRINGSSETTINGS
        public static SqlPersistenceWireup UsingSqlPersistence(this Wireup wireup, string connectionName)
        {
            var factory = new ConfigurationConnectionFactory(connectionName);
            return wireup.UsingSqlPersistence(factory);
        }
#endif

        public static SqlPersistenceWireup UsingSqlPersistence(this Wireup wireup, string connectionName, string providerName, string connectionString)
        {
            var factory = new ConfigurationConnectionFactory(connectionName, providerName, connectionString);
            return wireup.UsingSqlPersistence(factory);
        }

        public static SqlPersistenceWireup UsingSqlPersistence(this Wireup wireup, IConnectionFactory factory)
        {
            return new SqlPersistenceWireup(wireup, factory);
        }
    }
}
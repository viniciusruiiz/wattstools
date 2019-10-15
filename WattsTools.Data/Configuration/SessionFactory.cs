using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace WattsTools.Data.Configuration
{
    public class SessionFactory
    {
        private static ISessionFactory session;

        private static ISessionFactory Session
        {
            get
            {
                if (session is null)
                    InitializeSessionFactory();

                return session;
            }
        }

        private static void InitializeSessionFactory()
        {
            session = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("Server=localhost;Database=master;Trusted_Connection=True;")//ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                    .ShowSql()
                    .FormatSql())
                .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return Session.OpenSession();
        }
    }
}

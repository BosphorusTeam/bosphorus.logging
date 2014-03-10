using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bosphorus.Common;
using Bosphorus.Dao.Core.Session.Builder;
using Bosphorus.Dao.NHibernate.Session;
using Bosphorus.Library.Logging.Core;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ISession = Bosphorus.Dao.Core.Session.ISession;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class SessionBuilder : ISessionBuilder
    {
        private readonly ISessionFactory sessionFactory;

        //http://webdotnet.googlecode.com/svn-history/r98/trunk/Src/Commons.Persistence.NHibernate/NHibernateConfigHelper.cs
        public SessionBuilder(AssemblyRepository assemblyRepository)
        {
            Assembly[] assemblies = assemblyRepository.GetAssemblies();

            sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                              .ConnectionString(
                              @"data source=.\Demo.db3")
                              .ShowSql()
                )
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                                                .Execute(true, true))
                .Mappings(m =>
                    m.AutoMappings.Add(
                        AutoMap.Assemblies(new AutoMappingConfiguration(), assemblies)
                    )
                )
                .BuildSessionFactory();            
        }

        public ISession Build(string sessionAlias)
        {
            global::NHibernate.ISession openSession = sessionFactory.OpenSession();
            ISession session = new NHibernateSession(openSession);
            return session;
        }
    }
}
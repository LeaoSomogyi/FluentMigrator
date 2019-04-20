using System.Collections.Generic;
using System.Reflection;

namespace MigrationExample.FluentMigrator
{
    public class BaseContext
    {
        private List<Assembly> _migrations = new List<Assembly>();

        public List<Assembly> Migrations { get { return _migrations; } set {; } }

        public BaseContext()
        {
            LoadMigrations();
        }

        public void Add<T>() where T : class, new()
        {
            _migrations.Add(typeof(T).Assembly);
        }

        public void LoadMigrations()
        {
            Add<BaseTables>();
            Add<LogTableMigration>();
        }
    }
}

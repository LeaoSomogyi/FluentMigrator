using FluentMigrator;
using System;
using System.IO;

namespace MigrationExample.FluentMigrator
{
    [Migration(201904162142)]
    public class BaseTables : Migration
    {
        public override void Up()
        {
            Execute.Script(Path.Combine(Environment.CurrentDirectory, @"../../FluentMigrator/Scripts\", "CreateDatabase.sql"));
        }

        public override void Down()
        {
            Execute.Script(Path.Combine(Environment.CurrentDirectory, @"../../FluentMigrator/Scripts\", "DropDatabase.sql"));
        }
    }

    [Migration(201904162203)]
    public class LogTableMigration : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("TBLog")
                .WithColumn("Code_Log").AsGuid().PrimaryKey()
                .WithColumn("Description_Log").AsString();
        }
    }
}

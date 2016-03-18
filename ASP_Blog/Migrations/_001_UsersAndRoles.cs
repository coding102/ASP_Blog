using System;
using FluentMigrator;

namespace ASP_Blog.Migrations
{
    [Migration(1)]
    public class _001_UsersAndRoles : Migration
    {
        public override void Up()
        {
            Create.Table("users")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("username").AsString(120)
                .WithColumn("email").AsString("256")
                .WithColumn("password_hash").AsString("128");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }

        
    }
}
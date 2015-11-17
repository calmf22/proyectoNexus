namespace Nexus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class depa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NombreDepartamento = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departamentos");
        }
    }
}

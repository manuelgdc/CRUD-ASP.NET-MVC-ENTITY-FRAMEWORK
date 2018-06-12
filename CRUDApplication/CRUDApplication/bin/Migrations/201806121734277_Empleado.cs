namespace CRUDApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empleado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Email = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}

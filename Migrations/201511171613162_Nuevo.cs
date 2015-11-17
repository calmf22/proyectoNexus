namespace Nexus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDCompra = c.Int(nullable: false),
                        Proveedor = c.Int(nullable: false),
                        Producto = c.Int(nullable: false),
                        IDProducto = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(),
                        precioUnitario = c.Int(nullable: false),
                        UnidadMedida = c.String(),
                        RutaImagen = c.String(),
                    })
                .PrimaryKey(t => t.IdProducto);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        IDProveedor = c.Int(nullable: false, identity: true),
                        NombreProveedor = c.String(),
                        DireccionProveedor = c.String(),
                        NumeroTelProveedor = c.String(),
                        CiudadProveedor = c.String(),
                        DepartamentoID = c.Int(nullable: false),
                        PaisProveedor = c.String(),
                        CorreoProveedor = c.String(),
                    })
                .PrimaryKey(t => t.IDProveedor);
            
            CreateTable(
                "dbo.Salidas",
                c => new
                    {
                        IDSalida = c.Int(nullable: false, identity: true),
                        IDproducto = c.Int(nullable: false),
                        Nombre = c.String(),
                        IDproveedor = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDSalida);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IDUsuario = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        NombreUsuario = c.String(),
                        Contraseña = c.String(),
                    })
                .PrimaryKey(t => t.IDUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Salidas");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Productoes");
            DropTable("dbo.Compras");
        }
    }
}

Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Inicial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Estados",
                Function(c) New With
                    {
                        .IdEstado = c.Int(nullable := False, identity := True),
                        .Estado = c.String(maxLength := 50, unicode := false),
                        .Fecha = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IdEstado)
            
            CreateTable(
                "dbo.Usuarios",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 50, unicode := false),
                        .Apellido = c.String(nullable := False, maxLength := 50, unicode := false),
                        .Fecha = c.DateTime(nullable := False),
                        .Email = c.String(nullable := False, maxLength := 50, unicode := false),
                        .IdEstado = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Email) _
                .ForeignKey("dbo.Estados", Function(t) t.IdEstado, cascadeDelete := True) _
                .Index(Function(t) t.IdEstado)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Usuarios", "IdEstado", "dbo.Estados")
            DropIndex("dbo.Usuarios", New String() { "IdEstado" })
            DropTable("dbo.Usuarios")
            DropTable("dbo.Estados")
        End Sub
    End Class
End Namespace

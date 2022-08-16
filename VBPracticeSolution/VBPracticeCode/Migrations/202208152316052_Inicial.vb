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
                        .Id = c.Int(nullable := False, identity := True),
                        .Estado = c.String(maxLength := 50, unicode := false),
                        .Fecha = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Estados")
        End Sub
    End Class
End Namespace

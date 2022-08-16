Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Estados")>
Public Class Estados

    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column(Order:=1, TypeName:="INT")>
    <Key>
    Public Property Id As Integer

    <Column(Order:=2, TypeName:="VARCHAR")>
    <StringLength(50)>
    Public Property Estado As String

    <Column(Order:=3, TypeName:="DATETIME")>
    Public Property Fecha As DateTime

End Class

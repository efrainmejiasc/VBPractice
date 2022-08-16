Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


<Table("Usuarios")>
Public Class Usuarios


    <Column(Order:=1, TypeName:="INT")>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <Column(Order:=2, TypeName:="VARCHAR")>
    <StringLength(50)>
    <Required>
    Public Property Nombre As String

    <Column(Order:=3, TypeName:="VARCHAR")>
    <StringLength(50)>
    <Required>
    Public Property Apellido As String

    <Column(Order:=4, TypeName:="DATETIME")>
    Public Property Fecha As DateTime

    <Column(Order:=5, TypeName:="VARCHAR")>
    <StringLength(50)>
    <Required>
    <Key>
    Public Property Email As String

    <Column(Order:=6, TypeName:="INT")>
    <Required>
    Public Property IdEstado As Integer

    <ForeignKey("IdEstado")>
    Public Overridable Property Estados As Estados = Nothing


End Class

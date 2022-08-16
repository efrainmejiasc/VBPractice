
Imports System.Data.Entity

Public Class MyAppContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("Data Source=EMCSERVERHP\SQLEXPRESS;Initial Catalog=DbPractice;User Id=sa;Password=1234santiago")
    End Sub

    Public Overridable Property Estados As DbSet(Of Estados)
    Public Overridable Property Usuarios As DbSet(Of Usuarios)



End Class

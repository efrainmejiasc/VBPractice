Public Class UsuariosRepository
    Implements IUsuariosRepository

    Private ReadOnly _db As MyAppContext


    Public Sub New()
        Me._db = New MyAppContext()
    End Sub


    Public Function InsertUsuario(ByVal usuario As Usuarios) As Usuarios Implements IUsuariosRepository.InsertUsuario
        Me._db.Usuarios.Add(usuario)
        Me._db.SaveChanges()

        Return usuario
    End Function

    Public Function GetUsuarios() As List(Of Usuarios) Implements IUsuariosRepository.GetUsuarios
        Dim usuarios = Me._db.Usuarios.ToList()

        Return usuarios
    End Function

End Class

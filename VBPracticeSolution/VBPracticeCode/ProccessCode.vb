Public Class ProccessCode

    Private ReadOnly _usuarioRepository As IUsuariosRepository

    Public Sub New()

        Me._usuarioRepository = New UsuariosRepository

    End Sub

    Public Function InsertUsuario(ByVal usuario) As Usuarios
        usuario = Me._usuarioRepository.InsertUsuario(usuario)

        Return usuario
    End Function

    Public Function GetUsuarios() As List(Of Usuarios)
        Dim usuarios = Me._usuarioRepository.GetUsuarios()

        Return usuarios
    End Function
End Class

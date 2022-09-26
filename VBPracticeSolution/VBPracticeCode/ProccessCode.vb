Public Class ProccessCode

    Private ReadOnly _usuarioRepository As IUsuariosRepository
    Private ReadOnly _requestService As IRequestHTTP

    Public Sub New()

        Me._usuarioRepository = New UsuariosRepository
        Me._requestService = New RequestHTTP

    End Sub

    Public Function InsertUsuario(ByVal usuario) As Usuarios
        usuario = Me._usuarioRepository.InsertUsuario(usuario)

        Return usuario
    End Function

    Public Function GetUsuarios() As List(Of Usuarios)
        Dim usuarios = Me._usuarioRepository.GetUsuarios()

        Return usuarios
    End Function

    Public Async Function RequestGetHttpAsync() As Task(Of String)
        Dim respuesta = Await Me._requestService.ExecuteRequest()

        Return respuesta
    End Function

End Class

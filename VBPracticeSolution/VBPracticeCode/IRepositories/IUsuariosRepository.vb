Public Interface IUsuariosRepository

    Function InsertUsuario(ByVal usuario As Usuarios) As Usuarios
    Function GetUsuarios() As List(Of Usuarios)

End Interface

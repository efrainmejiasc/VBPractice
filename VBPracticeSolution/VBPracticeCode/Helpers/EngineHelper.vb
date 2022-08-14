Imports System.Configuration
Imports System.Data.SqlClient

Public Class EngineHelper

    Public Sub New()

    End Sub

    Private Shared valor As New EngineHelper
    Public Shared Function Instance() As EngineHelper
        If (valor Is Nothing) Then
            valor = New EngineHelper()
        End If

        Return valor
    End Function

    Public Shared conexionStr As String = ConfigurationManager.ConnectionStrings("ConexionSQL").ToString()
    Public conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionSQL").ToString())
    Public Shared secretKey As String = ConfigurationManager.AppSettings("SecretKey")

    Public Function StrConexion() As String
        Return conexionStr
    End Function


    Public Function PruebaConexion() As Boolean
        Dim resultado As Boolean = False

        Try
            conexion.Open()
            resultado = True
            conexion.Close()

        Catch ex As SqlException
            conexion.Close()
        End Try


        Return resultado
    End Function

End Class

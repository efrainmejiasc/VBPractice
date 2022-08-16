Imports System.Configuration
Imports System.Data
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
    Public Shared conexionStrDbPractice As String = ConfigurationManager.ConnectionStrings("ConexionContextSQL").ToString()
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

    Public Function GetRoles() As DataTable

        Dim dt As DataTable = New DataTable()
        Dim sql As String = "SELECT Id, Rol FROM Roles"

        Using conexion
            Dim comando As SqlCommand = New SqlCommand(sql, conexion)
            comando.Parameters.Clear()
            Dim dataAdaptador As SqlDataAdapter = New SqlDataAdapter(comando)
            dataAdaptador.Fill(dt)
        End Using

        Return dt

    End Function

End Class

Imports System.Globalization
Imports Newtonsoft.Json
Imports VBPracticeCode

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form1 = New Form1()
        form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As New Usuarios() With {
            .Nombre = "Rossy",
            .Apellido = "Virguez",
            .Email = "rossy2022@gmail.com",
            .Fecha = Convert.ToDateTime(DateTime.Now),
            .IdEstado = 1
        }

        Dim strUsuario As String = JsonConvert.SerializeObject(usuario)
        RichTextBox1.Text = strUsuario

        Dim funcion = New ProccessCode()
        usuario = funcion.InsertUsuario(usuario)

        If (usuario.Id > 0) Then
            MessageBox.Show("Exito")
        Else
            MessageBox.Show("Fallido")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim funcion = New ProccessCode()
        Dim usuarios = funcion.GetUsuarios()

        Dim strUsuario As String = JsonConvert.SerializeObject(usuarios)
        RichTextBox1.Text = strUsuario
    End Sub

    Private Async Sub Button3_ClickAsync(sender As Object, e As EventArgs) Handles Button3.Click
        Dim funcion = New ProccessCode()

        Dim respuesta = Await funcion.RequestGetHttpAsync()
        RichTextBox1.Text = respuesta

    End Sub
End Class
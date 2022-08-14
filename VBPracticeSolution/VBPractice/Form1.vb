Imports VBPracticeCode

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = EngineHelper.conexionStr
        TextBox2.Text = EngineHelper.secretKey

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim engineCode As EngineCode = New EngineCode()
        dgv = engineCode.AddColumnas(dgv)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim engineCode As EngineCode = New EngineCode()
        dgv = engineCode.RemoveColumnas(dgv)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lstStr As List(Of String) = New List(Of String)
        lstStr.Add("Hola")
        lstStr.Add("Chao")
        lstStr.Add("Que bien!")

        For Each item As String In lstStr
            MessageBox.Show(item)
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lstStr As List(Of String) = New List(Of String)
        lstStr.Add("Hola")
        lstStr.Add("Chao")
        lstStr.Add("Que bien!")

        Dim lst2 = lstStr.FirstOrDefault()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim engineHelper As EngineHelper = New EngineHelper()
        Dim resultado = engineHelper.PruebaConexion()

        MessageBox.Show("Resultado: " + Convert.ToString(resultado))

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim engineHelper As EngineHelper = New EngineHelper()
        dgv.DataSource = engineHelper.GetRoles()

        Dim engineCode As EngineCode = New EngineCode()
        engineCode.PintarGrid(dgv)
        engineCode.EnumeraGrid(dgv)

        dgv.ClearSelection()

    End Sub

End Class
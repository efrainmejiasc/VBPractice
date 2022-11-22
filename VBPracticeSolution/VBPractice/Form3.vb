Imports System.IO
Imports System.Security.AccessControl
Imports System.Xml

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.fileDialogo.ShowDialog()
        TextBox1.Text = Me.fileDialogo.FileName()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (String.IsNullOrEmpty(TextBox1.Text)) Then
            Return
        End If

        RichTextBox1.Text = String.Empty
        Dim strXml As String = File.ReadAllText(TextBox1.Text)
        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.LoadXml(strXml)
        Dim allElements As XmlNodeList = xmlDoc.SelectNodes("//*")
        Dim nNodes As Integer = allElements.Count - 1

        'For i As Integer = 0 To nNodes Step 1
        '    Try
        '        Dim elemento As String = IIf(Not IsNothing(allElements.Item(i).Name), allElements.Item(i).Name.ToString(), String.Empty)
        '        RichTextBox1.Text = RichTextBox1.Text & elemento & Constants.vbCrLf
        '    Catch ex As Exception
        '        Dim n As String = ex.ToString()
        '    End Try

        'Next

        Dim nodoTercero As XmlNode = xmlDoc.SelectSingleNode("/GuardarTercero/Datos/Terceros/Tercero")
        Dim identificacion As String = nodoTercero.Item("Identificacion").InnerText
        Dim sucursal As String = nodoTercero.Item("Sucursal").InnerText
        Dim usaSucursal As String = nodoTercero.Item("UsaSucursal").InnerText
        Dim nombre As String = nodoTercero.Item("Nombre").InnerText
        Dim tipo As String = nodoTercero.Item("Tipo").InnerText
        Dim contacto As String = nodoTercero.Item("Contacto").InnerText
        Dim direccion As String = nodoTercero.Item("Direccion").InnerText
        Dim email As String = nodoTercero.Item("Email").InnerText
        Dim estado As String = nodoTercero.Item("Estado").InnerText
        Dim codigoPais As String = nodoTercero.Item("CodigoPais").InnerText
        Dim codigoCiudad As String = nodoTercero.Item("CodigoCiudad").InnerText
        Dim tipoIdentificacionTributaria As String = nodoTercero.Item("TipoIdentificacionTributaria").InnerText
        Dim clasificacionTributaria As String = nodoTercero.Item("ClasificacionTributaria").InnerText

        Dim elementoCliente As XmlElement = nodoTercero.Item("Cliente")
        Dim listaPrecio As String = elementoCliente.Attributes(0).Value.ToString()
        Dim calificacion As String = elementoCliente.Attributes(1).Value.ToString()
        Dim formaPago As String = elementoCliente.Attributes(2).Value.ToString()
        Dim vendedor As String = elementoCliente.Attributes(3).Value.ToString()
        Dim cobrador As String = elementoCliente.Attributes(4).Value.ToString()

        Dim cliente As String = nodoTercero.Item("Cliente").InnerText
        Dim proveedor As String = nodoTercero.Item("Proveedor").InnerText
        Dim telefono1 As String = nodoTercero.Item("Telefono1").InnerText
        Dim telefono2 As String = nodoTercero.Item("Telefono2").InnerText
        Dim telefono3 As String = nodoTercero.Item("Telefono3").InnerText


        For Each xn As XmlElement In allElements
            Try
                Dim elemento As String = IIf(Not IsNothing(xn.Name), xn.Name.ToString(), String.Empty)
                Dim nodo As XmlNode = xn.SelectSingleNode(elemento)
                RichTextBox1.Text = RichTextBox1.Text & elemento & Constants.vbCrLf
            Catch ex As Exception
                Dim n As String = ex.ToString()
            End Try
        Next

        'Dim anode = xmlDoc.SelectSingleNode("Datos/Terceros/Tercero")




    End Sub
End Class
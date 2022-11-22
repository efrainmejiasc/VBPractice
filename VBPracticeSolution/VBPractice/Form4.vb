

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SendMail()
        EnviarEmailUsandoSmtpOffice365()
        'EnviarMail()
    End Sub

    'Dirección del servidor:  smtp.office365.com
    'Nombre de usuario:  su dirección de Office 365 (p. ej., ejemplo@sudominio.com)
    'Contraseña:  su contraseña de Office 365
    'Número de puerto:  587 (con TLS)
    'Autenticación:  Requerido
    'Límites  de envío: 10,000 correos electrónicos por día

    Public Sub SendMail()
        Try
            Dim oMail As New EASendMail.SmtpMail("TryIt")

            ' Set sender email address, please change it to yours
            oMail.From = "efrain.mejias@smd.software"
            ' Set recipient email address, please change it to yours
            oMail.To = "efrainmejias@hotmail.com"

            ' Set email subject
            oMail.Subject = "Prueba de correo usando SMTP"
            ' Set email body
            oMail.TextBody = "Este email es una prueba usando SMTP"
            oMail.AddAttachment("E:\SiiMEd\Proyecto\SMTP\Analisis.txt")

            ' Your SMTP server address
            Dim oServer As New EASendMail.SmtpServer("smtp.office365.com")

            ' User and password for ESMTP authentication
            oServer.User = "efrain.mejias@smd.software"
            oServer.Password = "EMejias2022"

            ' Most mordern SMTP servers require SSL/TLS connection now.
            ' ConnectTryTLS means if server supports SSL/TLS, SSL/TLS will be used automatically.
            'oServer.ConnectType = SmtpConnectType.ConnectTryTLS

            ' If your SMTP server uses 587 port
            ' oServer.Port = 587

            ' If your SMTP server requires SSL/TLS connection on 25/587/465 port
            oServer.Port = 587 ' 25 or 587 or 465
            oServer.ConnectType = EASendMail.SmtpConnectType.ConnectSSLAuto

            Console.WriteLine("start to send email ...")

            Dim oSmtp As New EASendMail.SmtpClient()
            oSmtp.SendMail(oServer, oMail)

        Catch ep As Exception
            Dim excepcion As String = ep.Message
        End Try

    End Sub

    Public Function EnviarMail() As Boolean
        Dim result As Boolean = False

        Try
            Dim mensaje As Net.Mail.MailMessage = New Net.Mail.MailMessage()
            Dim servidor As Net.Mail.SmtpClient = New Net.Mail.SmtpClient()
            mensaje.From = New Net.Mail.MailAddress("efrain.mejias@smd.software")
            mensaje.Subject = "Testing enviar correo"
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8
            mensaje.Body = "Cuerpo del mensaje"
            mensaje.BodyEncoding = System.Text.Encoding.UTF8
            mensaje.[To].Add(New Net.Mail.MailAddress("luz.pena@siimed.com.co"))
            mensaje.[To].Add(New Net.Mail.MailAddress("efrainmejias@hotmail.com"))
            mensaje.CC.Add(New Net.Mail.MailAddress("efrainmejiasc@hotmail.com"))
            mensaje.Bcc.Add(New Net.Mail.MailAddress("emcingenieriadesoftware@outlook.com"))
            servidor.Credentials = New System.Net.NetworkCredential("efrain.mejias@smd.software", "EMejias2022")
            servidor.Port = 587
            servidor.Host = "smtp.office365.com"
            servidor.EnableSsl = True
            servidor.Send(mensaje)
            mensaje.Dispose()
            result = True
        Catch ep As Exception
            Console.WriteLine("failed to send email with the following error:")
            Console.WriteLine(ep.Message)
        End Try
        Return result
    End Function

    Public Sub EnviarEmailUsandoSmtpOffice365()
        Try
            'TryIt es un codigo de licencia para evaluacion
            Dim oMail As New EASendMail.SmtpMail("TryIt")
            oMail.From = "efrain.mejias@smd.software"
            oMail.To = "efrainmejias@hotmail.com;efrainmejias@gmail.com;emcingenieriadesoftware@outlook.com"

            oMail.Subject = "Prueba de correo usando SMTP Office 365"
            oMail.TextBody = "Este email es una prueba usando SMTP - OFFICE 365"
            oMail.AddAttachment("E:\SiiMEd\Proyecto\SMTP\Analisis.txt")

            Dim oServer As New EASendMail.SmtpServer("smtp.office365.com")
            oServer.User = "efrain.mejias@smd.software"
            oServer.Password = "EMejias2022"


            ' Si tu servidor SMTP requiere SSL/TLS conexion sobre el puerto 25/587/465 
            oServer.Port = 587 ' 25 o 587 o 465
            oServer.ConnectType = EASendMail.SmtpConnectType.ConnectSSLAuto

            Dim oSmtp As New EASendMail.SmtpClient()
            oSmtp.SendMail(oServer, oMail)

        Catch ep As Exception
            Dim excepcion As String = ep.Message
        End Try

    End Sub

End Class
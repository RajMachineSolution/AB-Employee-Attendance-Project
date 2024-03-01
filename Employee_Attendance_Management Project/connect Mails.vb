Imports System.Net.Mail
Imports Microsoft.Win32
Public Class connect_Mails

    Public Sub SendOTP(OTP As Integer, varEmailId As String)
        Dim smtpServer As New SmtpClient
        Dim e_mail As New MailMessage()

        Try
            Dim senderEmail As String = "anujbhadoriya0102rmsse@outlook.com"
            Dim senderPassword As String = "nxanqsjczohwktvn"
            Dim recieverEmail As String = varEmailId

            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential(senderEmail, senderPassword)
            smtpServer.Port = 587
            smtpServer.Host = "smtp.office365.com"
            smtpServer.EnableSsl = True
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(senderEmail)
            e_mail.To.Add(recieverEmail)
            e_mail.Subject = "otp to change Password"
            e_mail.IsBodyHtml = False
            e_mail.Body = "otp of change password " & OTP

            smtpServer.Send(e_mail)
            MsgBox("OTP sent")
        Catch ex As Exception
            Console.WriteLine("problem in authentication : " & ex.Message)
        End Try

    End Sub

End Class

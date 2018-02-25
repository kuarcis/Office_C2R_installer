Public Class info_form
    Private Sub info_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += My.Resources.version
        Dim info_text As String = ""

        info_text += "Office C2R installer will always install all components of Office," & vbCrLf
        info_text += "and by Microsoft's suggest, for those functions users don't want" & vbCrLf
        info_text += "to use, 'delete those links of apps that you don't want to use'," & vbCrLf
        info_text += "which is a very strange design for such a huge software suite." & vbCrLf
        info_text += vbCrLf
        info_text += "This tool is work as a frontend to generate config.xml file that" & vbCrLf
        info_text += "can let C2R installer only install components of Office 2016/365 " & vbCrLf
        info_text += "you really want." & vbCrLf
        info_text += vbCrLf
        info_text += "This tool only work with Office Deployment Tools for Office 2016/365," & vbCrLf
        info_text += "which can be found on Microsoft website" & vbCrLf
        info_text += vbCrLf
        info_text += "made by joseph:" & vbCrLf

        info_label.Text += info_text


        'MsgBox(info_text, MsgBoxStyle.OkOnly, "C2R custom install XML make and installer v" & My.Resources.version & " by joseph")
    End Sub

    Private Sub github_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles github_link.LinkClicked
        Try
            github_link.LinkVisited = True
            Process.Start("https://github.com/kuarcis/Office_C2R_installer")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            github_link.LinkVisited = True
            Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=49117")
        Catch ex As Exception

        End Try
    End Sub
End Class
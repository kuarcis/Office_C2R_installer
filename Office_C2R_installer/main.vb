Imports System.Security
Imports System.IO
Imports System.Globalization

Public Class C2R_XML_maker


    'predefined product id and langID list
    Dim productID As New List(Of String) From
       {"ProPlusRetail",
        "ProfessionalRetail",
        "HomeStudentRetail",
        "HomeBusinessRetail",
        "O365ProPlusRetail",
        "O365HomePremRetail",
        "O365BusinessRetail",
        "O365SmallBusPremRetail"}
    Dim langID As New List(Of String) From
        {"ar-sa", "bg-bg", "zh-cn", "zh-tw",
        "hr-hr", "cs-cz", "da-dk", "nl-nl",
        "en-us", "et-ee", "fi-fi", "fr-fr",
        "de-de", "el-gr", "he-il", "hi-in",
        "hu-hu", "id-id", "it-it", "ja-jp",
        "kk-kz", "ko-kr", "lv-lv", "lt-lt",
        "ms-my", "nb-no", "pl-pl", "pt-br",
        "pt-pt", "ro-ro", "ru-ru", "sr-latn-rs",
        "sk-sk", "sl-si", "es-es", "sv-se",
        "th-th", "tr-tr", "uk-ua", "vi-vn"}

    Public is_previewed As Boolean = False
    Public is_cfg_saved As Boolean = False
    Public is_exe_selected As Boolean = False
    Public is_src_selected As Boolean = False
    'empty cfg is kind of 'altered', compare with the assuming completed one
    Public cfg_alter As Boolean = True
    Public use32or64 As Integer
    Public sys_langid As String
    'control of altering event
    Private Sub alter_handler(sender As Object, e As EventArgs)
        cfg_alter = True
        With gen_preview
            .Font = New Font(gen_preview.Font, FontStyle.Bold)
            .ForeColor = Color.Red
        End With
        save_cfg_only.Enabled = False
        save_and_install.Enabled = False
    End Sub


    'onload events
    Public Sub C2R_XML_maker_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text += My.Resources.version
        sys_langid = CultureInfo.CurrentCulture.ToString
        Dim langid_idx As Integer = 8 'if can't find match langID, use en-us as default
        'find default langid
        For Each id_tmp In langID
            If id_tmp.ToUpper = sys_langid.ToUpper Then
                langid_idx = langID.FindIndex(Function(ids As String)
                                                  Return ids = id_tmp
                                              End Function)
            End If
        Next

        Dim fill_tmp As String
        For Each fill_tmp In productID
            edition_list.Items.Add(fill_tmp)
        Next
        For Each fill_tmp In langID
            lang_list.Items.Add(fill_tmp)
        Next
        save_cfg_only.Enabled = False
        save_and_install.Enabled = False
        cfg_path_label.Text = Path.GetTempPath()
        RadioButton_64bit.Checked = True
        use32or64 = 64
        edition_list.SelectedIndex = 0
        lang_list.SelectedIndex = langid_idx

        'add handlers to all controls
        For Each GroupBoxCntrol As Control In Controls
            If TypeOf GroupBoxCntrol Is GroupBox Then
                For Each ctl_item As Control In GroupBoxCntrol.Controls
                    'monitor all check box change
                    If TypeOf ctl_item Is CheckBox Then
                        AddHandler DirectCast(ctl_item, CheckBox).CheckedChanged, AddressOf alter_handler
                    End If
                    'monitor all combobox change
                    If TypeOf ctl_item Is ComboBox Then
                        AddHandler DirectCast(ctl_item, ComboBox).SelectedIndexChanged, AddressOf alter_handler
                    End If
                    'monitor radio button change
                    If TypeOf ctl_item Is RadioButton Then
                        AddHandler DirectCast(ctl_item, RadioButton).CheckedChanged, AddressOf alter_handler
                    End If
                Next

            End If
        Next

        'monitor src path change
        AddHandler src_path_label.TextChanged, AddressOf alter_handler

    End Sub


    'control of setup.exe path
    Private Sub exe_path_sel_Click(sender As Object, e As EventArgs) Handles exe_path_sel.Click
        Dim check_exe
        check_exe = exe_path_label.Text
        If filefinder_1.ShowDialog() = DialogResult.Cancel Then
            exe_path_label.Text = check_exe
            filefinder_1.FileName = check_exe
        End If

        If check_exe <> filefinder_1.FileName Then
            is_exe_selected = True
            exe_path_label.Text = filefinder_1.FileName

        End If
        'clean up path in dialogue box

    End Sub
    'whille exe path change, if src path is not select, auto fill setup path, 


    Private Sub exe_path_cln_Click(sender As Object, e As EventArgs) Handles exe_path_reset.Click
        exe_path_label.Text = ""
        is_exe_selected = False
    End Sub


    'control of sourcepath
    Private Sub src_path_sel_Click(sender As Object, e As EventArgs) Handles src_path_sel.Click
        Dim check_path
        check_path = src_path_label.Text

        If pathfinder_1.ShowDialog() = DialogResult.Cancel Then
            src_path_label.Text = check_path
            pathfinder_1.SelectedPath = check_path
        End If

        If check_path <> pathfinder_1.SelectedPath Then
            src_path_label.Text = pathfinder_1.SelectedPath
            is_src_selected = True
        End If
    End Sub

    Private Sub src_path_cln_Click(sender As Object, e As EventArgs) Handles src_path_reset.Click
        src_path_label.Text = ""
        is_src_selected = False
    End Sub

    'control langID

    Private Sub matchOSCheck_CheckedChanged(sender As Object, e As EventArgs) Handles matchOSCheck.CheckedChanged

        If matchOSCheck.Checked Then
            lang_list.Enabled = False
        Else
            lang_list.Enabled = True
        End If
    End Sub

    'control of cofig.xml save location
    Private Sub cfg_path_sel_Click(sender As Object, e As EventArgs) Handles cfg_path_sel.Click
        Dim check_path
        check_path = cfg_path_label.Text

        If pathfinder_1.ShowDialog() = DialogResult.Cancel Then
            cfg_path_label.Text = check_path


        ElseIf check_path <> (pathfinder_1.SelectedPath & "\") Then
            cfg_path_label.Text = (pathfinder_1.SelectedPath & "\")

        End If
    End Sub

    Private Sub cfg_path_cln_Click(sender As Object, e As EventArgs) Handles cfg_path_cln.Click
        cfg_path_label.Text = Path.GetTempPath()

    End Sub

    'control of product selection
    Private Sub product_all_Click(sender As Object, e As EventArgs) Handles product_all.Click
        Array.ForEach(cpomnt_ctl_group.Controls.OfType(Of CheckBox).ToArray(), Sub(box As CheckBox) box.Checked = True)

    End Sub

    Private Sub product_clean_Click(sender As Object, e As EventArgs) Handles product_clean.Click
        Array.ForEach(cpomnt_ctl_group.Controls.OfType(Of CheckBox).ToArray(), Sub(box As CheckBox) box.Checked = False)

    End Sub



    'generate preview
    Private Sub gen_preview_Click(sender As Object, e As EventArgs) Handles gen_preview.Click

        If cfg_alter Then
            If RadioButton_32bit.Checked Then
                use32or64 = 32
            Else
                use32or64 = 64
            End If

            preview_text.Text = ""
            Dim tmp_prev_text_list As New List(Of String)
            tmp_prev_text_list.Add("<Configuration>" & vbCrLf)

            'src path handler
            If is_src_selected Then

                tmp_prev_text_list.Add("    <Add SourcePath=""" & src_path_label.Text & """ OfficeClientEdition=""" & use32or64 & """>" & vbCrLf)
            Else
                tmp_prev_text_list.Add("    <Add OfficeClientEdition=""" & use32or64 & """ >" & vbCrLf)
            End If

            tmp_prev_text_list.Add("        <Product ID=""" & edition_list.SelectedItem.ToString & """>" & vbCrLf)

            'lang id handler
            If matchOSCheck.Checked Then
                tmp_prev_text_list.Add("            <Language ID=""MatchOS""/>" & vbCrLf)
            Else
                tmp_prev_text_list.Add("            <Language ID=""" & lang_list.SelectedItem.ToString & """/>" & vbCrLf)
            End If

            'product installation handler
            For Each product_selection As CheckBox In cpomnt_ctl_group.Controls.OfType(Of CheckBox).ToArray
                If Not product_selection.Checked Then
                    If product_selection.Text = "OneDrive(Groove)" Then
                        tmp_prev_text_list.Add("            <ExcludeApp ID=""OneDrive""/>" & vbCrLf)
                        tmp_prev_text_list.Add("            <ExcludeApp ID=""Groove""/>" & vbCrLf)
                    Else
                        tmp_prev_text_list.Add("            <ExcludeApp ID=""" & product_selection.Text & """/>" & vbCrLf)
                    End If
                End If
            Next
            tmp_prev_text_list.Add("        </Product>" & vbCrLf)
            tmp_prev_text_list.Add("    </Add>" & vbCrLf)
            tmp_prev_text_list.Add("    <logging level=""standard""/> " & vbCrLf)
            tmp_prev_text_list.Add("</Configuration>" & vbCrLf)

            'preview writer
            For Each text_input_line In tmp_prev_text_list
                preview_text.Text += text_input_line
            Next
            is_previewed = True
            cfg_alter = False
            With gen_preview
                .Font = New Font(gen_preview.Font, FontStyle.Regular)
                .ForeColor = Color.Black
            End With
            save_cfg_only.Enabled = True
            save_and_install.Enabled = True
        End If

    End Sub

    Public Function file_writer() As Boolean

        Dim tar_path = cfg_path_label.Text & "config.xml"
        Try
            My.Computer.FileSystem.WriteAllText(tar_path, preview_text.Text, False)
            MsgBox("file write done", MsgBoxStyle.OkOnly, "XML writer")
            Return True
        Catch e As Exception
            MsgBox("Exception occur:" & vbCrLf & vbCrLf & e.Message, MsgBoxStyle.Exclamation, "XML writer")
            MsgBox("Save file fail, try a different path, or reset path to default", MsgBoxStyle.Exclamation, "XML writer")
            Return False
        End Try

    End Function


    Private Sub save_cfg_only_Click(sender As Object, e As EventArgs) Handles save_cfg_only.Click

        file_writer()

    End Sub


    Private Sub save_and_install_Click(sender As Object, e As EventArgs) Handles save_and_install.Click
        If is_exe_selected Then
            If File.Exists(exe_path_label.Text) Then
                If Directory.Exists(src_path_label.Text) Then
                    If file_writer() Then
                        Try
                            Process.Start(exe_path_label.Text, "/configure " & cfg_path_label.Text & "config.xml")
                        Catch err As Exception
                            MsgBox("Exception occur:" & vbCrLf & vbCrLf & err.Message, MsgBoxStyle.Exclamation, "Installer")
                        End Try


                    End If
                Else
                    MsgBox("Can't find Selected SourcePath" & vbCrLf & "maybe the folder has been moved.")
                End If

            Else
                MsgBox("Can't find Setup.exe form selected Setup.exe location," & vbCrLf & "maybe the file has been moved.")
            End If
        Else
            MsgBox("No setup.exe selected")
        End If
    End Sub


    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        info_form.Show()

    End Sub
End Class

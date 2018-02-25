<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class C2R_XML_maker
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C2R_XML_maker))
        Me.preview_group = New System.Windows.Forms.GroupBox()
        Me.preview_text = New System.Windows.Forms.TextBox()
        Me.pathfinder_1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.src_ctl_group = New System.Windows.Forms.GroupBox()
        Me.path_hint1 = New System.Windows.Forms.Label()
        Me.src_path_reset = New System.Windows.Forms.Button()
        Me.src_path_label = New System.Windows.Forms.Label()
        Me.src_path_sel = New System.Windows.Forms.Button()
        Me.edtion_ctl_group = New System.Windows.Forms.GroupBox()
        Me.edition_list = New System.Windows.Forms.ComboBox()
        Me.RadioButton_64bit = New System.Windows.Forms.RadioButton()
        Me.RadioButton_32bit = New System.Windows.Forms.RadioButton()
        Me.lang_ctl_group = New System.Windows.Forms.GroupBox()
        Me.matchOSCheck = New System.Windows.Forms.CheckBox()
        Me.lang_list = New System.Windows.Forms.ComboBox()
        Me.exe_ctl_group = New System.Windows.Forms.GroupBox()
        Me.exe_path_reset = New System.Windows.Forms.Button()
        Me.exe_path_label = New System.Windows.Forms.Label()
        Me.exe_path_sel = New System.Windows.Forms.Button()
        Me.filefinder_1 = New System.Windows.Forms.OpenFileDialog()
        Me.cpomnt_ctl_group = New System.Windows.Forms.GroupBox()
        Me.product_clean = New System.Windows.Forms.Button()
        Me.product_all = New System.Windows.Forms.Button()
        Me.porduct10 = New System.Windows.Forms.CheckBox()
        Me.porduct9 = New System.Windows.Forms.CheckBox()
        Me.product8 = New System.Windows.Forms.CheckBox()
        Me.product7 = New System.Windows.Forms.CheckBox()
        Me.product12 = New System.Windows.Forms.CheckBox()
        Me.product11 = New System.Windows.Forms.CheckBox()
        Me.product5 = New System.Windows.Forms.CheckBox()
        Me.product1 = New System.Windows.Forms.CheckBox()
        Me.product4 = New System.Windows.Forms.CheckBox()
        Me.product3 = New System.Windows.Forms.CheckBox()
        Me.product2 = New System.Windows.Forms.CheckBox()
        Me.product6 = New System.Windows.Forms.CheckBox()
        Me.cfg_ctl_group = New System.Windows.Forms.GroupBox()
        Me.cfg_path_cln = New System.Windows.Forms.Button()
        Me.cfg_path_label = New System.Windows.Forms.Label()
        Me.cfg_path_sel = New System.Windows.Forms.Button()
        Me.gen_preview = New System.Windows.Forms.Button()
        Me.save_cfg_only = New System.Windows.Forms.Button()
        Me.save_and_install = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Button()
        Me.preview_group.SuspendLayout()
        Me.src_ctl_group.SuspendLayout()
        Me.edtion_ctl_group.SuspendLayout()
        Me.lang_ctl_group.SuspendLayout()
        Me.exe_ctl_group.SuspendLayout()
        Me.cpomnt_ctl_group.SuspendLayout()
        Me.cfg_ctl_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'preview_group
        '
        Me.preview_group.Controls.Add(Me.preview_text)
        Me.preview_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.preview_group.ForeColor = System.Drawing.Color.Black
        Me.preview_group.Location = New System.Drawing.Point(581, 12)
        Me.preview_group.Name = "preview_group"
        Me.preview_group.Size = New System.Drawing.Size(467, 528)
        Me.preview_group.TabIndex = 0
        Me.preview_group.TabStop = False
        Me.preview_group.Text = "Config.xml Preview"
        '
        'preview_text
        '
        Me.preview_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.preview_text.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.preview_text.Location = New System.Drawing.Point(5, 21)
        Me.preview_text.Multiline = True
        Me.preview_text.Name = "preview_text"
        Me.preview_text.ReadOnly = True
        Me.preview_text.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.preview_text.Size = New System.Drawing.Size(456, 492)
        Me.preview_text.TabIndex = 0
        Me.preview_text.WordWrap = False
        '
        'pathfinder_1
        '
        Me.pathfinder_1.SelectedPath = "Office"
        '
        'src_ctl_group
        '
        Me.src_ctl_group.Controls.Add(Me.path_hint1)
        Me.src_ctl_group.Controls.Add(Me.src_path_reset)
        Me.src_ctl_group.Controls.Add(Me.src_path_label)
        Me.src_ctl_group.Controls.Add(Me.src_path_sel)
        Me.src_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.src_ctl_group.Location = New System.Drawing.Point(12, 70)
        Me.src_ctl_group.Name = "src_ctl_group"
        Me.src_ctl_group.Size = New System.Drawing.Size(541, 121)
        Me.src_ctl_group.TabIndex = 7
        Me.src_ctl_group.TabStop = False
        Me.src_ctl_group.Text = "Source Path"
        '
        'path_hint1
        '
        Me.path_hint1.AutoSize = True
        Me.path_hint1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.path_hint1.Location = New System.Drawing.Point(18, 44)
        Me.path_hint1.Name = "path_hint1"
        Me.path_hint1.Size = New System.Drawing.Size(467, 64)
        Me.path_hint1.TabIndex = 11
        Me.path_hint1.Text = resources.GetString("path_hint1.Text")
        '
        'src_path_reset
        '
        Me.src_path_reset.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.src_path_reset.Location = New System.Drawing.Point(457, 18)
        Me.src_path_reset.Name = "src_path_reset"
        Me.src_path_reset.Size = New System.Drawing.Size(75, 23)
        Me.src_path_reset.TabIndex = 10
        Me.src_path_reset.Text = "Reset"
        Me.src_path_reset.UseVisualStyleBackColor = True
        '
        'src_path_label
        '
        Me.src_path_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.src_path_label.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.src_path_label.Location = New System.Drawing.Point(100, 21)
        Me.src_path_label.Name = "src_path_label"
        Me.src_path_label.Size = New System.Drawing.Size(351, 20)
        Me.src_path_label.TabIndex = 9
        Me.src_path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'src_path_sel
        '
        Me.src_path_sel.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.src_path_sel.Location = New System.Drawing.Point(19, 18)
        Me.src_path_sel.Name = "src_path_sel"
        Me.src_path_sel.Size = New System.Drawing.Size(75, 23)
        Me.src_path_sel.TabIndex = 8
        Me.src_path_sel.Text = "Select Folder"
        Me.src_path_sel.UseVisualStyleBackColor = True
        '
        'edtion_ctl_group
        '
        Me.edtion_ctl_group.Controls.Add(Me.edition_list)
        Me.edtion_ctl_group.Controls.Add(Me.RadioButton_64bit)
        Me.edtion_ctl_group.Controls.Add(Me.RadioButton_32bit)
        Me.edtion_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.edtion_ctl_group.Location = New System.Drawing.Point(12, 197)
        Me.edtion_ctl_group.Name = "edtion_ctl_group"
        Me.edtion_ctl_group.Size = New System.Drawing.Size(541, 54)
        Me.edtion_ctl_group.TabIndex = 8
        Me.edtion_ctl_group.TabStop = False
        Me.edtion_ctl_group.Text = "Install Edition"
        '
        'edition_list
        '
        Me.edition_list.AutoCompleteCustomSource.AddRange(New String() {"ProPlusRetail", "ProfessionalRetail", "HomeStudentRetail", "HomeBusinessRetail", "O365ProPlusRetail", "O365HomePremRetail", "O365BusinessRetail", "O365SmallBusPremRetail", "VisioProRetail", "ProjectProRetail", "SPDRetail"})
        Me.edition_list.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.edition_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.edition_list.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.edition_list.FormattingEnabled = True
        Me.edition_list.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.edition_list.Location = New System.Drawing.Point(19, 17)
        Me.edition_list.Name = "edition_list"
        Me.edition_list.Size = New System.Drawing.Size(244, 24)
        Me.edition_list.TabIndex = 9
        '
        'RadioButton_64bit
        '
        Me.RadioButton_64bit.AutoSize = True
        Me.RadioButton_64bit.Checked = True
        Me.RadioButton_64bit.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton_64bit.Location = New System.Drawing.Point(391, 21)
        Me.RadioButton_64bit.Name = "RadioButton_64bit"
        Me.RadioButton_64bit.Size = New System.Drawing.Size(98, 20)
        Me.RadioButton_64bit.TabIndex = 8
        Me.RadioButton_64bit.TabStop = True
        Me.RadioButton_64bit.Text = "64bit Edition"
        Me.RadioButton_64bit.UseVisualStyleBackColor = True
        '
        'RadioButton_32bit
        '
        Me.RadioButton_32bit.AutoSize = True
        Me.RadioButton_32bit.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton_32bit.Location = New System.Drawing.Point(287, 21)
        Me.RadioButton_32bit.Name = "RadioButton_32bit"
        Me.RadioButton_32bit.Size = New System.Drawing.Size(98, 20)
        Me.RadioButton_32bit.TabIndex = 7
        Me.RadioButton_32bit.Text = "32bit Edition"
        Me.RadioButton_32bit.UseVisualStyleBackColor = True
        '
        'lang_ctl_group
        '
        Me.lang_ctl_group.Controls.Add(Me.matchOSCheck)
        Me.lang_ctl_group.Controls.Add(Me.lang_list)
        Me.lang_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lang_ctl_group.Location = New System.Drawing.Point(12, 257)
        Me.lang_ctl_group.Name = "lang_ctl_group"
        Me.lang_ctl_group.Size = New System.Drawing.Size(541, 54)
        Me.lang_ctl_group.TabIndex = 10
        Me.lang_ctl_group.TabStop = False
        Me.lang_ctl_group.Text = "Install Language"
        '
        'matchOSCheck
        '
        Me.matchOSCheck.AutoSize = True
        Me.matchOSCheck.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.matchOSCheck.Location = New System.Drawing.Point(342, 21)
        Me.matchOSCheck.Name = "matchOSCheck"
        Me.matchOSCheck.Size = New System.Drawing.Size(80, 20)
        Me.matchOSCheck.TabIndex = 10
        Me.matchOSCheck.Text = "MatchOS"
        Me.matchOSCheck.UseVisualStyleBackColor = True
        '
        'lang_list
        '
        Me.lang_list.AutoCompleteCustomSource.AddRange(New String() {"ProPlusRetail", "ProfessionalRetail", "HomeStudentRetail", "HomeBusinessRetail", "O365ProPlusRetail", "O365HomePremRetail", "O365BusinessRetail", "O365SmallBusPremRetail", "VisioProRetail", "ProjectProRetail", "SPDRetail"})
        Me.lang_list.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lang_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lang_list.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lang_list.FormattingEnabled = True
        Me.lang_list.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.lang_list.Location = New System.Drawing.Point(19, 19)
        Me.lang_list.Name = "lang_list"
        Me.lang_list.Size = New System.Drawing.Size(281, 24)
        Me.lang_list.TabIndex = 9
        '
        'exe_ctl_group
        '
        Me.exe_ctl_group.Controls.Add(Me.exe_path_reset)
        Me.exe_ctl_group.Controls.Add(Me.exe_path_label)
        Me.exe_ctl_group.Controls.Add(Me.exe_path_sel)
        Me.exe_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.exe_ctl_group.Location = New System.Drawing.Point(12, 10)
        Me.exe_ctl_group.Name = "exe_ctl_group"
        Me.exe_ctl_group.Size = New System.Drawing.Size(541, 54)
        Me.exe_ctl_group.TabIndex = 11
        Me.exe_ctl_group.TabStop = False
        Me.exe_ctl_group.Text = "Setup.exe Location (Required For Install)"
        '
        'exe_path_reset
        '
        Me.exe_path_reset.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.exe_path_reset.Location = New System.Drawing.Point(457, 19)
        Me.exe_path_reset.Name = "exe_path_reset"
        Me.exe_path_reset.Size = New System.Drawing.Size(75, 23)
        Me.exe_path_reset.TabIndex = 13
        Me.exe_path_reset.Text = "Reset"
        Me.exe_path_reset.UseVisualStyleBackColor = True
        '
        'exe_path_label
        '
        Me.exe_path_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exe_path_label.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.exe_path_label.Location = New System.Drawing.Point(100, 22)
        Me.exe_path_label.Name = "exe_path_label"
        Me.exe_path_label.Size = New System.Drawing.Size(351, 20)
        Me.exe_path_label.TabIndex = 12
        Me.exe_path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'exe_path_sel
        '
        Me.exe_path_sel.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.exe_path_sel.Location = New System.Drawing.Point(19, 19)
        Me.exe_path_sel.Name = "exe_path_sel"
        Me.exe_path_sel.Size = New System.Drawing.Size(75, 23)
        Me.exe_path_sel.TabIndex = 11
        Me.exe_path_sel.Text = "Select"
        Me.exe_path_sel.UseVisualStyleBackColor = True
        '
        'filefinder_1
        '
        Me.filefinder_1.DefaultExt = "exe"
        Me.filefinder_1.Filter = "Setup.exe|setup.exe"
        '
        'cpomnt_ctl_group
        '
        Me.cpomnt_ctl_group.Controls.Add(Me.product_clean)
        Me.cpomnt_ctl_group.Controls.Add(Me.product_all)
        Me.cpomnt_ctl_group.Controls.Add(Me.porduct10)
        Me.cpomnt_ctl_group.Controls.Add(Me.porduct9)
        Me.cpomnt_ctl_group.Controls.Add(Me.product8)
        Me.cpomnt_ctl_group.Controls.Add(Me.product7)
        Me.cpomnt_ctl_group.Controls.Add(Me.product12)
        Me.cpomnt_ctl_group.Controls.Add(Me.product11)
        Me.cpomnt_ctl_group.Controls.Add(Me.product5)
        Me.cpomnt_ctl_group.Controls.Add(Me.product1)
        Me.cpomnt_ctl_group.Controls.Add(Me.product4)
        Me.cpomnt_ctl_group.Controls.Add(Me.product3)
        Me.cpomnt_ctl_group.Controls.Add(Me.product2)
        Me.cpomnt_ctl_group.Controls.Add(Me.product6)
        Me.cpomnt_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cpomnt_ctl_group.Location = New System.Drawing.Point(12, 317)
        Me.cpomnt_ctl_group.Name = "cpomnt_ctl_group"
        Me.cpomnt_ctl_group.Size = New System.Drawing.Size(541, 122)
        Me.cpomnt_ctl_group.TabIndex = 12
        Me.cpomnt_ctl_group.TabStop = False
        Me.cpomnt_ctl_group.Text = "Install Components"
        '
        'product_clean
        '
        Me.product_clean.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product_clean.Location = New System.Drawing.Point(457, 87)
        Me.product_clean.Name = "product_clean"
        Me.product_clean.Size = New System.Drawing.Size(75, 23)
        Me.product_clean.TabIndex = 13
        Me.product_clean.Text = "Deselect All"
        Me.product_clean.UseVisualStyleBackColor = True
        '
        'product_all
        '
        Me.product_all.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product_all.Location = New System.Drawing.Point(362, 87)
        Me.product_all.Name = "product_all"
        Me.product_all.Size = New System.Drawing.Size(75, 23)
        Me.product_all.TabIndex = 12
        Me.product_all.Text = "Select All"
        Me.product_all.UseVisualStyleBackColor = True
        '
        'porduct10
        '
        Me.porduct10.AutoSize = True
        Me.porduct10.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.porduct10.Location = New System.Drawing.Point(207, 65)
        Me.porduct10.Name = "porduct10"
        Me.porduct10.Size = New System.Drawing.Size(54, 20)
        Me.porduct10.TabIndex = 11
        Me.porduct10.Text = "Visio"
        Me.porduct10.UseVisualStyleBackColor = True
        '
        'porduct9
        '
        Me.porduct9.AutoSize = True
        Me.porduct9.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.porduct9.Location = New System.Drawing.Point(207, 43)
        Me.porduct9.Name = "porduct9"
        Me.porduct9.Size = New System.Drawing.Size(138, 20)
        Me.porduct9.TabIndex = 10
        Me.porduct9.Text = "SharePointDesigner"
        Me.porduct9.UseVisualStyleBackColor = True
        '
        'product8
        '
        Me.product8.AutoSize = True
        Me.product8.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product8.Location = New System.Drawing.Point(207, 21)
        Me.product8.Name = "product8"
        Me.product8.Size = New System.Drawing.Size(66, 20)
        Me.product8.TabIndex = 9
        Me.product8.Text = "Project"
        Me.product8.UseVisualStyleBackColor = True
        '
        'product7
        '
        Me.product7.AutoSize = True
        Me.product7.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product7.Location = New System.Drawing.Point(121, 87)
        Me.product7.Name = "product7"
        Me.product7.Size = New System.Drawing.Size(74, 20)
        Me.product7.TabIndex = 8
        Me.product7.Text = "InfoPath"
        Me.product7.UseVisualStyleBackColor = True
        '
        'product12
        '
        Me.product12.AutoSize = True
        Me.product12.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product12.Location = New System.Drawing.Point(380, 43)
        Me.product12.Name = "product12"
        Me.product12.Size = New System.Drawing.Size(52, 20)
        Me.product12.TabIndex = 7
        Me.product12.Text = "Lync"
        Me.product12.UseVisualStyleBackColor = True
        '
        'product11
        '
        Me.product11.AutoSize = True
        Me.product11.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product11.Location = New System.Drawing.Point(380, 21)
        Me.product11.Name = "product11"
        Me.product11.Size = New System.Drawing.Size(130, 20)
        Me.product11.TabIndex = 6
        Me.product11.Text = "OneDrive(Groove)"
        Me.product11.UseVisualStyleBackColor = True
        '
        'product5
        '
        Me.product5.AutoSize = True
        Me.product5.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product5.Location = New System.Drawing.Point(121, 43)
        Me.product5.Name = "product5"
        Me.product5.Size = New System.Drawing.Size(73, 20)
        Me.product5.TabIndex = 5
        Me.product5.Text = "Outlook"
        Me.product5.UseVisualStyleBackColor = True
        '
        'product1
        '
        Me.product1.AutoSize = True
        Me.product1.Checked = True
        Me.product1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.product1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product1.Location = New System.Drawing.Point(19, 21)
        Me.product1.Name = "product1"
        Me.product1.Size = New System.Drawing.Size(59, 20)
        Me.product1.TabIndex = 4
        Me.product1.Text = "Word"
        Me.product1.UseVisualStyleBackColor = True
        '
        'product4
        '
        Me.product4.AutoSize = True
        Me.product4.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product4.Location = New System.Drawing.Point(121, 21)
        Me.product4.Name = "product4"
        Me.product4.Size = New System.Drawing.Size(78, 20)
        Me.product4.TabIndex = 3
        Me.product4.Text = "Publisher"
        Me.product4.UseVisualStyleBackColor = True
        '
        'product3
        '
        Me.product3.AutoSize = True
        Me.product3.Checked = True
        Me.product3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.product3.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product3.Location = New System.Drawing.Point(19, 65)
        Me.product3.Name = "product3"
        Me.product3.Size = New System.Drawing.Size(91, 20)
        Me.product3.TabIndex = 2
        Me.product3.Text = "PowerPoint"
        Me.product3.UseVisualStyleBackColor = True
        '
        'product2
        '
        Me.product2.AutoSize = True
        Me.product2.Checked = True
        Me.product2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.product2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product2.Location = New System.Drawing.Point(19, 43)
        Me.product2.Name = "product2"
        Me.product2.Size = New System.Drawing.Size(56, 20)
        Me.product2.TabIndex = 1
        Me.product2.Text = "Excel"
        Me.product2.UseVisualStyleBackColor = True
        '
        'product6
        '
        Me.product6.AutoSize = True
        Me.product6.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product6.Location = New System.Drawing.Point(121, 65)
        Me.product6.Name = "product6"
        Me.product6.Size = New System.Drawing.Size(64, 20)
        Me.product6.TabIndex = 0
        Me.product6.Text = "Access"
        Me.product6.UseVisualStyleBackColor = True
        '
        'cfg_ctl_group
        '
        Me.cfg_ctl_group.Controls.Add(Me.cfg_path_cln)
        Me.cfg_ctl_group.Controls.Add(Me.cfg_path_label)
        Me.cfg_ctl_group.Controls.Add(Me.cfg_path_sel)
        Me.cfg_ctl_group.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cfg_ctl_group.Location = New System.Drawing.Point(12, 445)
        Me.cfg_ctl_group.Name = "cfg_ctl_group"
        Me.cfg_ctl_group.Size = New System.Drawing.Size(541, 54)
        Me.cfg_ctl_group.TabIndex = 13
        Me.cfg_ctl_group.TabStop = False
        Me.cfg_ctl_group.Text = "Config.xml Save Path(Default to Temp Folder)"
        '
        'cfg_path_cln
        '
        Me.cfg_path_cln.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cfg_path_cln.Location = New System.Drawing.Point(457, 22)
        Me.cfg_path_cln.Name = "cfg_path_cln"
        Me.cfg_path_cln.Size = New System.Drawing.Size(75, 23)
        Me.cfg_path_cln.TabIndex = 13
        Me.cfg_path_cln.Text = "Reset"
        Me.cfg_path_cln.UseVisualStyleBackColor = True
        '
        'cfg_path_label
        '
        Me.cfg_path_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cfg_path_label.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cfg_path_label.Location = New System.Drawing.Point(100, 22)
        Me.cfg_path_label.Name = "cfg_path_label"
        Me.cfg_path_label.Size = New System.Drawing.Size(351, 20)
        Me.cfg_path_label.TabIndex = 12
        Me.cfg_path_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cfg_path_sel
        '
        Me.cfg_path_sel.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cfg_path_sel.Location = New System.Drawing.Point(19, 21)
        Me.cfg_path_sel.Name = "cfg_path_sel"
        Me.cfg_path_sel.Size = New System.Drawing.Size(75, 23)
        Me.cfg_path_sel.TabIndex = 11
        Me.cfg_path_sel.Text = "Select"
        Me.cfg_path_sel.UseVisualStyleBackColor = True
        '
        'gen_preview
        '
        Me.gen_preview.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gen_preview.ForeColor = System.Drawing.Color.Red
        Me.gen_preview.Location = New System.Drawing.Point(12, 514)
        Me.gen_preview.Name = "gen_preview"
        Me.gen_preview.Size = New System.Drawing.Size(168, 61)
        Me.gen_preview.TabIndex = 14
        Me.gen_preview.Text = "Generate Config.xml Preview"
        Me.gen_preview.UseVisualStyleBackColor = True
        '
        'save_cfg_only
        '
        Me.save_cfg_only.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.save_cfg_only.Location = New System.Drawing.Point(200, 514)
        Me.save_cfg_only.Name = "save_cfg_only"
        Me.save_cfg_only.Size = New System.Drawing.Size(168, 61)
        Me.save_cfg_only.TabIndex = 15
        Me.save_cfg_only.Text = "Save Preview Config.xml " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Path"
        Me.save_cfg_only.UseVisualStyleBackColor = True
        '
        'save_and_install
        '
        Me.save_and_install.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.save_and_install.Location = New System.Drawing.Point(374, 514)
        Me.save_and_install.Name = "save_and_install"
        Me.save_and_install.Size = New System.Drawing.Size(166, 61)
        Me.save_and_install.TabIndex = 16
        Me.save_and_install.Text = "Save Config.xml" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "And Run Setup"
        Me.save_and_install.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.Location = New System.Drawing.Point(772, 548)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(75, 23)
        Me.info.TabIndex = 17
        Me.info.Text = "Info"
        Me.info.UseVisualStyleBackColor = True
        '
        'C2R_XML_maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 583)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.save_and_install)
        Me.Controls.Add(Me.save_cfg_only)
        Me.Controls.Add(Me.gen_preview)
        Me.Controls.Add(Me.cfg_ctl_group)
        Me.Controls.Add(Me.cpomnt_ctl_group)
        Me.Controls.Add(Me.exe_ctl_group)
        Me.Controls.Add(Me.lang_ctl_group)
        Me.Controls.Add(Me.edtion_ctl_group)
        Me.Controls.Add(Me.src_ctl_group)
        Me.Controls.Add(Me.preview_group)
        Me.Name = "C2R_XML_maker"
        Me.Text = "Office 2016/365 C2R Setup config.xml Maker And Installer v"
        Me.preview_group.ResumeLayout(False)
        Me.preview_group.PerformLayout()
        Me.src_ctl_group.ResumeLayout(False)
        Me.src_ctl_group.PerformLayout()
        Me.edtion_ctl_group.ResumeLayout(False)
        Me.edtion_ctl_group.PerformLayout()
        Me.lang_ctl_group.ResumeLayout(False)
        Me.lang_ctl_group.PerformLayout()
        Me.exe_ctl_group.ResumeLayout(False)
        Me.cpomnt_ctl_group.ResumeLayout(False)
        Me.cpomnt_ctl_group.PerformLayout()
        Me.cfg_ctl_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents preview_group As GroupBox
    Friend WithEvents pathfinder_1 As FolderBrowserDialog
    Friend WithEvents src_ctl_group As GroupBox
    Friend WithEvents src_path_label As Label
    Friend WithEvents src_path_sel As Button
    Friend WithEvents src_path_reset As Button
    Friend WithEvents edtion_ctl_group As GroupBox
    Friend WithEvents edition_list As ComboBox
    Friend WithEvents RadioButton_64bit As RadioButton
    Friend WithEvents RadioButton_32bit As RadioButton
    Friend WithEvents lang_ctl_group As GroupBox
    Friend WithEvents lang_list As ComboBox
    Friend WithEvents path_hint1 As Label
    Friend WithEvents exe_ctl_group As GroupBox
    Friend WithEvents exe_path_reset As Button
    Friend WithEvents exe_path_label As Label
    Friend WithEvents exe_path_sel As Button
    Friend WithEvents filefinder_1 As OpenFileDialog
    Friend WithEvents cpomnt_ctl_group As GroupBox
    Friend WithEvents product5 As CheckBox
    Friend WithEvents product1 As CheckBox
    Friend WithEvents product4 As CheckBox
    Friend WithEvents product3 As CheckBox
    Friend WithEvents product2 As CheckBox
    Friend WithEvents product6 As CheckBox
    Friend WithEvents matchOSCheck As CheckBox
    Friend WithEvents porduct10 As CheckBox
    Friend WithEvents porduct9 As CheckBox
    Friend WithEvents product8 As CheckBox
    Friend WithEvents product7 As CheckBox
    Friend WithEvents product12 As CheckBox
    Friend WithEvents product11 As CheckBox
    Friend WithEvents product_clean As Button
    Friend WithEvents product_all As Button
    Friend WithEvents cfg_ctl_group As GroupBox
    Friend WithEvents cfg_path_cln As Button
    Friend WithEvents cfg_path_label As Label
    Friend WithEvents cfg_path_sel As Button
    Friend WithEvents gen_preview As Button
    Friend WithEvents save_cfg_only As Button
    Friend WithEvents save_and_install As Button
    Friend WithEvents preview_text As TextBox
    Friend WithEvents info As Button
End Class

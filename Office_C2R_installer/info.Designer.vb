<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.github_link = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.info_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'github_link
        '
        Me.github_link.AutoSize = True
        Me.github_link.Location = New System.Drawing.Point(40, 176)
        Me.github_link.Name = "github_link"
        Me.github_link.Size = New System.Drawing.Size(56, 12)
        Me.github_link.TabIndex = 0
        Me.github_link.TabStop = True
        Me.github_link.Text = "github link"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(40, 213)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(211, 12)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Office Dployment Tool for Office 2016/365"
        '
        'info_label
        '
        Me.info_label.Location = New System.Drawing.Point(40, 13)
        Me.info_label.Name = "info_label"
        Me.info_label.Size = New System.Drawing.Size(349, 188)
        Me.info_label.TabIndex = 2
        '
        'info_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 261)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.github_link)
        Me.Controls.Add(Me.info_label)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "info_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office 2016/365 C2R Setup config.xml Maker And Installer v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents github_link As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents info_label As Label
End Class

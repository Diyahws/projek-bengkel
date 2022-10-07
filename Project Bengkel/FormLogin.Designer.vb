<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txboxPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.txboxUser = New System.Windows.Forms.TextBox()
        Me.labelpss = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLogin.Controls.Add(Me.CheckBox1)
        Me.PanelLogin.Controls.Add(Me.txboxPass)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.btnMasuk)
        Me.PanelLogin.Controls.Add(Me.txboxUser)
        Me.PanelLogin.Controls.Add(Me.labelpss)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Location = New System.Drawing.Point(228, 85)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(365, 270)
        Me.PanelLogin.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(176, 155)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txboxPass
        '
        Me.txboxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxPass.Location = New System.Drawing.Point(150, 129)
        Me.txboxPass.Name = "txboxPass"
        Me.txboxPass.Size = New System.Drawing.Size(150, 20)
        Me.txboxPass.TabIndex = 2
        Me.txboxPass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(147, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LOGIN"
        '
        'btnMasuk
        '
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Location = New System.Drawing.Point(140, 190)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(88, 28)
        Me.btnMasuk.TabIndex = 3
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = True
        '
        'txboxUser
        '
        Me.txboxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxUser.Location = New System.Drawing.Point(150, 97)
        Me.txboxUser.Name = "txboxUser"
        Me.txboxUser.Size = New System.Drawing.Size(150, 20)
        Me.txboxUser.TabIndex = 1
        '
        'labelpss
        '
        Me.labelpss.AutoSize = True
        Me.labelpss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelpss.Location = New System.Drawing.Point(69, 131)
        Me.labelpss.Name = "labelpss"
        Me.labelpss.Size = New System.Drawing.Size(53, 13)
        Me.labelpss.TabIndex = 1
        Me.labelpss.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(69, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Kode"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(814, 493)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents txboxUser As TextBox
    Friend WithEvents labelpss As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txboxPass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class

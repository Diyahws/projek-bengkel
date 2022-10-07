<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuUtama = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPart = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJasa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMontir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsslblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblUser0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblNama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblNama0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblTgl0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblJam0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelStatus.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.PeachPuff
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUtama, Me.menuUser, Me.menuPart, Me.menuJasa, Me.menuMontir, Me.menuTransaksi, Me.menuLogin, Me.menuKeluar})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(210, 690)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'menuUtama
        '
        Me.menuUtama.Name = "menuUtama"
        Me.menuUtama.Size = New System.Drawing.Size(193, 32)
        Me.menuUtama.Text = "Menu Utama"
        '
        'menuUser
        '
        Me.menuUser.Name = "menuUser"
        Me.menuUser.Size = New System.Drawing.Size(193, 32)
        Me.menuUser.Text = "Master User"
        '
        'menuPart
        '
        Me.menuPart.Name = "menuPart"
        Me.menuPart.Size = New System.Drawing.Size(193, 32)
        Me.menuPart.Text = "Master Sparepart"
        '
        'menuJasa
        '
        Me.menuJasa.Name = "menuJasa"
        Me.menuJasa.Size = New System.Drawing.Size(193, 32)
        Me.menuJasa.Text = "Master Jasa Service"
        '
        'menuMontir
        '
        Me.menuMontir.Name = "menuMontir"
        Me.menuMontir.Size = New System.Drawing.Size(193, 32)
        Me.menuMontir.Text = "Master Montir"
        '
        'menuTransaksi
        '
        Me.menuTransaksi.Name = "menuTransaksi"
        Me.menuTransaksi.Size = New System.Drawing.Size(193, 32)
        Me.menuTransaksi.Text = "Transaksi"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(193, 32)
        Me.menuLogin.Text = "Login"
        '
        'menuKeluar
        '
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(193, 32)
        Me.menuKeluar.Text = "Keluar"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.PeachPuff
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblUser, Me.tsslblUser0, Me.tsslblNama, Me.tsslblNama0, Me.tsslblTgl, Me.tsslblTgl0, Me.tsslblJam, Me.tsslblJam0})
        Me.StatusStrip.Location = New System.Drawing.Point(210, 664)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1102, 26)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tsslblUser
        '
        Me.tsslblUser.Name = "tsslblUser"
        Me.tsslblUser.Size = New System.Drawing.Size(39, 20)
        Me.tsslblUser.Text = "user:"
        '
        'tsslblUser0
        '
        Me.tsslblUser0.Name = "tsslblUser0"
        Me.tsslblUser0.Size = New System.Drawing.Size(0, 20)
        '
        'tsslblNama
        '
        Me.tsslblNama.Name = "tsslblNama"
        Me.tsslblNama.Size = New System.Drawing.Size(49, 20)
        Me.tsslblNama.Text = "nama:"
        '
        'tsslblNama0
        '
        Me.tsslblNama0.Name = "tsslblNama0"
        Me.tsslblNama0.Size = New System.Drawing.Size(0, 20)
        '
        'tsslblTgl
        '
        Me.tsslblTgl.Name = "tsslblTgl"
        Me.tsslblTgl.Size = New System.Drawing.Size(63, 20)
        Me.tsslblTgl.Text = "tanggal:"
        '
        'tsslblTgl0
        '
        Me.tsslblTgl0.Name = "tsslblTgl0"
        Me.tsslblTgl0.Size = New System.Drawing.Size(0, 20)
        '
        'tsslblJam
        '
        Me.tsslblJam.Name = "tsslblJam"
        Me.tsslblJam.Size = New System.Drawing.Size(37, 20)
        Me.tsslblJam.Text = "jam:"
        '
        'tsslblJam0
        '
        Me.tsslblJam0.Name = "tsslblJam0"
        Me.tsslblJam0.Size = New System.Drawing.Size(0, 20)
        '
        'PanelStatus
        '
        Me.PanelStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.PanelStatus.Controls.Add(Me.lblStatus)
        Me.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelStatus.Location = New System.Drawing.Point(210, 0)
        Me.PanelStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(1102, 57)
        Me.PanelStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(25, 17)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(134, 25)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Menu Utama"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(210, 57)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1102, 607)
        Me.PanelDesktop.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Project_Bengkel.My.Resources.Resources.kindpng_34621
        Me.PictureBox1.Location = New System.Drawing.Point(193, 188)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(745, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1312, 690)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelStatus)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUtama"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents menuUtama As ToolStripMenuItem
    Friend WithEvents menuUser As ToolStripMenuItem
    Friend WithEvents menuPart As ToolStripMenuItem
    Friend WithEvents menuJasa As ToolStripMenuItem
    Friend WithEvents menuMontir As ToolStripMenuItem
    Friend WithEvents menuTransaksi As ToolStripMenuItem
    Friend WithEvents menuLogin As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents tsslblUser As ToolStripStatusLabel
    Friend WithEvents tsslblUser0 As ToolStripStatusLabel
    Friend WithEvents tsslblNama As ToolStripStatusLabel
    Friend WithEvents tsslblNama0 As ToolStripStatusLabel
    Friend WithEvents tsslblTgl As ToolStripStatusLabel
    Friend WithEvents tsslblTgl0 As ToolStripStatusLabel
    Friend WithEvents tsslblJam As ToolStripStatusLabel
    Friend WithEvents tsslblJam0 As ToolStripStatusLabel
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuKeluar As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSparepart
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
        Me.dgvPart = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txboxNmPart = New System.Windows.Forms.TextBox()
        Me.txboxKdPart = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txboxCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txboxStokPart = New System.Windows.Forms.TextBox()
        Me.txboxHargaPart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInputJasa = New System.Windows.Forms.Button()
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPart
        '
        Me.dgvPart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPart.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPart.Location = New System.Drawing.Point(505, 183)
        Me.dgvPart.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPart.Name = "dgvPart"
        Me.dgvPart.RowHeadersWidth = 51
        Me.dgvPart.Size = New System.Drawing.Size(553, 348)
        Me.dgvPart.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(383, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MASTER SPAREPART"
        '
        'txboxNmPart
        '
        Me.txboxNmPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxNmPart.Location = New System.Drawing.Point(201, 110)
        Me.txboxNmPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxNmPart.Name = "txboxNmPart"
        Me.txboxNmPart.Size = New System.Drawing.Size(199, 22)
        Me.txboxNmPart.TabIndex = 10
        '
        'txboxKdPart
        '
        Me.txboxKdPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxKdPart.Location = New System.Drawing.Point(201, 71)
        Me.txboxKdPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxKdPart.Name = "txboxKdPart"
        Me.txboxKdPart.Size = New System.Drawing.Size(199, 22)
        Me.txboxKdPart.TabIndex = 9
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label.Location = New System.Drawing.Point(67, 112)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(107, 16)
        Me.Label.TabIndex = 8
        Me.Label.Text = "Nama Sparepart"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(67, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kode Sparepart"
        '
        'txboxCari
        '
        Me.txboxCari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxCari.Location = New System.Drawing.Point(820, 117)
        Me.txboxCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxCari.Name = "txboxCari"
        Me.txboxCari.Size = New System.Drawing.Size(238, 22)
        Me.txboxCari.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(739, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pencarian"
        '
        'txboxStokPart
        '
        Me.txboxStokPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxStokPart.Location = New System.Drawing.Point(201, 186)
        Me.txboxStokPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxStokPart.Name = "txboxStokPart"
        Me.txboxStokPart.Size = New System.Drawing.Size(199, 22)
        Me.txboxStokPart.TabIndex = 16
        '
        'txboxHargaPart
        '
        Me.txboxHargaPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxHargaPart.Location = New System.Drawing.Point(201, 148)
        Me.txboxHargaPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxHargaPart.Name = "txboxHargaPart"
        Me.txboxHargaPart.Size = New System.Drawing.Size(199, 22)
        Me.txboxHargaPart.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(67, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stok Sparepart"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(67, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga Sparepart"
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(24, 267)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 28)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(132, 267)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 28)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(240, 267)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 19
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(348, 267)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.txboxKdPart)
        Me.Panel1.Controls.Add(Me.txboxStokPart)
        Me.Panel1.Controls.Add(Me.txboxNmPart)
        Me.Panel1.Controls.Add(Me.txboxHargaPart)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(27, 183)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 348)
        Me.Panel1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(172, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Input Data"
        '
        'btnInputJasa
        '
        Me.btnInputJasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInputJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputJasa.Location = New System.Drawing.Point(958, 147)
        Me.btnInputJasa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInputJasa.Name = "btnInputJasa"
        Me.btnInputJasa.Size = New System.Drawing.Size(100, 28)
        Me.btnInputJasa.TabIndex = 58
        Me.btnInputJasa.Text = "Input"
        Me.btnInputJasa.UseVisualStyleBackColor = True
        '
        'FormSparepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1085, 607)
        Me.Controls.Add(Me.btnInputJasa)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txboxCari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvPart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSparepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSparepart"
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPart As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txboxNmPart As TextBox
    Friend WithEvents txboxKdPart As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txboxCari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txboxStokPart As TextBox
    Friend WithEvents txboxHargaPart As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnInputJasa As Button
End Class

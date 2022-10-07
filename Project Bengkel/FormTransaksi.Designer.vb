<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.txboxUser = New System.Windows.Forms.TextBox()
        Me.txboxKdTransaksi = New System.Windows.Forms.TextBox()
        Me.txboxTanggal = New System.Windows.Forms.TextBox()
        Me.txboxJam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.txboxHargaJasa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmboxJasa = New System.Windows.Forms.ComboBox()
        Me.cmboxMontir = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txboxTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txboxJumlah = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txboxKembali = New System.Windows.Forms.TextBox()
        Me.txboxDibayar = New System.Windows.Forms.TextBox()
        Me.txboxHargaPart = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txboxStokPart = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txboxJmlItem = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmboxPart = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnInputPart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txboxNopol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txboxNmPelanggan = New System.Windows.Forms.TextBox()
        Me.txboxKendaraan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnInputJasa = New System.Windows.Forms.Button()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "TRANSAKSI"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(459, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "User"
        '
        'Label
        '
        Me.Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label.AutoSize = True
        Me.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label.Location = New System.Drawing.Point(303, 231)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(58, 16)
        Me.Label.TabIndex = 30
        Me.Label.Text = "Tanggal"
        '
        'txboxUser
        '
        Me.txboxUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxUser.Enabled = False
        Me.txboxUser.Location = New System.Drawing.Point(459, 251)
        Me.txboxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxUser.Name = "txboxUser"
        Me.txboxUser.Size = New System.Drawing.Size(137, 22)
        Me.txboxUser.TabIndex = 31
        '
        'txboxKdTransaksi
        '
        Me.txboxKdTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxKdTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxKdTransaksi.Enabled = False
        Me.txboxKdTransaksi.Location = New System.Drawing.Point(40, 251)
        Me.txboxKdTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxKdTransaksi.Name = "txboxKdTransaksi"
        Me.txboxKdTransaksi.Size = New System.Drawing.Size(114, 22)
        Me.txboxKdTransaksi.TabIndex = 36
        '
        'txboxTanggal
        '
        Me.txboxTanggal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxTanggal.Enabled = False
        Me.txboxTanggal.Location = New System.Drawing.Point(307, 251)
        Me.txboxTanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxTanggal.Name = "txboxTanggal"
        Me.txboxTanggal.Size = New System.Drawing.Size(143, 22)
        Me.txboxTanggal.TabIndex = 32
        '
        'txboxJam
        '
        Me.txboxJam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxJam.Enabled = False
        Me.txboxJam.Location = New System.Drawing.Point(163, 251)
        Me.txboxJam.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxJam.Name = "txboxJam"
        Me.txboxJam.Size = New System.Drawing.Size(135, 22)
        Me.txboxJam.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(159, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Jam"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(36, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Kode Transaksi"
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvTransaksi.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(16, 287)
        Me.dgvTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.RowHeadersWidth = 51
        Me.dgvTransaksi.Size = New System.Drawing.Size(1053, 212)
        Me.dgvTransaksi.TabIndex = 37
        '
        'txboxHargaJasa
        '
        Me.txboxHargaJasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxHargaJasa.Enabled = False
        Me.txboxHargaJasa.Location = New System.Drawing.Point(347, 37)
        Me.txboxHargaJasa.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxHargaJasa.Name = "txboxHargaJasa"
        Me.txboxHargaJasa.Size = New System.Drawing.Size(183, 22)
        Me.txboxHargaJasa.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(343, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Harga Service"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(4, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Nama Montir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(173, 17)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Jenis Service"
        '
        'cmboxJasa
        '
        Me.cmboxJasa.FormattingEnabled = True
        Me.cmboxJasa.Location = New System.Drawing.Point(177, 37)
        Me.cmboxJasa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxJasa.Name = "cmboxJasa"
        Me.cmboxJasa.Size = New System.Drawing.Size(160, 24)
        Me.cmboxJasa.TabIndex = 39
        '
        'cmboxMontir
        '
        Me.cmboxMontir.FormattingEnabled = True
        Me.cmboxMontir.Location = New System.Drawing.Point(8, 37)
        Me.cmboxMontir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxMontir.Name = "cmboxMontir"
        Me.cmboxMontir.Size = New System.Drawing.Size(160, 24)
        Me.cmboxMontir.TabIndex = 40
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(148, 517)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 41
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(256, 517)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 42
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(40, 517)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 28)
        Me.btnSimpan.TabIndex = 40
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(843, 551)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Kembali"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(843, 522)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Dibayar"
        '
        'txboxTotal
        '
        Me.txboxTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxTotal.Enabled = False
        Me.txboxTotal.Location = New System.Drawing.Point(675, 549)
        Me.txboxTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxTotal.Name = "txboxTotal"
        Me.txboxTotal.Size = New System.Drawing.Size(159, 22)
        Me.txboxTotal.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Location = New System.Drawing.Point(613, 551)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Total"
        '
        'txboxJumlah
        '
        Me.txboxJumlah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxJumlah.Enabled = False
        Me.txboxJumlah.Location = New System.Drawing.Point(675, 517)
        Me.txboxJumlah.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxJumlah.Name = "txboxJumlah"
        Me.txboxJumlah.Size = New System.Drawing.Size(159, 22)
        Me.txboxJumlah.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Location = New System.Drawing.Point(613, 519)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Jumlah"
        '
        'txboxKembali
        '
        Me.txboxKembali.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxKembali.Enabled = False
        Me.txboxKembali.Location = New System.Drawing.Point(909, 549)
        Me.txboxKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxKembali.Name = "txboxKembali"
        Me.txboxKembali.Size = New System.Drawing.Size(159, 22)
        Me.txboxKembali.TabIndex = 49
        '
        'txboxDibayar
        '
        Me.txboxDibayar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboxDibayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxDibayar.Location = New System.Drawing.Point(909, 517)
        Me.txboxDibayar.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxDibayar.Name = "txboxDibayar"
        Me.txboxDibayar.Size = New System.Drawing.Size(159, 22)
        Me.txboxDibayar.TabIndex = 50
        '
        'txboxHargaPart
        '
        Me.txboxHargaPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxHargaPart.Enabled = False
        Me.txboxHargaPart.Location = New System.Drawing.Point(136, 68)
        Me.txboxHargaPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxHargaPart.Name = "txboxHargaPart"
        Me.txboxHargaPart.Size = New System.Drawing.Size(159, 22)
        Me.txboxHargaPart.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Location = New System.Drawing.Point(14, 71)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Harga Sparepart"
        '
        'txboxStokPart
        '
        Me.txboxStokPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxStokPart.Enabled = False
        Me.txboxStokPart.Location = New System.Drawing.Point(136, 107)
        Me.txboxStokPart.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxStokPart.Name = "txboxStokPart"
        Me.txboxStokPart.Size = New System.Drawing.Size(159, 22)
        Me.txboxStokPart.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Location = New System.Drawing.Point(14, 109)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Stok Sparepart"
        '
        'txboxJmlItem
        '
        Me.txboxJmlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxJmlItem.Location = New System.Drawing.Point(136, 145)
        Me.txboxJmlItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxJmlItem.Name = "txboxJmlItem"
        Me.txboxJmlItem.Size = New System.Drawing.Size(159, 22)
        Me.txboxJmlItem.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Location = New System.Drawing.Point(14, 147)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Jumlah Item"
        '
        'cmboxPart
        '
        Me.cmboxPart.FormattingEnabled = True
        Me.cmboxPart.Location = New System.Drawing.Point(136, 29)
        Me.cmboxPart.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxPart.Name = "cmboxPart"
        Me.cmboxPart.Size = New System.Drawing.Size(159, 24)
        Me.cmboxPart.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Location = New System.Drawing.Point(14, 33)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 16)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Nama Sparepart"
        '
        'btnCari
        '
        Me.btnCari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Location = New System.Drawing.Point(297, 28)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 26)
        Me.btnCari.TabIndex = 51
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnInputPart
        '
        Me.btnInputPart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInputPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputPart.Location = New System.Drawing.Point(113, 183)
        Me.btnInputPart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInputPart.Name = "btnInputPart"
        Me.btnInputPart.Size = New System.Drawing.Size(100, 28)
        Me.btnInputPart.TabIndex = 51
        Me.btnInputPart.Text = "Input"
        Me.btnInputPart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.btnInputJasa)
        Me.GroupBox1.Controls.Add(Me.cmboxMontir)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmboxJasa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txboxHargaJasa)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 145)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(660, 74)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txboxNopol)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txboxNmPelanggan)
        Me.GroupBox2.Controls.Add(Me.txboxKendaraan)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 69)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(585, 74)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'txboxNopol
        '
        Me.txboxNopol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxNopol.Location = New System.Drawing.Point(392, 39)
        Me.txboxNopol.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxNopol.Name = "txboxNopol"
        Me.txboxNopol.Size = New System.Drawing.Size(183, 22)
        Me.txboxNopol.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(388, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Nopol Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(196, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Kendaraan Pelanggan"
        '
        'txboxNmPelanggan
        '
        Me.txboxNmPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxNmPelanggan.Location = New System.Drawing.Point(8, 39)
        Me.txboxNmPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxNmPelanggan.Name = "txboxNmPelanggan"
        Me.txboxNmPelanggan.Size = New System.Drawing.Size(183, 22)
        Me.txboxNmPelanggan.TabIndex = 54
        '
        'txboxKendaraan
        '
        Me.txboxKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txboxKendaraan.Location = New System.Drawing.Point(200, 39)
        Me.txboxKendaraan.Margin = New System.Windows.Forms.Padding(4)
        Me.txboxKendaraan.Name = "txboxKendaraan"
        Me.txboxKendaraan.Size = New System.Drawing.Size(183, 22)
        Me.txboxKendaraan.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(4, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nama Pelanggan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txboxJmlItem)
        Me.GroupBox3.Controls.Add(Me.btnInputPart)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btnCari)
        Me.GroupBox3.Controls.Add(Me.txboxHargaPart)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cmboxPart)
        Me.GroupBox3.Controls.Add(Me.txboxStokPart)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(700, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(380, 219)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Sparepart"
        '
        'Timer1
        '
        '
        'btnInputJasa
        '
        Me.btnInputJasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInputJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputJasa.Location = New System.Drawing.Point(538, 33)
        Me.btnInputJasa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInputJasa.Name = "btnInputJasa"
        Me.btnInputJasa.Size = New System.Drawing.Size(100, 28)
        Me.btnInputJasa.TabIndex = 57
        Me.btnInputJasa.Text = "Input"
        Me.btnInputJasa.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1085, 607)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txboxDibayar)
        Me.Controls.Add(Me.txboxKembali)
        Me.Controls.Add(Me.txboxJumlah)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txboxTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txboxUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.txboxKdTransaksi)
        Me.Controls.Add(Me.txboxTanggal)
        Me.Controls.Add(Me.txboxJam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label As Label
    Friend WithEvents txboxUser As TextBox
    Friend WithEvents txboxKdTransaksi As TextBox
    Friend WithEvents txboxTanggal As TextBox
    Friend WithEvents txboxJam As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents txboxHargaJasa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmboxMontir As ComboBox
    Friend WithEvents cmboxJasa As ComboBox
    Friend WithEvents btnInputPart As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents cmboxPart As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txboxJmlItem As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txboxStokPart As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txboxHargaPart As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txboxTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txboxJumlah As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txboxKembali As TextBox
    Friend WithEvents txboxDibayar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txboxNopol As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txboxNmPelanggan As TextBox
    Friend WithEvents txboxKendaraan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnInputJasa As Button
End Class

Public Class FormTransaksi
    Sub kolomSparepart()
        dgvTransaksi.Columns.Clear()
        dgvTransaksi.Columns.Add("namaPart", "Nama Sparepart")
        dgvTransaksi.Columns.Add("hargaPart", "Harga Sparepart")
        dgvTransaksi.Columns.Add("jumlahJual", "Jumlah")
        dgvTransaksi.Columns.Add("totalJual", "Sub Total")
    End Sub

    Sub autokode_transaksi()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM transaksi WHERE kodeTransaksi IN (SELECT MAX(kodeTransaksi)
                                                                FROM transaksi) ORDER BY kodeTransaksi DESC", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "TS-" + "001"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            str = "TS-" + Microsoft.VisualBasic.Right("000" & lng, 3)
        End If
        txboxKdTransaksi.Text = str
    End Sub

    Sub datacb_montir()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM montir", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cmboxMontir.Items.Add(dr.Item(1))
        Loop

        cmboxMontir.Text = ""
    End Sub

    Sub datacb_jasa()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM service", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cmboxJasa.Items.Add(dr.Item(1))
        Loop

        cmboxJasa.Text = ""
    End Sub

    Sub datacb_part()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM sparepart", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            cmboxPart.Items.Add(dr.Item(1))
        Loop

        cmboxPart.Text = ""
    End Sub

    Sub rumus_total()
        total = 0
        For i = 0 To dgvTransaksi.Rows.Count - 1
            total = total + dgvTransaksi.Rows(i).Cells(3).Value
            txboxTotal.Text = total
        Next
    End Sub

    Sub rumus_jumlah()
        jumlah = 0
        For i = 0 To dgvTransaksi.Rows.Count - 1
            jumlah = jumlah + dgvTransaksi.Rows(i).Cells(2).Value
            txboxJumlah.Text = jumlah
        Next
    End Sub

    Sub rumus_kembali()
        kembali = Val(txboxDibayar.Text) - Val(txboxTotal.Text)
        txboxKembali.Text = kembali
    End Sub

    Sub clean()
        dgvTransaksi.Rows.Clear()
        txboxNmPelanggan.Text = ""
        txboxKendaraan.Text = ""
        txboxNopol.Text = ""
        cmboxMontir.Text = ""
        cmboxJasa.Text = ""
        txboxHargaJasa.Text = ""
        cmboxPart.Text = ""
        txboxHargaJasa.Text = ""
        txboxStokPart.Text = ""
        txboxJmlItem.Text = ""
        txboxJumlah.Text = ""
        txboxTotal.Text = ""
        txboxDibayar.Text = ""
        txboxKembali.Text = ""

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kolomSparepart()
        autokode_transaksi()
        datacb_montir()
        datacb_jasa()
        datacb_part()

        Timer1.Enabled = True
        txboxNmPelanggan.Select()
        txboxTanggal.Text = Today
        txboxUser.Text = FormMenuUtama.tsslblUser0.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txboxJam.Text = TimeOfDay
    End Sub

    Private Sub cmboxJasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxJasa.SelectedIndexChanged
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM service WHERE jenisJasa = '" & cmboxJasa.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            txboxHargaJasa.Text = dr!hargaJasa
        End If
    End Sub

    Private Sub cmboxPart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxPart.SelectedIndexChanged
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM sparepart WHERE namaPart = '" & cmboxPart.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            txboxHargaPart.Text = dr!hargaPart
            txboxStokPart.Text = dr!stokPart
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInputPart.Click
        If txboxJmlItem.Text = Nothing Then
            MessageBox.Show("Masukkan Jumlah Item", "Peringatan!", MessageBoxButtons.OK)
        Else
            dgvTransaksi.Rows.Add(New String() {cmboxPart.Text, txboxHargaPart.Text, txboxJmlItem.Text, Val(txboxJmlItem.Text) * Val(txboxHargaPart.Text)})
            rumus_total()
            rumus_jumlah()
            cmboxPart.Text = ""
            txboxHargaPart.Text = ""
            txboxStokPart.Text = ""
            txboxJmlItem.Text = ""
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()

        If txboxDibayar.Text < txboxTotal.Text Then
            MessageBox.Show("Pembayaran Kurang!", "Peringatan!", MessageBoxButtons.OK)
        Else
            cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO transaksi VALUES('" & txboxKdTransaksi.Text & "',
                                                                                    '" & txboxTanggal.Text = "yyyy-MM-dd" & "',
                                                                                    '" & txboxJam.Text & "',
                                                                                    '" & txboxUser.Text & "',
                                                                                    '" & txboxNmPelanggan.Text & "',
                                                                                    '" & txboxKendaraan.Text & "',
                                                                                    '" & txboxNopol.Text & "',
                                                                                    '" & cmboxMontir.ValueMember & "',
                                                                                    '" & cmboxJasa.ValueMember & "',
                                                                                    '" & cmboxPart.ValueMember & "',
                                                                                    '" & txboxJumlah.Text & "',
                                                                                    '" & txboxTotal.Text & "',
                                                                                    '" & txboxDibayar.Text & "',
                                                                                    '" & txboxKembali.Text & "')", connct)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To dgvTransaksi.Rows.Count - 1

                cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM sparepart WHERE namaPart = '" & dgvTransaksi.Rows(baris).Cells(0).Value & "'", connct)
                dr.Close()
                dr = cmd.ExecuteReader
                dr.Read()

                cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE sparepart SET stokPart = '" & dr.Item("stokPart") - dgvTransaksi.Rows(baris).Cells(3).Value & "'
                                                           WHERE namaPart = '" & dgvTransaksi.Rows(baris).Cells(0).Value & "'", connct)
                dr.Close()
                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Berhasil Disimpan", "Pemberitahuan", MessageBoxButtons.OK)
            clean()
            autokode_transaksi()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Yakin Hapus Sparepart?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            i = dgvTransaksi.CurrentCell.RowIndex
            dgvTransaksi.Rows.RemoveAt(i)
            rumus_total()
            rumus_jumlah()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FormSparepart.Show()
        FormSparepart.btnSimpan.Enabled = False
        FormSparepart.btnEdit.Enabled = False
        FormSparepart.btnHapus.Enabled = False
        FormSparepart.btnClear.Enabled = False
        FormSparepart.txboxKdPart.Enabled = False
        FormSparepart.txboxNmPart.Enabled = False
        FormSparepart.txboxStokPart.Enabled = False
        FormSparepart.txboxHargaPart.Enabled = False

        cmboxPart.Show()
    End Sub

    Private Sub txboxDibayar_TextChanged(sender As Object, e As EventArgs) Handles txboxDibayar.TextChanged
        rumus_kembali()
    End Sub

    Private Sub btnInputJasa_Click(sender As Object, e As EventArgs) Handles btnInputJasa.Click
        dgvTransaksi.Rows.Add(New String() {cmboxJasa.Text, txboxHargaJasa.Text, 1, txboxHargaJasa.Text})
        rumus_total()
        btnInputJasa.Enabled = False
        txboxHargaJasa.Enabled = False
        cmboxJasa.Enabled = False
    End Sub
End Class
'masih error di btnCari dan btnSimpan. stok belum berkurang.
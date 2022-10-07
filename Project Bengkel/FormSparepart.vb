Public Class FormSparepart

    Sub panggildata_part()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM sparepart", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvPart.DataSource = dt
            dgvPart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPart.Columns(0).HeaderText = "Kode Sparepart"
            dgvPart.Columns(1).HeaderText = "Nama Sparepart"
            dgvPart.Columns(2).HeaderText = "Harga Sparepart"
            dgvPart.Columns(3).HeaderText = "Stok Sparepart"
        Else
            dgvPart.DataSource = Nothing
        End If
    End Sub

    Sub autokode_part()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM sparepart WHERE kodePart IN (SELECT MAX(kodePart) FROM sparepart)
                                                                                              ORDER BY kodePart DESC", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "SP-" + "01"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            str = "SP-" + Microsoft.VisualBasic.Right("00" & lng, 2)
        End If
        txboxKdPart.Text = str
    End Sub

    Sub clean()
        txboxKdPart.Text = ""
        txboxNmPart.Text = ""
        txboxHargaPart.Text = ""
        txboxStokPart.Text = ""
    End Sub

    Private Sub FormSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_part()
        autokode_part()

        txboxKdPart.Select()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO sparepart VALUE ('" & txboxKdPart.Text & "',
                                                                                    '" & txboxNmPart.Text & "',
                                                                                    '" & txboxHargaPart.Text & "',
                                                                                    '" & txboxStokPart.Text & "',)", connct)
        cmd.ExecuteNonQuery()
        panggildata_part()
        clean()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE sparepart SET kodePart = '" & txboxKdPart.Text & "',
                                                                            namaPart = '" & txboxNmPart.Text & "',
                                                                            hargaPart = '" & txboxHargaPart.Text & "',
                                                                            stokPart = '" & txboxStokPart.Text & "',
                                                                      WHERE kodePart = '" & txboxKdPart.Text & "'", connct)
        cmd.ExecuteNonQuery()
        panggildata_part()
        clean()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()
        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE sparepart WHERE kodePart = '" & txboxKdPart.Text & "'", connct)
            cmd.ExecuteNonQuery()
            panggildata_part()
        End If
        clean()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub

    Private Sub txboxCari_TextChanged(sender As Object, e As EventArgs) Handles txboxCari.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM sparepart WHERE kodePart LIKE '%" & txboxCari.Text & "%' OR
                                                                                        namaPart LIKE '%" & txboxCari.Text & "%' OR
                                                                                        hargaPart LIKE '%" & txboxCari.Text & "%' OR
                                                                                        stokPart LIKE '%" & txboxCari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvPart.DataSource = dt
            dgvPart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPart.Columns(0).HeaderText = "Kode Sparepart"
            dgvPart.Columns(1).HeaderText = "Nama Sparepart"
            dgvPart.Columns(2).HeaderText = "Harga Sparepart"
            dgvPart.Columns(3).HeaderText = "Stok Sparepart"
        Else
            dgvPart.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvPart_Click(sender As Object, e As EventArgs) Handles dgvPart.Click
        i = dgvPart.CurrentRow.Index
        With dgvPart.Rows.Item(i)
            txboxKdPart.Text = .Cells(0).Value
            txboxNmPart.Text = .Cells(1).Value
            txboxHargaPart.Text = .Cells(2).Value
            txboxStokPart.Text = .Cells(3).Value
        End With
    End Sub

    Private Sub btnInputJasa_Click(sender As Object, e As EventArgs) Handles btnInputJasa.Click
        FormTransaksi.cmboxPart.Text = txboxNmPart.Text
        Me.Close()
    End Sub
End Class
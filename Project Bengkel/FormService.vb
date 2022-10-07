Public Class FormService

    Sub panggildata_jasa()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM service", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvJasa.DataSource = dt
            dgvJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvJasa.Columns(0).HeaderText = "Kode Service"
            dgvJasa.Columns(1).HeaderText = "Jenis Service"
            dgvJasa.Columns(2).HeaderText = "Harga Service"
        Else
            dgvJasa.DataSource = Nothing
        End If
    End Sub

    Sub panggildatacmbox_jenisjasa()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM service", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            'cmboxJenisJasa.Items.Add(dr.Item(0))
            cmboxJenisJasa.Items.Add(dr.Item(1))
        Loop

        cmboxJenisJasa.Text = ""
    End Sub

    Sub autokode_jasa()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM service WHERE kodeJasa IN (SELECT MAX(kodeJasa) FROM service)
                                                                                            ORDER BY kodeJasa DESC", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "JS-" + "01"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            str = "JS-" + Microsoft.VisualBasic.Right("00" & lng, 2)
        End If
        txboxKdJasa.Text = str
    End Sub

    Sub clean()
        txboxKdJasa.Text = ""
        cmboxJenisJasa.Text = ""
        txboxHargaJasa.Text = ""
    End Sub

    Private Sub FormService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_jasa()
        panggildatacmbox_jenisjasa()
        autokode_jasa()

        txboxKdJasa.Select()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO service VALUE('" & txboxKdJasa.Text & "',
                                                                                 '" & cmboxJenisJasa.Text & "',
                                                                                 '" & txboxHargaJasa.Text & "')", connct)
        cmd.ExecuteNonQuery()
        panggildata_jasa()
        clean()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE service SET kodeJasa = '" & txboxKdJasa.Text & "',
                                                                          jenisJasa = '" & cmboxJenisJasa.Text & "',
                                                                          hargaJasa = '" & txboxHargaJasa.Text & "'
                                                                    WHERE kodeJasa = '" & txboxKdJasa.Text & "'", connct)
        cmd.ExecuteNonQuery()
        panggildata_jasa()
        clean()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()
        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM service WHERE kodeJasa = '" & txboxKdJasa.Text & "'", connct)
            cmd.ExecuteNonQuery()
            panggildata_jasa()
        End If
        clean()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub

    Private Sub txboxCari_TextChanged(sender As Object, e As EventArgs) Handles txboxCari.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM service WHERE kodeJasa LIKE '%" & txboxCari.Text & "%' OR
                                                                                      jenisJasa LIKE '%" & txboxCari.Text & "%' OR
                                                                                      hargaJasa LIKE '%" & txboxCari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvJasa.DataSource = dt
            dgvJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvJasa.Columns(0).HeaderText = "Kode Service"
            dgvJasa.Columns(1).HeaderText = "Jenis Service"
            dgvJasa.Columns(2).HeaderText = "Harga Service"
        Else
            dgvJasa.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvJasa_Click(sender As Object, e As EventArgs) Handles dgvJasa.Click
        i = dgvJasa.CurrentRow.Index
        With dgvJasa.Rows.Item(i)
            txboxKdJasa.Text = .Cells(0).Value
            cmboxJenisJasa.Text = .Cells(1).Value
            txboxHargaJasa.Text = .Cells(2).Value
        End With
    End Sub
End Class
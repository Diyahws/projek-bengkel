Public Class FormMontir
    Sub panggildata_montir()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM montir", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvMontir.DataSource = dt
            dgvMontir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvMontir.Columns(0).HeaderText = "Kode Montir"
            dgvMontir.Columns(1).HeaderText = "Nama Montir"
            dgvMontir.Columns(2).HeaderText = "Alamat"
            dgvMontir.Columns(3).HeaderText = "No. HP"
        Else
            dgvMontir.DataSource = Nothing
        End If
    End Sub

    Sub autokode_montir()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM montir WHERE kodeMontir IN (SELECT MAX(kodeMontir) FROM montir) 
                                                                                             ORDER BY kodeMontir DESC", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "MK-" + "01"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
            str = "MK-" + Microsoft.VisualBasic.Right("00" & lng, 2)
        End If
        txboxKdMontir.Text = str
    End Sub

    Sub clean()
        txboxKdMontir.Text = ""
        txboxNmMontir.Text = ""
        txboxAlamat.Text = ""
        txboxNoHp.Text = ""
    End Sub
    Private Sub FormMontir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_montir()
        autokode_montir()

        txboxNoHp.MaxLength = 12
        txboxKdMontir.Select()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO montir VALUES ('" & txboxKdMontir.Text & "',
                                                                                  '" & txboxNmMontir.Text & "',
                                                                                  '" & txboxAlamat.Text & "',
                                                                                  '" & txboxNoHp.Text & "')", connct)
        cmd.ExecuteNonQuery()
        panggildata_montir()
        clean()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE montir SET kodeMontir = '" & txboxKdMontir.Text & "',
                                                                            namaMontir = '" & txboxNmMontir.Text & "',
                                                                            alamatMontir = '" & txboxAlamat.Text & "',
                                                                            noHpMontir = '" & txboxNoHp.Text & "'
                                                                      WHERE kodeMontir = '" & txboxKdMontir.Text & "'", connct)
        cmd.ExecuteNonQuery()
        panggildata_montir()
        clean()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()
        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM montir WHERE kodeMontir = '" & txboxKdMontir.Text & "'", connct)
            cmd.ExecuteNonQuery()
            panggildata_montir()
        End If
        clean()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub

    Private Sub txboxCari_TextChanged(sender As Object, e As EventArgs) Handles txboxCari.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM montir WHERE kodeMontir LIKE '%" & txboxCari.Text & "%' OR
                                                                                     namaMontir LIKE '%" & txboxCari.Text & "%' OR
                                                                                     alamatMontir LIKE '%" & txboxCari.Text & "%' OR
                                                                                     noHpMontir LIKE '%" & txboxCari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvMontir.DataSource = dt
            dgvMontir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvMontir.Columns(0).HeaderText = "Kode Montir"
            dgvMontir.Columns(1).HeaderText = "Nama Montir"
            dgvMontir.Columns(2).HeaderText = "Alamat"
            dgvMontir.Columns(3).HeaderText = "No. HP"
        Else
            dgvMontir.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvMontir_Click(sender As Object, e As EventArgs) Handles dgvMontir.Click
        i = dgvMontir.CurrentRow.Index
        With dgvMontir.Rows.Item(i)
            txboxKdMontir.Text = .Cells(0).Value
            txboxNmMontir.Text = .Cells(1).Value
            txboxAlamat.Text = .Cells(2).Value
            txboxNoHp.Text = .Cells(3).Value
        End With
    End Sub
End Class
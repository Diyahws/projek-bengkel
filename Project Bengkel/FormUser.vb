Public Class FormUser

    Sub panggildata_user()
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM user", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvUser.DataSource = dt
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvUser.Columns(0).HeaderText = "Kode User"
            dgvUser.Columns(1).HeaderText = "Nama User"
            dgvUser.Columns(2).HeaderText = "Password"
        Else
            dgvUser.DataSource = Nothing
        End If
    End Sub
    Sub autokode_user()
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM user WHERE kodeUser IN (SELECT max(kodeUser) FROM user) ORDER BY kodeUser desc", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "admin" + "1"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 1) + 1
            str = "admin" + Microsoft.VisualBasic.Right("0" & lng, 1)
        End If
        txboxKdUser.Text = str
    End Sub
    Sub clean()
        txboxKdUser.Text = ""
        txboxNmUser.Text = ""
        txboxPassword.Text = ""
    End Sub
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_user()
        autokode_user()
        txboxKdUser.MaxLength = 6
        txboxNmUser.MaxLength = 6
        txboxPassword.MaxLength = 6
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO user VALUES ('" & txboxKdUser.Text & "',
                                                                                '" & txboxNmUser.Text & "',
                                                                                '" & txboxPassword.Text & "')", connct)
        cmd.ExecuteNonQuery()
        panggildata_user()
        clean()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE user SET kodeUser = '" & txboxKdUser.Text & "',
                                                              namaUser = '" & txboxNmUser.Text & "',
                                                              password = '" & txboxPassword.Text & "'
                                                        WHERE kodeUser = '" & txboxKdUser.Text & "'", connct)
        cmd.ExecuteNonQuery()
        panggildata_user()
        clean()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM user WHERE kodeUser = '" & txboxKdUser.Text & "'", connct)
            cmd.ExecuteNonQuery()
            panggildata_user()
        End If
        clean()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub

    Private Sub txboxCari_TextChanged(sender As Object, e As EventArgs) Handles txboxCari.TextChanged
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM user WHERE kodeUser LIKE '%" & txboxKdUser.Text & "%' OR
                                                                                   namaUser LIKE '%" & txboxNmUser.Text & "%' OR
                                                                                   password LIKE '%" & txboxPassword.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            dgvUser.DataSource = dt
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvUser.Columns(0).HeaderText = "Kode User"
            dgvUser.Columns(1).HeaderText = "Nama User"
            dgvUser.Columns(2).HeaderText = "Password"
        Else
            dgvUser.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvUser_Click(sender As Object, e As EventArgs) Handles dgvUser.Click
        i = dgvUser.CurrentRow.Index
        With dgvUser.Rows.Item(i)
            txboxKdUser.Text = .Cells(0).Value
            txboxNmUser.Text = .Cells(1).Value
            txboxPassword.Text = .Cells(2).Value
        End With
    End Sub
End Class
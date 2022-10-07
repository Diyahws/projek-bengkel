Public Class FormLogin

    Sub kondisiLogin()
        FormMenuUtama.menuUtama.Enabled = True
        FormMenuUtama.menuUser.Enabled = True
        FormMenuUtama.menuPart.Enabled = True
        FormMenuUtama.menuJasa.Enabled = True
        FormMenuUtama.menuMontir.Enabled = True
        FormMenuUtama.menuTransaksi.Enabled = True
        FormMenuUtama.menuLogin.Enabled = False
        FormMenuUtama.menuKeluar.Enabled = True
        FormMenuUtama.PanelDesktop.Visible = True
        FormMenuUtama.lblStatus.Text = "Menu Utama"
        Me.Close()
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        txboxUser.Select()
        txboxUser.MaxLength = 6
        txboxPass.MaxLength = 6
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txboxPass.UseSystemPasswordChar = True Then
            txboxPass.UseSystemPasswordChar = False
        Else
            txboxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM user WHERE
                                                    kodeUser = '" & txboxUser.Text & "' AND
                                                    password = '" & txboxPass.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            kondisiLogin()
            FormMenuUtama.tsslblUser0.Text = dr!kodeUser
            FormMenuUtama.tsslblNama0.Text = dr!namaUser
        Else
            MessageBox.Show("Periksa Kembali User Kode dan Password Anda!", "Peringatan!", MessageBoxButtons.OK)
            txboxUser.Text = ""
            txboxPass.Text = ""
        End If
    End Sub
End Class
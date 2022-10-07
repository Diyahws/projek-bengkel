Public Class FormMenuUtama
    Dim formSkrg As Form

    Sub kondisiawal()
        menuUtama.Enabled = False
        menuUser.Enabled = False
        menuPart.Enabled = False
        menuJasa.Enabled = False
        menuMontir.Enabled = False
        menuTransaksi.Enabled = False
    End Sub

    Public Sub bukaForm(formAnak As Form)
        If formSkrg IsNot Nothing Then
            formSkrg.Close()
        End If
        formSkrg = formAnak

        formAnak.TopLevel = False
        formAnak.FormBorderStyle = FormBorderStyle.None
        formAnak.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(formAnak)
        'PanelDesktop.Tag = formSkrg
        formAnak.BringToFront()
        formAnak.Show()
        lblStatus.Text = formAnak.Text
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        'kondisiawal()
        Timer1.Start()
        tsslblTgl0.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsslblJam0.Text = TimeOfDay
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Me.Close()
    End Sub

    Private Sub menuLogin_Click(sender As Object, e As EventArgs) Handles menuLogin.Click
        bukaForm(New FormLogin)
    End Sub

    Private Sub menuUtama_Click(sender As Object, e As EventArgs) Handles menuUtama.Click

    End Sub

    Private Sub menuUser_Click(sender As Object, e As EventArgs) Handles menuUser.Click
        bukaForm(New FormUser)
    End Sub

    Private Sub menuPart_Click(sender As Object, e As EventArgs) Handles menuPart.Click
        bukaForm(New FormSparepart)
    End Sub

    Private Sub menuJasa_Click(sender As Object, e As EventArgs) Handles menuJasa.Click
        bukaForm(New FormService)
    End Sub

    Private Sub menuMontir_Click(sender As Object, e As EventArgs) Handles menuMontir.Click
        bukaForm(New FormMontir)
    End Sub

    Private Sub menuTransaksi_Click(sender As Object, e As EventArgs) Handles menuTransaksi.Click
        bukaForm(New FormTransaksi)
    End Sub
End Class

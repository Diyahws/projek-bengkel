Imports MySql.Data.MySqlClient
Module Module1
    Public connct As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public str As String
    Public data As Integer
    Public lng As Long
    Public i As Integer
    Public total As Double
    Public jumlah As Double
    Public kembali As Double


    Sub koneksi()

        str = "server=localhost;userid=root;password=;database=db_bengkel;convert zero datetime=true"
        connct = New MySqlConnection(str)

        If connct.State = ConnectionState.Closed Then
            connct.Open()
        End If
    End Sub
End Module

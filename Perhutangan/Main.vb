Imports MySql.Data.MySqlClient

Public Class Main

    Dim query As String
    Dim paidStat As String
    Dim hutang As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call dataConnection()
        Call showData()



        'Data Grid View Styles'
        dataGrid.Columns(0).HeaderText = "ID"
        dataGrid.Columns(1).HeaderText = "Nama"
        dataGrid.Columns(2).HeaderText = "Alamat"
        dataGrid.Columns(3).HeaderText = "Jumlah Hutang"
        dataGrid.Columns(4).HeaderText = "Jatuh Tempo"
        dataGrid.Columns(5).HeaderText = "Status"

        dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


    End Sub

    'Untuk mengeksekusi perintah'
    Sub executeData()
        Try
            Call dataConnection()
            CMD = New MySqlCommand
            CMD.Connection = CONN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = query
            CMD.ExecuteNonQuery()
            CMD.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Mereset control form'
        ID.Text = "ID"
        userName.Text = "Nama"
        userAddress.Text = "Alamat"
        debtAmount.Text = "Jumlah Hutang"
        paid.Checked = False
        unPaid.Checked = False
        dateTime.Text = Date.Now()
    End Sub


    Private Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click

        'Mengecek apakah nilai yang dimasukan valid atau tidak'
        If ID.Text = "ID" Or userName.Text = "Nama" Or userAddress.Text = "Alamat" Then

            MsgBox("Mohon masukan data yang valid")

        ElseIf paid.Checked = False And unPaid.Checked = False Then

            MsgBox("Mohon pilih status hutang (Lunas/Belum Lunas)")

        Else

            'Menentukan status hutang'
            If paid.Checked = True Then
                paidStat = "Lunas"
            ElseIf unPaid.Checked = True Then
                paidStat = "Belum Lunas"
            End If

            'memberikan mata uang Rupiah pada input jumlah hutang'
            If IsNumeric(debtAmount.Text) = True Then
                hutang = "Rp. " + debtAmount.Text + ",-"
            Else
                hutang = debtAmount.Text
            End If


            query = "INSERT INTO tb_hutang(ID, nama, alamat, jumlah, jatuh_tempo, status) VALUES('" & ID.Text & "', '" & userName.Text & "', '" & userAddress.Text & "', '" & hutang & "', '" & dateTime.Text & "', '" & paidStat & "')"

            Call executeData()
            Call showData()

        End If


    End Sub

    Private Sub dataGrid_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGrid.RowHeaderMouseClick

        Dim index As Integer
        Dim check As String
        index = dataGrid.CurrentRow.Index


        ID.Text = dataGrid.Item(0, index).Value
        userName.Text = dataGrid.Item(1, index).Value
        userAddress.Text = dataGrid.Item(2, index).Value
        debtAmount.Text = dataGrid.Item(3, index).Value
        dateTime.Text = dataGrid.Item(4, index).Value
        check = dataGrid.Item(5, index).Value

        If check = "Lunas" Then
            paid.Checked = True
        ElseIf check = "Belum Lunas" Then
            unPaid.Checked = True
        End If



    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        If paid.Checked = True Then
            paidStat = "Lunas"
        ElseIf unPaid.Checked = True Then
            paidStat = "Belum Lunas"
        End If

        If IsNumeric(debtAmount.Text) = True Then
            hutang = "Rp. " + debtAmount.Text + ",-"
        Else
            hutang = debtAmount.Text
        End If


        query = "UPDATE tb_hutang set nama='" & userName.Text & "', alamat='" & userAddress.Text & "', jumlah='" & hutang & "', status='" & paidStat & "', jatuh_tempo='" & dateTime.Text & "' WHERE id='" & ID.Text & "'"

        If IsNumeric(ID.Text) = True Then
            Call executeData()
        Else
            MsgBox("Anda belum memilih data dari tabel")
        End If


        Call showData()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        query = "DELETE FROM tb_hutang where id='" & ID.Text & "'"
        Call executeData()
        Call showData()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        CONN.Close()
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Call dataConnection()
        DA = New MySqlDataAdapter("SELECT * FROM tb_hutang where nama like'%" & searchBox.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_hutang")
        dataGrid.DataSource = DS.Tables("tb_hutang")
    End Sub
End Class

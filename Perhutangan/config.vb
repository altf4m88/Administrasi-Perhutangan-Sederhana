Imports MySql.Data.MySqlClient
Imports System.Data

Module config

    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public CMDBUILD As MySqlCommandBuilder
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public DT As DataTable
    Public BS As BindingSource
    Dim str As String

    Public Sub dataConnection()
        Try
            str = "server=localhost;user id=root;password=;database=perhutangan;"
            CONN = New MySqlConnection(str)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("Error Connecting To Database")
        End Try

    End Sub

    Public Sub showData()
        Try
            Dim DA As New MySqlDataAdapter
            Dim DT As New DataTable
            Dim BS As New BindingSource
            Call dataConnection()
            str = "SELECT * FROM tb_hutang"
            CMD = New MySqlCommand(str, CONN)
            DA.SelectCommand = CMD
            DA.Fill(DT)
            BS.DataSource = DT
            Main.dataGrid.DataSource = BS
            DA.Update(DT)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub




End Module

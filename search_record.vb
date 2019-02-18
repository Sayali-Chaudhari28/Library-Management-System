Imports MySql.Data.MySqlClient
Public Class search_record
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server = localhost;userid=root;password= sarthak333;database = student_details"
        Dim sda As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim query As String
            query = "select *from Student_details.stud_info where student_id = '" & stud_id.Text & "'"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dbDataset)
            bSource.DataSource = dbDataset
            display_record.book_details.DataSource = bSource
            sda.Update(dbDataset)
            display_record.Show()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class
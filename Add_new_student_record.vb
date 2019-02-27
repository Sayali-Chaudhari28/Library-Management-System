Imports MySql.Data.MySqlClient
Public Class Add_new_student_record
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
            query = "insert into student_details.stud_info (student_id,First_name,Middle_name,Last_name,Section,Address,Mobile_number)values('" & stud_id.Text & "','" & fname.Text & "','" & mname.Text & "','" & lname.Text & "','" & section.Text & "','" & address.Text & "','" & mbno.Text & "')"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dbDataset)
            bSource.DataSource = dbDataset
            display_record.book_details.DataSource = bSource
            sda.Update(dbDataset)
            connection.Close()
            MsgBox("New student record added ! ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class
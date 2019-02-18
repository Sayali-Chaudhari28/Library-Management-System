Imports MySql.Data.MySqlClient
Public Class Form2
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label7.Click
        Add_new_student_record.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label8.Click
        search_record.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label9.Click
        issue_book.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label10.Click
        return_book.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label11.Click
        display_record.Show()
        connection = New MySqlConnection
        connection.ConnectionString = "server = localhost;userid=root;password= sarthak333;database = student_details"
        Dim sda As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim query As String
            query = "select *from student_details.stud_info"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dbDataset)
            bSource.DataSource = dbDataset
            display_record.book_details.DataSource = bSource
            sda.Update(dbDataset)
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class

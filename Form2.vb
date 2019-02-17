Public Class Form2
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
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

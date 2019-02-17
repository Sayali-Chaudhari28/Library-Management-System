Public Class return_book
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles R_exit.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Book returned !")
    End Sub
End Class
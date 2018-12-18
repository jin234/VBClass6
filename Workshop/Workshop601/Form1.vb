Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        lblStart.Text = MonthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy")
        lblEnd.Text = MonthCalendar1.SelectionEnd.ToString("dd-MMMM-yyyy")
        lblRange.Text = (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If TextBoxName.TextLength = 0 And TextBoxEmail.TextLength = 0 And TextBoxID.TextLength = 0 Then
            MessageBox.Show("Error")
        End If
    End Sub
End Class

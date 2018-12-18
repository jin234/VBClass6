Public Class Form1

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click

        lblStart.Text = MonthCalendar1.SelectionStart.ToString("dd MMMM yyyy")
        lblEnd.Text = MonthCalendar1.SelectionEnd.ToString("dd MMMM yyyy")
        lblRange.Text = (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1 & " Days."
    End Sub


End Class

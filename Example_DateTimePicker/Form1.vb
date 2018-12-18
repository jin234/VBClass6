Public Class Form1



    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click, DateTimePicker1.ValueChanged


        Dim data As DateTimePicker = DateTimePicker1
        lblMinDate.Text = data.MinDate
        lblMaxDate.Text = data.MaxDate
        lblDate.Text = data.Value
        lblDay.Text = data.Value.Day
        lblMonth.Text = data.Value.Month.ToString("MMM")
        lblHour.Text = data.Value.Hour
        lblHour.Text = DateTime.Now.Hour

        lblMinute.Text = data.Value.Minute
        lblMinute.Text = DateTime.Now.Minute

        lblSecond.Text = data.Value.Second
        lblSecond.Text = DateTime.Now.Second




    End Sub

End Class

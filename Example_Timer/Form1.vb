Public Class Form1
    Dim Msec As Integer
    Dim sec As Integer
    Dim min As Integer
    Dim hour As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Msec += 1
        If Msec = 60 Then
            Msec = 0
            sec += 1
        End If
        If sec = 60 Then
            sec = 0
            min += 1
        End If
        If min = 60 Then
            min = 0
            hour += 1
        End If
        lblTime.Text = hour.ToString("00") & " : " & min.ToString("00") & " : " & sec.ToString("00") & " : " & Msec.ToString("00")
    End Sub
End Class

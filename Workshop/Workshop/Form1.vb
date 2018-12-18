Public Class Form1

    Dim Msec As Integer
    Dim sec As Integer
    Dim min As Integer
    Dim hour As Integer
    Dim word() As String = {"Apple", "Bird", "Cats", "Dogs", "Eggs", "Fish", "Fish", "Fish", "Fish", "Fish", "Fish"}
    Dim CWordi As Integer
    Dim Rand As Random = New Random
    Dim score As Integer
    Dim words As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        GenNewWord()
        Timer1.Start()
        btnStart.Enabled = False
        ButtonAns.Enabled = True
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

        If sec = 3 Then
            Timer1.Stop()
            MessageBox.Show("You Guess" & words & " Word" & vbNewLine & "Correct " & score & " Word")
            GameReset()
        End If

    End Sub



    Private Sub ButtonAns_Click(sender As Object, e As EventArgs) Handles ButtonAns.Click
        Hardmode()
    End Sub

    Private Sub GameReset()
        Msec = 0
        sec = 0
        min = 0
        hour = 0
        score = 0
        btnStart.Enabled = True
        ButtonAns.Enabled = False
        lblTime.Text = "00 : 00 : 00 : 00"
        Label2.Text = "..."
        Label3.Text = "..."
        ComboBox1.Text = ""
    End Sub

    Private Sub GenNewWord()

        CWordi = Rand.Next(0, word.Length)
        Label2.Text = word(CWordi)(0)
        Label3.Text = word(CWordi).Length()

    End Sub


    Private Sub Ezmode()
        If ComboBox1.Text.ToLower = word(CWordi).ToLower Then
            ComboBox1.Items.Clear()
            score += 1
            GenNewWord()
        Else
            ComboBox1.Items.Add(ComboBox1.Text)
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Hardmode()
        If ComboBox1.Text.ToLower = word(CWordi).ToLower Then
            score += 1

        End If
        ComboBox1.Text = ""
        words += 1
        GenNewWord()

    End Sub
End Class

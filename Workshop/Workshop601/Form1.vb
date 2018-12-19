Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 2
        LabelResult.Text = "เลขบัตรประชาชน : " & TextBoxID.Text & vbNewLine &
                            "ชื่อ - นามสกุล : " & TextBoxName.Text & vbNewLine &
                            "เบอร์โทรศัพท์  : " & TextBoxPhone.Text & vbNewLine &
                            "จองตั้งแต่วันที่  : " & lblStart.Text & vbNewLine &
                            "จองจนถึงวันที่  : " & lblEnd.Text & vbNewLine &
                            "จำนวนวันรวม  : " & lblRange.Text & " วัน"
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        lblStart.Text = MonthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy")
        lblEnd.Text = MonthCalendar1.SelectionEnd.ToString("dd-MMMM-yyyy")
        lblRange.Text = (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If TextBoxID.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนเลขรหัสประชาชน")
        ElseIf TextBoxName.TextLength = 0 Then
            MessageBox.Show("กรุณากรอกชื่อ")
        ElseIf TextBoxPhone.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนเลขโทรศัพท์")
        Else
            TabControl1.SelectedIndex = 1
            MonthCalendar1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub
End Class

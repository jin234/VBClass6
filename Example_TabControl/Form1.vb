Public Class Form1

    Dim ID As String
    Dim FName As String
    Dim Email As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ID = txtId.Text
        FName = txtName.Text
        Email = txtEmail.Text
        TabControl1.SelectedIndex = 1
        lblFullname.Text = ID & " , " & FName


    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubject.SelectedIndexChanged
        listSubject.Items.Add(cmbSubject.SelectedItem)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim subject As String = ""
        For Each item In listSubject.Items
            subject += "-" & item & vbNewLine
        Next
        MessageBox.Show(ID & " , " & FName & vbNewLine &
                        "Email " & Email & vbNewLine & subject)


    End Sub


End Class

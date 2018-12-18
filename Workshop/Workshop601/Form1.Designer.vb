<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelFname = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelIDCard = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(497, 264)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonNext)
        Me.TabPage1.Controls.Add(Me.TextBoxPhone)
        Me.TabPage1.Controls.Add(Me.LabelPhone)
        Me.TabPage1.Controls.Add(Me.TextBoxName)
        Me.TabPage1.Controls.Add(Me.LabelFname)
        Me.TabPage1.Controls.Add(Me.TextBoxID)
        Me.TabPage1.Controls.Add(Me.LabelIDCard)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(489, 238)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลลูกค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(224, 124)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(103, 31)
        Me.ButtonNext.TabIndex = 6
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Location = New System.Drawing.Point(94, 89)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxPhone.TabIndex = 5
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Location = New System.Drawing.Point(6, 92)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(72, 13)
        Me.LabelPhone.TabIndex = 4
        Me.LabelPhone.Text = "Mobile Phone"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(94, 53)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxName.TabIndex = 3
        '
        'LabelFname
        '
        Me.LabelFname.AutoSize = True
        Me.LabelFname.Location = New System.Drawing.Point(24, 56)
        Me.LabelFname.Name = "LabelFname"
        Me.LabelFname.Size = New System.Drawing.Size(54, 13)
        Me.LabelFname.TabIndex = 2
        Me.LabelFname.Text = "Full Name"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(94, 17)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxID.TabIndex = 1
        '
        'LabelIDCard
        '
        Me.LabelIDCard.AutoSize = True
        Me.LabelIDCard.Location = New System.Drawing.Point(35, 20)
        Me.LabelIDCard.Name = "LabelIDCard"
        Me.LabelIDCard.Size = New System.Drawing.Size(43, 13)
        Me.LabelIDCard.TabIndex = 0
        Me.LabelIDCard.Text = "ID Card"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lblRange)
        Me.TabPage2.Controls.Add(Me.lblEnd)
        Me.TabPage2.Controls.Add(Me.lblStart)
        Me.TabPage2.Controls.Add(Me.MonthCalendar1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(489, 238)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "การจอง"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(252, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Count Range (Days) : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(249, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "End Date : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(249, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Start Date : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRange
        '
        Me.lblRange.BackColor = System.Drawing.Color.Snow
        Me.lblRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRange.Location = New System.Drawing.Point(252, 143)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(185, 24)
        Me.lblRange.TabIndex = 21
        Me.lblRange.Text = "0"
        Me.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.Color.Snow
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(252, 91)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(185, 24)
        Me.lblEnd.TabIndex = 20
        Me.lblEnd.Text = "dd-mm-yyyy"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.Snow
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(252, 40)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(185, 24)
        Me.lblStart.TabIndex = 18
        Me.lblStart.Text = "dd-mm-yyyy"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(13, 16)
        Me.MonthCalendar1.MaxSelectionCount = 10
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Confirm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LabelResult)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(489, 238)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "สรุปการจอง"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.BackColor = System.Drawing.Color.LightGray
        Me.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelResult.Enabled = False
        Me.LabelResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LabelResult.Location = New System.Drawing.Point(15, 33)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(453, 182)
        Me.LabelResult.TabIndex = 6
        Me.LabelResult.Text = "..."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Result : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Thai-Nichi Resort"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtonNext As Button
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents LabelPhone As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelFname As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelIDCard As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRange As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

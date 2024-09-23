<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtFirstname = New TextBox()
        txtLastname = New TextBox()
        txtGender = New TextBox()
        btnEnter = New Button()
        txt_Firstname = New Label()
        txt_LastName = New Label()
        txt_Gender = New Label()
        SuspendLayout()
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(311, 75)
        txtFirstname.Multiline = True
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(365, 41)
        txtFirstname.TabIndex = 0
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(308, 139)
        txtLastname.Multiline = True
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(365, 41)
        txtLastname.TabIndex = 1
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(309, 215)
        txtGender.Multiline = True
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(365, 40)
        txtGender.TabIndex = 2
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = SystemColors.Highlight
        btnEnter.Font = New Font("Segoe UI", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnEnter.ForeColor = SystemColors.Control
        btnEnter.Location = New Point(353, 290)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(255, 54)
        btnEnter.TabIndex = 3
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' txt_Firstname
        ' 
        txt_Firstname.AutoSize = True
        txt_Firstname.Location = New Point(140, 78)
        txt_Firstname.Name = "txt_Firstname"
        txt_Firstname.Size = New Size(139, 25)
        txt_Firstname.TabIndex = 4
        txt_Firstname.Text = "Enter First name"
        ' 
        ' txt_LastName
        ' 
        txt_LastName.AutoSize = True
        txt_LastName.Location = New Point(139, 142)
        txt_LastName.Name = "txt_LastName"
        txt_LastName.Size = New Size(140, 25)
        txt_LastName.TabIndex = 5
        txt_LastName.Text = "Enter Last Name"
        ' 
        ' txt_Gender
        ' 
        txt_Gender.AutoSize = True
        txt_Gender.Location = New Point(188, 215)
        txt_Gender.Name = "txt_Gender"
        txt_Gender.Size = New Size(69, 25)
        txt_Gender.TabIndex = 6
        txt_Gender.Text = "Gender"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_Gender)
        Controls.Add(txt_LastName)
        Controls.Add(txt_Firstname)
        Controls.Add(btnEnter)
        Controls.Add(txtGender)
        Controls.Add(txtLastname)
        Controls.Add(txtFirstname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txt_Firstname As Label
    Friend WithEvents txt_LastName As Label
    Friend WithEvents txt_Gender As Label

End Class

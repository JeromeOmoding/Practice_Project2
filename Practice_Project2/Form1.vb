Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim stfirstName As String
        Dim stlastName As String
        Dim stgender As String

        stfirstName = txtFirstname.Text
        stlastName = txtLastname.Text
        stgender = txtGender.Text

        MsgBox("Am" & " " & stfirstName & stlastName & " i am " & stgender)




    End Sub
End Class

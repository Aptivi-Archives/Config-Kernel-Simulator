Public Class Libs

    Private Sub Libs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RichTextBox1.Rtf = My.Resources.AboutLibs

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class
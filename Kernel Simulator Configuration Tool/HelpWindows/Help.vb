Public Class Help

    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Rtf = My.Resources.Main
        Label1.Text = "Version " + Configurator.Ver
        Sections.SelectedItem = "Introduction"
    End Sub

    Private Sub Sections_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sections.SelectedValueChanged
        If (Sections.SelectedItem = "Introduction") Then
            RichTextBox1.Rtf = My.Resources.Main
        ElseIf (Sections.SelectedItem = "General") Then
            RichTextBox1.Rtf = My.Resources.General
        ElseIf (Sections.SelectedItem = "Login") Then
            RichTextBox1.Rtf = My.Resources.Login
        ElseIf (Sections.SelectedItem = "Hardware") Then
            RichTextBox1.Rtf = My.Resources.Hardware
        ElseIf (Sections.SelectedItem = "Shell") Then
            RichTextBox1.Rtf = My.Resources.Shell
        ElseIf (Sections.SelectedItem = "Others") Then
            RichTextBox1.Rtf = My.Resources.Others
        ElseIf (Sections.SelectedItem = "Localization") Then
            RichTextBox1.Rtf = My.Resources.Localization
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
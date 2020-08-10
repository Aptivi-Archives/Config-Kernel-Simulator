
'    Kernel Simulator Configuration Tool  Copyright (C) 2018-2020  EoflaOE
'
'    This file is part of Kernel Simulator Configuration Tool
'
'    Kernel Simulator Configuration Tool is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    Kernel Simulator Configuration Tool is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <https://www.gnu.org/licenses/>.

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
        ElseIf (Sections.SelectedItem = "Localization") Then
            RichTextBox1.Rtf = My.Resources.Localization
        ElseIf (Sections.SelectedItem = "Network") Then
            RichTextBox1.Rtf = My.Resources.Network
        ElseIf (Sections.SelectedItem = "Others") Then
            RichTextBox1.Rtf = My.Resources.Others
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
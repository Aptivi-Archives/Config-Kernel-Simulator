
'    Kernel Simulator Configuration Tool  Copyright (C) 2018  EoflaOE
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

Public Class LiveColor

    Private Sub LiveColor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Configurator.Button1.Enabled = True
    End Sub

    Private Sub LiveColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadColors()
        MakeBrightReadable()
        correctColors()
    End Sub

    Sub LoadColors()
        RichTextBox1.ForeColor = Color.FromName(Configurator.textColor.Text)
        RichTextBox2.ForeColor = Color.FromName(Configurator.licenseColor.Text)
        RichTextBox3.ForeColor = Color.FromName(Configurator.contError.Text)
        RichTextBox6.ForeColor = Color.FromName(Configurator.uncontError.Text)
        RichTextBox5.ForeColor = Color.FromName(Configurator.hostNameColor.Text)
        RichTextBox4.ForeColor = Color.FromName(Configurator.userNameColor.Text)
        RichTextBox7.ForeColor = Color.FromName(Configurator.inputColor.Text)
        If (Configurator.backgroundColor.Text = "DarkYellow") Then
            RichTextBox8.BackColor = Color.DarkGoldenrod
        Else
            RichTextBox8.BackColor = Color.FromName(Configurator.backgroundColor.Text)
        End If
    End Sub

    Sub MakeBrightReadable()
        If (Configurator.textColor.Text = "White" Or Configurator.textColor.Text = "Yellow" Or Configurator.textColor.Text = "Cyan") Then
            RichTextBox1.BackColor = Color.Black
        Else
            RichTextBox1.BackColor = Color.White
        End If
        If (Configurator.licenseColor.Text = "White" Or Configurator.licenseColor.Text = "Yellow" Or Configurator.licenseColor.Text = "Cyan") Then
            RichTextBox2.BackColor = Color.Black
        Else
            RichTextBox2.BackColor = Color.White
        End If
        If (Configurator.contError.Text = "White" Or Configurator.contError.Text = "Yellow" Or Configurator.contError.Text = "Cyan") Then
            RichTextBox3.BackColor = Color.Black
        Else
            RichTextBox3.BackColor = Color.White
        End If
        If (Configurator.userNameColor.Text = "White" Or Configurator.userNameColor.Text = "Yellow" Or Configurator.userNameColor.Text = "Cyan") Then
            RichTextBox4.BackColor = Color.Black
        Else
            RichTextBox4.BackColor = Color.White
        End If
        If (Configurator.hostNameColor.Text = "White" Or Configurator.hostNameColor.Text = "Yellow" Or Configurator.hostNameColor.Text = "Cyan") Then
            RichTextBox5.BackColor = Color.Black
        Else
            RichTextBox5.BackColor = Color.White
        End If
        If (Configurator.uncontError.Text = "White" Or Configurator.uncontError.Text = "Yellow" Or Configurator.uncontError.Text = "Cyan") Then
            RichTextBox6.BackColor = Color.Black
        Else
            RichTextBox6.BackColor = Color.White
        End If
        If (Configurator.backgroundColor.Text = "Cyan" Or Configurator.backgroundColor.Text = "Yellow") Then
            RichTextBox8.ForeColor = Color.Black
        Else
            RichTextBox8.ForeColor = Color.White
        End If
        If (Configurator.inputColor.Text = "White" Or Configurator.inputColor.Text = "Yellow" Or Configurator.inputColor.Text = "Cyan") Then
            RichTextBox7.BackColor = Color.Black
        Else
            RichTextBox7.BackColor = Color.White
        End If

    End Sub

    Sub correctColors()
        If (Configurator.textColor.Text = "DarkYellow") Then
            RichTextBox1.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.licenseColor.Text = "DarkYellow") Then
            RichTextBox2.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.contError.Text = "DarkYellow") Then
            RichTextBox3.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.userNameColor.Text = "DarkYellow") Then
            RichTextBox4.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.hostNameColor.Text = "DarkYellow") Then
            RichTextBox5.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.uncontError.Text = "DarkYellow") Then
            RichTextBox6.ForeColor = Color.DarkGoldenrod
        End If
        If (Configurator.inputColor.Text = "DarkYellow") Then
            RichTextBox7.ForeColor = Color.DarkGoldenrod
        End If
    End Sub

End Class
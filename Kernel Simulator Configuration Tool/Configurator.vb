
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

Imports System.IO
Imports System.Reflection

Public Class Configurator

    Public Ver As String
    Public started As Boolean = False

    Private Sub Configurator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Read the configuration file
        Try
            readConfig()
            started = True
        Catch noFile As FileNotFoundException
            Dim response = MsgBox("The configuration file is not found. Do you want to make one?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Config Not Found")
            If (response = vbYes) Then
                SimulatorsSelection.ShowDialog()
                readConfig()
                started = True
            Else
                Environment.Exit(1)
            End If
        End Try

    End Sub

    Sub readConfig()
        initializeCombos()
        Dim KernelIni As New StreamReader(Environ("USERPROFILE") + "\kernelConfig.ini")
        Dim LineValue As String = KernelIni.ReadLine
        Do While LineValue IsNot Nothing
            If (LineValue.Contains("Kernel Version = ")) Then
                Ver = LineValue.Replace("Kernel Version = ", "")
                Me.Text = Me.Text + " - Version " + Ver
            ElseIf (LineValue.Contains("Customized Colors on Boot = ")) Then
                If (LineValue.Replace("Customized Colors on Boot = ", "") = "True") Then
                    CheckBox5.Checked = True
                Else
                    CheckBox5.Checked = False
                End If
            ElseIf (LineValue.Contains("User Name Shell Color = ")) Then
                userNameColor.Text = LineValue.Replace("User Name Shell Color = ", "")
            ElseIf (LineValue.Contains("Host Name Shell Color = ")) Then
                hostNameColor.Text = LineValue.Replace("Host Name Shell Color = ", "")
            ElseIf (LineValue.Contains("Continuable Kernel Error Color = ")) Then
                contError.Text = LineValue.Replace("Continuable Kernel Error Color = ", "")
            ElseIf (LineValue.Contains("Uncontinuable Kernel Error Color = ")) Then
                uncontError.Text = LineValue.Replace("Uncontinuable Kernel Error Color = ", "")
            ElseIf (LineValue.Contains("Text Color = ")) Then
                textColor.Text = LineValue.Replace("Text Color = ", "")
            ElseIf (LineValue.Contains("License Color = ")) Then
                licenseColor.Text = LineValue.Replace("License Color = ", "")
            ElseIf (LineValue.Contains("Create Demo Account = ")) Then
                If (LineValue.Replace("Create Demo Account = ", "") = "True") Then
                    demo.Checked = True
                ElseIf (LineValue.Replace("Create Demo Account = ", "") = "False") Then
                    demo.Checked = False
                End If
            ElseIf (LineValue.Contains("Change Root Password = ")) Then
                If (LineValue.Replace("Change Root Password = ", "") = "True") Then
                    RootPC.Checked = True
                ElseIf (LineValue.Replace("Change Root Password = ", "") = "False") Then
                    RootPC.Checked = False
                End If
            ElseIf (LineValue.Contains("Set Root Password to = ")) Then
                RootPwd.Text = LineValue.Replace("Set Root Password to = ", "")
            ElseIf (LineValue.Contains("Maintenance Mode = ")) Then
                If (LineValue.Replace("Maintenance Mode = ", "") = "True") Then
                    MaintMode.Checked = True
                ElseIf (LineValue.Replace("Maintenance Mode = ", "") = "False") Then
                    MaintMode.Checked = False
                End If
            ElseIf (LineValue.Contains("Prompt for Arguments on Boot = ")) Then
                If (LineValue.Replace("Prompt for Arguments on Boot = ", "") = "True") Then
                    BootPrompt.Checked = True
                ElseIf (LineValue.Replace("Prompt for Arguments on Boot = ", "") = "False") Then
                    BootPrompt.Checked = False
                End If
            ElseIf (LineValue.Contains("Clear Screen on Log-in = ")) Then
                If (LineValue.Replace("Clear Screen on Log-in = ", "") = "True") Then
                    clslogin.Checked = True
                ElseIf (LineValue.Replace("Clear Screen on Log-in = ", "") = "False") Then
                    clslogin.Checked = False
                End If
            ElseIf (LineValue.Contains("Show MOTD on Log-in = ")) Then
                If (LineValue.Replace("Show MOTD on Log-in = ", "") = "True") Then
                    motdShow.Checked = True
                ElseIf (LineValue.Replace("Show MOTD on Log-in = ", "") = "False") Then
                    motdShow.Checked = False
                End If
            ElseIf (LineValue.Contains("Simplified Help Command = ")) Then
                If (LineValue.Replace("Simplified Help Command = ", "") = "True") Then
                    simHelp.Checked = True
                ElseIf (LineValue.Replace("Simplified Help Command = ", "") = "False") Then
                    simHelp.Checked = False
                End If
            ElseIf (LineValue.Contains("Colored Shell = ")) Then
                If (LineValue.Replace("Colored Shell = ", "") = "True") Then
                    colorShell.Checked = True
                Else
                    colorShell.Checked = False
                End If
            ElseIf (LineValue.Contains("Probe Slots = ")) Then
                If (LineValue.Replace("Probe Slots = ", "") = "True") Then
                    slotProbe.Checked = True
                ElseIf (LineValue.Replace("Probe Slots = ", "") = "False") Then
                    slotProbe.Checked = False
                End If
            ElseIf (LineValue.Contains("Quiet Probe = ")) Then
                If (LineValue.Replace("Quiet Probe = ", "") = "True") Then
                    probeQuiet.Checked = True
                ElseIf (LineValue.Replace("Quiet Probe = ", "") = "False") Then
                    probeQuiet.Checked = False
                End If
            ElseIf (LineValue.Contains("Probe GPU = ")) Then
                If (LineValue.Replace("Probe GPU = ", "") = "True") Then
                    gpuProbe.Checked = True
                ElseIf (LineValue.Replace("Probe GPU = ", "") = "False") Then
                    gpuProbe.Checked = False
                End If
            ElseIf (LineValue.Contains("Background Color = ")) Then
                backgroundColor.Text = LineValue.Replace("Background Color = ", "")
            ElseIf (LineValue.Contains("Input Color = ")) Then
                inputColor.Text = LineValue.Replace("Input Color = ", "")
            End If
            LineValue = KernelIni.ReadLine
        Loop
        KernelIni.Close()
        KernelIni.Dispose()
    End Sub

    Sub initializeCombos()

        Dim Colors() As String = {"White", "Gray", "DarkGray", "DarkRed", "Red", "DarkYellow", "Yellow", "DarkGreen", "Green", "DarkCyan", _
                                  "Cyan", "DarkBlue", "Blue", "DarkMagenta", "Magenta", "Black"}
        textColor.Items.AddRange(Colors) : textColor.Items.Remove("Black") : textColor.Text = "Gray"
        licenseColor.Items.AddRange(Colors) : licenseColor.Items.Remove("Black") : licenseColor.Text = "White"
        contError.Items.AddRange(Colors) : contError.Items.Remove("Black") : contError.Text = "Yellow"
        userNameColor.Items.AddRange(Colors) : userNameColor.Items.Remove("Black") : userNameColor.Text = "Green"
        hostNameColor.Items.AddRange(Colors) : hostNameColor.Items.Remove("Black") : hostNameColor.Text = "DarkGreen"
        uncontError.Items.AddRange(Colors) : uncontError.Items.Remove("Black") : uncontError.Text = "Red"
        backgroundColor.Items.AddRange(Colors) : backgroundColor.Items.Remove("White") : backgroundColor.Text = "Black"
        inputColor.Items.AddRange(Colors) : inputColor.Items.Remove("Black") : inputColor.Text = "White"
        For c As Integer = 0 To Colors.Length

        Next

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        If (CheckBox5.Checked = True) Then
            textColor.Enabled = True
            licenseColor.Enabled = True
            contError.Enabled = True
            userNameColor.Enabled = True
            hostNameColor.Enabled = True
            uncontError.Enabled = True
        Else
            textColor.Enabled = False
            licenseColor.Enabled = False
            contError.Enabled = False
            userNameColor.Enabled = False
            hostNameColor.Enabled = False
            uncontError.Enabled = False
        End If

    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        Try
            My.Computer.FileSystem.WriteAllText(Environ("USERPROFILE") + "\kernelConfig.ini", "", False)
            Dim KernelIni As New StreamWriter(Environ("USERPROFILE") + "\kernelConfig.ini")
            If (RootPwd.Text = "") Then
                RootPwd.Text = "toor"
            End If
            KernelIni.WriteLine("Kernel Version = {0}" + vbNewLine + _
                                "Customized Colors on Boot = {1}" + vbNewLine + _
                                "User Name Shell Color = {2}" + vbNewLine + _
                                "Host Name Shell Color = {3}" + vbNewLine + _
                                "Continuable Kernel Error Color = {4}" + vbNewLine + _
                                "Uncontinuable Kernel Error Color = {5}" + vbNewLine + _
                                "Text Color = {6}" + vbNewLine + _
                                "License Color = {7}" + vbNewLine + _
                                "Create Demo Account = {8}" + vbNewLine + _
                                "Change Root Password = {9}" + vbNewLine + _
                                "Set Root Password to = {10}" + vbNewLine + _
                                "Maintenance Mode = {11}" + vbNewLine + _
                                "Prompt for Arguments on Boot = {12}" + vbNewLine + _
                                "Clear Screen on Log-in = {13}" + vbNewLine + _
                                "Show MOTD on Log-in = {14}" + vbNewLine + _
                                "Simplified Help Command = {15}" + vbNewLine + _
                                "Colored Shell = {16}" + vbNewLine + _
                                "Probe Slots = {17}" + vbNewLine + _
                                "Quiet Probe = {18}" + vbNewLine + _
                                "Probe GPU = {19}" + vbNewLine + _
                                "Background Color = {20}" + vbNewLine + _
                                "Input Color = {21}", Ver, CheckBox5.Checked, userNameColor.Text, hostNameColor.Text, contError.Text, uncontError.Text, _
                                                    textColor.Text, licenseColor.Text, demo.Checked, RootPC.Checked, RootPwd.Text, MaintMode.Checked, _
                                                    BootPrompt.Checked, clslogin.Checked, motdShow.Checked, simHelp.Checked, colorShell.Checked, _
                                                    slotProbe.Checked, probeQuiet.Checked, gpuProbe.Checked, backgroundColor.Text, inputColor.Text)
            KernelIni.Close()
            KernelIni.Dispose()
        Catch ex As IO.IOException
            MsgBox(ex.StackTrace + vbNewLine + vbNewLine + "There is an error when trying to write to a configuration file. The file might be opened by another program, or other error specified below." + vbNewLine + "Error " + CStr(Err.Number) + ": " + ex.Message, vbOKOnly + vbCritical, "Error")
        Catch ex As Exception
            MsgBox(ex.StackTrace + vbNewLine + vbNewLine + "There is an error when trying to write to a configuration file that is specified below." + vbNewLine + "Error " + CStr(Err.Number) + ": " + ex.Message, vbOKOnly + vbCritical, "Error")
        End Try

    End Sub

    Private Sub RootPC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RootPC.CheckedChanged
        If (RootPC.Checked = True) Then
            RootPwd.Enabled = True
        Else
            RootPwd.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        LiveColor.Show()
    End Sub

    Private Sub textColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub licenseColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles licenseColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub contError_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles contError.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub uncontError_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uncontError.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub hostNameColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hostNameColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub userNameColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles userNameColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub backgroundColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles backgroundColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub

    Private Sub inputColor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles inputColor.SelectedValueChanged
        If (started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.correctColors()
        End If
    End Sub
End Class

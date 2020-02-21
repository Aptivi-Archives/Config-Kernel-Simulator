
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

Public Class Configurator

    Public Ver As String
    Public Started As Boolean = False
    Public configReader As New IniFile()
    Public confPath As String 'For multi-platform support
    Public EnvironmentOSType As String = Environment.OSVersion.ToString

    Private Sub Configurator_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Initialize directory
        If EnvironmentOSType.Contains("Unix") Then
            confPath = Environ("HOME") + "/kernelConfig.ini"
        Else
            confPath = Environ("USERPROFILE") + "\kernelConfig.ini"
        End If

        'Read the configuration file
        Try
            ReadConfig()
        Catch noFile As FileNotFoundException
            Dim response = MsgBox("The configuration file is not found. Do you want to make one?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Config Not Found")
            If (response = Global.Microsoft.VisualBasic.Constants.vbYes) Then
                SimulatorsSelection.ShowDialog()
                ReadConfig()
            Else
                Environment.Exit(1)
            End If
        End Try

    End Sub

    Sub ReadConfig()
        InitializeCombos()
        configReader.Load(confPath)
        If (configReader.Sections("Shell").Keys("Colored Shell").Value = "True") Then
            CheckBox5.Checked = True
            textColor.Enabled = True
            licenseColor.Enabled = True
            contError.Enabled = True
            userNameColor.Enabled = True
            hostNameColor.Enabled = True
            uncontError.Enabled = True
            backgroundColor.Enabled = True
            inputColor.Enabled = True
            CmdHelpColor.Enabled = True
            DefHelpColor.Enabled = True
            StageColor.Enabled = True
            Button1.Enabled = True
        Else
            CheckBox5.Checked = False
            textColor.Enabled = False
            licenseColor.Enabled = False
            contError.Enabled = False
            userNameColor.Enabled = False
            hostNameColor.Enabled = False
            uncontError.Enabled = False
            backgroundColor.Enabled = False
            inputColor.Enabled = False
            CmdHelpColor.Enabled = False
            DefHelpColor.Enabled = False
            StageColor.Enabled = True
            Button1.Enabled = False
        End If

        'Colors Section
        userNameColor.Text = configReader.Sections("Colors").Keys("User Name Shell Color").Value
        hostNameColor.Text = configReader.Sections("Colors").Keys("Host Name Shell Color").Value
        contError.Text = configReader.Sections("Colors").Keys("Continuable Kernel Error Color").Value
        uncontError.Text = configReader.Sections("Colors").Keys("Uncontinuable Kernel Error Color").Value
        textColor.Text = configReader.Sections("Colors").Keys("Text Color").Value
        licenseColor.Text = configReader.Sections("Colors").Keys("License Color").Value
        backgroundColor.Text = configReader.Sections("Colors").Keys("Background Color").Value
        inputColor.Text = configReader.Sections("Colors").Keys("Input Color").Value
        CmdHelpColor.Text = configReader.Sections("Colors").Keys("Listed command in help Color").Value
        DefHelpColor.Text = configReader.Sections("Colors").Keys("Definition of command in Help Color").Value
        StageColor.Text = configReader.Sections("Colors").Keys("Kernel Stage Color").Value
        Started = True

        'General Section
        If (configReader.Sections("General").Keys("Create Demo Account").Value = "True") Then demo.Checked = True Else demo.Checked = False
        If (configReader.Sections("General").Keys("Change Root Password").Value = "True") Then RootPC.Checked = True Else RootPC.Checked = False
        RootPwd.Text = configReader.Sections("General").Keys("Set Root Password to").Value
        If (configReader.Sections("General").Keys("Maintenance Mode").Value = "True") Then MaintMode.Checked = True Else MaintMode.Checked = False
        If (configReader.Sections("General").Keys("Prompt for Arguments on Boot").Value = "True") Then BootPrompt.Checked = True Else BootPrompt.Checked = False
        If configReader.Sections("General").Keys("Check for Updates on Startup").Value = "True" Then UpdateStart.Checked = True Else UpdateStart.Checked = False
        ReadLocalization()

        'Login Section
        If (configReader.Sections("Login").Keys("Clear Screen on Log-in").Value = "True") Then clslogin.Checked = True Else clslogin.Checked = False
        If (configReader.Sections("Login").Keys("Show MOTD on Log-in").Value = "True") Then motdShow.Checked = True Else motdShow.Checked = False
        HostName.Text = configReader.Sections("Login").Keys("Host Name").Value
        If (configReader.Sections("Login").Keys("Show available usernames").Value = "True") Then UsersShow.Checked = True Else UsersShow.Checked = False

        'Shell Section
        If (configReader.Sections("Shell").Keys("Simplified Help Command").Value = "True") Then simHelp.Checked = True Else simHelp.Checked = False
        If (configReader.Sections("Shell").Keys("Colored Shell").Value = "True") Then colorShell.Checked = True Else colorShell.Checked = False

        'Hardware Section
        If (configReader.Sections("Hardware").Keys("Probe Slots").Value = "True") Then slotProbe.Checked = True Else slotProbe.Checked = False
        If (configReader.Sections("Hardware").Keys("Quiet Probe").Value = "True") Then probeQuiet.Checked = True Else probeQuiet.Checked = False

        'Misc Section
        If (configReader.Sections("Misc").Keys("Show Time/Date on Upper Right Corner").Value = "True") Then tdCorner.Checked = True Else tdCorner.Checked = False
        Screensave.Text = configReader.Sections("Misc").Keys("Screensaver").Value
        DebugPort.Text = configReader.Sections("Misc").Keys("Debug Port").Value
        DebugMax.Text = configReader.Sections("Misc").Keys("Debug Size Quota in Bytes").Value
        DebugNPrefix.Text = configReader.Sections("Misc").Keys("Remote Debug Default Nick Prefix").Value
        RetryDownload.Text = configReader.Sections("Misc").Keys("Download Retry Times").Value
        If configReader.Sections("Misc").Keys("Log FTP username").Value = "True" Then LogFTPUsr.Checked = True Else LogFTPUsr.Checked = False
        If configReader.Sections("Misc").Keys("Log FTP IP address").Value = "True" Then LogFTPIP.Checked = True Else LogFTPIP.Checked = False
        If configReader.Sections("Misc").Keys("Size parse mode").Value = "True" Then FullParseMode.Checked = True Else FullParseMode.Checked = False
        If configReader.Sections("Misc").Keys("Marquee on startup").Value = "True" Then StartScroll.Checked = True Else StartScroll.Checked = False
        If configReader.Sections("Misc").Keys("Long Time and Date").Value = "True" Then LongTimeDate.Checked = True Else LongTimeDate.Checked = False
        If configReader.Sections("Misc").Keys("Show Hidden Files").Value = "True" Then HiddenFiles.Checked = True Else HiddenFiles.Checked = False
        Ver = configReader.Sections("Misc").Keys("Kernel Version").Value
    End Sub

    Sub ReadLocalization()
        Select Case configReader.Sections("General").Keys("Language").Value
            Case "eng"
                Languages.Text = "English (United States - eng)"
            Case "arb"
                Languages.Text = "Arabic (Arab countries - arb)"
            Case "arb-T"
                Languages.Text = "Arabic (Arab countries - arb) (Translated)"
            Case "chi"
                Languages.Text = "Chinese (Simplified - China - chi)"
            Case "chi-T"
                Languages.Text = "Chinese (Simplified - China - chi) (Translated)"
            Case "fre"
                Languages.Text = "French (France - fre)"
            Case "ger"
                Languages.Text = "German (Germany - ger)"
            Case "ind"
                Languages.Text = "Hindi (India - ind)"
            Case "ind-T"
                Languages.Text = "Hindi (India - ind) (Translated)"
            Case "ptg"
                Languages.Text = "Portuguese (Brazil - ptg)"
            Case "spa"
                Languages.Text = "Spanish (Spain - spa)"
            Case "dtc"
                Languages.Text = "Dutch (Netherlands - dtc)"
            Case "fin"
                Languages.Text = "Finnish (Finland - fin)"
            Case "ita"
                Languages.Text = "Italian (Italy - ita)"
            Case "mal"
                Languages.Text = "Malay (mal)"
            Case "swe"
                Languages.Text = "Swedish (Switzerland - swe)"
            Case "tky"
                Languages.Text = "Turkish (Turkey - tky)"
            Case "cze"
                Languages.Text = "Czech (cze)"
            Case "cro"
                Languages.Text = "Croatian (Croatia - cro)"
            Case "ndo"
                Languages.Text = "Indonesian (Indonesia - ndo)"
            Case "pol"
                Languages.Text = "Polish (Poland - pol)"
            Case "rmn"
                Languages.Text = "Romanian (Roman - rmn)"
            Case "uzb"
                Languages.Text = "Uzbek (Uzbekistan - uzb)"
            Case "rus"
                Languages.Text = "Russian (Russia - rus)"
            Case "rus-T"
                Languages.Text = "Russian (Russia - rus) (Translated)"
            Case "jpn"
                Languages.Text = "Japanese (Japan - jpn)"
            Case "jpn-T"
                Languages.Text = "Japanese (Japan - jpn) (Translated)"
            Case "kor"
                Languages.Text = "Korean (Korea - kor)"
            Case "kor-T"
                Languages.Text = "Korean (Korea - kor) (Translated)"
            Case "dan"
                Languages.Text = "Danish (dan)"
            Case "vtn"
                Languages.Text = "Vietnamese (Vietnam - vtn)"
            Case "nwg"
                Languages.Text = "Norwegian (nwg)"
            Case Else
                Languages.Text = "English (United States - eng)"
        End Select
    End Sub

    Function SaveLocalization() As String
        Select Case Languages.Text
            Case "English (United States - eng)"
                Return "eng"
            Case "Arabic (Arab countries - arb)"
                Return "arb"
            Case "Arabic (Arab countries - arb) (Translated)"
                Return "arb-T"
            Case "Chinese (Simplified - China - chi)"
                Return "chi"
            Case "Chinese (Simplified - China - chi) (Translated)"
                Return "chi-T"
            Case "French (France - fre)"
                Return "fre"
            Case "German (Germany - ger)"
                Return "ger"
            Case "Hindi (India - ind)"
                Return "ind"
            Case "Hindi (India - ind) (Translated)"
                Return "ind-T"
            Case "Portuguese (Brazil - ptg)"
                Return "ptg"
            Case "Spanish (Spain - spa)"
                Return "spa"
            Case "Dutch (Netherlands - dtc)"
                Return "dtc"
            Case "Finnish (Finland - fin)"
                Return "fin"
            Case "Italian (Italy - ita)"
                Return "ita"
            Case "Malay (mal)"
                Return "mal"
            Case "Swedish (Switzerland - swe)"
                Return "swe"
            Case "Turkish (Turkey - tky)"
                Return "tky"
            Case "Czech (cze)"
                Return "cze"
            Case "Croatian (Croatia - cro)"
                Return "cro"
            Case "Indonesian (Indonesia - ndo)"
                Return "ndo"
            Case "Polish (Poland - pol)"
                Return "pol"
            Case "Romanian (Roman - rmn)"
                Return "rmn"
            Case "Uzbek (Uzbekistan - uzb)"
                Return "uzb"
            Case "Russian (Russia - rus)"
                Return "rus"
            Case "Russian (Russia - rus) (Translated)"
                Return "rus-T"
            Case "Japanese (Japan - jpn)"
                Return "jpn"
            Case "Japanese (Japan - jpn) (Translated)"
                Return "jpn-T"
            Case "Korean (Korea - kor)"
                Return "kor"
            Case "Korean (Korea - kor) (Translated)"
                Return "kor-T"
            Case "Danish (dan)"
                Return "dan"
            Case "Vietnamese (Vietnam - vtn)"
                Return "vtn"
            Case "Norwegian (nwg)"
                Return "nwg"
            Case Else
                Return "eng"
        End Select
    End Function

    Sub InitializeCombos()

        Dim Colors As New List(Of String)

        'Enumerate all colors and add to list
        For Each Enumed As ConsoleColors In [Enum].GetValues(GetType(ConsoleColors))
            Colors.Add(Enumed.ToString)
        Next

        'Add colors to list
        textColor.Items.AddRange(Colors.ToArray) : textColor.Items.Remove("Black") : textColor.Text = "Gray"
        licenseColor.Items.AddRange(Colors.ToArray) : licenseColor.Items.Remove("Black") : licenseColor.Text = "White"
        contError.Items.AddRange(Colors.ToArray) : contError.Items.Remove("Black") : contError.Text = "Yellow"
        userNameColor.Items.AddRange(Colors.ToArray) : userNameColor.Items.Remove("Black") : userNameColor.Text = "Green"
        hostNameColor.Items.AddRange(Colors.ToArray) : hostNameColor.Items.Remove("Black") : hostNameColor.Text = "DarkGreen"
        uncontError.Items.AddRange(Colors.ToArray) : uncontError.Items.Remove("Black") : uncontError.Text = "Red"
        backgroundColor.Items.AddRange(Colors.ToArray) : backgroundColor.Items.Remove("White") : backgroundColor.Text = "Black"
        inputColor.Items.AddRange(Colors.ToArray) : inputColor.Items.Remove("Black") : inputColor.Text = "White"
        CmdHelpColor.Items.AddRange(Colors.ToArray) : CmdHelpColor.Items.Remove("Black") : CmdHelpColor.Text = "DarkYellow"
        DefHelpColor.Items.AddRange(Colors.ToArray) : DefHelpColor.Items.Remove("Black") : DefHelpColor.Text = "DarkGray"
        StageColor.Items.AddRange(Colors.ToArray) : StageColor.Items.Remove("Black") : StageColor.Text = "Green"

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked Then
            textColor.Enabled = True
            licenseColor.Enabled = True
            contError.Enabled = True
            userNameColor.Enabled = True
            hostNameColor.Enabled = True
            uncontError.Enabled = True
            backgroundColor.Enabled = True
            inputColor.Enabled = True
            CmdHelpColor.Enabled = True
            DefHelpColor.Enabled = True
            StageColor.Enabled = True
            Button1.Enabled = True
        Else
            textColor.Enabled = False
            licenseColor.Enabled = False
            contError.Enabled = False
            userNameColor.Enabled = False
            hostNameColor.Enabled = False
            uncontError.Enabled = False
            backgroundColor.Enabled = False
            inputColor.Enabled = False
            CmdHelpColor.Enabled = False
            DefHelpColor.Enabled = False
            StageColor.Enabled = True
            Button1.Enabled = False
        End If

    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        Try
            'Save file before doing anything
            My.Computer.FileSystem.WriteAllText(confPath, "", False)
            Dim ksconf As New IniFile()

            'Set to default password if there is no password for "root"
            If (RootPwd.Text = "") Then
                RootPwd.Text = "toor"
            End If

            'The General Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "General",
                    New IniKey(ksconf, "Prompt for Arguments on Boot", BootPrompt.Checked),
                    New IniKey(ksconf, "Maintenance Mode", MaintMode.Checked),
                    New IniKey(ksconf, "Change Root Password", RootPC.Checked),
                    New IniKey(ksconf, "Set Root Password to", RootPwd.Text),
                    New IniKey(ksconf, "Create Demo Account", demo.Checked),
                    New IniKey(ksconf, "Customized Colors on Boot", CheckBox5.Checked),
                    New IniKey(ksconf, "Check for Updates on Startup", UpdateStart.Checked),
                    New IniKey(ksconf, "Language", SaveLocalization)))

            'The Colors Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "Colors",
                    New IniKey(ksconf, "User Name Shell Color", userNameColor.Text),
                    New IniKey(ksconf, "Host Name Shell Color", hostNameColor.Text),
                    New IniKey(ksconf, "Continuable Kernel Error Color", contError.Text),
                    New IniKey(ksconf, "Uncontinuable Kernel Error Color", uncontError.Text),
                    New IniKey(ksconf, "Text Color", textColor.Text),
                    New IniKey(ksconf, "License Color", licenseColor.Text),
                    New IniKey(ksconf, "Background Color", backgroundColor.Text),
                    New IniKey(ksconf, "Input Color", inputColor.Text),
                    New IniKey(ksconf, "Listed command in Help Color", CmdHelpColor.Text),
                    New IniKey(ksconf, "Definition of command in Help Color", DefHelpColor.Text),
                    New IniKey(ksconf, "Kernel Stage Color", StageColor.Text)))

            'The Hardware Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "Hardware",
                    New IniKey(ksconf, "Quiet Probe", probeQuiet.Checked),
                    New IniKey(ksconf, "Probe Slots", slotProbe.Checked)))

            'The Login Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "Login",
                    New IniKey(ksconf, "Show MOTD on Log-in", motdShow.Checked),
                    New IniKey(ksconf, "Clear Screen on Log-in", clslogin.Checked),
                    New IniKey(ksconf, "Host Name", HostName.Text)))

            'The Shell Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "Shell",
                    New IniKey(ksconf, "Colored Shell", colorShell.Checked),
                    New IniKey(ksconf, "Simplified Help Command", simHelp.Checked)))

            'Misc Section
            ksconf.Sections.Add(
                New IniSection(ksconf, "Misc",
                    New IniKey(ksconf, "Show Time/Date on Upper Right Corner", tdCorner.Checked),
                    New IniKey(ksconf, "Screensaver", Screensave.Text),
                    New IniKey(ksconf, "Debug Port", DebugPort.Text),
                    New IniKey(ksconf, "Debug Size Quota in Bytes", DebugMax.Text),
                    New IniKey(ksconf, "Remote Debug Default Nick Prefix", DebugNPrefix.Text),
                    New IniKey(ksconf, "Download Retry Times", RetryDownload.Text),
                    New IniKey(ksconf, "Log FTP username", LogFTPUsr.Checked),
                    New IniKey(ksconf, "Log FTP IP address", LogFTPIP.Checked),
                    New IniKey(ksconf, "Size parse mode", FullParseMode.Checked),
                    New IniKey(ksconf, "Marquee on startup", StartScroll.Checked),
                    New IniKey(ksconf, "Long Time and Date", LongTimeDate.Checked),
                    New IniKey(ksconf, "Show Hidden Files", HiddenFiles.Checked),
                    New IniKey(ksconf, "Kernel Version", Ver)))

            'Save Config
            ksconf.Save(confPath)
            MsgBox("Settings saved, but remember that your config will not be backwards-compatible with 0.0.5.2 or lower. You can:" + vbNewLine + vbNewLine +
                   "• Use ""reloadconfig"" on Kernel Simulator to see the changes," + vbNewLine +
                   "• Use ""reboot"" to see the changes, or" + vbNewLine +
                   "• Exit and re-open Kernel Simulator (recommended)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Settings saved successfully")
        Catch ex As IOException
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

    Private Sub ReadyLiveColor(ByVal sender As Object, ByVal e As System.EventArgs) Handles DefHelpColor.SelectedValueChanged, CmdHelpColor.SelectedValueChanged, backgroundColor.SelectedValueChanged, inputColor.SelectedValueChanged, userNameColor.SelectedValueChanged, hostNameColor.SelectedValueChanged, uncontError.SelectedValueChanged, contError.SelectedValueChanged, licenseColor.SelectedValueChanged, textColor.SelectedValueChanged
        If (Started = True) Then
            LiveColor.LoadColors()
            LiveColor.MakeBrightReadable()
            LiveColor.CorrectColors()
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub OpenSourceLibrariesUsedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSourceLibrariesUsedToolStripMenuItem.Click
        Libs.Show()
    End Sub

    Private Sub Screensave_SelectedValueChanged(sender As Object, e As EventArgs) Handles Screensave.SelectedValueChanged
        Select Case Screensave.Text
            Case "matrix", "disco", "disco255", "colorMix", "colorMix255", "glitterMatrix", "glitterColor", "glitterColor255", "lines", "lines255", "aptErrorSim", "hackUserFromAD"
                configReader.Sections("Misc").Keys("Screensaver").Value = Screensave.Text
            Case Else
                If ScreenOpen.ShowDialog() = DialogResult.OK Then 'TODO: Make a check for screensaver health
                    configReader.Sections("Misc").Keys("Screensaver").Value = ScreenOpen.SafeFileName
                End If
        End Select
    End Sub
End Class

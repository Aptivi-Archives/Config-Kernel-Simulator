﻿
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configurator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configurator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.userNameColor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hostNameColor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uncontError = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.contError = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.licenseColor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textColor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.RootPwd = New System.Windows.Forms.MaskedTextBox()
        Me.demo = New System.Windows.Forms.CheckBox()
        Me.RootPC = New System.Windows.Forms.CheckBox()
        Me.MaintMode = New System.Windows.Forms.CheckBox()
        Me.BootPrompt = New System.Windows.Forms.CheckBox()
        Me.LogIn = New System.Windows.Forms.TabPage()
        Me.clslogin = New System.Windows.Forms.CheckBox()
        Me.motdShow = New System.Windows.Forms.CheckBox()
        Me.Shell = New System.Windows.Forms.TabPage()
        Me.simHelp = New System.Windows.Forms.CheckBox()
        Me.colorShell = New System.Windows.Forms.CheckBox()
        Me.Hardware = New System.Windows.Forms.TabPage()
        Me.slotProbe = New System.Windows.Forms.CheckBox()
        Me.probeQuiet = New System.Windows.Forms.CheckBox()
        Me.gpuProbe = New System.Windows.Forms.CheckBox()
        Me.Others = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inputColor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.backgroundColor = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LogIn.SuspendLayout()
        Me.Shell.SuspendLayout()
        Me.Hardware.SuspendLayout()
        Me.Others.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Controls.Add(Me.LogIn)
        Me.TabControl1.Controls.Add(Me.Shell)
        Me.TabControl1.Controls.Add(Me.Hardware)
        Me.TabControl1.Controls.Add(Me.Others)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 353)
        Me.TabControl1.TabIndex = 1
        '
        'General
        '
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.RootPwd)
        Me.General.Controls.Add(Me.demo)
        Me.General.Controls.Add(Me.RootPC)
        Me.General.Controls.Add(Me.MaintMode)
        Me.General.Controls.Add(Me.BootPrompt)
        Me.General.Location = New System.Drawing.Point(4, 24)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(639, 325)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.userNameColor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.hostNameColor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.uncontError)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.contError)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.licenseColor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textColor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 210)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(505, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 30)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Live"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(583, 30)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Warning: When you choose the bright background color, you should set all text col" & _
            "ors into dark colors that is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "readable, or (at least), black. To confirm this, " & _
            "click on ""Live"" button."
        '
        'userNameColor
        '
        Me.userNameColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userNameColor.Enabled = False
        Me.userNameColor.FormattingEnabled = True
        Me.userNameColor.Location = New System.Drawing.Point(438, 119)
        Me.userNameColor.Name = "userNameColor"
        Me.userNameColor.Size = New System.Drawing.Size(168, 23)
        Me.userNameColor.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "User Name Shell Color"
        '
        'hostNameColor
        '
        Me.hostNameColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hostNameColor.Enabled = False
        Me.hostNameColor.FormattingEnabled = True
        Me.hostNameColor.Location = New System.Drawing.Point(227, 119)
        Me.hostNameColor.Name = "hostNameColor"
        Me.hostNameColor.Size = New System.Drawing.Size(168, 23)
        Me.hostNameColor.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Host Name Shell Color"
        '
        'uncontError
        '
        Me.uncontError.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uncontError.Enabled = False
        Me.uncontError.FormattingEnabled = True
        Me.uncontError.Location = New System.Drawing.Point(15, 119)
        Me.uncontError.Name = "uncontError"
        Me.uncontError.Size = New System.Drawing.Size(168, 23)
        Me.uncontError.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Uncontinuable Kernel Error Color"
        '
        'contError
        '
        Me.contError.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.contError.Enabled = False
        Me.contError.FormattingEnabled = True
        Me.contError.Location = New System.Drawing.Point(438, 66)
        Me.contError.Name = "contError"
        Me.contError.Size = New System.Drawing.Size(168, 23)
        Me.contError.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Continuable Kernel Error Color"
        '
        'licenseColor
        '
        Me.licenseColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.licenseColor.Enabled = False
        Me.licenseColor.FormattingEnabled = True
        Me.licenseColor.Location = New System.Drawing.Point(227, 66)
        Me.licenseColor.Name = "licenseColor"
        Me.licenseColor.Size = New System.Drawing.Size(168, 23)
        Me.licenseColor.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "License Color"
        '
        'textColor
        '
        Me.textColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.textColor.Enabled = False
        Me.textColor.FormattingEnabled = True
        Me.textColor.Location = New System.Drawing.Point(15, 66)
        Me.textColor.Name = "textColor"
        Me.textColor.Size = New System.Drawing.Size(168, 23)
        Me.textColor.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Text Color"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(15, 22)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Customized Colors on Boot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'RootPwd
        '
        Me.RootPwd.BeepOnError = True
        Me.RootPwd.Enabled = False
        Me.RootPwd.Location = New System.Drawing.Point(166, 60)
        Me.RootPwd.Name = "RootPwd"
        Me.RootPwd.Size = New System.Drawing.Size(462, 23)
        Me.RootPwd.TabIndex = 7
        Me.RootPwd.UseSystemPasswordChar = True
        '
        'demo
        '
        Me.demo.AutoSize = True
        Me.demo.Checked = True
        Me.demo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.demo.Location = New System.Drawing.Point(10, 87)
        Me.demo.Name = "demo"
        Me.demo.Size = New System.Drawing.Size(106, 19)
        Me.demo.TabIndex = 3
        Me.demo.Text = "Demo Account"
        Me.demo.UseVisualStyleBackColor = True
        '
        'RootPC
        '
        Me.RootPC.AutoSize = True
        Me.RootPC.Location = New System.Drawing.Point(10, 62)
        Me.RootPC.Name = "RootPC"
        Me.RootPC.Size = New System.Drawing.Size(151, 19)
        Me.RootPC.TabIndex = 2
        Me.RootPC.Text = "Root Password Change:"
        Me.RootPC.UseVisualStyleBackColor = True
        '
        'MaintMode
        '
        Me.MaintMode.AutoSize = True
        Me.MaintMode.Location = New System.Drawing.Point(10, 37)
        Me.MaintMode.Name = "MaintMode"
        Me.MaintMode.Size = New System.Drawing.Size(129, 19)
        Me.MaintMode.TabIndex = 1
        Me.MaintMode.Text = "Maintenance Mode"
        Me.MaintMode.UseVisualStyleBackColor = True
        '
        'BootPrompt
        '
        Me.BootPrompt.AutoSize = True
        Me.BootPrompt.Location = New System.Drawing.Point(10, 12)
        Me.BootPrompt.Name = "BootPrompt"
        Me.BootPrompt.Size = New System.Drawing.Size(191, 19)
        Me.BootPrompt.TabIndex = 0
        Me.BootPrompt.Text = "Prompt for Arguments on Boot"
        Me.BootPrompt.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.Controls.Add(Me.clslogin)
        Me.LogIn.Controls.Add(Me.motdShow)
        Me.LogIn.Location = New System.Drawing.Point(4, 24)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Padding = New System.Windows.Forms.Padding(3)
        Me.LogIn.Size = New System.Drawing.Size(639, 325)
        Me.LogIn.TabIndex = 1
        Me.LogIn.Text = "Log in"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'clslogin
        '
        Me.clslogin.AutoSize = True
        Me.clslogin.Location = New System.Drawing.Point(10, 37)
        Me.clslogin.Name = "clslogin"
        Me.clslogin.Size = New System.Drawing.Size(131, 17)
        Me.clslogin.TabIndex = 1
        Me.clslogin.Text = "Clear Screen on Login"
        Me.clslogin.UseVisualStyleBackColor = True
        '
        'motdShow
        '
        Me.motdShow.AutoSize = True
        Me.motdShow.Checked = True
        Me.motdShow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.motdShow.Location = New System.Drawing.Point(10, 12)
        Me.motdShow.Name = "motdShow"
        Me.motdShow.Size = New System.Drawing.Size(132, 17)
        Me.motdShow.TabIndex = 0
        Me.motdShow.Text = "Show MOTD on Login"
        Me.motdShow.UseVisualStyleBackColor = True
        '
        'Shell
        '
        Me.Shell.Controls.Add(Me.simHelp)
        Me.Shell.Controls.Add(Me.colorShell)
        Me.Shell.Location = New System.Drawing.Point(4, 24)
        Me.Shell.Name = "Shell"
        Me.Shell.Size = New System.Drawing.Size(639, 325)
        Me.Shell.TabIndex = 2
        Me.Shell.Text = "Shell"
        Me.Shell.UseVisualStyleBackColor = True
        '
        'simHelp
        '
        Me.simHelp.AutoSize = True
        Me.simHelp.Location = New System.Drawing.Point(10, 37)
        Me.simHelp.Name = "simHelp"
        Me.simHelp.Size = New System.Drawing.Size(145, 17)
        Me.simHelp.TabIndex = 1
        Me.simHelp.Text = "Simplified Help Command"
        Me.simHelp.UseVisualStyleBackColor = True
        '
        'colorShell
        '
        Me.colorShell.AutoSize = True
        Me.colorShell.Checked = True
        Me.colorShell.CheckState = System.Windows.Forms.CheckState.Checked
        Me.colorShell.Location = New System.Drawing.Point(10, 12)
        Me.colorShell.Name = "colorShell"
        Me.colorShell.Size = New System.Drawing.Size(88, 17)
        Me.colorShell.TabIndex = 0
        Me.colorShell.Text = "Colored Shell"
        Me.colorShell.UseVisualStyleBackColor = True
        '
        'Hardware
        '
        Me.Hardware.Controls.Add(Me.slotProbe)
        Me.Hardware.Controls.Add(Me.probeQuiet)
        Me.Hardware.Controls.Add(Me.gpuProbe)
        Me.Hardware.Location = New System.Drawing.Point(4, 24)
        Me.Hardware.Name = "Hardware"
        Me.Hardware.Size = New System.Drawing.Size(639, 325)
        Me.Hardware.TabIndex = 3
        Me.Hardware.Text = "Hardware"
        Me.Hardware.UseVisualStyleBackColor = True
        '
        'slotProbe
        '
        Me.slotProbe.AutoSize = True
        Me.slotProbe.Checked = True
        Me.slotProbe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.slotProbe.Location = New System.Drawing.Point(10, 62)
        Me.slotProbe.Name = "slotProbe"
        Me.slotProbe.Size = New System.Drawing.Size(290, 17)
        Me.slotProbe.TabIndex = 3
        Me.slotProbe.Text = "Probe Slots by Name and by Numbers (and Percentage)"
        Me.slotProbe.UseVisualStyleBackColor = True
        '
        'probeQuiet
        '
        Me.probeQuiet.AutoSize = True
        Me.probeQuiet.Location = New System.Drawing.Point(10, 37)
        Me.probeQuiet.Name = "probeQuiet"
        Me.probeQuiet.Size = New System.Drawing.Size(82, 17)
        Me.probeQuiet.TabIndex = 1
        Me.probeQuiet.Text = "Quiet Probe"
        Me.probeQuiet.UseVisualStyleBackColor = True
        '
        'gpuProbe
        '
        Me.gpuProbe.AutoSize = True
        Me.gpuProbe.Location = New System.Drawing.Point(10, 12)
        Me.gpuProbe.Name = "gpuProbe"
        Me.gpuProbe.Size = New System.Drawing.Size(80, 17)
        Me.gpuProbe.TabIndex = 0
        Me.gpuProbe.Text = "Probe GPU"
        Me.gpuProbe.UseVisualStyleBackColor = True
        '
        'Others
        '
        Me.Others.Controls.Add(Me.Label8)
        Me.Others.Controls.Add(Me.inputColor)
        Me.Others.Controls.Add(Me.Label7)
        Me.Others.Controls.Add(Me.backgroundColor)
        Me.Others.Location = New System.Drawing.Point(4, 24)
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(639, 325)
        Me.Others.TabIndex = 4
        Me.Others.Text = "Others"
        Me.Others.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Input Color:"
        '
        'inputColor
        '
        Me.inputColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inputColor.FormattingEnabled = True
        Me.inputColor.Location = New System.Drawing.Point(138, 39)
        Me.inputColor.Name = "inputColor"
        Me.inputColor.Size = New System.Drawing.Size(489, 23)
        Me.inputColor.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Background Color:"
        '
        'backgroundColor
        '
        Me.backgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.backgroundColor.FormattingEnabled = True
        Me.backgroundColor.Location = New System.Drawing.Point(138, 10)
        Me.backgroundColor.Name = "backgroundColor"
        Me.backgroundColor.Size = New System.Drawing.Size(489, 23)
        Me.backgroundColor.TabIndex = 8
        '
        'Configurator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 390)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Configurator"
        Me.Text = "Kernel Simulator Configuration Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.LogIn.ResumeLayout(False)
        Me.LogIn.PerformLayout()
        Me.Shell.ResumeLayout(False)
        Me.Shell.PerformLayout()
        Me.Hardware.ResumeLayout(False)
        Me.Hardware.PerformLayout()
        Me.Others.ResumeLayout(False)
        Me.Others.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents userNameColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hostNameColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents uncontError As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents contError As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents licenseColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents RootPwd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents demo As System.Windows.Forms.CheckBox
    Friend WithEvents RootPC As System.Windows.Forms.CheckBox
    Friend WithEvents MaintMode As System.Windows.Forms.CheckBox
    Friend WithEvents BootPrompt As System.Windows.Forms.CheckBox
    Friend WithEvents LogIn As System.Windows.Forms.TabPage
    Friend WithEvents clslogin As System.Windows.Forms.CheckBox
    Friend WithEvents motdShow As System.Windows.Forms.CheckBox
    Friend WithEvents Shell As System.Windows.Forms.TabPage
    Friend WithEvents simHelp As System.Windows.Forms.CheckBox
    Friend WithEvents colorShell As System.Windows.Forms.CheckBox
    Friend WithEvents Hardware As System.Windows.Forms.TabPage
    Friend WithEvents slotProbe As System.Windows.Forms.CheckBox
    Friend WithEvents probeQuiet As System.Windows.Forms.CheckBox
    Friend WithEvents Others As System.Windows.Forms.TabPage
    Friend WithEvents backgroundColor As System.Windows.Forms.ComboBox
    Friend WithEvents gpuProbe As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents inputColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
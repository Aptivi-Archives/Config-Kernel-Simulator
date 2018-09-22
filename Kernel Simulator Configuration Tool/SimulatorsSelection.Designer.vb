
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
Partial Class SimulatorsSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimulatorsSelection))
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.cancelButtonList = New System.Windows.Forms.Button()
        Me.statBottomBar = New System.Windows.Forms.StatusStrip()
        Me.statBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.statText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.population = New System.ComponentModel.BackgroundWorker()
        Me.Simulators = New System.Windows.Forms.ListView()
        Me.PathAndName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Version = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(12, 470)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(116, 29)
        Me.refreshButton.TabIndex = 1
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OKButton.Location = New System.Drawing.Point(815, 470)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(116, 29)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'cancelButtonList
        '
        Me.cancelButtonList.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButtonList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cancelButtonList.Location = New System.Drawing.Point(937, 470)
        Me.cancelButtonList.Name = "cancelButtonList"
        Me.cancelButtonList.Size = New System.Drawing.Size(116, 29)
        Me.cancelButtonList.TabIndex = 3
        Me.cancelButtonList.Text = "Cancel"
        Me.cancelButtonList.UseVisualStyleBackColor = True
        '
        'statBottomBar
        '
        Me.statBottomBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.statBottomBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statBar, Me.statText})
        Me.statBottomBar.Location = New System.Drawing.Point(0, 505)
        Me.statBottomBar.Name = "statBottomBar"
        Me.statBottomBar.Size = New System.Drawing.Size(1061, 22)
        Me.statBottomBar.TabIndex = 5
        Me.statBottomBar.Text = "StatusStrip1"
        '
        'statBar
        '
        Me.statBar.Name = "statBar"
        Me.statBar.Size = New System.Drawing.Size(100, 16)
        '
        'statText
        '
        Me.statText.Name = "statText"
        Me.statText.Size = New System.Drawing.Size(41, 17)
        Me.statText.Text = "Ready!"
        '
        'population
        '
        '
        'Simulators
        '
        Me.Simulators.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PathAndName, Me.Version})
        Me.Simulators.FullRowSelect = True
        Me.Simulators.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Simulators.HideSelection = False
        Me.Simulators.Location = New System.Drawing.Point(12, 11)
        Me.Simulators.MultiSelect = False
        Me.Simulators.Name = "Simulators"
        Me.Simulators.Size = New System.Drawing.Size(1041, 453)
        Me.Simulators.TabIndex = 6
        Me.Simulators.UseCompatibleStateImageBehavior = False
        Me.Simulators.View = System.Windows.Forms.View.Details
        '
        'PathAndName
        '
        Me.PathAndName.Text = "Path and Name"
        Me.PathAndName.Width = 926
        '
        'Version
        '
        Me.Version.Text = "Version"
        Me.Version.Width = 110
        '
        'SimulatorsSelection
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelButtonList
        Me.ClientSize = New System.Drawing.Size(1061, 527)
        Me.Controls.Add(Me.Simulators)
        Me.Controls.Add(Me.statBottomBar)
        Me.Controls.Add(Me.cancelButtonList)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SimulatorsSelection"
        Me.Text = "Found 0 Simulators - Choose one from the list and click OK to create a config fil" & _
            "e."
        Me.statBottomBar.ResumeLayout(False)
        Me.statBottomBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents cancelButtonList As System.Windows.Forms.Button
    Friend WithEvents statBottomBar As System.Windows.Forms.StatusStrip
    Friend WithEvents statBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents statText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents population As System.ComponentModel.BackgroundWorker
    Friend WithEvents Simulators As System.Windows.Forms.ListView
    Friend WithEvents PathAndName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Version As System.Windows.Forms.ColumnHeader

End Class

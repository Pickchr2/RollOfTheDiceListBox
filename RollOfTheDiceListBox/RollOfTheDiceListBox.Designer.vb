<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollOfTheDiceListBox
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
        Me.components = New System.ComponentModel.Container()
        Me.RollTheDiceMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollResultListBox = New System.Windows.Forms.ListBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.RollTheDiceLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RollTheDiceMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RollTheDiceMenuStrip
        '
        Me.RollTheDiceMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.RollTheDiceMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.RollTheDiceMenuStrip.Name = "RollTheDiceMenuStrip"
        Me.RollTheDiceMenuStrip.Size = New System.Drawing.Size(473, 24)
        Me.RollTheDiceMenuStrip.TabIndex = 0
        Me.RollTheDiceMenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'RollToolStripMenuItem
        '
        Me.RollToolStripMenuItem.Name = "RollToolStripMenuItem"
        Me.RollToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RollToolStripMenuItem.Text = "Roll"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'RollResultListBox
        '
        Me.RollResultListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RollResultListBox.FormattingEnabled = True
        Me.RollResultListBox.ItemHeight = 21
        Me.RollResultListBox.Location = New System.Drawing.Point(9, 75)
        Me.RollResultListBox.Name = "RollResultListBox"
        Me.RollResultListBox.Size = New System.Drawing.Size(454, 214)
        Me.RollResultListBox.TabIndex = 2
        Me.RollResultListBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(291, 304)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click to exit the application.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(196, 304)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click to clear the results.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(101, 304)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(75, 23)
        Me.RollButton.TabIndex = 3
        Me.RollButton.Text = "&Roll"
        Me.ToolTip1.SetToolTip(Me.RollButton, "Click to see the results of 1000 two 6-sided dice rolls.")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'RollTheDiceLabel
        '
        Me.RollTheDiceLabel.AutoSize = True
        Me.RollTheDiceLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RollTheDiceLabel.Location = New System.Drawing.Point(16, 33)
        Me.RollTheDiceLabel.Name = "RollTheDiceLabel"
        Me.RollTheDiceLabel.Size = New System.Drawing.Size(439, 32)
        Me.RollTheDiceLabel.TabIndex = 1
        Me.RollTheDiceLabel.Text = "Roll The Dice Results from 1000 Rolls"
        '
        'RollOfTheDiceListBox
        '
        Me.AcceptButton = Me.RollButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(473, 340)
        Me.Controls.Add(Me.RollTheDiceLabel)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollResultListBox)
        Me.Controls.Add(Me.RollTheDiceMenuStrip)
        Me.MainMenuStrip = Me.RollTheDiceMenuStrip
        Me.Name = "RollOfTheDiceListBox"
        Me.Text = "Roll of the dice"
        Me.RollTheDiceMenuStrip.ResumeLayout(False)
        Me.RollTheDiceMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollTheDiceMenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollResultListBox As ListBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents RollButton As Button
    Friend WithEvents RollTheDiceLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

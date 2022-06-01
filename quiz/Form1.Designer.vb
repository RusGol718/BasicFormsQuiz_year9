<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdOptionA = New System.Windows.Forms.Button()
        Me.cmdOptionB = New System.Windows.Forms.Button()
        Me.cmdOptionC = New System.Windows.Forms.Button()
        Me.lblQuestionText = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptionA
        '
        Me.cmdOptionA.Location = New System.Drawing.Point(23, 113)
        Me.cmdOptionA.Name = "cmdOptionA"
        Me.cmdOptionA.Size = New System.Drawing.Size(100, 44)
        Me.cmdOptionA.TabIndex = 0
        Me.cmdOptionA.Text = "A"
        Me.cmdOptionA.UseVisualStyleBackColor = True
        '
        'cmdOptionB
        '
        Me.cmdOptionB.Location = New System.Drawing.Point(141, 113)
        Me.cmdOptionB.Name = "cmdOptionB"
        Me.cmdOptionB.Size = New System.Drawing.Size(98, 43)
        Me.cmdOptionB.TabIndex = 1
        Me.cmdOptionB.Text = "Button2"
        Me.cmdOptionB.UseVisualStyleBackColor = True
        '
        'cmdOptionC
        '
        Me.cmdOptionC.Location = New System.Drawing.Point(257, 113)
        Me.cmdOptionC.Name = "cmdOptionC"
        Me.cmdOptionC.Size = New System.Drawing.Size(95, 43)
        Me.cmdOptionC.TabIndex = 2
        Me.cmdOptionC.Text = "Button3"
        Me.cmdOptionC.UseVisualStyleBackColor = True
        '
        'lblQuestionText
        '
        Me.lblQuestionText.AutoSize = True
        Me.lblQuestionText.Location = New System.Drawing.Point(84, 49)
        Me.lblQuestionText.Name = "lblQuestionText"
        Me.lblQuestionText.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestionText.TabIndex = 4
        Me.lblQuestionText.Text = "Label1"
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Location = New System.Drawing.Point(20, 49)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestionNumber.TabIndex = 5
        Me.lblQuestionNumber.Text = "Label2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 261)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.lblQuestionText)
        Me.Controls.Add(Me.cmdOptionC)
        Me.Controls.Add(Me.cmdOptionB)
        Me.Controls.Add(Me.cmdOptionA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Amazing Quiz"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOptionA As System.Windows.Forms.Button
    Friend WithEvents cmdOptionB As System.Windows.Forms.Button
    Friend WithEvents cmdOptionC As System.Windows.Forms.Button
    Friend WithEvents lblQuestionText As System.Windows.Forms.Label
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

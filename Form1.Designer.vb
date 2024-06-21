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
        Me.viewBtn = New System.Windows.Forms.Button()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewBtn
        '
        Me.viewBtn.BackColor = System.Drawing.SystemColors.Info
        Me.viewBtn.ImageKey = "(none)"
        Me.viewBtn.Location = New System.Drawing.Point(23, 103)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(352, 42)
        Me.viewBtn.TabIndex = 0
        Me.viewBtn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.viewBtn.UseVisualStyleBackColor = False
        '
        'createBtn
        '
        Me.createBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.createBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.createBtn.Location = New System.Drawing.Point(23, 151)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(352, 41)
        Me.createBtn.TabIndex = 1
        Me.createBtn.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.createBtn.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.viewBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents viewBtn As Button
    Friend WithEvents createBtn As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
End Class

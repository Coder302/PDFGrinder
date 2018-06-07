<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressForm
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
        Me.ProgFiles = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.ProgPages = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.ProgSize = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTimeElapsed = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgFiles
        '
        Me.ProgFiles.Location = New System.Drawing.Point(83, 18)
        Me.ProgFiles.Name = "ProgFiles"
        Me.ProgFiles.Size = New System.Drawing.Size(380, 23)
        Me.ProgFiles.Step = 1
        Me.ProgFiles.TabIndex = 20
        Me.ProgFiles.Text = "[Formatted]"
        '
        'ProgPages
        '
        Me.ProgPages.Location = New System.Drawing.Point(83, 54)
        Me.ProgPages.Name = "ProgPages"
        Me.ProgPages.Size = New System.Drawing.Size(380, 23)
        Me.ProgPages.Step = 1
        Me.ProgPages.TabIndex = 21
        Me.ProgPages.Text = "[Formatted]"
        '
        'ProgSize
        '
        Me.ProgSize.Location = New System.Drawing.Point(83, 90)
        Me.ProgSize.Name = "ProgSize"
        Me.ProgSize.Size = New System.Drawing.Size(380, 23)
        Me.ProgSize.Step = 1
        Me.ProgSize.TabIndex = 22
        Me.ProgSize.Text = "[Formatted]"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(199, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Abort"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Files"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Pages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Size"
        '
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.AutoSize = True
        Me.lblTimeElapsed.Location = New System.Drawing.Point(83, 120)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(94, 17)
        Me.lblTimeElapsed.TabIndex = 27
        Me.lblTimeElapsed.Text = "Time Elapsed"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Location = New System.Drawing.Point(83, 137)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(110, 17)
        Me.lblTimeLeft.TabIndex = 28
        Me.lblTimeLeft.Text = "Time Remaining"
        '
        'ProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblTimeElapsed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ProgSize)
        Me.Controls.Add(Me.ProgPages)
        Me.Controls.Add(Me.ProgFiles)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ProgressForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Processing Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgFiles As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents ProgPages As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents ProgSize As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents lblTimeLeft As Label
End Class

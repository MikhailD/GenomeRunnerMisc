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
        Me.btnExtractAllGFs = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnRandFOIs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExtractAllGFs
        '
        Me.btnExtractAllGFs.Location = New System.Drawing.Point(12, 45)
        Me.btnExtractAllGFs.Name = "btnExtractAllGFs"
        Me.btnExtractAllGFs.Size = New System.Drawing.Size(96, 23)
        Me.btnExtractAllGFs.TabIndex = 0
        Me.btnExtractAllGFs.Text = "Extract All GFs"
        Me.btnExtractAllGFs.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 12)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(96, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnRandFOIs
        '
        Me.btnRandFOIs.Location = New System.Drawing.Point(12, 76)
        Me.btnRandFOIs.Name = "btnRandFOIs"
        Me.btnRandFOIs.Size = New System.Drawing.Size(96, 23)
        Me.btnRandFOIs.TabIndex = 2
        Me.btnRandFOIs.Text = "Create rand FOIs"
        Me.btnRandFOIs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 262)
        Me.Controls.Add(Me.btnRandFOIs)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnExtractAllGFs)
        Me.Name = "Form1"
        Me.Text = "GenomeRunnerMisc"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExtractAllGFs As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnRandFOIs As System.Windows.Forms.Button

End Class

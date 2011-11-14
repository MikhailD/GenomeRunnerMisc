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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.rbtnPipe = New System.Windows.Forms.RadioButton()
        Me.rbtnComma = New System.Windows.Forms.RadioButton()
        Me.rbtn3stars = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnSourceID = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExtractAllGFs
        '
        Me.btnExtractAllGFs.Location = New System.Drawing.Point(389, 45)
        Me.btnExtractAllGFs.Name = "btnExtractAllGFs"
        Me.btnExtractAllGFs.Size = New System.Drawing.Size(96, 23)
        Me.btnExtractAllGFs.TabIndex = 0
        Me.btnExtractAllGFs.Text = "Extract All GFs"
        Me.btnExtractAllGFs.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(389, 12)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(96, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnRandFOIs
        '
        Me.btnRandFOIs.Location = New System.Drawing.Point(389, 76)
        Me.btnRandFOIs.Name = "btnRandFOIs"
        Me.btnRandFOIs.Size = New System.Drawing.Size(96, 23)
        Me.btnRandFOIs.TabIndex = 2
        Me.btnRandFOIs.Text = "Create rand FOIs"
        Me.btnRandFOIs.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(3, 220)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert!"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(143, 198)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RefSeq ID to name converter"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(3, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(3, 249)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'rbtnPipe
        '
        Me.rbtnPipe.AutoSize = True
        Me.rbtnPipe.Checked = True
        Me.rbtnPipe.Location = New System.Drawing.Point(9, 21)
        Me.rbtnPipe.Name = "rbtnPipe"
        Me.rbtnPipe.Size = New System.Drawing.Size(46, 17)
        Me.rbtnPipe.TabIndex = 9
        Me.rbtnPipe.TabStop = True
        Me.rbtnPipe.Text = "Pipe"
        Me.rbtnPipe.UseVisualStyleBackColor = True
        '
        'rbtnComma
        '
        Me.rbtnComma.AutoSize = True
        Me.rbtnComma.Location = New System.Drawing.Point(9, 44)
        Me.rbtnComma.Name = "rbtnComma"
        Me.rbtnComma.Size = New System.Drawing.Size(60, 17)
        Me.rbtnComma.TabIndex = 10
        Me.rbtnComma.TabStop = True
        Me.rbtnComma.Text = "Comma"
        Me.rbtnComma.UseVisualStyleBackColor = True
        '
        'rbtn3stars
        '
        Me.rbtn3stars.AutoSize = True
        Me.rbtn3stars.Checked = True
        Me.rbtn3stars.Location = New System.Drawing.Point(6, 19)
        Me.rbtn3stars.Name = "rbtn3stars"
        Me.rbtn3stars.Size = New System.Drawing.Size(37, 17)
        Me.rbtn3stars.TabIndex = 12
        Me.rbtn3stars.TabStop = True
        Me.rbtn3stars.Text = "***"
        Me.rbtn3stars.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnComma)
        Me.GroupBox1.Controls.Add(Me.rbtnPipe)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 66)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Separator"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnSourceID)
        Me.GroupBox2.Controls.Add(Me.rbtn3stars)
        Me.GroupBox2.Location = New System.Drawing.Point(160, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 63)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "If not converted, replace by"
        '
        'rbtnSourceID
        '
        Me.rbtnSourceID.AutoSize = True
        Me.rbtnSourceID.Location = New System.Drawing.Point(6, 40)
        Me.rbtnSourceID.Name = "rbtnSourceID"
        Me.rbtnSourceID.Size = New System.Drawing.Size(73, 17)
        Me.rbtnSourceID.TabIndex = 13
        Me.rbtnSourceID.Text = "Source ID"
        Me.rbtnSourceID.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 307)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRandFOIs)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnExtractAllGFs)
        Me.Name = "Form1"
        Me.Text = "GenomeRunnerMisc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExtractAllGFs As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnRandFOIs As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents rbtnPipe As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnComma As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn3stars As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnSourceID As System.Windows.Forms.RadioButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(64, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBlue)
        Me.GroupBox1.Controls.Add(Me.radGreen)
        Me.GroupBox1.Controls.Add(Me.radRed)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 121)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(15, 85)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 2
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "&Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(15, 62)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 1
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "&Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Checked = True
        Me.radRed.Location = New System.Drawing.Point(15, 39)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "&Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(177, 71)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 101)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(177, 127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(16, 199)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 24)
        Me.lblResult.TabIndex = 6
        '
        'Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Q1"
        Me.Text = "P2Q1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radRed As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class

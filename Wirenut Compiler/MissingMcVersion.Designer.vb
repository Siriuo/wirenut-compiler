<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissingMcVersion
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
        Me.skipMissingInfo = New System.Windows.Forms.Button()
        Me.submitMissingInfo = New System.Windows.Forms.Button()
        Me.missingLabelInfo = New System.Windows.Forms.Label()
        Me.missingFormInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'skipMissingInfo
        '
        Me.skipMissingInfo.Location = New System.Drawing.Point(246, 80)
        Me.skipMissingInfo.Name = "skipMissingInfo"
        Me.skipMissingInfo.Size = New System.Drawing.Size(226, 60)
        Me.skipMissingInfo.TabIndex = 7
        Me.skipMissingInfo.Text = "Skip"
        Me.skipMissingInfo.UseVisualStyleBackColor = True
        '
        'submitMissingInfo
        '
        Me.submitMissingInfo.Location = New System.Drawing.Point(12, 80)
        Me.submitMissingInfo.Name = "submitMissingInfo"
        Me.submitMissingInfo.Size = New System.Drawing.Size(226, 60)
        Me.submitMissingInfo.TabIndex = 6
        Me.submitMissingInfo.Text = "Submit"
        Me.submitMissingInfo.UseVisualStyleBackColor = True
        '
        'missingLabelInfo
        '
        Me.missingLabelInfo.Location = New System.Drawing.Point(12, 11)
        Me.missingLabelInfo.Name = "missingLabelInfo"
        Me.missingLabelInfo.Size = New System.Drawing.Size(460, 40)
        Me.missingLabelInfo.TabIndex = 5
        Me.missingLabelInfo.Text = "Some Information is Missing"
        '
        'missingFormInput
        '
        Me.missingFormInput.Location = New System.Drawing.Point(15, 54)
        Me.missingFormInput.Name = "missingFormInput"
        Me.missingFormInput.Size = New System.Drawing.Size(457, 20)
        Me.missingFormInput.TabIndex = 4
        '
        'MissingMcVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 150)
        Me.Controls.Add(Me.skipMissingInfo)
        Me.Controls.Add(Me.submitMissingInfo)
        Me.Controls.Add(Me.missingLabelInfo)
        Me.Controls.Add(Me.missingFormInput)
        Me.Name = "MissingMcVersion"
        Me.Text = "Missing Minecraft Version"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents skipMissingInfo As Button
    Friend WithEvents submitMissingInfo As Button
    Friend WithEvents missingLabelInfo As Label
    Friend WithEvents missingFormInput As TextBox
End Class

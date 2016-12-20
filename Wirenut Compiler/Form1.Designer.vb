<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.folderOpenPath = New System.Windows.Forms.TextBox()
        Me.folderOpenBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.folderSavePath = New System.Windows.Forms.TextBox()
        Me.folderSaveBrowse = New System.Windows.Forms.Button()
        Me.convertSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'folderOpenPath
        '
        Me.folderOpenPath.Location = New System.Drawing.Point(12, 29)
        Me.folderOpenPath.Name = "folderOpenPath"
        Me.folderOpenPath.Size = New System.Drawing.Size(356, 20)
        Me.folderOpenPath.TabIndex = 0
        '
        'folderOpenBrowse
        '
        Me.folderOpenBrowse.Location = New System.Drawing.Point(374, 29)
        Me.folderOpenBrowse.Name = "folderOpenBrowse"
        Me.folderOpenBrowse.Size = New System.Drawing.Size(75, 23)
        Me.folderOpenBrowse.TabIndex = 1
        Me.folderOpenBrowse.Text = "Browse"
        Me.folderOpenBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Browse for the folder containing all the mods"
        '
        'folderSavePath
        '
        Me.folderSavePath.Location = New System.Drawing.Point(12, 81)
        Me.folderSavePath.Name = "folderSavePath"
        Me.folderSavePath.Size = New System.Drawing.Size(356, 20)
        Me.folderSavePath.TabIndex = 3
        '
        'folderSaveBrowse
        '
        Me.folderSaveBrowse.Location = New System.Drawing.Point(374, 81)
        Me.folderSaveBrowse.Name = "folderSaveBrowse"
        Me.folderSaveBrowse.Size = New System.Drawing.Size(75, 23)
        Me.folderSaveBrowse.TabIndex = 4
        Me.folderSaveBrowse.Text = "Browse"
        Me.folderSaveBrowse.UseVisualStyleBackColor = True
        '
        'convertSave
        '
        Me.convertSave.Location = New System.Drawing.Point(12, 110)
        Me.convertSave.Name = "convertSave"
        Me.convertSave.Size = New System.Drawing.Size(437, 49)
        Me.convertSave.TabIndex = 5
        Me.convertSave.Text = "Convert & Save"
        Me.convertSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Choose the save location"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 165)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(437, 23)
        Me.progressBar.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 196)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.convertSave)
        Me.Controls.Add(Me.folderSaveBrowse)
        Me.Controls.Add(Me.folderSavePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.folderOpenBrowse)
        Me.Controls.Add(Me.folderOpenPath)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents folderBrowser As FolderBrowserDialog
    Friend WithEvents folderOpenPath As TextBox
    Friend WithEvents folderOpenBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents folderSavePath As TextBox
    Friend WithEvents folderSaveBrowse As Button
    Friend WithEvents convertSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents progressBar As ProgressBar
End Class

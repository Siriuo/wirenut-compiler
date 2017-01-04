<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.conversionMethod = New System.Windows.Forms.GroupBox()
        Me.conversionMethodModInfo = New System.Windows.Forms.RadioButton()
        Me.conversionMethodFileName = New System.Windows.Forms.RadioButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.conversionMethod.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'folderOpenPath
        '
        Me.folderOpenPath.Location = New System.Drawing.Point(12, 93)
        Me.folderOpenPath.Name = "folderOpenPath"
        Me.folderOpenPath.Size = New System.Drawing.Size(356, 20)
        Me.folderOpenPath.TabIndex = 0
        '
        'folderOpenBrowse
        '
        Me.folderOpenBrowse.Location = New System.Drawing.Point(374, 93)
        Me.folderOpenBrowse.Name = "folderOpenBrowse"
        Me.folderOpenBrowse.Size = New System.Drawing.Size(75, 23)
        Me.folderOpenBrowse.TabIndex = 1
        Me.folderOpenBrowse.Text = "Browse"
        Me.folderOpenBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Browse for the folder containing all the mods"
        '
        'folderSavePath
        '
        Me.folderSavePath.Location = New System.Drawing.Point(12, 145)
        Me.folderSavePath.Name = "folderSavePath"
        Me.folderSavePath.Size = New System.Drawing.Size(356, 20)
        Me.folderSavePath.TabIndex = 3
        '
        'folderSaveBrowse
        '
        Me.folderSaveBrowse.Location = New System.Drawing.Point(374, 145)
        Me.folderSaveBrowse.Name = "folderSaveBrowse"
        Me.folderSaveBrowse.Size = New System.Drawing.Size(75, 23)
        Me.folderSaveBrowse.TabIndex = 4
        Me.folderSaveBrowse.Text = "Browse"
        Me.folderSaveBrowse.UseVisualStyleBackColor = True
        '
        'convertSave
        '
        Me.convertSave.Location = New System.Drawing.Point(12, 174)
        Me.convertSave.Name = "convertSave"
        Me.convertSave.Size = New System.Drawing.Size(437, 49)
        Me.convertSave.TabIndex = 5
        Me.convertSave.Text = "Convert && Save"
        Me.convertSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Choose the save location"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 229)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(437, 23)
        Me.progressBar.TabIndex = 7
        '
        'conversionMethod
        '
        Me.conversionMethod.Controls.Add(Me.conversionMethodModInfo)
        Me.conversionMethod.Controls.Add(Me.conversionMethodFileName)
        Me.conversionMethod.Location = New System.Drawing.Point(12, 37)
        Me.conversionMethod.Name = "conversionMethod"
        Me.conversionMethod.Size = New System.Drawing.Size(437, 37)
        Me.conversionMethod.TabIndex = 8
        Me.conversionMethod.TabStop = False
        Me.conversionMethod.Text = "Conversion Method"
        '
        'conversionMethodModInfo
        '
        Me.conversionMethodModInfo.AutoSize = True
        Me.conversionMethodModInfo.Location = New System.Drawing.Point(103, 14)
        Me.conversionMethodModInfo.Name = "conversionMethodModInfo"
        Me.conversionMethodModInfo.Size = New System.Drawing.Size(67, 17)
        Me.conversionMethodModInfo.TabIndex = 1
        Me.conversionMethodModInfo.Text = "Mod Info"
        Me.conversionMethodModInfo.UseVisualStyleBackColor = True
        '
        'conversionMethodFileName
        '
        Me.conversionMethodFileName.AutoSize = True
        Me.conversionMethodFileName.Checked = True
        Me.conversionMethodFileName.Location = New System.Drawing.Point(7, 14)
        Me.conversionMethodFileName.Name = "conversionMethodFileName"
        Me.conversionMethodFileName.Size = New System.Drawing.Size(72, 17)
        Me.conversionMethodFileName.TabIndex = 0
        Me.conversionMethodFileName.TabStop = True
        Me.conversionMethodFileName.Text = "File Name"
        Me.conversionMethodFileName.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(461, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 264)
        Me.Controls.Add(Me.conversionMethod)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.convertSave)
        Me.Controls.Add(Me.folderSaveBrowse)
        Me.Controls.Add(Me.folderSavePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.folderOpenBrowse)
        Me.Controls.Add(Me.folderOpenPath)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Wirenut Compiler"
        Me.conversionMethod.ResumeLayout(False)
        Me.conversionMethod.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
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
    Friend WithEvents conversionMethod As GroupBox
    Friend WithEvents conversionMethodModInfo As RadioButton
    Friend WithEvents conversionMethodFileName As RadioButton
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

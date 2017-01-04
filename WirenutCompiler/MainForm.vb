Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.Compression

Imports System.Reflection

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq



Public Class MainForm
    Private Sub folderOpenBrowse_Click(sender As Object, e As EventArgs) Handles folderOpenBrowse.Click
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            folderOpenPath.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub folderSaveBrowse_Click(sender As Object, e As EventArgs) Handles folderSaveBrowse.Click
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            folderSavePath.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub convertSave_Click(sender As Object, e As EventArgs) Handles convertSave.Click

        Dim openPath As String = folderOpenPath.Text
        Dim savePath As String = folderSavePath.Text

        If (openPath IsNot "" And savePath IsNot "" And Directory.Exists(openPath) And Directory.Exists(savePath)) Then


            Dim modFiles As String() = Directory.GetFiles(openPath, "*.jar")

            If (Not Directory.Exists(openPath + "/tmp/mods")) Then

                Directory.CreateDirectory(openPath + "/tmp/mods")


            End If

            If (Not Directory.Exists(openPath + "/tmp/done")) Then

                Directory.CreateDirectory(openPath + "/tmp/done")


            End If

            progressBar.Maximum = modFiles.Length

            progressBar.Value = 0


            For Each modFile As String In modFiles


                Dim fileName As String = Path.GetFileNameWithoutExtension(modFile)
                Dim fileExtension As String = Path.GetExtension(modFile)

                Dim zipName As String



                If conversionMethodModInfo.Checked Then
                    Using modStream As FileStream = New FileStream(modFile, FileMode.Open)

                        Using modArchive As ZipArchive = New ZipArchive(modStream, ZipArchiveMode.Read)
                            Dim modInfo As ZipArchiveEntry = modArchive.GetEntry("mcmod.info")



                            If modInfo Is Nothing Then
                                zipName = fileName
                            Else
                                Using reader As StreamReader = New StreamReader(modInfo.Open())

                                    Dim Json As String = reader.ReadToEnd.ToString

                                    Console.WriteLine("JSON" + Json)

                                    Dim Token As JToken = JToken.Parse(Json)

                                    Dim modObject As JToken = JToken.Parse(Json)

                                    Dim modID As String
                                    Dim modVersion As String
                                    Dim mcVersion As String


                                    If modObject.Type.ToString = "Array" Then
                                        modID = modObject.First.Item("modid")

                                        modVersion = modObject.First.Item("version")

                                        mcVersion = modObject.First.Item("mcversion")
                                    ElseIf modObject.Type.ToString = "Object" Then

                                        modObject = modObject.Item("modList").First

                                        Console.WriteLine(modObject)



                                        modID = modObject.Item("modid")

                                        modVersion = modObject.Item("version")

                                        mcVersion = modObject.Item("mcversion")

                                    End If

                                    If modID Is Nothing Then
                                        MissingModID.missingLabelInfo.Text = "The Mod ID is missing for " + fileName + fileExtension + ". Please enter this below"


                                        MissingModID.ShowDialog()

                                        modID = MissingModID.MissingResult()

                                    ElseIf modVersion Is Nothing Then
                                        MissingModVersion.missingLabelInfo.Text = "The Mod Version is missing for " + fileName + fileExtension + ". Please enter this below"

                                        MissingModVersion.ShowDialog()

                                        modVersion = MissingModVersion.MissingResult()

                                    ElseIf mcVersion Is Nothing Then
                                        MissingMcVersion.missingLabelInfo.Text = "The Minecraft Version is missing for " + fileName + fileExtension + ". Please enter this below"

                                        MissingMcVersion.ShowDialog()

                                        mcVersion = MissingMcVersion.MissingResult()
                                    End If

                                    zipName = modID + "-" + mcVersion + "-" + modVersion


                                    reader.Close()
                                End Using

                            End If


                        End Using
                    End Using

                Else

                    zipName = fileName
                End If

                System.IO.File.Move(modFile, openPath + "/tmp/mods/" + fileName + fileExtension)
                Console.WriteLine("Moved To Mods Folder")

                If (Not File.Exists(savePath + "/" + zipName.ToLower + ".zip")) Then

                    ZipFile.CreateFromDirectory(openPath + "/tmp/mods", savePath + "/" + zipName.ToLower + ".zip", CompressionLevel.Fastest, True)
                    Console.WriteLine("Zipped File")
                End If

                System.IO.File.Move(openPath + "/tmp/mods/" + fileName + fileExtension, openPath + "/tmp/done/" + fileName + fileExtension)
                Console.WriteLine("Moved To Done Folder")

                progressBar.Value = progressBar.Value + 1
                Console.WriteLine("Updated Progress Bar")



            Next



            For Each jars As String In Directory.GetFiles(openPath + "/tmp/done")
                System.IO.File.Move(jars, openPath + "/" + Path.GetFileName(jars))



            Next

            System.IO.Directory.Delete(openPath + "/tmp", True)

            MessageBox.Show("Compile Complete!")
        Else

            MessageBox.Show("Please choose a Valid Folder location!")

        End If

    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click

        Dim Updater As New Updater

        Updater.CheckUpdate()


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Updater As New Updater
        System.IO.File.Delete("installer.msi")

        Updater.StartupCheckUpdate()


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Console.WriteLine(Application.ProductVersion)
    End Sub
End Class
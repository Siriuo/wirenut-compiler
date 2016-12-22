Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.Compression

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

            If (Not Directory.Exists(openPath + "/mods")) Then

                Directory.CreateDirectory(openPath + "/mods")


            End If

            If (Not Directory.Exists(openPath + "/done")) Then

                Directory.CreateDirectory(openPath + "/done")


            End If

            progressBar.Maximum = modFiles.Count

            progressBar.Value = 0


            For Each modFile As String In modFiles


                Dim fileName As String = Path.GetFileNameWithoutExtension(modFile)
                Dim fileExtension As String = Path.GetExtension(modFile)

                Dim zipName As String



                If conversionMethodModInfo.Checked Then

                    Using modStream As FileStream = New FileStream(modFile, FileMode.Open)



                        Using modArchive As ZipArchive = New ZipArchive(modStream, ZipArchiveMode.Read)
                            Dim modInfo As ZipArchiveEntry = modArchive.GetEntry("mcmod.info")

                            Using reader As StreamReader = New StreamReader(modInfo.Open())



                                Dim Json As String = reader.ReadToEnd.ToString

                                Console.WriteLine("JSON" + Json)

                                Dim modObject As JArray = JArray.Parse(Json)

                                Dim modID As String = modObject.First.Item("modid")

                                Dim modVersion As String = modObject.First.Item("version")

                                Dim mcVersion As String = modObject.First.Item("mcversion")

                                zipName = modID + "-" + mcVersion + "-" + modVersion


                                reader.Close()
                            End Using
                        End Using
                    End Using
                Else

                    zipName = fileName
                End If

                System.IO.File.Move(modFile, openPath + "/mods/" + fileName + fileExtension)
                Console.WriteLine("Moved To Mods Folder")

                If (Not File.Exists(savePath + "/" + zipName.ToLower + ".zip")) Then

                    ZipFile.CreateFromDirectory(openPath + "/mods", savePath + "/" + zipName.ToLower + ".zip", CompressionLevel.Fastest, True)
                    Console.WriteLine("Zipped File")
                End If

                System.IO.File.Move(openPath + "/mods/" + fileName + fileExtension, openPath + "/done/" + fileName + fileExtension)
                Console.WriteLine("Moved To Done Folder")

                progressBar.Value = progressBar.Value + 1
                Console.WriteLine("Updated Progress Bar")


            Next
        Else

            MessageBox.Show("Please choose a Valid Folder location!")

        End If

    End Sub

End Class

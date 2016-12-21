Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.Compression


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


            For Each modFile As String In modFiles
                Dim fileName As String = Path.GetFileNameWithoutExtension(modFile)
                Dim fileExtension As String = Path.GetExtension(modFile)


                System.IO.File.Move(modFile, openPath + "/mods/" + fileName + fileExtension)
                Console.WriteLine("Moved To Mods Folder")

                If (Not File.Exists(savePath + "/" + fileName.ToLower + ".zip")) Then

                    ZipFile.CreateFromDirectory(openPath + "/mods", savePath + "/" + fileName.ToLower + ".zip", CompressionLevel.Fastest, True)
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

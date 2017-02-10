Imports Octokit
Imports Octokit.Release

Imports System
Imports System.IO
Imports System.Net

Public Class Updater

    Function GetReleases()

        Dim branch As String = "stable"

        Dim updateClient As New GitHubClient(New ProductHeaderValue("wirenut-compiler"))
        Dim releases = updateClient.Repository.Release.GetAll("siriuo", "wirenut-compiler")

        'Console.WriteLine("Release" + releases.ToString)
        Dim latest = releases.Result(0)
        If branch = "stable" Then

            Dim result = 0 ' Sets initial result
            Do

                latest = releases.Result(result)


                result = result + 1
            Loop Until latest.Prerelease = False
        Else
            latest = releases.Result(0)

        End If

        Return latest.TagName


    End Function

    Function CheckUpdate()
        Dim currentVersion As String = System.Windows.Forms.Application.ProductVersion
        Dim latestVersion As String = GetReleases()

        Console.WriteLine(currentVersion)
        Console.WriteLine(latestVersion)

        If currentVersion < latestVersion Then
            Dim responseMsg = MsgBox("There is an Update! Would you like to Download this update?", MsgBoxStyle.YesNo, "Notice")



            If responseMsg = MsgBoxResult.Yes Then
                Console.WriteLine("YES PRESSED")
                DownloadUpdate()
            Else
                Console.WriteLine("NO PRESSED")
            End If
        Else
            MsgBox("Already up to date!", MsgBoxStyle.OkOnly, "Notice")
        End If

        Return Nothing

    End Function

    Function StartupCheckUpdate()
        Dim currentVersion As String = System.Windows.Forms.Application.ProductVersion
        Dim latestVersion As String = GetReleases()

        Console.WriteLine(currentVersion)
        Console.WriteLine(latestVersion)
        If currentVersion < latestVersion Then
            Dim responseMsg = MsgBox("There is an Update! Would you like to download this Update?", MsgBoxStyle.YesNo, "Notice")



            If responseMsg = MsgBoxResult.Yes Then
                Console.WriteLine("YES PRESSED")
                DownloadUpdate()
            Else
                Console.WriteLine("NO PRESSED")
            End If
        End If

        Return Nothing

    End Function

    Function DownloadUpdate()

        Dim RemoteURI As String = "https://github.com/Siriuo/wirenut-compiler/releases/download/" + GetReleases() + "/WirenutCompilerInstaller-" + GetReleases() + ".msi"

        Dim WebClient As New WebClient()

        Dim tempDir As String = Path.GetTempPath()

        Directory.CreateDirectory(tempDir + "Wirenut")


        WebClient.DownloadFile(RemoteURI, tempDir + "Wirenut\installer.msi")




        Dim responseMsg = MsgBox("Ready to Install! Would you like to run the installer?", MsgBoxStyle.YesNo, "Notice")



        If responseMsg = MsgBoxResult.Yes Then

            Dim ProcessInfo As New ProcessStartInfo

            'ProcessInfo.Verb = "RunAs"
            'ProcessInfo.WindowStyle = ProcessWindowStyle.Normal
            'ProcessInfo.FileName = tempDir + "Wirenut\installer.msi"

            Process.Start(tempDir + "Wirenut\installer.msi")




            System.Windows.Forms.Application.Exit()
        Else
            System.IO.File.Delete(tempDir + "Wirenut\installer.msi")
        End If



        Return Nothing

    End Function

End Class

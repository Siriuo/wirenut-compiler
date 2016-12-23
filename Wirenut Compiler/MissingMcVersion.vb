Public Class MissingMcVersion

    Public Function MissingResult()
        Return missingFormInput.Text
    End Function
    Private Sub submitMissingInfo_Click(sender As Object, e As EventArgs) Handles submitMissingInfo.Click
        Me.Hide()
    End Sub

    Private Sub skipMissingInfo_Click(sender As Object, e As EventArgs) Handles skipMissingInfo.Click
        Me.Close()
    End Sub

End Class
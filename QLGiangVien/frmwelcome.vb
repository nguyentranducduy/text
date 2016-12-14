Public Class frmwelcome

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
        End If
    End Sub
End Class
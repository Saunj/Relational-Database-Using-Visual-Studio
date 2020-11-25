Public Class cExit
    Public Shared Function ExitSystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Payment Junction Management System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Function
End Class

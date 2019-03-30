Public Class MainForm

    Public Shared f As New MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        f = Me

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim t As New Threading.Thread(Sub()
                                          For i As Integer = 0 To 100 Step 1
                                              'Progress bar value increment : from 0 to 100%
                                              If ProgressBarMain.InvokeRequired Then
                                                  ProgressBarMain.Invoke(Sub()
                                                                             ProgressBarMain.Value = i
                                                                         End Sub)
                                              Else
                                                  ProgressBarMain.Value = i
                                              End If
                                              '50 % : Update dialog status : "Listing processes..."
                                              If i = 50 Then
                                                  If lbStatus.InvokeRequired Then
                                                      lbStatus.Invoke(Sub()
                                                                          lbStatus.Text = "Listing processes..."
                                                                      End Sub)
                                                  Else
                                                      lbStatus.Text = "Listing processes..."
                                                  End If
                                              End If
                                              '75 % : Update dialog status : "Exiting process..."
                                              If i = 75 Then
                                                  If lbStatus.InvokeRequired Then
                                                      lbStatus.Invoke(Sub()
                                                                          lbStatus.Text = "Exiting process..."
                                                                      End Sub)
                                                  Else
                                                      lbStatus.Text = "Exiting process..."
                                                  End If
                                              End If
                                              Threading.Thread.Sleep(25)
                                          Next
                                          '100 % : Dialog box : "The session needs to be restarted; we apologize for the inconvenience."
                                          If f.InvokeRequired Then
                                              f.Invoke(Sub()
                                                           Call ShowPopupAndExit()
                                                       End Sub)
                                          Else
                                              Call ShowPopupAndExit()
                                          End If
                                      End Sub)
        t.IsBackground = True
        t.Start()

    End Sub

    Sub ShowPopupAndExit()

        If My.Settings.ShowMsgBox And My.Settings.MsgBoxText <> String.Empty Then
            MessageBox.Show(f, My.Settings.MsgBoxText, "Runtime exception", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Application.Exit()

    End Sub

End Class



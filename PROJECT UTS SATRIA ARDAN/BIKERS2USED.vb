Imports System.Media
Public Class BIKERS2USED
    Private Sub BIKERS2USED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button3.Left > 0 - Button3.Width Then
            Button3.Left -= 1
        Else : Button3.Left = Me.ClientSize.Width
        End If
        If Button5.Left > 0 - Button5.Width Then
            Button5.Left -= 1
        Else : Button5.Left = Me.ClientSize.Width
        End If
        If Button6.Left > 0 - Button6.Width Then
            Button6.Left -= 1
        Else : Button6.Left = Me.ClientSize.Width
        End If
        If Button7.Left > 0 - Button7.Width Then
            Button7.Left -= 1
        Else : Button7.Left = Me.ClientSize.Width
        End If
        If Button8.Left > 0 - Button8.Width Then
            Button8.Left -= 1
        Else : Button8.Left = Me.ClientSize.Width
        End If
        If Button4.Left > 0 - Button4.Width Then
            Button4.Left -= 1
        Else : Button4.Left = Me.ClientSize.Width
        End If
        If Button9.Left > 0 - Button9.Width Then
            Button9.Left -= 1
        Else : Button9.Left = Me.ClientSize.Width
        End If
        If Button10.Left > 0 - Button10.Width Then
            Button10.Left -= 1
        Else : Button10.Left = Me.ClientSize.Width
        End If
        If Button11.Left > 0 - Button11.Width Then
            Button11.Left -= 1
        Else : Button11.Left = Me.ClientSize.Width
        End If
        If Button12.Left > 0 - Button12.Width Then
            Button12.Left -= 1
        Else : Button12.Left = Me.ClientSize.Width
        End If
        If Button13.Left > 0 - Button13.Width Then
            Button13.Left -= 1
        Else : Button13.Left = Me.ClientSize.Width
        End If
        If Button14.Left > 0 - Button14.Width Then
            Button14.Left -= 1
        Else : Button14.Left = Me.ClientSize.Width
        End If
        If Button15.Left > 0 - Button15.Width Then
            Button15.Left -= 1
        Else : Button15.Left = Me.ClientSize.Width
        End If
        If Button16.Left > 0 - Button16.Width Then
            Button16.Left -= 1
        Else : Button16.Left = Me.ClientSize.Width
        End If
        If Button17.Left > 0 - Button17.Width Then
            Button17.Left -= 1
        Else : Button17.Left = Me.ClientSize.Width
        End If
        If Button18.Left > 0 - Button18.Width Then
            Button18.Left -= 1
        Else : Button18.Left = Me.ClientSize.Width
        End If
        If Button19.Left > 0 - Button19.Width Then
            Button19.Left -= 1
        Else : Button19.Left = Me.ClientSize.Width
        End If
        If Button20.Left > 0 - Button20.Width Then
            Button20.Left -= 1
        Else : Button20.Left = Me.ClientSize.Width
        End If
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Ducati.Show()
    End Sub

    Private Sub Button21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseEnter
        Button21.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button21_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseLeave
        Button21.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Purchase_Ducati.Show()
    End Sub

    Private Sub Button22_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.MouseEnter
        Button22.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button22_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.MouseLeave
        Button22.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Purchase_Kawasaki.ShowDialog()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Me.Close()
        Button24.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaPlayer.Enter
        MediaPlayer.URL = "C:\Users\wiwim\OneDrive\Documents\Visual Studio 2010\Projects\PROJECT UTS SATRIA ARDAN\PROJECT UTS SATRIA ARDAN\Resources\Differences_awM6ICnCM6o.mp3"
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        GroupBox1.Visible = True
        Button25.Visible = False
        Button26.Visible = True
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        GroupBox1.Visible = False
        Button25.Visible = True
        Button26.Visible = False
    End Sub

End Class
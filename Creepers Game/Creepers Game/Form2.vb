Public Class Form2

    Dim root As String = ("C:\Creepersgame\")
    Dim path As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        menusong.Ctlcontrols.stop()
        Form1.ShowDialog()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        path = root & "introvid.wmv"
        introvideo.URL = path
        path = root & "menu.wma"
        menusong.URL = path
        path = root & "game.mp3"
        Form1.gamemainsong.URL = path
        path = root & "boss.wma"
        Form1.gamesong.URL = path
        introvideo.Ctlcontrols.play()


    End Sub

    Private Sub scoresboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scoresboard.Click
        Form3.ShowDialog()
    End Sub

    

    Private Sub endvideo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endvideo.Tick
        If introvideo.playState = 3 Then
            menusong.Ctlcontrols.stop()
        End If

        If introvideo.playState = 2 Or introvideo.playState = 1 Then
            introvideo.Visible = False
            menusong.Ctlcontrols.play()
            skipbutton.Visible = False
            endvideo.Enabled = False

        End If
    End Sub

    Private Sub skipbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skipbutton.Click
        introvideo.Ctlcontrols.stop()
        skipbutton.Visible = False
    End Sub

 


End Class
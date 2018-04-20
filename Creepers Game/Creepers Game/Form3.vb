Public Class Form3
    Dim respnum As Integer
    Dim respnom As String
    Dim led5 As Integer = False

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Do While led5 = False
            led5 = True
            For cont = 0 To 8
                If Form1.scores(cont) < Form1.scores(cont + 1) Then
                    respnum = Form1.scores(cont + 1)
                    Form1.scores(cont + 1) = Form1.scores(cont)
                    Form1.scores(cont) = respnum

                    respnom = Form1.nombre(cont + 1)
                    Form1.nombre(cont + 1) = Form1.nombre(cont)
                    Form1.nombre(cont) = respnom

                    led5 = False
                End If
            Next
        Loop
        led5 = False
        Label1.Text = "1.- " & Form1.nombre(0) & " : " & Form1.scores(0)
        Label2.Text = "2.- " & Form1.nombre(1) & " : " & Form1.scores(1)
        Label3.Text = "3.- " & Form1.nombre(2) & " : " & Form1.scores(2)
        Label4.Text = "4.- " & Form1.nombre(3) & " : " & Form1.scores(3)
        Label5.Text = "5.- " & Form1.nombre(4) & " : " & Form1.scores(4)
        Label6.Text = "6.- " & Form1.nombre(5) & " : " & Form1.scores(5)
        Label7.Text = "7.- " & Form1.nombre(6) & " : " & Form1.scores(6)
        Label8.Text = "8.- " & Form1.nombre(7) & " : " & Form1.scores(7)
        Label9.Text = "9.- " & Form1.nombre(8) & " : " & Form1.scores(8)
        Label10.Text = "10.- " & Form1.nombre(9) & " : " & Form1.scores(9)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
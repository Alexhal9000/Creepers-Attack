Public Class Form1
    Dim disparos As Integer = 0
    Dim numjuego As Integer = 0
    Public nombre(0 To 10) As String
    Public scores(0 To 10) As Integer
    Dim randm As Integer
    Dim score As Integer
    Dim led3 As Boolean = True
    Dim led2 As Boolean = False
    Dim sder As Boolean = False
    Dim sizq As Boolean = False
    Dim espa As Boolean = False
    Dim shoot As Boolean = False
    Dim dificultad As Integer = 1
    Dim shipspeed As Integer = 5
    Dim direction As Boolean = False
    Dim bosshit As Integer = 0
    Dim bossled As Boolean = True
    Dim bossfilarepeat As Integer = 0

    'generar creepers
    Private Sub generar()
        If dificultad = 15 Then
            Call boss()
        Else

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox1.Visible = True
            Else
                PictureBox1.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox9.Visible = True
            Else
                PictureBox9.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox3.Visible = True
            Else
                PictureBox3.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox4.Visible = True
            Else
                PictureBox4.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox5.Visible = True
            Else
                PictureBox5.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox6.Visible = True
            Else
                PictureBox6.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox7.Visible = True
            Else
                PictureBox7.Visible = False
            End If

            randm = ((Rnd()) * 3) + 1
            If randm > 2 Then
                PictureBox8.Visible = True
            Else
                PictureBox8.Visible = False
            End If

            If dificultad <> 10 And PictureBox9.Visible = False And PictureBox1.Visible = False And PictureBox3.Visible = False And PictureBox4.Visible = False And PictureBox5.Visible = False And PictureBox6.Visible = False And PictureBox7.Visible = False And PictureBox8.Visible = False Then

                Call generar()

            End If
        End If

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

    'start
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call generar()


        Timer1.Enabled = True
        Timer2.Enabled = True
        Button1.Visible = False
        Button2.Visible = False
        PictureBox2.Visible = False
        ship.Visible = True
        gamemainsong.Ctlcontrols.play()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim led As Boolean = False


        If PictureBox1.Location.Y < 400 Then
            PictureBox1.Top = PictureBox1.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox1.Visible = True Then
                led = True
            End If
            PictureBox1.Top = 20
            Call generar()
        End If

        If PictureBox3.Location.Y < 400 Then
            PictureBox3.Top = PictureBox3.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox3.Visible = True Then
                led = True
            End If
            PictureBox3.Top = 20
            Call generar()
        End If

        If PictureBox4.Location.Y < 400 Then
            PictureBox4.Top = PictureBox4.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox4.Visible = True Then
                led = True
            End If
            PictureBox4.Top = 20
            Call generar()
        End If

        If PictureBox5.Location.Y < 400 Then
            PictureBox5.Top = PictureBox5.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox5.Visible = True Then
                led = True
            End If
            PictureBox5.Top = 20
            Call generar()
        End If

        If PictureBox6.Location.Y < 400 Then
            PictureBox6.Top = PictureBox6.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox6.Visible = True Then
                led = True
            End If
            PictureBox6.Top = 20
            Call generar()
        End If

        If PictureBox7.Location.Y < 400 Then
            PictureBox7.Top = PictureBox7.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox7.Visible = True Then
                led = True
            End If
            PictureBox7.Top = 20
            Call generar()
        End If

        If PictureBox8.Location.Y < 400 Then
            PictureBox8.Top = PictureBox8.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox8.Visible = True Then
                led = True
            End If
            PictureBox8.Top = 20
            Call generar()
        End If

        If PictureBox9.Location.Y < 400 Then
            PictureBox9.Top = PictureBox9.Location.Y + (10 + (0.5 * dificultad))
        Else
            If PictureBox9.Visible = True Then
                led = True
            End If
            PictureBox9.Top = 20
            Call generar()
        End If

        'check next deployment
        If PictureBox9.Visible = False And PictureBox1.Visible = False And PictureBox3.Visible = False And PictureBox4.Visible = False And PictureBox5.Visible = False And PictureBox6.Visible = False And PictureBox7.Visible = False And PictureBox8.Visible = False Then
            dificultad = dificultad + 1

            PictureBox1.Top = 20
            PictureBox3.Top = 20
            PictureBox4.Top = 20
            PictureBox5.Top = 20
            PictureBox6.Top = 20
            PictureBox7.Top = 20
            PictureBox8.Top = 20
            PictureBox9.Top = 20

            Call generar()
        End If

        If led = True Then

            Timer1.Enabled = False
            'score
            score = (Int(10 * (dificultad ^ 2.71))) - disparos
            If dificultad > 6 Then
                score = (Int(10 * (dificultad ^ 2.71))) - (10 * disparos)
                If score < 0 Then
                    score = 0
                End If
            End If
            'message GAME OVER

            MsgBox("Perdiste!! tu score fue de " & score & " puntos")
            nombre(numjuego) = InputBox("Ingresa tu nombre: ")
            scores(numjuego) = score
            dificultad = 1
            gamesong.Ctlcontrols.stop()
            gamemainsong.Ctlcontrols.stop()
            Button1.Visible = True
            Button2.Visible = True
            If numjuego < 9 Then
                numjuego = numjuego + 1
            End If
            ship.Left = 350
            laser.Left = 383

        End If


    End Sub

    Private Sub boss()
        gamemainsong.Ctlcontrols.pause()
        gamesong.Ctlcontrols.play()
        bosshp.Visible = True
        Timer1.Enabled = False
        If dificultad = 15 Then

            boss1.Visible = True
            bosstimer.Enabled = True


        End If
    End Sub


    'movimiento de la nave
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.D Then
            sder = True
            sizq = False
        Else

            If e.KeyValue = Keys.A Then
                sizq = True
                sder = False
            End If
        End If

        If e.KeyValue = Keys.K Then
            shoot = True

        End If


    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.D Then
            sder = False
        End If

        If e.KeyValue = Keys.A Then
            sizq = False
        End If

        If e.KeyValue = Keys.K Then
            shoot = False
            led3 = True

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'right
        If sder = True And ship.Location.X < Me.DisplayRectangle.Width - ship.Width Then
            ship.Left += shipspeed
            laser.Left += shipspeed
        End If
        'left
        If sizq = True And ship.Location.X > 0 Then
            ship.Left -= shipspeed
            laser.Left -= shipspeed
        End If
    End Sub

    'shooter de la nave



   
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        led2 = False
        'posición Y del laser
        If bosstimer.Enabled = False Then
            laser.Height = ship.Location.Y - PictureBox1.Location.Y - PictureBox1.Width
            laser.Top = PictureBox1.Location.Y + PictureBox1.Height
        Else
            laser.Height = ship.Location.Y - boss1.Location.Y - boss1.Width
            laser.Top = boss1.Location.Y + boss1.Height
        End If

        If shoot = True And led3 = True Then
            laser.Visible = True
            led3 = False
        End If

        'destruir creepers
        If laser.Visible = True And PictureBox1.Visible = True And laser.Location.X + 3 > PictureBox1.Location.X And laser.Location.X + 3 < PictureBox1.Location.X + PictureBox1.Width Then
            PictureBox1.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox3.Visible = True And laser.Location.X + 3 > PictureBox3.Location.X And laser.Location.X + 3 < PictureBox3.Location.X + PictureBox3.Width Then
            PictureBox3.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox4.Visible = True And laser.Location.X + 3 > PictureBox4.Location.X And laser.Location.X + 3 < PictureBox4.Location.X + PictureBox4.Width Then
            PictureBox4.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox5.Visible = True And laser.Location.X + 3 > PictureBox5.Location.X And laser.Location.X + 3 < PictureBox5.Location.X + PictureBox5.Width Then
            PictureBox5.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox6.Visible = True And laser.Location.X + 3 > PictureBox6.Location.X And laser.Location.X + 3 < PictureBox6.Location.X + PictureBox6.Width Then
            PictureBox6.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox7.Visible = True And laser.Location.X + 3 > PictureBox7.Location.X And laser.Location.X + 3 < PictureBox7.Location.X + PictureBox7.Width Then
            PictureBox7.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox8.Visible = True And laser.Location.X + 3 > PictureBox8.Location.X And laser.Location.X + 3 < PictureBox8.Location.X + PictureBox8.Width Then
            PictureBox8.Visible = False
            led2 = True
        End If

        If laser.Visible = True And PictureBox9.Visible = True And laser.Location.X + 3 > PictureBox9.Location.X And laser.Location.X + 3 < PictureBox9.Location.X + PictureBox9.Width Then
            PictureBox9.Visible = False
            led2 = True
        End If

        'pausa antes de desaparecer
        If laser.Visible = True Then
            Timer4.Enabled = True
            disparos = disparos + 1
        End If

    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        laser.Visible = False

        Timer4.Enabled = False
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gamesong.Ctlcontrols.stop()
        Form2.menusong.Ctlcontrols.play()

        Me.Close()


    End Sub

    Private Sub bosstimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bosstimer.Tick
        Dim led As Boolean = False




        If boss1.Location.Y + boss1.Height < ship.Location.Y And bossled = True Then
            If direction = False Then

                boss1.Left = boss1.Location.X + 10
                If boss1.Location.X + boss1.Width > Me.DisplayRectangle.Width Then

                    direction = True
                    bossfilarepeat = bossfilarepeat + 1

                End If

            Else

                boss1.Left = boss1.Location.X - 10
                If boss1.Location.X < 0 Then

                    direction = False
                    bossfilarepeat = bossfilarepeat + 1

                End If

            End If

            If bossfilarepeat = 2 Then
                boss1.Top = boss1.Location.Y + 10 + dificultad
                bossfilarepeat = 0
            End If

        Else
            If bossled = True Then
                led = True
                boss1.Top = 12
                boss1.Left = 300
                boss1.Visible = False
                bossled = False
            End If

        End If

        

        If led = True Then

            score = (Int(10 * (dificultad ^ 2.71))) - disparos
            If dificultad > 6 Then
                score = (Int(10 * (dificultad ^ 2.71))) - (10 * disparos)
                If score < 0 Then
                    score = 0
                End If
            End If

            MsgBox("Perdiste!! tu score fue de " & score & " puntos")
            nombre(numjuego) = InputBox("Ingresa tu nombre: ")
            scores(numjuego) = score
            dificultad = 1
            bosstimer.Enabled = False
            bossled = True
            gamesong.Ctlcontrols.stop()
            bosshp.Visible = False
            Button1.Visible = True
            Button2.Visible = True
            If numjuego < 9 Then
                numjuego = numjuego + 1
            End If
            ship.Left = 350
            laser.Left = 383
        End If

        If shoot = True And led3 = True And laser.Location.X + 2 > boss1.Location.X And laser.Location.X < boss1.Location.X + boss1.Width And boss1.Location.Y + boss1.Height < ship.Location.Y Then
            bosshit = bosshit + 1
        End If

            If bosshit = 20 Then
                bosstimer.Enabled = False
            boss1.Visible = False
            bosshp.Visible = False
                Timer1.Enabled = True
                dificultad = dificultad + 1
            gamesong.Ctlcontrols.stop()
            gamemainsong.Ctlcontrols.play()

            End If
        bosshp.Text = 20 - bosshit
    End Sub
End Class

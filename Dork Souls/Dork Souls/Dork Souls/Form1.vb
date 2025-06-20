Public Class Form1

    Dim lado As Integer = 1
    Dim esq As Boolean = False
    Dim dir As Boolean = False
    Dim cima As Boolean = False
    Dim baixo As Boolean = False
    Dim cam As Boolean = False
    Dim atB As Boolean = False

    Dim vida As Single = 100
    Dim nivel As Integer = 1
    Dim vidaboss As Single = 250
    Dim spawn As Point

    Dim loc(2) As Point
    Dim ini(2) As PictureBox
    Dim pdir1 As Boolean = False
    Dim pdir2 As Boolean = False
    Dim pdir0 As Boolean = False
    Dim inimvivos As Integer
    Dim espinhosd(2) As Label
    Dim espinhose(2) As Label
    Dim espLoc(5) As Point
    Dim bdir As Boolean = False
    Dim bbateu As Boolean = False


    Dim a As Boolean = False
    Dim b As Boolean = False
    Dim c As Boolean = False
    Dim a1 As Integer = 0
    Dim b1 As Integer = 0
    Dim c1 As Integer = 0
    Dim cooldown1 As Integer = 0

    Dim cd As Boolean = False

    Dim bmorto As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        spawn = New Point(boneco.Location.X, boneco.Location.Y)
        Me.Width = 1200
        Me.Height = 900
        nivel = 1
        vida = 100
        vidaboss = 250
        inimvivos = 1

        Panel1.Location = New Point(0, 0)

        loc(0) = inimigo0.Location
        loc(1) = inimigo1.Location
        loc(2) = inimigo2.Location
        ini(0) = inimigo0
        ini(1) = inimigo1
        ini(2) = inimigo2

        espinhose(0) = espinho0
        espinhose(1) = espinho1
        espinhose(2) = espinho2
        espinhosd(0) = espinho3
        espinhosd(1) = espinho4
        espinhosd(2) = espinho5

        espLoc(0) = espinho0.Location
        espLoc(1) = espinho1.Location
        espLoc(2) = espinho2.Location
        espLoc(3) = espinho3.Location
        espLoc(4) = espinho4.Location
        espLoc(5) = espinho5.Location

        inimigo0.Visible = True

        For i = 0 To 2
            espinhose(i).Top -= 1000
            espinhosd(i).Top -= 1000
        Next
    End Sub

    Private Sub PictureBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.A Then
            esq = True
            If cam = False Then
                boneco.Image = My.Resources.knightwalke
            End If
            cam = True

            lado = -1
        End If
        If e.KeyValue = Keys.D Then
            dir = True
            If cam = False Then
                boneco.Image = My.Resources.walk
            End If
            cam = True
            lado = 1
        End If
        If e.KeyValue = Keys.W Then
            cima = True
            If cam = False Then
                If lado = 1 Then
                    boneco.Image = My.Resources.walk
                Else : boneco.Image = My.Resources.knightwalke
                End If
            End If
            cam = True
        End If
        If e.KeyValue = Keys.S Then
            baixo = True
            If cam = False Then
                If lado = 1 Then
                    boneco.Image = My.Resources.walk
                Else : boneco.Image = My.Resources.knightwalke
                End If
            End If
            cam = True
        End If

        If e.KeyValue = Keys.K Then
            If atB = False Then
                slash.Show()


                If lado = 1 Then
                    boneco.Image = My.Resources.slash2d
                    slash.Location = New Point((boneco.Location.X + 130), boneco.Location.Y)
                End If
                If lado = -1 Then
                    boneco.Image = My.Resources.slash2e
                    slash.Location = New Point((boneco.Location.X - 30), boneco.Location.Y)
                End If
                If slash.Bounds.IntersectsWith(Boss.Bounds) Then
                    vidaboss -= 7
                End If
                For i = 0 To ini.Length - 1
                    If slash.Bounds.IntersectsWith(ini(i).Bounds) Then
                        ini(i).Hide()
                        inimvivos -= 1
                    End If
                Next
                slash.Show()

            End If
            atB = True
        End If
    End Sub

    Private Sub PictureBox1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.A Then
            esq = False
            cam = False
            boneco.Image = My.Resources.idlee
        End If
        If e.KeyValue = Keys.D Then
            dir = False
            cam = False
            boneco.Image = My.Resources.idle___Cópia
        End If
        If e.KeyValue = Keys.W Then
            cima = False

        End If
        If e.KeyValue = Keys.S Then
            baixo = False
        End If
        If e.KeyValue = Keys.K Then
            atB = False
            If lado = 1 Then
                boneco.Image = My.Resources.idle___Cópia
            End If
            If lado = -1 Then
                boneco.Image = My.Resources.idlee
            End If
        End If
    End Sub

   

    Private Sub Movimento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimento.Tick

        Label2.Width = 227 * vida / 100
        label9.Text = espinho0.Visible
        bHp.Width = 380 * vidaboss / 250
        Label6.Text = espinho0.Left


        If cooldown1 > 0 Then
            cooldown1 += 1
        End If
        If cooldown1 = 34 Then
            boneco.Image = My.Resources.idle___Cópia
            cooldown1 = 0
            cd = False
        End If
        If dir = True And cd = False Then
            boneco.Left += 7
        End If

        If esq = True And boneco.Left > 0 And cd = False Then
            boneco.Left -= 7
        End If

        If cima = True And boneco.Top > 0 And cd = False Then
            boneco.Top -= 7
        End If

        If baixo = True And boneco.Bottom < 900 And cd = False Then
            boneco.Top += 7
        End If

        If boneco.Left >= 1200 And inimvivos = 0 Then
            nivel += 5
            boneco.Location = spawn
            For i = 0 To loc.Length - 1
                ini(i).Location = loc(i)
            Next
            Select Case nivel
                Case 2
                    inimvivos = 2
                    inimigo1.Show()
                    Me.BackgroundImage = My.Resources.nivel2
                    inimigo0.Show()
                    inimvivos = 2

                Case 3
                    Me.BackgroundImage = My.Resources.nivel3
                    inimigo0.Show()
                    inimvivos = 1
                Case 4
                    inimigo1.Show()
                    inimigo2.Show()
                    Me.BackgroundImage = My.Resources.nivel4

                    inimvivos = 2
                Case 5
                    For i = 0 To loc.Length - 1
                        ini(i).Show()
                    Next
                    Me.BackgroundImage = My.Resources.nivel5
                    inimvivos = 3
                    For i = 0 To loc.Length - 1
                        ini(i).Show()
                    Next
                Case 6
                    Me.BackgroundImage = My.Resources.nivel6
                    Boss.Show()
                    bHp.Show()
                    lbBoss.Show()
                    bkcBHp.Show()

            End Select
        End If

        If inimigo0.Location.X < loc(0).X - 75 Then
            pdir0 = True
            inimigo0.Image = My.Resources.minionwalkd
        End If
        If inimigo0.Location.X > loc(0).X + 75 Then
            pdir0 = False
            inimigo0.Image = My.Resources.minionwalk
        End If

        If inimigo1.Location.X < loc(1).X - 75 Then
            pdir1 = True
        End If
        If inimigo1.Location.X > loc(1).X + 75 Then
            pdir1 = False
        End If

        If inimigo2.Location.X < loc(2).X - 75 Then
            pdir2 = True
        End If
        If inimigo2.Location.X > loc(2).X + 75 Then
            pdir2 = False
        End If


        For i = 0 To 2
            If boneco.Bounds.IntersectsWith(espinhosd(i).Bounds) And espinhosd(i).Visible = True Then
                vida -= 8
                espinhosd(i).Top -= 1000
            End If
            If boneco.Bounds.IntersectsWith(espinhose(i).Bounds) And espinhose(i).Visible = True Then
                vida -= 8
                espinhose(i).Top -= 1000
            End If
        Next


        If nivel = 6 Then
            Select Case vidaboss
                Case Is > 250 * 0.65
                    picos.Start()
                    For i = 0 To 2
                        espinhosd(i).Show()
                        espinhose(i).Show()
                        espinhosd(i).Left += 10
                        espinhose(i).Left -= 10

                    Next
                    calhau.Left = boneco.Left
                Case Is > 250 * 0.58
                    picos.Stop()
                    For i = 0 To 2
                        espinhosd(i).Hide()
                        espinhose(i).Hide()
                    Next
                    calhau.Show()
                    calhau.Top += 10
                    If calhau.Top >= 900 Then
                        calhau.Left = boneco.Left
                        calhau.Top = -10
                    End If
                Case Is > 250 * 0.4

                    calhau.Hide()
                    Onda.Start()
                    If boneco.Bottom < Boss.Bottom Then
                        Boss.Top -= 1
                    End If
                    If boneco.Bottom > Boss.Bottom Then
                        Boss.Top += 1
                    End If

                Case Is > 250 * 0.25
                    wavee.Hide()
                    Onda.Stop()
                    picos.Start()
                    For i = 0 To 2
                        espinhosd(i).Show()
                        espinhose(i).Show()
                        espinhosd(i).Left += 10
                        espinhose(i).Left -= 10

                    Next


                Case Is > 0
                    For i = 0 To 2
                        espinhosd(i).Hide()
                        espinhose(i).Hide()
                    Next
                    Onda.Start()
                    If boneco.Bottom < Boss.Bottom Then
                        Boss.Top -= 1
                    End If
                    If boneco.Bottom > Boss.Bottom Then
                        Boss.Top += 1
                    End If
            End Select
        End If

        If boneco.Bounds.IntersectsWith(calhau.Bounds) And calhau.Visible = True Then
            vida -= 30
            calhau.Left = boneco.Left
            calhau.Top = -10
        End If

        For i = 0 To 2
            If ini(i).Bounds.IntersectsWith(boneco.Bounds) Then
                If i = 0 And a1 = 0 Then
                    a = True
                ElseIf i = 1 And b1 = 0 Then
                    b = True
                ElseIf c1 = 0 And i = 2 Then
                    c = True
                End If
                mobAtq()
            End If
        Next
        If a1 = 1 Then
            ini(0).Image = My.Resources.minionataque___Cópia
        End If
        If b1 = 1 Then
            ini(1).Image = My.Resources.minionataque___Cópia
        End If
        If c1 = 1 Then
            ini(2).Image = My.Resources.minionataque___Cópia
        End If
        If a1 > 0 Then
            a1 += 1
        End If
        If b1 > 0 Then
            b1 += 1
        End If
        If c1 > 0 Then
            c1 += 1
        End If
        If a1 = 29 Then
            a1 = 0
            ini(0).Image = My.Resources.minionwalk
        End If
        If b1 = 29 Then
            b1 = 0
            ini(1).Image = My.Resources.minionwalk
        End If
        If c1 = 29 Then
            c1 = 1
            ini(2).Image = My.Resources.minionwalk
        End If

        If boneco.Right > inimigo0.Left - 100 And boneco.Top < inimigo0.Bottom + 100 And boneco.Left < inimigo0.Right + 100 And boneco.Bottom > inimigo0.Top - 100 Then
            If boneco.Left < inimigo0.Right + 10 Then
                inimigo0.Left -= 4
            End If
            If boneco.Right > inimigo0.Left - 10 Then
                inimigo0.Left += 4
            End If
            If inimigo0.Top > boneco.Top Then
                inimigo0.Top -= 4
            End If

            If inimigo0.Top < boneco.Top Then
                inimigo0.Top += 4
            End If

        ElseIf pdir0 = True Then
            inimigo0.Left += 2
        Else : inimigo0.Left -= 2
        End If


        If boneco.Right > inimigo1.Left - 100 And boneco.Top < inimigo1.Bottom + 100 And boneco.Left < inimigo1.Right + 100 And boneco.Bottom > inimigo1.Top - 100 Then
            If boneco.Left < inimigo0.Right + 10 Then
                inimigo1.Left -= 4
            End If
            If boneco.Right > inimigo0.Left - 10 Then
                inimigo1.Left += 4
            End If
            If inimigo1.Top > boneco.Top Then
                inimigo1.Top -= 4
            End If

            If inimigo1.Top < boneco.Top Then
                inimigo1.Top += 4
            End If
        ElseIf pdir1 = True Then
            inimigo1.Left += 2
        Else : inimigo1.Left -= 2
        End If

        If boneco.Right > inimigo2.Left - 100 And boneco.Top < inimigo2.Bottom + 100 And boneco.Left < inimigo2.Right + 100 And boneco.Bottom > inimigo2.Top - 100 Then
            If boneco.Left < inimigo2.Right + 10 Then
                inimigo2.Left -= 4
            End If
            If boneco.Right > inimigo2.Left - 10 Then
                inimigo2.Left += 4
            End If
            If inimigo2.Top > boneco.Top Then
                inimigo2.Top -= 4
            End If

            If inimigo2.Top < boneco.Top Then
                inimigo2.Top += 4
            End If
        ElseIf pdir2 = True Then
            inimigo2.Left += 2
        Else : inimigo2.Left -= 2
        End If

        If vida < 0 Then
            Panel2.Show()
            boneco.Hide()
            calhau.Hide()
            For i = 0 To ini.Length - 1
                ini(i).Hide()
                espinhosd(i).Hide()
                espinhose(i).Hide()
            Next
        End If

        If vidaboss < 0 Then
            Movimento.Stop()
            Panel3.Show()
            Onda.Stop()
            wavee.Hide()
            calhau.Hide()
            Boss.Hide()
            For i = 0 To ini.Length - 1
                ini(i).Hide()
                espinhosd(i).Hide()
                espinhose(i).Hide()
            Next
        End If
    End Sub

    Private Sub picos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picos.Tick
        espinho0.Location = espLoc(0)
        espinho1.Location = espLoc(1)
        espinho2.Location = espLoc(2)
        espinho3.Location = espLoc(3)
        espinho4.Location = espLoc(4)
        espinho5.Location = espLoc(5)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        vidaboss = 250 * 0.3
    End Sub

    Private Sub Onda_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Onda.Tick

        Boss.Image = My.Resources.demonioatq2d
        wavee.Top = Boss.Top + 320
        wavee.Show()
        If wavee.Bounds.IntersectsWith(boneco.Bounds) Then
            vida -= 25

        End If

    End Sub

    Private Sub mobAtq()
        If a = True And ini(0).Visible = True Then
            If ini(0).Bounds.IntersectsWith(boneco.Bounds) And a1 = 0 Then
                vida -= 10
                a1 = 1
            End If
        ElseIf b = True And ini(1).Visible = True Then
            If ini(1).Bounds.IntersectsWith(boneco.Bounds) And b1 = 0 Then
                vida -= 10
                b1 = 1
            End If
        ElseIf c = True And ini(2).Visible = True Then
            If ini(2).Bounds.IntersectsWith(boneco.Bounds) And c1 = 0 Then
                vida -= 10
                c1 = 1
            End If
        End If
    End Sub

    Private Sub label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label9.Click
        vida = -1
    End Sub


    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.BackgroundImage = My.Resources.nivel1
        Movimento.Start()
        nivel = 1
        vida = 100
        vidaboss = 250
        inimvivos = 1
        boneco.Location = spawn
        inimigo0.Location = loc(0)
        inimigo0.Show()
        boneco.Show()
        picos.Stop()
        Onda.Stop()
        For i = 0 To 2
            espinhose(i).Top -= 1000
            espinhosd(i).Top -= 1000
        Next
        Panel1.Hide()
    End Sub


    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        nivel = 1
        Boss.Hide()
        vida = 100
        vidaboss = 250
        inimvivos = 1
        boneco.Location = spawn
        inimigo0.Location = loc(0)
        inimigo0.Show()
        boneco.Show()
        Panel2.Hide()
        picos.Stop()
        Onda.Stop()
        For i = 0 To 2
            espinhose(i).Top -= 1000
            espinhosd(i).Top -= 1000
        Next
        lbBoss.Hide()
        bkcBHp.Hide()
        bHp.Hide()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Panel1.Show()
        Panel3.Hide()
        lbBoss.Hide()
        bkcBHp.Hide()
        bHp.Hide()
    End Sub
End Class

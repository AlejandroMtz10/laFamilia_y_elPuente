Public Class Form1
    '-------Lado derecho------------------------
    'Posicion inicial de la lampara: 793, 394
    'Posicion inicial del papá: 841, 267
    'Posicion inicial de la hija: 912, 261
    'Posicion inicial del hijo: 985, 250
    'Posicion inicial del hijo menor: 1051, 340
    'Posicion inicial de la mamá: 1110, 230

    '-------Lado izquierdo----------------------
    'Posicion inicial de la lampara: 391, 429
    'Posicion inicial del papá: 310, 304
    'Posicion inicial de la hija: 242, 305
    'Posicion inicial del hijo: 193, 314
    'Posicion inicial del hijo menor: 136, 414
    'Posicion inicial de la mamá: 83, 321

    'Variable para contar cuantos personajes se han seleccionado
    Dim marcados As Integer
    Dim tiempo As Integer
    Dim velPapa As Double = 200.5     '1 Segundo
    Dim velMama As Double = 66.7      '3 Segundos
    Dim velHija As Double = 33.5      '6 Segundos
    Dim velHijo As Double = 25.5      '8 Segundos
    Dim velHijoMenor As Integer = 17  '12 Segundos
    Dim stateTimer As Boolean = False
    Dim papaPrimero As Boolean = False
    Dim mamaPrimero As Boolean = False
    Dim hijoPrimero As Boolean = False
    Dim hijaPrimero As Boolean = False
    Dim hijoMenorPrimero As Boolean = False

    Dim papaSegundo As Boolean = False
    Dim mamaSegundo As Boolean = False
    Dim hijoSegundo As Boolean = False
    Dim hijaSegundo As Boolean = False
    Dim hijoMenorSegundo As Boolean = False

    Dim linternaIzq As Boolean = False

    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        marcados = 0
        revisarInicio()
    End Sub

    'Metodo para revisar si se cumplen las normas para iniciar el juego
    Private Sub revisarInicio()
        If checkPapa.Checked = True Then
            marcados = marcados + 1
        End If

        If checkMama.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHija.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHijo.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHijoMenor.Checked = True Then
            marcados = marcados + 1
        End If

        If marcados = 0 Then
            MsgBox("Selecciona al menos un personaje marcandolo.", vbCritical, "No ha seleccionado un personaje.")
        ElseIf marcados >= 3 Then
            MsgBox("Seleccionaste más de 2 personajes, desmarca algunos hasta tener solo uno o dos personajes marcados.", vbCritical, "Personajes seleccionados de más.")
        Else
            If tiempo = 0 Then
                tiempo = 30
            End If
            Timer1.Enabled = True
            Timer1.Start()
            stateTimer = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo > 0 Then
            lblTime.ForeColor = Color.White
            tiempo = tiempo - 1

            If marcados = 1 Then

                checkPapa.Enabled = False
                checkHija.Enabled = False
                checkHijo.Enabled = False
                checkHijoMenor.Enabled = False
                checkMama.Enabled = False
                btnEmpezar.Enabled = False

                'El papá avanza
                If checkPapa.Checked = True Then
                    If papa.Visible = True And papaIzq.Visible = False Then
                        If papa.Left >= 441 And papa.Left <= 850 And stateTimer = True Then
                            papa.Left = papa.Left - velPapa
                            imgLinterna.Left = imgLinterna.Left - velPapa
                        End If
                        If papa.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkPapa.Checked = False
                            papa.Visible = False
                            papa.Top = 267
                            papa.Left = 841
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf papaIzq.Visible = True And papa.Visible = False Then
                        If papaIzq.Left >= 200 And papaIzq.Left <= 680 And stateTimer = True Then
                            papaIzq.Left = papaIzq.Left + velPapa
                            imgLinterna.Left = imgLinterna.Left + velPapa
                        End If
                        If papaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkPapa.Checked = False
                            papaIzq.Visible = False
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'El hijo avanza
                If checkHijo.Checked = True Then
                    If hijo.Visible = True And hijoIzq.Visible = False Then
                        If hijo.Left >= 441 And hijo.Left <= 850 And stateTimer = True Then
                            hijo.Left = hijo.Left - velHijo
                            imgLinterna.Left = imgLinterna.Left - velHijo
                        End If
                        If hijo.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            hijo.Visible = False
                            checkHijo.Checked = False
                            hijo.Top = 250
                            hijo.Left = 985
                            hijoIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijoIzq.Visible = True And hijo.Visible = False Then
                        If hijoIzq.Left >= 200 And hijoIzq.Left <= 700 And stateTimer = True Then
                            hijoIzq.Left = hijoIzq.Left + velHijo
                            imgLinterna.Left = imgLinterna.Left + velHijo
                        End If
                        If hijoIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            hijoIzq.Visible = False
                            hijoIzq.Top = 314
                            hijoIzq.Left = 193
                            hijo.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If

                'La hija avanza
                If checkHija.Checked = True Then
                    If hija.Visible = True And hijaIzq.Visible = False Then
                        If hija.Left >= 441 And hija.Left <= 850 And stateTimer = True Then
                            hija.Left = hija.Left - velHija
                            imgLinterna.Left = imgLinterna.Left - velHija
                        End If
                        If hija.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            hija.Visible = False
                            hija.Top = 261
                            hija.Left = 912
                            hijaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijaIzq.Visible = True And hija.Visible = False Then
                        If hijaIzq.Left >= 200 And hijaIzq.Left <= 680 And stateTimer = True Then
                            hijaIzq.Left = hijaIzq.Left + velHija
                            imgLinterna.Left = imgLinterna.Left + velHija
                        End If
                        If hijaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            hijaIzq.Visible = False
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            hija.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If

                'El hijo menor avanza
                If checkHijoMenor.Checked = True Then
                    If hijo2.Visible = True And hijo2Izq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If hijo2.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            hijo2.Visible = False
                            hijo2.Top = 261
                            hijo2.Left = 912
                            hijo2Izq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2Izq.Visible = True And hijo2.Visible = False Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 700 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            hijo2Izq.Visible = False
                            hijo2Izq.Top = 305
                            hijo2Izq.Left = 242
                            hijo2.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'La mamá avanza
                If checkMama.Checked = True Then
                    If mama.Visible = True And mamaIzq.Visible = False Then
                        If mama.Left >= 441 And mama.Left <= 850 And stateTimer = True Then
                            mama.Left = mama.Left - velMama
                            imgLinterna.Left = imgLinterna.Left - velMama
                        End If
                        If mama.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            mama.Visible = False
                            mama.Top = 230
                            mama.Left = 1110
                            mamaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf mamaIzq.Visible = True And mama.Visible = False Then
                        If mamaIzq.Left >= 200 And mamaIzq.Left <= 680 And stateTimer = True Then
                            mamaIzq.Left = mamaIzq.Left + velMama
                            imgLinterna.Left = imgLinterna.Left + velMama
                        End If
                        If mamaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            mamaIzq.Visible = False
                            mamaIzq.Top = 321
                            mamaIzq.Left = 83
                            mama.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
            ElseIf marcados = 2 Then
                checkPapa.Enabled = False
                checkHija.Enabled = False
                checkHijo.Enabled = False
                checkHijoMenor.Enabled = False
                checkMama.Enabled = False
                btnEmpezar.Enabled = False

                'Padre e hijo menor avanzan
                If checkHijoMenor.Checked = True And checkPapa.Checked = True Then
                    If hijo2.Visible = True And papa.Visible = True And hijo2Izq.Visible = False And papaIzq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            papa.Left = papa.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If papa.Left <= 460 Or hijo2.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkPapa.Checked = False
                            hijo2.Visible = False
                            papa.Visible = False
                            hijo2.Top = 340
                            hijo2.Left = 1051
                            papa.Top = 267
                            papa.Left = 841
                            hijo2Izq.Visible = True
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2.Visible = False And papa.Visible = False And hijo2Izq.Visible = True And papaIzq.Visible = True Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 700 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            papaIzq.Left = papaIzq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 700 Or papaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkPapa.Checked = False
                            hijo2Izq.Visible = False
                            papaIzq.Visible = False
                            hijo2Izq.Top = 414
                            hijo2Izq.Left = 136
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            hijo2.Visible = True
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo menor e hijo avanzan
                If checkHijoMenor.Checked = True And checkHijo.Checked = True Then
                    If hijo2.Visible = True And hijo.Visible = True And hijo2Izq.Visible = False And hijoIzq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            hijo.Left = hijo.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If hijo.Left <= 460 Or hijo2.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkHijo.Checked = False
                            hijo2.Visible = False
                            hijo.Visible = False
                            hijo2.Top = 340
                            hijo2.Left = 1051
                            hijo.Top = 250
                            hijo.Left = 985
                            hijo2Izq.Visible = True
                            hijoIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2.Visible = False And hijo.Visible = False And hijo2Izq.Visible = True And hijoIzq.Visible = True Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 700 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            hijoIzq.Left = hijoIzq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 700 Or hijoIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkHijo.Checked = False
                            hijo2Izq.Visible = False
                            hijoIzq.Visible = False
                            hijo2Izq.Top = 414
                            hijo2Izq.Left = 136
                            hijoIzq.Top = 305
                            hijoIzq.Left = 193
                            hijo2.Visible = True
                            hijo.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo menor e hija avanzan
                If checkHijoMenor.Checked = True And checkHija.Checked = True Then
                    If hijo2.Visible = True And hija.Visible = True And hijo2Izq.Visible = False And hijaIzq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            hija.Left = hija.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If hija.Left <= 460 Or hijo2.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkHija.Checked = False
                            hijo2.Visible = False
                            hija.Visible = False
                            hijo2.Top = 340
                            hijo2.Left = 1051
                            hija.Top = 261
                            hija.Left = 912
                            hijo2Izq.Visible = True
                            hijaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2.Visible = False And hija.Visible = False And hijo2Izq.Visible = True And hijaIzq.Visible = True Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 700 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            hijaIzq.Left = hijaIzq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 700 Or hijaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkHija.Checked = False
                            hijo2Izq.Visible = False
                            hijaIzq.Visible = False
                            hijo2Izq.Top = 414
                            hijo2Izq.Left = 136
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            hijo2.Visible = True
                            hija.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo menor y mama avanzan
                If checkHijoMenor.Checked = True And checkMama.Checked = True Then
                    If hijo2.Visible = True And mama.Visible = True And hijo2Izq.Visible = False And mamaIzq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            mama.Left = mama.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If mama.Left <= 460 Or hijo2.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkMama.Checked = False
                            hijo2.Visible = False
                            mama.Visible = False
                            hijo2.Top = 340
                            hijo2.Left = 1051
                            mama.Top = 230
                            mama.Left = 1110
                            hijo2Izq.Visible = True
                            mamaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2.Visible = False And mama.Visible = False And hijo2Izq.Visible = True And mamaIzq.Visible = True Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 700 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            mamaIzq.Left = mamaIzq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 700 Or mamaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            checkMama.Checked = False
                            hijo2Izq.Visible = False
                            mamaIzq.Visible = False
                            hijo2Izq.Top = 414
                            hijo2Izq.Left = 136
                            mamaIzq.Top = 83
                            mamaIzq.Left = 321
                            hijo2.Visible = True
                            mama.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo y papá avanzan
                If checkHijo.Checked = True And checkPapa.Checked = True Then
                    If hijo.Visible = True And papa.Visible = True And hijoIzq.Visible = False And papaIzq.Visible = False Then
                        If hijo.Left >= 441 And hijo.Left <= 850 And stateTimer = True Then
                            hijo.Left = hijo.Left - velHijo
                            papa.Left = papa.Left - velHijo
                            imgLinterna.Left = imgLinterna.Left - velHijo
                        End If
                        If papa.Left <= 460 Or hijo.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkPapa.Checked = False
                            hijo.Visible = False
                            papa.Visible = False
                            hijo.Top = 250
                            hijo.Left = 985
                            papa.Top = 267
                            papa.Left = 841
                            hijoIzq.Visible = True
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo.Visible = False And papa.Visible = False And hijoIzq.Visible = True And papaIzq.Visible = True Then
                        If hijoIzq.Left >= 200 And hijoIzq.Left <= 700 And stateTimer = True Then
                            hijoIzq.Left = hijoIzq.Left + velHijo
                            papaIzq.Left = papaIzq.Left + velHijo
                            imgLinterna.Left = imgLinterna.Left + velHijo
                        End If
                        If hijoIzq.Left >= 700 Or papaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkPapa.Checked = False
                            hijoIzq.Visible = False
                            papaIzq.Visible = False
                            hijoIzq.Top = 314
                            hijoIzq.Left = 193
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            hijo.Visible = True
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo e hija avanzan
                If checkHijo.Checked = True And checkHija.Checked = True Then
                    If hijo.Visible = True And hija.Visible = True And hijoIzq.Visible = False And hijaIzq.Visible = False Then
                        If hijo.Left >= 441 And hijo.Left <= 850 And stateTimer = True Then
                            hijo.Left = hijo.Left - velHijo
                            hija.Left = hija.Left - velHijo
                            imgLinterna.Left = imgLinterna.Left - velHijo
                        End If
                        If hija.Left <= 460 Or hijo.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkHija.Checked = False
                            hijo.Visible = False
                            hija.Visible = False
                            hijo.Top = 250
                            hijo.Left = 985
                            hija.Top = 261
                            hija.Left = 912
                            hijoIzq.Visible = True
                            hijaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo.Visible = False And hija.Visible = False And hijoIzq.Visible = True And hijaIzq.Visible = True Then
                        If hijoIzq.Left >= 200 And hijoIzq.Left <= 700 And stateTimer = True Then
                            hijoIzq.Left = hijoIzq.Left + velHijo
                            hijaIzq.Left = hijaIzq.Left + velHijo
                            imgLinterna.Left = imgLinterna.Left + velHijo
                        End If
                        If hijoIzq.Left >= 700 Or hijaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkHija.Checked = False
                            hijoIzq.Visible = False
                            hijaIzq.Visible = False
                            hijoIzq.Top = 314
                            hijoIzq.Left = 193
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            hijo.Visible = True
                            hija.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hijo y mamá avanzan
                If checkHijo.Checked = True And checkMama.Checked = True Then
                    If hijo.Visible = True And mama.Visible = True And hijoIzq.Visible = False And mamaIzq.Visible = False Then
                        If hijo.Left >= 441 And hijo.Left <= 850 And stateTimer = True Then
                            hijo.Left = hijo.Left - velHijo
                            mama.Left = mama.Left - velHijo
                            imgLinterna.Left = imgLinterna.Left - velHijo
                        End If
                        If mama.Left <= 460 Or hijo.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkMama.Checked = False
                            hijo.Visible = False
                            mama.Visible = False
                            hijo.Top = 250
                            hijo.Left = 985
                            mama.Top = 230
                            mama.Left = 1110
                            hijoIzq.Visible = True
                            mamaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo.Visible = False And mama.Visible = False And hijoIzq.Visible = True And mamaIzq.Visible = True Then
                        If hijoIzq.Left >= 200 And hijoIzq.Left <= 700 And stateTimer = True Then
                            hijoIzq.Left = hijoIzq.Left + velHijo
                            mamaIzq.Left = mamaIzq.Left + velHijo
                            imgLinterna.Left = imgLinterna.Left + velHijo
                        End If
                        If hijoIzq.Left >= 700 Or mamaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            checkMama.Checked = False
                            hijoIzq.Visible = False
                            mamaIzq.Visible = False
                            hijoIzq.Top = 314
                            hijoIzq.Left = 193
                            mamaIzq.Top = 321
                            mamaIzq.Left = 83
                            hijo.Visible = True
                            mama.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Papa e hija avanzan
                If checkHija.Checked = True And checkPapa.Checked = True Then
                    If hija.Visible = True And papa.Visible = True And hijaIzq.Visible = False And papaIzq.Visible = False Then
                        If hija.Left >= 441 And hija.Left <= 850 And stateTimer = True Then
                            hija.Left = hija.Left - velHija
                            papa.Left = papa.Left - velHija
                            imgLinterna.Left = imgLinterna.Left - velHija
                        End If
                        If papa.Left <= 460 Or hija.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            checkPapa.Checked = False
                            hija.Visible = False
                            papa.Visible = False
                            hija.Top = 261
                            hija.Left = 912
                            papa.Top = 267
                            papa.Left = 841
                            hijaIzq.Visible = True
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hija.Visible = False And papa.Visible = False And hijaIzq.Visible = True And papaIzq.Visible = True Then
                        If hijaIzq.Left >= 200 And hijaIzq.Left <= 700 And stateTimer = True Then
                            hijaIzq.Left = hijaIzq.Left + velHija
                            papaIzq.Left = papaIzq.Left + velHija
                            imgLinterna.Left = imgLinterna.Left + velHija
                        End If
                        If hijaIzq.Left >= 700 Or papaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            checkPapa.Checked = False
                            hijaIzq.Visible = False
                            papaIzq.Visible = False
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            hija.Visible = True
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Hija y mamá avanzan
                If checkHija.Checked = True And checkMama.Checked = True Then
                    If hija.Visible = True And mama.Visible = True And hijaIzq.Visible = False And mamaIzq.Visible = False Then
                        If hija.Left >= 441 And hija.Left <= 850 And stateTimer = True Then
                            hija.Left = hija.Left - velHija
                            mama.Left = mama.Left - velHija
                            imgLinterna.Left = imgLinterna.Left - velHija
                        End If
                        If mama.Left <= 460 Or hija.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            checkMama.Checked = False
                            hija.Visible = False
                            mama.Visible = False
                            hija.Top = 261
                            hija.Left = 912
                            mama.Top = 230
                            mama.Left = 1110
                            hijaIzq.Visible = True
                            mamaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hija.Visible = False And mama.Visible = False And hijaIzq.Visible = True And mamaIzq.Visible = True Then
                        If hijaIzq.Left >= 200 And hijaIzq.Left <= 700 And stateTimer = True Then
                            hijaIzq.Left = hijaIzq.Left + velHija
                            mamaIzq.Left = mamaIzq.Left + velHija
                            imgLinterna.Left = imgLinterna.Left + velHija
                        End If
                        If hijaIzq.Left >= 700 Or mamaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            checkMama.Checked = False
                            hijaIzq.Visible = False
                            mamaIzq.Visible = False
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            mamaIzq.Top = 321
                            mamaIzq.Left = 83
                            hija.Visible = True
                            mama.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'Padre y madre avanzan
                If checkMama.Checked = True And checkPapa.Checked = True Then
                    If mama.Visible = True And papa.Visible = True And mamaIzq.Visible = False And papaIzq.Visible = False Then
                        If mama.Left >= 441 And mama.Left <= 850 And stateTimer = True Then
                            mama.Left = mama.Left - velMama
                            papa.Left = papa.Left - velMama
                            imgLinterna.Left = imgLinterna.Left - velMama
                        End If
                        If papa.Left <= 460 Or mama.Left <= 460 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            checkPapa.Checked = False
                            mama.Visible = False
                            papa.Visible = False
                            mama.Top = 230
                            mama.Left = 1110
                            papa.Top = 267
                            papa.Left = 841
                            mamaIzq.Visible = True
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf mama.Visible = False And papa.Visible = False And mamaIzq.Visible = True And papaIzq.Visible = True Then
                        If mamaIzq.Left >= 200 And mamaIzq.Left <= 700 And stateTimer = True Then
                            mamaIzq.Left = mamaIzq.Left + velMama
                            papaIzq.Left = papaIzq.Left + velMama
                            imgLinterna.Left = imgLinterna.Left + velMama
                        End If
                        If mamaIzq.Left >= 700 Or papaIzq.Left >= 700 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            checkPapa.Checked = False
                            mamaIzq.Visible = False
                            papaIzq.Visible = False
                            mamaIzq.Top = 321
                            mamaIzq.Left = 83
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            mama.Visible = True
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
            End If
        Else
            Timer1.Stop()
            MsgBox("Tiempo agotado.", vbExclamation, "Perdiste.")
            checkPapa.Enabled = False
            checkHija.Enabled = False
            checkHijo.Enabled = False
            checkHijoMenor.Enabled = False
            checkMama.Enabled = False
            btnEmpezar.Enabled = False
        End If

        If tiempo > 10 Then
            lblTime.Text = tiempo.ToString
        ElseIf tiempo < 10 Then
            lblTime.Text = "0" + tiempo.ToString
            lblTime.ForeColor = Color.Red
        End If

        If stateTimer = False Then
            checkPapa.Enabled = True
            checkHija.Enabled = True
            checkHijo.Enabled = True
            checkHijoMenor.Enabled = True
            checkMama.Enabled = True
            btnEmpezar.Enabled = True
        End If

        If papaIzq.Visible = True And hijoIzq.Visible = True And hijaIzq.Visible = True And hijo2Izq.Visible = True And mamaIzq.Visible = True Then
            Timer1.Stop()
            MsgBox("Haz ganado.", vbInformation, "Ganador.")
            checkPapa.Enabled = False
            checkHija.Enabled = False
            checkHijo.Enabled = False
            checkHijoMenor.Enabled = False
            checkMama.Enabled = False
            btnEmpezar.Enabled = False
        End If
    End Sub

    Private Sub checkPapa_CheckedChanged(sender As Object, e As EventArgs) Handles checkPapa.CheckedChanged
        If linternaIzq = False And papaIzq.Visible = True And checkPapa.Checked = True Then
            checkPapa.Checked = False
            MsgBox("No se puede seleccionar el papá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And papa.Visible = True And checkPapa.Checked = True Then
            checkPapa.Checked = False
            MsgBox("No se puede seleccionar el papá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And hijaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
                papaPrimero = True
            ElseIf mamaPrimero = True Or hijaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
                papaSegundo = True
            End If

            If checkPapa.Checked = True Then
                If papa.Visible = True And papaIzq.Visible = False Then
                    If papaPrimero = True Then
                        papa.Left = 650
                        papa.Top = 255
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        papa.Left = 721
                        papa.Top = 255
                    End If

                ElseIf papaIzq.Visible = True And papa.Visible = False Then
                    If papaPrimero = True Then
                        papaIzq.Left = 510
                        papaIzq.Top = 255
                        imgLinterna.Left = 565
                        imgLinterna.Top = 400
                    Else
                        papaIzq.Left = 435
                        papaIzq.Top = 255
                    End If

                End If
            End If

            If checkPapa.Checked = False Then
                If (papa.Left >= 650 And papa.Top = 255) Then
                    If papaPrimero = True Then
                        papa.Top = 267
                        papa.Left = 841
                        If hijaSegundo = True Or hijoSegundo = True Or hijoMenorSegundo = True Or mamaSegundo = True Then
                            If checkHija.Checked = True Then
                                hijaPrimero = True
                                hijaSegundo = False
                                hija.Left = 651
                                hija.Top = 260
                            End If

                            If checkHijo.Checked = True Then
                                hijoPrimero = True
                                hijoSegundo = False
                                hijo.Left = 651
                                hijo.Top = 260
                            End If

                            If checkHijoMenor.Checked = True Then
                                hijoMenorPrimero = True
                                hijoMenorSegundo = False
                                hijo2.Left = 651
                                hijo2.Top = 352
                            End If

                            If checkMama.Checked = True Then
                                mamaPrimero = True
                                mamaSegundo = False
                                mama.Left = 651
                                mama.Top = 260
                            End If
                        Else
                            imgLinterna.Left = 793
                            imgLinterna.Top = 394
                        End If
                    ElseIf papaSegundo = True Then
                        papa.Top = 267
                        papa.Left = 841
                    End If
                End If

                If (papaIzq.Left <= 510 And papaIzq.Top = 255) Then
                    If papaPrimero = True Then
                        papaIzq.Top = 304
                        papaIzq.Left = 310
                        If hijaSegundo = True Or hijoSegundo = True Or hijoMenorSegundo = True Or mamaSegundo = True Then
                            If checkHija.Checked = True Then
                                hijaPrimero = True
                                hijaSegundo = False
                                hijaIzq.Left = 502
                                hijaIzq.Top = 260
                            End If

                            If checkHijo.Checked = True Then
                                hijoPrimero = True
                                hijoSegundo = False
                                hijoIzq.Left = 502
                                hijoIzq.Top = 260
                            End If

                            If checkHijoMenor.Checked = True Then
                                hijoMenorPrimero = True
                                hijoMenorSegundo = False
                                hijo2Izq.Left = 502
                                hijo2Izq.Top = 352
                            End If

                            If checkMama.Checked = True Then
                                mamaPrimero = True
                                mamaSegundo = False
                                mamaIzq.Left = 502
                                mamaIzq.Top = 260
                            End If
                        Else
                            imgLinterna.Left = 391
                            imgLinterna.Top = 429
                        End If
                    ElseIf papaSegundo = True Then
                        papaIzq.Top = 304
                        papaIzq.Left = 310
                    End If
                End If

                If papaPrimero = True Then
                    papaPrimero = False
                End If

                If papaSegundo = True Then
                    papaSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHija_CheckedChanged(sender As Object, e As EventArgs) Handles checkHija.CheckedChanged
        If linternaIzq = False And hijaIzq.Visible = True And checkHija.Checked = True Then
            checkHija.Checked = False
            MsgBox("No se puede seleccionar a la hija porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hija.Visible = True And checkHija.Checked = True Then
            checkHija.Checked = False
            MsgBox("No se puede seleccionar a la hija porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
                hijaPrimero = True
            ElseIf mamaPrimero = True Or papaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
                hijaSegundo = True
            End If
            If checkHija.Checked = True Then
                If hija.Visible = True And hijaIzq.Visible = False Then
                    If hijaPrimero = True Then
                        hija.Left = 651
                        hija.Top = 260
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        hija.Left = 726
                        hija.Top = 260
                    End If

                ElseIf hijaIzq.Visible = True And hija.Visible = False Then
                    If hijaPrimero = True Then
                        hijaIzq.Left = 502
                        hijaIzq.Top = 260
                        imgLinterna.Left = 565
                        imgLinterna.Top = 400
                    Else
                        hijaIzq.Left = 427
                        hijaIzq.Top = 260
                    End If

                End If
            End If
            If checkHija.Checked = False Then
                If hija.Left >= 651 And hija.Top = 260 Then
                    If hijaPrimero = True Then
                        hija.Left = 912
                        hija.Top = 261
                        imgLinterna.Left = 793
                        imgLinterna.Top = 394
                    ElseIf hijaSegundo Then
                        hija.Left = 912
                        hija.Top = 261
                    End If
                End If
                If hijaIzq.Left <= 502 And hijaIzq.Top = 260 Then
                    If hijaPrimero = True Then
                        hijaIzq.Left = 242
                        hijaIzq.Top = 305
                        imgLinterna.Left = 391
                        imgLinterna.Top = 429
                    ElseIf hijaSegundo = True Then
                        hijaIzq.Left = 242
                        hijaIzq.Top = 305
                    End If
                End If

                If hijaPrimero = True Then
                    hijaPrimero = False
                End If
                If hijaSegundo = True Then
                    hijaSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHijo_CheckedChanged(sender As Object, e As EventArgs) Handles checkHijo.CheckedChanged
        If linternaIzq = False And hijoIzq.Visible = True And checkHijo.Checked = True Then
            checkHijo.Checked = False
            MsgBox("No se puede seleccionar al hijo porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hijo.Visible = True And checkHijo.Checked = True Then
            checkHijo.Checked = False
            MsgBox("No se puede seleccionar al hijo porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoMenorPrimero = False And hijaPrimero = False Then
            hijoPrimero = True
        ElseIf mamaPrimero = True Or papaPrimero = True Or hijoMenorPrimero = True Or hijaPrimero = True Then
            hijoSegundo = True
        End If
            If checkHijo.Checked = True Then
                If hijo.Visible = True And hijoIzq.Visible = False Then
                    If hijoPrimero = True Then
                        hijo.Left = 651
                        hijo.Top = 260
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        hijo.Left = 726
                        hijo.Top = 260
                    End If

                ElseIf hijoIzq.Visible = True And hijo.Visible = False Then
                    If hijoPrimero = True Then
                        hijoIzq.Left = 502
                        hijoIzq.Top = 260
                        imgLinterna.Left = 565
                        imgLinterna.Top = 400
                    Else
                        hijoIzq.Left = 427
                        hijoIzq.Top = 260
                    End If

                End If
            End If

            If checkHijo.Checked = False Then
                If hijo.Left = 726 And hijo.Top = 241 Or hijoPrimero = True Then
                    hijo.Left = 985
                    hijo.Top = 250
                    imgLinterna.Left = 793
                    imgLinterna.Top = 429
                End If
                If hijoIzq.Left = 427 And hijoIzq.Top = 250 Or hijoPrimero = True Then
                    hijoIzq.Left = 193
                    hijoIzq.Top = 314
                    imgLinterna.Left = 391
                    imgLinterna.Top = 394
                End If

                If hijoPrimero = True Then
                    hijoPrimero = False
                End If
                If hijoSegundo = True Then
                    hijoSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHijoMenor_CheckedChanged(sender As Object, e As EventArgs) Handles checkHijoMenor.CheckedChanged
        If linternaIzq = False And hijo2Izq.Visible = True And checkHijoMenor.Checked = True Then
            checkHijoMenor.Checked = False
            MsgBox("No se puede seleccionar al hijo menor porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hijo2.Visible = True And checkHijoMenor.Checked = True Then
            checkHijoMenor.Checked = False
            MsgBox("No se puede seleccionar al hijo menor porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoPrimero = False And hijaPrimero = False Then
                hijoMenorPrimero = True
            ElseIf mamaPrimero = True Or papaPrimero = True Or hijoPrimero = True Or hijaPrimero = True Then
                hijoMenorSegundo = True
            End If
            If checkHijoMenor.Checked = True Then
                If hijo2.Visible = True And hijo2Izq.Visible = False Then
                    If hijoMenorPrimero = True Then
                        hijo2.Left = 651
                        hijo2.Top = 352
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        hijo2.Left = 726
                        hijo2.Top = 342
                    End If

                ElseIf hijo2Izq.Visible = True And hijo2.Visible = False Then
                    If hijoMenorPrimero = True Then
                        hijo2Izq.Left = 502
                        hijo2Izq.Top = 352
                        imgLinterna.Left = 565
                        imgLinterna.Top = 390
                    Else
                        hijo2Izq.Left = 427
                        hijo2Izq.Top = 342
                    End If

                End If
            End If

            If checkHijoMenor.Checked = False Then
                If hijo2.Left = 726 And hijo2.Top = 241 Or hijoMenorPrimero = True Then
                    hijo2.Left = 1051
                    hijo2.Top = 340
                    imgLinterna.Left = 793
                    imgLinterna.Top = 429
                End If
                If hijo2Izq.Left = 427 And hijo2Izq.Top = 250 Or hijoMenorPrimero = True Then
                    hijo2Izq.Left = 136
                    hijo2Izq.Top = 414
                    imgLinterna.Left = 391
                    imgLinterna.Top = 394
                End If

                If hijoMenorPrimero = True Then
                    hijoMenorPrimero = False
                End If

                If hijoMenorSegundo = True Then
                    hijoMenorSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkMama_CheckedChanged(sender As Object, e As EventArgs) Handles checkMama.CheckedChanged
        If linternaIzq = False And mamaIzq.Visible = True And checkMama.Checked = True Then
            checkMama.Checked = False
            MsgBox("No se puede seleccionar a la mamá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And mama.Visible = True And checkMama.Checked = True Then
            checkMama.Checked = False
            MsgBox("No se puede seleccionar a la mamá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If papaPrimero = False And hijaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
            mamaPrimero = True
        ElseIf papaPrimero = True Or hijaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
            mamaSegundo = True
        End If
        If checkMama.Checked = True Then
            If mama.Visible = True And mamaIzq.Visible = False Then
                If mamaPrimero = True Then
                    mama.Left = 651
                    mama.Top = 255
                    imgLinterna.Left = 620
                    imgLinterna.Top = 390
                Else
                    mama.Left = 726
                    mama.Top = 255
                End If

            ElseIf mamaIzq.Visible = True And mama.Visible = False Then
                If mamaPrimero = True Then
                    mamaIzq.Left = 502
                    mamaIzq.Top = 255
                    imgLinterna.Left = 565
                    imgLinterna.Top = 400
                Else
                    mamaIzq.Left = 427
                    mamaIzq.Top = 255
                End If

            End If
        End If

        If checkMama.Checked = False Then
            If mama.Left = 726 And mama.Top = 241 Or mamaPrimero = True Then
                mama.Left = 1110
                mama.Top = 230
                    imgLinterna.Left = 793
                    imgLinterna.Top = 429
            End If
            If mamaIzq.Left = 427 And mamaIzq.Top = 250 Or mamaPrimero = True Then
                mamaIzq.Left = 83
                mamaIzq.Top = 321
                    imgLinterna.Left = 391
                    imgLinterna.Top = 394
            End If

            If mamaPrimero = True Then
                mamaPrimero = False
            End If

            If mamaSegundo = True Then
                mamaSegundo = False
            End If
        End If
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        If MsgBox("¿Quieres realmente reiniciar el juego?", vbYesNo, "Reiniciar el juego.") = vbYes Then

            Timer1.Stop()

            marcados = 0

            checkPapa.Checked = False
            checkMama.Checked = False
            checkHija.Checked = False
            checkHijo.Checked = False
            checkHijoMenor.Checked = False

            imgLinterna.Left = 793
            imgLinterna.Top = 394

            papa.Visible = True
            papa.Left = 841
            papa.Top = 267

            hijo.Visible = True
            hijo.Left = 985
            hijo.Top = 250

            hija.Visible = True
            hija.Left = 912
            hija.Top = 261

            hijo2.Visible = True
            hijo2.Left = 1051
            hijo2.Top = 340

            mama.Visible = True
            mama.Left = 1110
            mama.Top = 230

            papaIzq.Visible = False
            papaIzq.Left = 310
            papaIzq.Top = 304

            hijaIzq.Visible = False
            hijaIzq.Left = 242
            hijaIzq.Top = 305

            hijoIzq.Visible = False
            hijoIzq.Left = 193
            hijoIzq.Top = 314

            hijo2Izq.Visible = False
            hijo2Izq.Left = 136
            hijo2Izq.Top = 414

            mamaIzq.Visible = False
            mamaIzq.Left = 83
            mamaIzq.Top = 321

            lblTime.Text = 30

            tiempo = 30

            linternaIzq = False

            stateTimer = False
            papaPrimero = False
            mamaPrimero = False
            hijoPrimero = False
            hijaPrimero = False
            hijoMenorPrimero = False

            papaSegundo = False
            mamaSegundo = False
            hijoSegundo = False
            hijaSegundo = False
            hijoMenorSegundo = False

            checkPapa.Enabled = True
            checkHija.Enabled = True
            checkHijo.Enabled = True
            checkHijoMenor.Enabled = True
            checkMama.Enabled = True
            btnEmpezar.Enabled = True

            lblTime.ForeColor = Color.White
        End If
    End Sub
End Class

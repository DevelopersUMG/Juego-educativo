Public Class Nivel_15_1
    Dim txtresp1_nivel5 As String
    Dim txtresp2_nivel5 As String
    Dim txtresp3_nivel5 As String
    Dim txtresp4_nivel5 As String
    Dim txtresp5_nivel5 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String
    Public Function calificandoquinceb()


        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel5 = "we eat an apple" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel5 = "the women and the girls read" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel5 = "the boys" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel5 = "the girls drink water" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel5 = "the boys eat bread" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)

        Else
            punteo = 0
        End If
        Return punteo
    End Function

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        Dim nivelactual As Integer
        puntos = objeto.comprobarpunteo()
        nivelactual = objeto.comprobarnivel()

        Dim calificar As Integer
        If (puntos = 80) Then
            calificar = calificandoquinceb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_15.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_15.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Nivel_15.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 92 And puntos < 100) Then
            calificar = calificandoquinceb()
            Select Case calificar

                Case 4 And puntos = 92 ' si tiene 1 respuesta buena y tiene 12 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 4 And puntos = 96     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case 8 And puntos = 92      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case 8 And puntos = 96   ' si tiene 2 respuesta buena y tiene 16 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()


                Case 12 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case 12 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case 12 And puntos = 96
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()


                Case 16 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()

                Case 16 And puntos = 96
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    fin.Show()


            End Select




            'no califica------------------------------------------------------------------------------------------------------
            'calificandonivelunob()
        End If
        Me.Close()

    End Sub






    Private Sub TxtPregunta1_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta1_5_1.TextChanged
        txtresp1_nivel5 = TxtPregunta1_5_1.Text
    End Sub

    Private Sub TxtPregunta2_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta2_5_1.TextChanged
        txtresp2_nivel5 = TxtPregunta2_5_1.Text
    End Sub

    Private Sub TxtPregunta3_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta3_5_1.TextChanged
        txtresp3_nivel5 = TxtPregunta3_5_1.Text
    End Sub

    Private Sub TxtPregunta4_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta4_5_1.TextChanged
        txtresp4_nivel5 = TxtPregunta4_5_1.Text
    End Sub

    Private Sub TxtPregunta5_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5_5_1.TextChanged
        txtresp5_nivel5 = TxtPregunta5_5_1.Text

    End Sub

    Private Sub Nive3_15_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
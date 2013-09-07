Public Class Nivel_6_1
    Dim txtresp1_nivel6_1 As String
    Dim txtresp2_nivel6_1 As String
    Dim txtresp3_nivel6_1 As String
    Dim txtresp4_nivel6_1 As String
    Dim txtresp5_nivel6_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandonivelseisb()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel6_1 = CheckImg3.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6_1 + "--- Es incorrecto" + " " + CheckImg3.Text + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel6_1 = CheckImg6.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel6_1 + "--- Es incorrecto" + " " + CheckImg6.Text + " " + "numero de intentos " + conver)


        End If

        '------------------------------------------  tercer CheckBox  ---------------------------------------------

        If txtresp3_nivel6_1 = CheckImg11.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel6_1 + "--- Es incorrecto" + " " + CheckImg11.Text + " " + "numero de intentos " + conver)

        End If


        '------------------------------------------  cuarto CheckBox  ---------------------------------------------

        If txtresp4_nivel6_1 = CheckImg22.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel6_1 + "--- Es incorrecto" + " " + CheckImg22.Text + " " + "numero de intentos " + conver)

        End If



        '------------------------------------------  quinto CheckBox  ---------------------------------------------

        If txtresp5_nivel6_1 = CheckImg33.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel6_1 + "--- Es incorrecto" + " " + CheckImg33.Text + " " + "numero de intentos " + conver)

        End If


        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)

        Else
            punteo = 0
        End If

        Return punteo
    End Function
    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub


    Private Sub CheckImg3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg3.CheckedChanged
        txtresp1_nivel6_1 = CheckImg3.Text

    End Sub

    Private Sub CheckImg6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg6.CheckedChanged
        txtresp2_nivel6_1 = CheckImg6.Text
    End Sub

    Private Sub CheckImg11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg11.CheckedChanged
        txtresp3_nivel6_1 = CheckImg11.Text
    End Sub
    Private Sub CheckImg22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg22.CheckedChanged
        txtresp4_nivel6_1 = CheckImg22.Text
    End Sub
    Private Sub CheckImg33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg33.CheckedChanged
        txtresp5_nivel6_1 = CheckImg33.Text

    End Sub



    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 0) Then
            calificar = calificandonivelseisb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_6.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_6.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 4, 8
                    Nivel_6.Show()


                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Menu_Nivel_Intermedio.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 12 And puntos < 20) Then
            calificar = calificandonivelseisb()
            Select Case calificar

                Case 4 And puntos = 12 ' si tiene 1 respuesta buena y tiene 12 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()

                Case 4 And puntos = 16     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()



                Case 8 And puntos = 12      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 8 And puntos = 16   ' si tiene 2 respuesta buena y tiene 16 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()


                Case 12 And puntos = 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Intermedio.Show()

                Case 12 And puntos = 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 12 And puntos = 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()

                Case 16 And puntos = 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 16 And puntos = 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()

            End Select


            Me.Close()

        End If
    End Sub



    Private Sub CheckImg4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckImg1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



End Class
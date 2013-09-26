Public Class Nivel_10_1
    Dim txtresp1_nivel10_1 As String
    Dim txtresp2_nivel10_1 As String
    Dim txtresp3_nivel10_1 As String
    Dim txtresp4_nivel10_1 As String
    Dim txtresp5_nivel10_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String
    Public Function calificandoniveldiesb()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel10_1 = CheckImg1.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel10_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel10_1 = CheckImg12.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel10_1 + "--- Es incorrecto" + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel10_1 = CheckImg21.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel10_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel10_1 = CheckImg31.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel10_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If




        '------------------------------------------ quinto checkbox   ---------------------------------------------

        If txtresp5_nivel10_1 = CheckImg42.Text Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel10_1 + " Es incorrecto" + " " + "   " + "numero de intentos " + conver)

        End If


        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)

        Else
            punteo = 0
        End If

        MsgBox("Mandamos : " + punteo.ToString)
        Return punteo

    End Function
    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub


    Private Sub CheckImg1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg1.CheckedChanged
        txtresp1_nivel10_1 = CheckImg1.Text
    End Sub

    Private Sub CheckImg12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg12.CheckedChanged
        txtresp2_nivel10_1 = CheckImg12.Text

    End Sub

    Private Sub CheckImg21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg21.CheckedChanged
        txtresp3_nivel10_1 = CheckImg21.Text
    End Sub

    Private Sub CheckImg31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg31.CheckedChanged
        txtresp4_nivel10_1 = CheckImg31.Text
    End Sub

    Private Sub CheckImg42_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg42.CheckedChanged
        txtresp5_nivel10_1 = CheckImg42.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        Dim calificar As Integer
        Dim nivelactual As Integer
        puntos = objeto.comprobarpunteo()
        nivelactual = objeto.comprobarnivel()


        If (puntos = 80) Then
            calificar = calificandoniveldiesb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_10.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_10.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    objeto.modificarnivel(nivelactual, 1)
                    objeto.regresarpunteo()

                    Menu_Nivel_Intermedio.Show()

                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Nivel_10.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 92 And puntos < 100) Then
            calificar = calificandoniveldiesb()
            Select Case calificar

                Case 4 And puntos = 92 ' si tiene 1 respuesta buena y tiene 12 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Intermedio.Show()

                Case 4 And puntos = 96     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)

                    objeto.modificarnivel(nivelactual, 1)
                    objeto.regresarpunteo()
                    Menu_Nivel_Intermedio.Show()



                Case 8 And puntos = 92      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()

                Case 8 And puntos = 96   ' si tiene 2 respuesta buena y tiene 16 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()



                Case 12 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()

                Case 12 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()

                Case 12 And puntos = 96
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()


                Case 16 And puntos = 92
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()

                Case 16 And puntos = 96
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    objeto.regresarpunteo()
                    objeto.modificarnivel(nivelactual, 1)
                    Menu_Nivel_Intermedio.Show()



            End Select
        End If
        Me.Close()

    End Sub


End Class
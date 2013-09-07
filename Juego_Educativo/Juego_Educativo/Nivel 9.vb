Public Class Nivel_9
    Dim txtresp1_nivel9 As String
    Dim txtresp2_nivel9 As String
    Dim txtresp3_nivel9 As String
    Dim txtresp4_nivel9 As String
    Dim txtresp5_nivel9 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String

    Public Function calificandonivelnueve()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel9 = CheckImg11.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel9 = CheckImg23.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel9 + "--- Es incorrecto" + " " + "numero de intentos " + conver)
           
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel9 = CheckImg33.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
           
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel9 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
         
        End If




        '------------------------------------------ quinto checkbox   ---------------------------------------------

        If txtresp5_nivel9 = CheckImg52.Text Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel9 + " Es incorrecto" + " " + "   " + "numero de intentos " + conver)
         
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

    Private Sub CheckImg11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg11.CheckedChanged
        txtresp1_nivel9 = CheckImg11.Text


    End Sub

    Private Sub CheckImg23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg23.CheckedChanged
        txtresp2_nivel9 = CheckImg23.Text
    End Sub

    Private Sub CheckImg33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg33.CheckedChanged
        txtresp3_nivel9 = CheckImg33.Text
    End Sub

    Private Sub CheckImg41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg41.CheckedChanged
        txtresp4_nivel9 = CheckImg41.Text
    End Sub

    Private Sub CheckImg52_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg52.CheckedChanged
        txtresp5_nivel9 = CheckImg52.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim nivelactual As Integer
        Dim calificar As Integer
        Dim puntos As Integer
        nivelactual = objeto.comprobarnivel() ''llamada a comprobar nivel
        MsgBox("nivel actual" + nivelactual.ToString)
        If nivelactual = 1 Then
            puntos = objeto.comprobarpunteo()
            MsgBox("Tiene" + puntos.ToString)
            If (puntos = 60) Then
                calificar = calificandonivelnueve()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_9_1.Show()
                    Case 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Nivel_9_1.Show()
                    Case 20
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Menu_Nivel_Intermedio.Show()
                    Case 4
                        puntos = objeto.comprobarpunteo()
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Intermedio.Show()
                    Case 8
                        puntos = objeto.comprobarpunteo()
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Intermedio.Show()
                    Case Else
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Intermedio.Show()
                End Select
                Me.Close()

            ElseIf (puntos >= 72 And puntos < 80) Then
                calificar = calificandonivelnueve()
                Select Case calificar

                    Case 4 And puntos = 72 ' si tiene 1 respuesta buena y tiene 12 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 4 And puntos = 76     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()



                    Case 8 And puntos = 72      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 8 And puntos = 76   ' si tiene 2 respuesta buena y tiene 16 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()



                    Case 12 And puntos = 72
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 12 And puntos = 72
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 12 And puntos = 76
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                    Case 16 And puntos = 72
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 16 And puntos = 76
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                End Select


                Me.Close()
            ElseIf (puntos = 80) Then
                calificandonivelnueve()
                Menu_Nivel_Intermedio.Show()
            End If

        Else

            'no califica------------------------------------------------------------------------------------------------------
            calificandonivelnueve()
        End If
    End Sub

End Class
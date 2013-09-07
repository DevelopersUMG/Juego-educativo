Public Class Nivel_7

    Dim txtresp1_nivel7 As String
    Dim txtresp2_nivel7 As String
    Dim txtresp3_nivel7 As String
    Dim txtresp4_nivel7 As String
    Dim txtresp5_nivel7 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String

    Public Function calificandonivelsiete()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel7 = CheckImg12.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel7 + "--- Es incorrecto" + " " + CheckImg12.Text + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel7 = CheckImg23.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel7 + "--- Es incorrecto" + " " + CheckImg23.Text + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel7 = CheckImg32.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel7 + "--- Es incorrecto" + " " + CheckImg32.Text + " " + "numero de intentos " + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel7 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel7 + "--- Es incorrecto" + " " + CheckImg41.Text + " " + "numero de intentos " + conver)

        End If


        '------------------------------------------  quinto textbox    ---------------------------------------------

        If txtresp5_nivel7 = CheckImg53.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel7 + "--- Es incorrecto" + " " + CheckImg53.Text + " " + "numero de intentos " + conver)

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

    Private Sub Nivel_7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckImg12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg12.CheckedChanged
        txtresp1_nivel7 = CheckImg12.Text
    End Sub

    Private Sub CheckImg23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg23.CheckedChanged
        txtresp2_nivel7 = CheckImg23.Text
    End Sub

    Private Sub CheckImg32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg32.CheckedChanged
        txtresp3_nivel7 = CheckImg32.Text
    End Sub

    Private Sub CheckImg41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg41.CheckedChanged
        txtresp4_nivel7 = CheckImg41.Text
    End Sub

    Private Sub CheckImg53_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg53.CheckedChanged
        txtresp5_nivel7 = CheckImg53.Text
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
            If (puntos = 20) Then
                calificar = calificandonivelsiete()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_7_1.Show()
                    Case 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Nivel_7_1.Show()
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
            ElseIf (puntos >= 32 And puntos < 40) Then
                calificar = calificandonivelsiete()
                Select Case calificar

                    Case 4 And puntos = 32 ' si tiene 1 respuesta buena y tiene 12 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 4 And puntos = 36     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()



                    Case 8 And puntos = 32      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()
                    Case 8 And puntos = 36   ' si tiene 2 respuesta buena y tiene 16 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                    Case 12 And puntos = 32
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 12 And puntos = 32
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()


                    Case 12 And puntos = 36
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 16 And puntos = 32
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 16 And puntos = 36
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                End Select


                Me.Close()
            ElseIf (puntos = 40) Then
                calificandonivelsiete()
                Menu_Nivel_Intermedio.Show()
            End If

        Else

            'no califica------------------------------------------------------------------------------------------------------
            calificandonivelsiete()
        End If





    End Sub
End Class
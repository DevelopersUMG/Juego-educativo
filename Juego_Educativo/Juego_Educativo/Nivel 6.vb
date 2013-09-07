Public Class Nivel_6
    Dim txtresp1_nivel6 As String
    Dim txtresp2_nivel6 As String
    Dim txtresp3_nivel6 As String
    Dim txtresp4_nivel6 As String
    Dim txtresp5_nivel6 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String


    Public Function calificandonivelseis()


        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel6 = CheckImg11.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel6 = CheckImg22.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel6 = CheckImg33.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel6 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel6 + "--- Es incorrecto" + " " + "numero de intentos " + conver)

        End If




        '------------------------------------------  primer textbox    ---------------------------------------------

        If txtresp5_nivel6 = "dinner cats" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel6 + "--- Es incorrecto" + " " + TxtPregunta5.Text + " " + "numero de intentos " + conver)


        End If


        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)

        Else
            punteo = 0
        End If

        'MsgBox("Mandamos : " + punteo.ToString)

        Return punteo
    End Function
    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg11.CheckedChanged
        txtresp1_nivel6 = CheckImg11.Text

    End Sub



    Private Sub CheckImg22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg22.CheckedChanged
        txtresp2_nivel6 = CheckImg22.Text

    End Sub

    Private Sub CheckImg33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg33.CheckedChanged
        txtresp3_nivel6 = CheckImg33.Text

    End Sub

    Private Sub CheckImg41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg41.CheckedChanged
        txtresp4_nivel6 = CheckImg41.Text

    End Sub

    Private Sub TxtPregunta5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5.TextChanged
        txtresp5_nivel6 = TxtPregunta5.Text

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
            If (puntos = 0) Then
                calificar = calificandonivelseis()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_6_1.Show()
                    Case 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Nivel_6_1.Show()
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
            ElseIf (puntos >= 12 And puntos < 20) Then
                calificar = calificandonivelseis()
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
            ElseIf (puntos = 20) Then
                calificandonivelseis()
                Menu_Nivel_Facil.Show()
            End If

        Else

            'no califica------------------------------------------------------------------------------------------------------
            calificandonivelseis()
        End If


    End Sub

    Private Sub Nivel_6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class
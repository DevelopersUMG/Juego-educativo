Public Class Nivel_8

    Dim txtresp1_nivel8 As String
    Dim txtresp2_nivel8 As String
    Dim txtresp3_nivel8 As String
    Dim txtresp4_nivel8 As String
    Dim txtresp5_nivel8 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String

    Public Function calificandonivelocho()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel8 = "red" Then

            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel8 + "--- Es incorrecto" + " " + TxtPregunta1.Text + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel8 = "blue" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel8 + "--- Es incorrecto" + " " + TxtPregunta2.Text + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel8 = "yellow" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel8 + "--- Es incorrecto" + " " + TxtPregunta3.Text + " " + "numero de intentos " + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel8 = "orange" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel8 + "--- Es incorrecto" + " " + TxtPregunta4.Text + " " + "numero de intentos " + conver)

        End If


        '------------------------------------------  quinto textbox    ---------------------------------------------

        If txtresp5_nivel8 = "green" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel8 + "--- Es incorrecto" + " " + TxtPregunta5.Text + " " + "numero de intentos " + conver)

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

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3.Click

    End Sub

    Private Sub TxtPregunta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta1.TextChanged
        txtresp1_nivel8 = TxtPregunta1.Text
    End Sub

    Private Sub TxtPregunta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta2.TextChanged
        txtresp2_nivel8 = TxtPregunta2.Text
    End Sub

    Private Sub TxtPregunta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta3.TextChanged
        txtresp3_nivel8 = TxtPregunta3.Text
    End Sub

    Private Sub TxtPregunta4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta4.TextChanged
        txtresp4_nivel8 = TxtPregunta4.Text
    End Sub

    Private Sub TxtPregunta5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5.TextChanged
        txtresp5_nivel8 = TxtPregunta5.Text
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
            If (puntos = 40) Then
                calificar = calificandonivelocho()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_8_1.Show()
                    Case 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Nivel_8_1.Show()
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

            ElseIf (puntos >= 52 And puntos < 60) Then
                calificar = calificandonivelocho()
                Select Case calificar

                    Case 4 And puntos = 52 ' si tiene 1 respuesta buena y tiene 12 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 4 And puntos = 56     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()



                    Case 8 And puntos = 52      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 8 And puntos = 56   ' si tiene 2 respuesta buena y tiene 16 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()



                    Case 12 And puntos = 52
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 12 And puntos = 52
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 12 And puntos = 56
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                    Case 16 And puntos = 52
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Intermedio.Show()

                    Case 16 And puntos = 56
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Intermedio.Show()


                End Select


                Me.Close()
            ElseIf (puntos = 60) Then
                calificandonivelocho()
                Menu_Nivel_Intermedio.Show()
            End If

        Else

            'no califica------------------------------------------------------------------------------------------------------
            calificandonivelocho()
        End If
             
    End Sub

    Private Sub Nivel_8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
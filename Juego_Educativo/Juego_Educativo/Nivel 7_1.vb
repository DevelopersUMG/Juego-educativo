﻿Public Class Nivel_7_1
    Dim txtresp1_nivel7_1 As String
    Dim txtresp2_nivel7_1 As String
    Dim txtresp3_nivel7_1 As String
    Dim txtresp4_nivel7_1 As String
    Dim txtresp5_nivel7_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String
    Public Function calificandonivelsieteb()
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel7_1 = "scarf" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel7_1 + "--- Es incorrecto" + " " + txtImagen1.Text + " " + "numero de intentos " + conver)
           
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel7_1 = "jeans" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel7_1 + "--- Es incorrecto" + " " + txtImagen2.Text + " " + "numero de intentos " + conver)
           
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel7_1 = "skirt" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel7_1 + "--- Es incorrecto" + " " + txtImagen3.Text + " " + "numero de intentos " + conver)
           
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel7_1 = "blouse" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel7_1 + "--- Es incorrecto" + " " + txtImagen4.Text + " " + "numero de intentos " + conver)
           
        End If


        '------------------------------------------  quinto textbox    ---------------------------------------------

        If txtresp5_nivel7_1 = "pyjamas" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel7_1 + "--- Es incorrecto" + " " + txtImagen5.Text + " " + "numero de intentos " + conver)
           
        End If




        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
          
        Else
            punteo = 0
        End If
        Return punteo
        MsgBox("Mandamos : " + punteo.ToString)

    End Function
    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub txtImagen1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1.TextChanged
        txtresp1_nivel7_1 = txtImagen1.Text
    End Sub

    Private Sub txtImagen2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2.TextChanged
        txtresp2_nivel7_1 = txtImagen2.Text
    End Sub

    Private Sub txtImagen3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3.TextChanged
        txtresp3_nivel7_1 = txtImagen3.Text
    End Sub

    Private Sub txtImagen4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4.TextChanged
        txtresp4_nivel7_1 = txtImagen4.Text
    End Sub

    Private Sub txtImagen5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5.TextChanged
        txtresp5_nivel7_1 = txtImagen5.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 20) Then
            calificar = calificandonivelsieteb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_7.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_7.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 4, 8
                    Nivel_7.Show()
            End Select

        ElseIf (puntos >= 32 And puntos < 40) Then
            calificar = calificandonivelsieteb()
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




            'no califica------------------------------------------------------------------------------------------------------
            'calificandonivelunob()
        End If
        Me.Close()






    End Sub
End Class
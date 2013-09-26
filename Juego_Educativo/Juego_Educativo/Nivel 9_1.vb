Public Class Nivel_9_1
    Dim txtresp1_nivel9_1 As String
    Dim txtresp2_nivel9_1 As String
    Dim txtresp3_nivel9_1 As String
    Dim txtresp4_nivel9_1 As String
    Dim txtresp5_nivel9_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String

    Public Function calificandonivelnueveb()

        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel9_1 = CheckImg3.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel9_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel9_1 = CheckImg11.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel9_1 + "--- Es incorrecto" + " " + "numero de intentos " + conver)

        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel9_1 = CheckImg23.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel9_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel9_1 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel9_1 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)

        End If




        '------------------------------------------ quinto checkbox   ---------------------------------------------

        If txtresp5_nivel9_1 = CheckImg52.Text Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel9_1 + " Es incorrecto" + " " + "   " + "numero de intentos " + conver)

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
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub CheckImg3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg3.CheckedChanged
        txtresp1_nivel9_1 = CheckImg3.Text
    End Sub

    Private Sub CheckImg11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg11.CheckedChanged
        txtresp2_nivel9_1 = CheckImg11.Text
    End Sub

    Private Sub CheckImg23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg23.CheckedChanged
        txtresp3_nivel9_1 = CheckImg23.Text
    End Sub

    Private Sub CheckImg41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg41.CheckedChanged
        txtresp4_nivel9_1 = CheckImg41.Text
    End Sub

    Private Sub CheckImg52_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg52.CheckedChanged
        txtresp5_nivel9_1 = CheckImg52.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 60) Then
            calificar = calificandonivelnueveb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_9.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_9.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Intermedio.Show()
                Case 4, 8
                    Nivel_9.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 72 And puntos < 80) Then
            calificar = calificandonivelnueveb()
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
        End If
        Me.Close()

    End Sub
End Class
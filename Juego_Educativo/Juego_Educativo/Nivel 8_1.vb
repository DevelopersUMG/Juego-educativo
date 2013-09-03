Public Class Nivel_8_1
    Dim txtresp1_nivel8_1 As String
    Dim txtresp2_nivel8_1 As String
    Dim txtresp3_nivel8_1 As String
    Dim txtresp4_nivel8_1 As String
    Dim txtresp5_nivel8_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim puntos As String
    Dim conver As String
    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub TxtPregunta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta1.TextChanged
        txtresp1_nivel8_1 = TxtPregunta1.Text
    End Sub

    Private Sub TxtPregunta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta2.TextChanged
        txtresp2_nivel8_1 = TxtPregunta2.Text
    End Sub

    Private Sub TxtPregunta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta3.TextChanged
        txtresp3_nivel8_1 = TxtPregunta3.Text
    End Sub

    Private Sub TxtPregunta4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta4.TextChanged
        txtresp4_nivel8_1 = TxtPregunta4.Text
    End Sub

    Private Sub TxtPregunta5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5.TextChanged
        txtresp5_nivel8_1 = TxtPregunta5.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel8_1 = "yellow" Then

            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel8_1 + "--- Es incorrecto" + " " + TxtPregunta1.Text + " " + "numero de intentos " + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_8.Show()
            End If
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel8_1 = "brown" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel8_1 + "--- Es incorrecto" + " " + TxtPregunta2.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_8.Show()
            End If
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel8_1 = "green" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel8_1 + "--- Es incorrecto" + " " + TxtPregunta3.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_8.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel8_1 = "red" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel8_1 + "--- Es incorrecto" + " " + TxtPregunta4.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_8.Show()
            End If
        End If


        '------------------------------------------  quinto textbox    ---------------------------------------------

        If txtresp5_nivel8_1 = "black" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel8_1 + "--- Es incorrecto" + " " + TxtPregunta5.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_8.Show()
            End If
        End If




        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_9.Show()
        Else
            punteo = 0
        End If
    End Sub
End Class
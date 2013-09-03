Public Class Nivel_6_1
    Dim txtresp1_nivel6_1 As String
    Dim txtresp2_nivel6_1 As String
    Dim txtresp3_nivel6_1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

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



    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel6_1 = CheckImg3.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6_1 + "--- Es incorrecto" + " " + CheckImg3.Text + " " + "numero de intentos " + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_6.Show()
            End If
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel6_1 = CheckImg6.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6_1 + "--- Es incorrecto" + " " + CheckImg6.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_6.Show()

            End If
        End If

        '------------------------------------------  tercer CheckBox  ---------------------------------------------

        If txtresp3_nivel6_1 = CheckImg11.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6_1 + "--- Es incorrecto" + " " + CheckImg11.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_6.Show()

            End If
        End If


        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_7.Show()
        Else
            punteo = 0
        End If
    End Sub

  
  
    Private Sub CheckImg4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg4.CheckedChanged

    End Sub

    Private Sub CheckImg1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImg1.CheckedChanged

    End Sub
End Class
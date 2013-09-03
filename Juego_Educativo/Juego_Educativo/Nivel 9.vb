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
        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel9 = CheckImg11.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_9_1.Show()
            End If
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel9 = CheckImg23.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel9 + "--- Es incorrecto" + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_9_1.Show()
            End If
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel9 = CheckImg33.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_9_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel9 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel9 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_9_1.Show()
            End If
        End If




        '------------------------------------------ quinto checkbox   ---------------------------------------------

        If txtresp5_nivel9 = CheckImg52.Text Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel9 + " Es incorrecto" + " " + "   " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_9_1.Show()
            End If
        End If


        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_10.Show()
        Else
            punteo = 0
        End If
    End Sub
End Class
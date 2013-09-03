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

        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel7 = CheckImg12.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel7 + "--- Es incorrecto" + " " + CheckImg12.Text + " " + "numero de intentos " + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_7_1.Show()
            End If
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel7 = CheckImg23.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel7 + "--- Es incorrecto" + " " + CheckImg23.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_7_1.Show()
            End If
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel7 = CheckImg32.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel7 + "--- Es incorrecto" + " " + CheckImg32.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_7_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel7 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel7 + "--- Es incorrecto" + " " + CheckImg41.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_7_1.Show()
            End If
        End If


        '------------------------------------------  quinto textbox    ---------------------------------------------

        If txtresp5_nivel7 = CheckImg53.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel7 + "--- Es incorrecto" + " " + CheckImg53.Text + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_7_1.Show()
            End If
        End If




        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_8.Show()
        Else
            punteo = 0
        End If
    End Sub
End Class
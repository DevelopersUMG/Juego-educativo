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

        '--------------------------------------   Primer CheckBox     -----------------------------------------------------

        If txtresp1_nivel6 = CheckImg11.Text Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_6_1.Show()
            End If
        End If

        '------------------------------------------  Seundo CheckBox  ---------------------------------------------

        If txtresp2_nivel6 = CheckImg22.Text Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_6_1.Show()
            End If
        End If

        '------------------------------------------  Tercer CheckBox    ---------------------------------------------

        If txtresp3_nivel6 = CheckImg33.Text Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel6 + "--- Es incorrecto" + " " + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_6_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel6 = CheckImg41.Text Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel6 + "--- Es incorrecto" + " " + "numero de intentos " + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_6_1.Show()
            End If
        End If




        '------------------------------------------  primer textbox    ---------------------------------------------

        If txtresp5_nivel6 = "dinner cats" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp1_nivel6 + "--- Es incorrecto" + " " + TxtPregunta5.Text + " " + "numero de intentos " + conver)

            If conta_errores > 2 Then
                Me.Close()
                Nivel_6_1.Show()
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

    Private Sub Nivel_6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
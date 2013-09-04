Public Class Nivel_4
    Dim txtresp1_nivel4 As String
    Dim txtresp2_nivel4 As String
    Dim txtresp3_nivel4 As String
    Dim txtresp4_nivel4 As String
    Dim txtresp5_nivel4 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel4 = "coffee" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_4_1.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel4 = "hamburger" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_4_1.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel4 = "cookies" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_4_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel4 = "orange juice" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_4_1.Show()
            End If
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel4 = "cake" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_4_1.Show()
            End If
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_5.Show()
        Else
            punteo = 0
        End If
    End Sub

    Private Sub txtImagen1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1.TextChanged
        txtresp1_nivel4 = txtImagen1.Text
    End Sub

    Private Sub txtImagen2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2.TextChanged
        txtresp2_nivel4 = txtImagen2.Text
    End Sub

    Private Sub txtImagen3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3.TextChanged
        txtresp3_nivel4 = txtImagen3.Text
    End Sub

    Private Sub txtImagen4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4.TextChanged
        txtresp4_nivel4 = txtImagen4.Text
    End Sub

    Private Sub txtImagen5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5.TextChanged
        txtresp5_nivel4 = txtImagen5.Text
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Nivel_4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Nivel_3_1a
    Dim txtresp1_nivel3 As String
    Dim txtresp2_nivel3 As String
    Dim txtresp3_nivel3 As String
    Dim txtresp4_nivel3 As String
    Dim txtresp5_nivel3 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String
    Private Sub txtpregunta1_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta1_3_1a.TextChanged
        txtresp1_nivel3 = txtpregunta1_3_1a.Text
    End Sub

    Private Sub txtpregunta2_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta2_3_1a.TextChanged
        txtresp2_nivel3 = txtpregunta2_3_1a.Text
    End Sub

    Private Sub txtpregunta3_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta3_3_1a.TextChanged
        txtresp3_nivel3 = txtpregunta3_3_1a.Text
    End Sub

    Private Sub txtpregunta4_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta4_3_1a.TextChanged
        txtresp4_nivel3 = txtpregunta4_3_1a.Text
    End Sub

    Private Sub txtpregunta5_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta5_3_1a.TextChanged
        txtresp5_nivel3 = txtpregunta5_3_1a.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click

    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub
End Class
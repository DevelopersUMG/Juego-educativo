Public Class Principal

    Private Sub Btn_Ingresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingresar.Click
        Menu_de_Opciones.Show()
        Me.Visible = False
    End Sub

    Private Sub Btn_Registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Registrarse.Click
        Registro.Show()
        Me.Visible = False
    End Sub

    Private Sub Btn_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Salir.Show()
    End Sub
End Class

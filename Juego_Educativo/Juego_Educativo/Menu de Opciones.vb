Public Class Menu_de_Opciones

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_Facil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Facil.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Private Sub Btn_Medio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Medio.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub Btn_Dificil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Dificil.Click
        Me.Close()
        Menu_Nivel_Avanzado.Show()
    End Sub
End Class
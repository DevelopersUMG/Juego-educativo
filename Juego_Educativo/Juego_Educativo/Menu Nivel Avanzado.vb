Public Class Menu_Nivel_Avanzado

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_de_Opciones.Show()
    End Sub

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub
End Class
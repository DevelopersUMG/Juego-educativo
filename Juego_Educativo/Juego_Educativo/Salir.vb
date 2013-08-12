Public Class Salir

    Private Sub Btn_Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Si.Click
        Me.Close()
        Principal.Visible = False
        Principal.Close()
    End Sub

    Private Sub Btn_No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_No.Click
        Me.Close()
        Principal.Show()
    End Sub
End Class
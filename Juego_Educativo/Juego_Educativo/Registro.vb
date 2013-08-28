Imports System.Data.SQLite
Imports Juego_Educativo.clases

Public Class Registro
    Dim conexion As String = "Data Source=database.db;Version=3;"
    Private Sub Btn_RegisCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegisCompleto.Click

        Dim crearcomando As SQLiteCommand
        Dim ejecutarin As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        sqlite_conn = New SQLiteConnection(conexion)
        Dim query As String
        Dim contador As Integer
        Dim queryin As String


        Try
            sqlite_conn.Open()
            query = "select * from usuarios where usuario='" + TextBox3.Text + "' "
            crearcomando = New SQLiteCommand(query, sqlite_conn)
            crearcomando.ExecuteNonQuery()
            dr = crearcomando.ExecuteReader()
            contador = 0

            While (dr.Read())

                contador = contador + 1


            End While
            Select Case contador
                Case 1
                    MsgBox("usuario duplicado ya existente, vuelva a crear otro usuario diferente")
                Case Is < 1
                    MsgBox("usuario y password creado correctamente")
                    queryin = "INSERT INTO usuarios (nombre,apellido,usuario,contrasena,nivel,punteo) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ",0,0)"
                    ejecutarin = New SQLiteCommand(queryin, sqlite_conn)
                    ejecutarin.ExecuteNonQuery()
            End Select

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        sqlite_conn.Close()
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Principal.Show()
    End Sub
End Class
Imports System.Data.SQLite
Imports Juego_Educativo.Principal
Module clases

End Module
Public Class usuario
    Public Function comprobarnivel()
        Dim crearcomando As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        Dim conexion As String = "Data Source=database.db;Version=3;"
        sqlite_conn = New SQLiteConnection(conexion)
        Dim enviar As Integer
        Try
            sqlite_conn.Open()
            Dim query = "select nivel from usuarios where usuario='" + Principal.Text_Usuario.Text + "'"
            crearcomando = New SQLiteCommand(query, sqlite_conn)
            crearcomando.ExecuteNonQuery()
            dr = crearcomando.ExecuteReader()
            dr.Read()
            enviar = dr.GetInt32(0)
            sqlite_conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return enviar
    End Function

    Public Sub comprobar()
    End Sub
    Public Sub calificar(ByVal punteo As Integer)

    End Sub


    Public Function comprobarpunteo()
        Dim crearcomando As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        Dim conexion As String = "Data Source=database.db;Version=3;"
        sqlite_conn = New SQLiteConnection(conexion)
        Dim enviar As Integer
        Try
            sqlite_conn.Open()
            Dim query = "select punteo from usuarios where usuario='" + Principal.Text_Usuario.Text + "'"
            crearcomando = New SQLiteCommand(query, sqlite_conn)
            crearcomando.ExecuteNonQuery()
            dr = crearcomando.ExecuteReader()
            dr.Read()
            enviar = dr.GetInt32(0)
            sqlite_conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return enviar
    End Function


    Public Sub modificarnivel(ByVal puntos As String)
        Dim conexion As String = "Data Source=database.db;Version=3;"
        Dim crearcomando As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        sqlite_conn = New SQLiteConnection(conexion)
        sqlite_conn.Open()
        If puntos >= 100 Then
            Dim query As String = "update usuarios set nivel= nivel+1,punteo=0 where usuario'=" + Principal.Text_Usuario.Text + "'"
            crearcomando = New SQLiteCommand(query, sqlite_conn)
            crearcomando.ExecuteNonQuery()
            dr = crearcomando.ExecuteReader()
            sqlite_conn.Close()

        End If
    End Sub

    Public Sub sumarpunteo(ByVal puntos As Integer, ByVal existente As Integer)
        Dim score As Integer
        score = puntos + existente
        Dim conexion As String = "Data Source=database.db;Version=3;"
        Dim crearcomando As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        sqlite_conn = New SQLiteConnection(conexion)
        sqlite_conn.Open()
        Dim query As String = "update usuarios set punteo=" + score.ToString + " where usuario='" + Principal.Text_Usuario.Text + "'"
        crearcomando = New SQLiteCommand(query, sqlite_conn)
        crearcomando.ExecuteNonQuery()
        dr = crearcomando.ExecuteReader()
        sqlite_conn.Close()
    End Sub
End Class

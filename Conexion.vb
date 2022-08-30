Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Configuration.ConfigurationManager


Public Class Conexion
    Private Servidor, DataBase, User, Pass As String

    Public Sub New()
        Try
            Servidor = System.Configuration.ConfigurationManager.AppSettings("Servidor").ToString
            DataBase = System.Configuration.ConfigurationManager.AppSettings("Database").ToString
            User = System.Configuration.ConfigurationManager.AppSettings("Usuario").ToString
            Pass = System.Configuration.ConfigurationManager.AppSettings("Password").ToString

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function AbrirConn() As MySqlConnection
        Dim MysqlConnectionString As String
        Dim conn As MySqlConnection

        MysqlConnectionString = "Server=" + Servidor + ";" & "Database=" + DataBase + ";" & "Uid=" + User + ";" & "Pwd=" + Pass + ";"
        conn = New MySqlConnection(MysqlConnectionString)

        conn.Open()

        Return conn

    End Function
End Class



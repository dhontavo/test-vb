Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Form1

    Dim conn As New MySqlConnection
    Dim objetoConexion As New Conexion

    Dim cmd As MySqlCommand

    Private Sub limpiar()
        TxtObservacion.Text = ""
        TxtArticulo.Text = ""
        TxtCodigo.Text = ""
        TxtCosto.Text = ""
        TxtDescripcion.Text = ""
        TxtVenta.Text = ""
        TxtExistencia.Text = ""
    End Sub

    Private Sub Validar()

    End Sub

    Private Sub Mostrar()
        conn = objetoConexion.AbrirConn

        Dim query As String = "SELECT * FROM inventario"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()

        adpt.Fill(ds)
        Tabla.DataSource = ds.Tables(0)

        conn.Close()
        conn.Dispose()


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        conn = objetoConexion.AbrirConn


        Try

            cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO inventario (Codigo, Articulo, Descripcion, Costo, venta, Existencia, observacion) 
            VALUES('" + TxtCodigo.Text + "','" + TxtArticulo.Text + "','" + TxtDescripcion.Text + "','" + TxtCosto.Text + "','" + TxtVenta.Text + "','" + TxtExistencia.Text + "','" + TxtObservacion.Text + "')"


            cmd.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()

            Mostrar()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        conn = objetoConexion.AbrirConn


        Try

            cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE inventario set Articulo= @art, Descripcion =@des, Costo=@cos, venta= @ven, Existencia=@exis, observacion=@obs where Codigo = @cod"

            cmd.Parameters.AddWithValue("@cod", TxtCodigo.Text)
            cmd.Parameters.AddWithValue("@art", TxtArticulo.Text)
            cmd.Parameters.AddWithValue("@des", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@cos", TxtCosto.Text)
            cmd.Parameters.AddWithValue("@ven", TxtVenta.Text)
            cmd.Parameters.AddWithValue("@obs", TxtObservacion.Text)

            cmd.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()

            Mostrar()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        conn = objetoConexion.AbrirConn


        Try

            cmd = conn.CreateCommand
            cmd.CommandText = "DELETE inventario where Codigo = @cod"

            cmd.Parameters.AddWithValue("@cod", TxtCodigo.Text)

            cmd.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()

            Mostrar()
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellContentClick
        Dim row As DataGridViewRow = Tabla.CurrentRow
        Try
            TxtCodigo.Text = row.Cells(0).Value.ToString()
            TxtArticulo.Text = row.Cells(1).Value.ToString()
            TxtDescripcion.Text = row.Cells(2).Value.ToString()
            TxtCosto.Text = row.Cells(3).Value.ToString()
            TxtVenta.Text = row.Cells(4).Value.ToString()
            TxtDescripcion.Text = row.Cells(5).Value.ToString()
            TxtExistencia.Text = row.Cells(6).Value.ToString()
            TxtObservacion.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        conn = objetoConexion.AbrirConn
        Try
            Dim query As String = "SELECT* FROM inventario where Articulo like '%" & TxtBuscar.Text & "%' OR CODIGO LIKE '%" & TxtBuscar.Text & "%'"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds)

            Tabla.DataSource.Tables(0)

            conn.Close()
            conn.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        limpiar()
    End Sub
End Class

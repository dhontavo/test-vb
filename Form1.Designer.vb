<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(91, 24)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 23)
        Me.TxtCodigo.TabIndex = 1
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(90, 60)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(253, 23)
        Me.TxtArticulo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Articulo"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(106, 94)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(237, 23)
        Me.TxtDescripcion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'TxtCosto
        '
        Me.TxtCosto.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.Location = New System.Drawing.Point(77, 133)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(102, 23)
        Me.TxtCosto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Costo"
        '
        'TxtVenta
        '
        Me.TxtVenta.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVenta.Location = New System.Drawing.Point(77, 172)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(102, 23)
        Me.TxtVenta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Venta"
        '
        'TxtExistencia
        '
        Me.TxtExistencia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistencia.Location = New System.Drawing.Point(106, 208)
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.Size = New System.Drawing.Size(102, 23)
        Me.TxtExistencia.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Existencia"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(109, 238)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(234, 23)
        Me.TxtObservacion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Observacion"
        '
        'BNuevo
        '
        Me.BNuevo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNuevo.Location = New System.Drawing.Point(390, 27)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BNuevo.TabIndex = 14
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.Location = New System.Drawing.Point(390, 63)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 15
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.Location = New System.Drawing.Point(390, 97)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(75, 23)
        Me.BModificar.TabIndex = 16
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.Location = New System.Drawing.Point(390, 130)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 17
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(123, 299)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(382, 23)
        Me.TxtBuscar.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Buscar articulo"
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Articulo, Me.Descripcion, Me.Costo, Me.Venta, Me.Existencia, Me.Observacion})
        Me.Tabla.Location = New System.Drawing.Point(28, 325)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(743, 184)
        Me.Tabla.TabIndex = 20
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Venta
        '
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 521)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtExistencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtArticulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Inventario"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtExistencia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BNuevo As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Venta As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
End Class

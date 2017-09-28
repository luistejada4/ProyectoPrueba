<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Me.CodigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ArticulosComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Itbis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.AgregarButton = New System.Windows.Forms.Button()
        Me.BuscarClienteButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoMaskedTextBox
        '
        Me.CodigoMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMaskedTextBox.Location = New System.Drawing.Point(213, 108)
        Me.CodigoMaskedTextBox.Mask = "9999999"
        Me.CodigoMaskedTextBox.Name = "CodigoMaskedTextBox"
        Me.CodigoMaskedTextBox.Size = New System.Drawing.Size(100, 29)
        Me.CodigoMaskedTextBox.TabIndex = 0
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(213, 143)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(258, 29)
        Me.FechaDateTimePicker.TabIndex = 1
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.Enabled = False
        Me.ClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextBox.Location = New System.Drawing.Point(213, 178)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(258, 29)
        Me.ClienteTextBox.TabIndex = 2
        '
        'ArticulosComboBox
        '
        Me.ArticulosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosComboBox.FormattingEnabled = True
        Me.ArticulosComboBox.Location = New System.Drawing.Point(213, 213)
        Me.ArticulosComboBox.Name = "ArticulosComboBox"
        Me.ArticulosComboBox.Size = New System.Drawing.Size(258, 32)
        Me.ArticulosComboBox.TabIndex = 3
        Me.ArticulosComboBox.Text = "Seleccione un articulo"
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AllowUserToAddRows = False
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoArticulo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.Itbis})
        Me.ItemsDataGridView.Location = New System.Drawing.Point(213, 251)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.Size = New System.Drawing.Size(544, 150)
        Me.ItemsDataGridView.TabIndex = 4
        '
        'CodigoArticulo
        '
        Me.CodigoArticulo.DataPropertyName = "CodigoArticulo"
        Me.CodigoArticulo.HeaderText = "CodigoArticulo"
        Me.CodigoArticulo.Name = "CodigoArticulo"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Itbis
        '
        Me.Itbis.DataPropertyName = "Itbis"
        Me.Itbis.HeaderText = "Itbis"
        Me.Itbis.Name = "Itbis"
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(600, 407)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 30)
        Me.BuscarButton.TabIndex = 5
        Me.BuscarButton.Text = "Nuevo"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(681, 407)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 30)
        Me.GuardarButton.TabIndex = 6
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(319, 107)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 30)
        Me.ButtonBuscar.TabIndex = 8
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'AgregarButton
        '
        Me.AgregarButton.Location = New System.Drawing.Point(477, 218)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(75, 27)
        Me.AgregarButton.TabIndex = 9
        Me.AgregarButton.Text = "Agregar"
        Me.AgregarButton.UseVisualStyleBackColor = True
        '
        'BuscarClienteButton
        '
        Me.BuscarClienteButton.Location = New System.Drawing.Point(477, 178)
        Me.BuscarClienteButton.Name = "BuscarClienteButton"
        Me.BuscarClienteButton.Size = New System.Drawing.Size(75, 30)
        Me.BuscarClienteButton.TabIndex = 10
        Me.BuscarClienteButton.Text = "Buscar"
        Me.BuscarClienteButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Articulos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(208, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(271, 407)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(42, 25)
        Me.TotalLabel.TabIndex = 16
        Me.TotalLabel.Text = "0.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(349, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Realizar Pedido"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 441)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuscarClienteButton)
        Me.Controls.Add(Me.AgregarButton)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.ItemsDataGridView)
        Me.Controls.Add(Me.ArticulosComboBox)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.CodigoMaskedTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Cliente"
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CodigoMaskedTextBox As MaskedTextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents ArticulosComboBox As ComboBox
    Friend WithEvents ItemsDataGridView As DataGridView
    Friend WithEvents BuscarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents AgregarButton As Button
    Friend WithEvents BuscarClienteButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CodigoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Itbis As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ClienteTextBox As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaArticulos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FiltrarComboBox = New System.Windows.Forms.ComboBox()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FiltrarComboBox
        '
        Me.FiltrarComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrarComboBox.FormattingEnabled = True
        Me.FiltrarComboBox.Items.AddRange(New Object() {"Codigo", "Descripcion", "Costo", "Precio", "Ganancia", "Itbis"})
        Me.FiltrarComboBox.Location = New System.Drawing.Point(36, 51)
        Me.FiltrarComboBox.Name = "FiltrarComboBox"
        Me.FiltrarComboBox.Size = New System.Drawing.Size(121, 32)
        Me.FiltrarComboBox.TabIndex = 0
        Me.FiltrarComboBox.Text = "Filtrar"
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarTextBox.Location = New System.Drawing.Point(163, 54)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(182, 29)
        Me.BuscarTextBox.TabIndex = 1
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Costo, Me.Precio, Me.Existencia, Me.Ganancia, Me.ITBIS})
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(36, 89)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(743, 252)
        Me.ArticulosDataGridView.TabIndex = 2
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(351, 52)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 34)
        Me.BuscarButton.TabIndex = 3
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle6
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Existencia
        '
        Me.Existencia.DataPropertyName = "Existencia"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Existencia.DefaultCellStyle = DataGridViewCellStyle8
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        '
        'Ganancia
        '
        Me.Ganancia.DataPropertyName = "Ganancia"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Ganancia.DefaultCellStyle = DataGridViewCellStyle9
        Me.Ganancia.HeaderText = "% Ganancia"
        Me.Ganancia.Name = "Ganancia"
        '
        'ITBIS
        '
        Me.ITBIS.DataPropertyName = "Itbis"
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ITBIS.DefaultCellStyle = DataGridViewCellStyle10
        Me.ITBIS.HeaderText = "% ITBIS"
        Me.ITBIS.Name = "ITBIS"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ConsultaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 377)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.FiltrarComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConsultaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConsultaArticulos"
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FiltrarComboBox As ComboBox
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents ArticulosDataGridView As DataGridView
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As DataGridViewTextBoxColumn
    Friend WithEvents ITBIS As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider
End Class

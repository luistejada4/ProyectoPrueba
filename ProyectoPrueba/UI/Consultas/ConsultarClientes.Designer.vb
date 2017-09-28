<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarClientes
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
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.FiltrarComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Direccion})
        Me.ClientesDataGridView.Location = New System.Drawing.Point(29, 123)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(444, 201)
        Me.ClientesDataGridView.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarTextBox.Location = New System.Drawing.Point(156, 70)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(165, 31)
        Me.BuscarTextBox.TabIndex = 1
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(327, 70)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 30)
        Me.BuscarButton.TabIndex = 2
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'FiltrarComboBox
        '
        Me.FiltrarComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrarComboBox.FormattingEnabled = True
        Me.FiltrarComboBox.Items.AddRange(New Object() {"Codigo", "Nombre", "Direccion"})
        Me.FiltrarComboBox.Location = New System.Drawing.Point(29, 69)
        Me.FiltrarComboBox.Name = "FiltrarComboBox"
        Me.FiltrarComboBox.Size = New System.Drawing.Size(121, 32)
        Me.FiltrarComboBox.TabIndex = 3
        Me.FiltrarComboBox.Text = "Filtrar"
        '
        'ConsultarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 375)
        Me.Controls.Add(Me.FiltrarComboBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConsultarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultarCliente"
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents FiltrarComboBox As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroArticulos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExistenciaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CodigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.CostoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PrecioMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ITBISMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de articulos"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.AccessibleDescription = ""
        Me.DescripcionTextBox.AccessibleName = ""
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(166, 88)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(261, 31)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Articulo id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Costo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Existencia"
        '
        'ExistenciaMaskedTextBox
        '
        Me.ExistenciaMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaMaskedTextBox.Location = New System.Drawing.Point(166, 199)
        Me.ExistenciaMaskedTextBox.Mask = "999999"
        Me.ExistenciaMaskedTextBox.Name = "ExistenciaMaskedTextBox"
        Me.ExistenciaMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.ExistenciaMaskedTextBox.TabIndex = 4
        '
        'CodigoMaskedTextBox
        '
        Me.CodigoMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMaskedTextBox.Location = New System.Drawing.Point(166, 51)
        Me.CodigoMaskedTextBox.Mask = "999999"
        Me.CodigoMaskedTextBox.Name = "CodigoMaskedTextBox"
        Me.CodigoMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.CodigoMaskedTextBox.TabIndex = 0
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(328, 273)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 32)
        Me.EliminarButton.TabIndex = 7
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(247, 273)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 32)
        Me.GuardarButton.TabIndex = 6
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(166, 273)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 32)
        Me.NuevoButton.TabIndex = 8
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'CostoMaskedTextBox
        '
        Me.CostoMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoMaskedTextBox.Location = New System.Drawing.Point(166, 125)
        Me.CostoMaskedTextBox.Mask = "9999999"
        Me.CostoMaskedTextBox.Name = "CostoMaskedTextBox"
        Me.CostoMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.CostoMaskedTextBox.TabIndex = 2
        '
        'PrecioMaskedTextBox
        '
        Me.PrecioMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioMaskedTextBox.Location = New System.Drawing.Point(166, 162)
        Me.PrecioMaskedTextBox.Mask = "9999999"
        Me.PrecioMaskedTextBox.Name = "PrecioMaskedTextBox"
        Me.PrecioMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.PrecioMaskedTextBox.TabIndex = 3
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ITBISMaskedTextBox
        '
        Me.ITBISMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITBISMaskedTextBox.Location = New System.Drawing.Point(166, 236)
        Me.ITBISMaskedTextBox.Mask = "999999"
        Me.ITBISMaskedTextBox.Name = "ITBISMaskedTextBox"
        Me.ITBISMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.ITBISMaskedTextBox.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ITBIS"
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(278, 53)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 32)
        Me.BuscarButton.TabIndex = 22
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'RegistroArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 356)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ITBISMaskedTextBox)
        Me.Controls.Add(Me.PrecioMaskedTextBox)
        Me.Controls.Add(Me.CostoMaskedTextBox)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.CodigoMaskedTextBox)
        Me.Controls.Add(Me.ExistenciaMaskedTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RegistroArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RegistroArticulos"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ExistenciaMaskedTextBox As MaskedTextBox
    Friend WithEvents CodigoMaskedTextBox As MaskedTextBox
    Friend WithEvents EliminarButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents NuevoButton As Button
    Friend WithEvents CostoMaskedTextBox As MaskedTextBox
    Friend WithEvents PrecioMaskedTextBox As MaskedTextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents ITBISMaskedTextBox As MaskedTextBox
    Friend WithEvents BuscarButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroClientes
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.CodigoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de clientes"
        '
        'NameTextBox
        '
        Me.NameTextBox.AccessibleDescription = ""
        Me.NameTextBox.AccessibleName = ""
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(144, 134)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(261, 31)
        Me.NameTextBox.TabIndex = 1
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.AccessibleDescription = ""
        Me.DireccionTextBox.AccessibleName = ""
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(144, 171)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(261, 91)
        Me.DireccionTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cliente id"
        '
        'NuevoButton
        '
        Me.NuevoButton.Location = New System.Drawing.Point(157, 268)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(75, 32)
        Me.NuevoButton.TabIndex = 7
        Me.NuevoButton.Text = "Nuevo"
        Me.NuevoButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(238, 268)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 32)
        Me.GuardarButton.TabIndex = 8
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(319, 268)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 32)
        Me.EliminarButton.TabIndex = 9
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(254, 98)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 32)
        Me.BuscarButton.TabIndex = 10
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'CodigoMaskedTextBox
        '
        Me.CodigoMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMaskedTextBox.Location = New System.Drawing.Point(142, 98)
        Me.CodigoMaskedTextBox.Mask = "999999"
        Me.CodigoMaskedTextBox.Name = "CodigoMaskedTextBox"
        Me.CodigoMaskedTextBox.Size = New System.Drawing.Size(106, 31)
        Me.CodigoMaskedTextBox.TabIndex = 15
        '
        'RegistroClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 373)
        Me.Controls.Add(Me.CodigoMaskedTextBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.GuardarButton)
        Me.Controls.Add(Me.NuevoButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RegistroClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RegistroClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NuevoButton As Button
    Friend WithEvents GuardarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents BuscarButton As Button
    Friend WithEvents CodigoMaskedTextBox As MaskedTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PedidosToolStripMenuItem2, Me.RegistrosToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PedidosToolStripMenuItem2
        '
        Me.PedidosToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.VerPedidosToolStripMenuItem})
        Me.PedidosToolStripMenuItem2.Name = "PedidosToolStripMenuItem2"
        Me.PedidosToolStripMenuItem2.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem2.Text = "Pedidos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'VerPedidosToolStripMenuItem
        '
        Me.VerPedidosToolStripMenuItem.Name = "VerPedidosToolStripMenuItem"
        Me.VerPedidosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerPedidosToolStripMenuItem.Text = "Ver Pedidos"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem2, Me.ArticulosToolStripMenuItem2})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ClientesToolStripMenuItem2.Text = "Clientes"
        '
        'ArticulosToolStripMenuItem2
        '
        Me.ArticulosToolStripMenuItem2.Name = "ArticulosToolStripMenuItem2"
        Me.ArticulosToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ArticulosToolStripMenuItem2.Text = "Articulos"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.ArticulosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPedidosToolStripMenuItem As ToolStripMenuItem
End Class

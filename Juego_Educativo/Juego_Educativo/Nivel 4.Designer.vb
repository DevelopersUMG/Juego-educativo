<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nivel_4))
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(209, 375)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 7
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'Nivel_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(553, 424)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nivel_4"
        Me.Text = "Nivel_4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
End Class

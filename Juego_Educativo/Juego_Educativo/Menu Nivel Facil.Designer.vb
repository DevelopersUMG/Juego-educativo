<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Nivel_Facil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Nivel_Facil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Nivel1 = New System.Windows.Forms.Button()
        Me.Btn_Nivel2 = New System.Windows.Forms.Button()
        Me.Btn_Nivel3 = New System.Windows.Forms.Button()
        Me.Btn_Nivel4 = New System.Windows.Forms.Button()
        Me.Btn_Nivel5 = New System.Windows.Forms.Button()
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.Btn_RegreInicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escoja entre los Siguientes Niveles"
        '
        'Btn_Nivel1
        '
        Me.Btn_Nivel1.Location = New System.Drawing.Point(148, 208)
        Me.Btn_Nivel1.Name = "Btn_Nivel1"
        Me.Btn_Nivel1.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel1.TabIndex = 1
        Me.Btn_Nivel1.Text = "1"
        Me.Btn_Nivel1.UseVisualStyleBackColor = True
        '
        'Btn_Nivel2
        '
        Me.Btn_Nivel2.Location = New System.Drawing.Point(258, 208)
        Me.Btn_Nivel2.Name = "Btn_Nivel2"
        Me.Btn_Nivel2.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel2.TabIndex = 2
        Me.Btn_Nivel2.Text = "2"
        Me.Btn_Nivel2.UseVisualStyleBackColor = True
        '
        'Btn_Nivel3
        '
        Me.Btn_Nivel3.Location = New System.Drawing.Point(363, 208)
        Me.Btn_Nivel3.Name = "Btn_Nivel3"
        Me.Btn_Nivel3.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel3.TabIndex = 3
        Me.Btn_Nivel3.Text = "3"
        Me.Btn_Nivel3.UseVisualStyleBackColor = True
        '
        'Btn_Nivel4
        '
        Me.Btn_Nivel4.Location = New System.Drawing.Point(468, 208)
        Me.Btn_Nivel4.Name = "Btn_Nivel4"
        Me.Btn_Nivel4.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel4.TabIndex = 4
        Me.Btn_Nivel4.Text = "4"
        Me.Btn_Nivel4.UseVisualStyleBackColor = True
        '
        'Btn_Nivel5
        '
        Me.Btn_Nivel5.Location = New System.Drawing.Point(590, 208)
        Me.Btn_Nivel5.Name = "Btn_Nivel5"
        Me.Btn_Nivel5.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel5.TabIndex = 5
        Me.Btn_Nivel5.Text = "5"
        Me.Btn_Nivel5.UseVisualStyleBackColor = True
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(180, 449)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 6
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(417, 450)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(126, 36)
        Me.Btn_RegreInicio.TabIndex = 7
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Menu_Nivel_Facil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 582)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Controls.Add(Me.Btn_Nivel5)
        Me.Controls.Add(Me.Btn_Nivel4)
        Me.Controls.Add(Me.Btn_Nivel3)
        Me.Controls.Add(Me.Btn_Nivel2)
        Me.Controls.Add(Me.Btn_Nivel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_Nivel_Facil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Nivel_Facil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Nivel1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel4 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel5 As System.Windows.Forms.Button
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
End Class

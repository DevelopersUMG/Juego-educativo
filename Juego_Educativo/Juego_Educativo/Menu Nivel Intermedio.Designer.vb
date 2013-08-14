<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Nivel_Intermedio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Nivel_Intermedio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Nivel10 = New System.Windows.Forms.Button()
        Me.Btn_Nivel9 = New System.Windows.Forms.Button()
        Me.Btn_Nivel8 = New System.Windows.Forms.Button()
        Me.Btn_Nivel7 = New System.Windows.Forms.Button()
        Me.Btn_Nivel6 = New System.Windows.Forms.Button()
        Me.Btn_RegreInicio = New System.Windows.Forms.Button()
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(160, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja entre los Siguientes Niveles"
        '
        'Btn_Nivel10
        '
        Me.Btn_Nivel10.Location = New System.Drawing.Point(572, 242)
        Me.Btn_Nivel10.Name = "Btn_Nivel10"
        Me.Btn_Nivel10.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Nivel10.TabIndex = 10
        Me.Btn_Nivel10.Text = "10"
        Me.Btn_Nivel10.UseVisualStyleBackColor = True
        '
        'Btn_Nivel9
        '
        Me.Btn_Nivel9.Location = New System.Drawing.Point(472, 242)
        Me.Btn_Nivel9.Name = "Btn_Nivel9"
        Me.Btn_Nivel9.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Nivel9.TabIndex = 9
        Me.Btn_Nivel9.Text = "9"
        Me.Btn_Nivel9.UseVisualStyleBackColor = True
        '
        'Btn_Nivel8
        '
        Me.Btn_Nivel8.Location = New System.Drawing.Point(340, 242)
        Me.Btn_Nivel8.Name = "Btn_Nivel8"
        Me.Btn_Nivel8.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Nivel8.TabIndex = 8
        Me.Btn_Nivel8.Text = "8"
        Me.Btn_Nivel8.UseVisualStyleBackColor = True
        '
        'Btn_Nivel7
        '
        Me.Btn_Nivel7.Location = New System.Drawing.Point(221, 242)
        Me.Btn_Nivel7.Name = "Btn_Nivel7"
        Me.Btn_Nivel7.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Nivel7.TabIndex = 7
        Me.Btn_Nivel7.Text = "7"
        Me.Btn_Nivel7.UseVisualStyleBackColor = True
        '
        'Btn_Nivel6
        '
        Me.Btn_Nivel6.Location = New System.Drawing.Point(120, 242)
        Me.Btn_Nivel6.Name = "Btn_Nivel6"
        Me.Btn_Nivel6.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Nivel6.TabIndex = 6
        Me.Btn_Nivel6.Text = "6"
        Me.Btn_Nivel6.UseVisualStyleBackColor = True
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(530, 534)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(126, 36)
        Me.Btn_RegreInicio.TabIndex = 12
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(108, 533)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 11
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'Menu_Nivel_Intermedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 582)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Controls.Add(Me.Btn_Nivel10)
        Me.Controls.Add(Me.Btn_Nivel9)
        Me.Controls.Add(Me.Btn_Nivel8)
        Me.Controls.Add(Me.Btn_Nivel7)
        Me.Controls.Add(Me.Btn_Nivel6)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu_Nivel_Intermedio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Nivel_Intermedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Nivel10 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel9 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel8 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel7 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel6 As System.Windows.Forms.Button
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
End Class

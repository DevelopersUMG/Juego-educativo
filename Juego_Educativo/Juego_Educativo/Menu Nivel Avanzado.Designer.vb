<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Nivel_Avanzado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Nivel_Avanzado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Nivel15 = New System.Windows.Forms.Button()
        Me.Btn_Nivel14 = New System.Windows.Forms.Button()
        Me.Btn_Nivel13 = New System.Windows.Forms.Button()
        Me.Btn_Nivel12 = New System.Windows.Forms.Button()
        Me.Btn_Nivel11 = New System.Windows.Forms.Button()
        Me.Btn_RegreInicio = New System.Windows.Forms.Button()
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja entre los Siguientes Niveles"
        '
        'Btn_Nivel15
        '
        Me.Btn_Nivel15.Location = New System.Drawing.Point(477, 192)
        Me.Btn_Nivel15.Name = "Btn_Nivel15"
        Me.Btn_Nivel15.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel15.TabIndex = 10
        Me.Btn_Nivel15.UseVisualStyleBackColor = True
        '
        'Btn_Nivel14
        '
        Me.Btn_Nivel14.Location = New System.Drawing.Point(355, 192)
        Me.Btn_Nivel14.Name = "Btn_Nivel14"
        Me.Btn_Nivel14.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel14.TabIndex = 9
        Me.Btn_Nivel14.UseVisualStyleBackColor = True
        '
        'Btn_Nivel13
        '
        Me.Btn_Nivel13.Location = New System.Drawing.Point(250, 192)
        Me.Btn_Nivel13.Name = "Btn_Nivel13"
        Me.Btn_Nivel13.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel13.TabIndex = 8
        Me.Btn_Nivel13.UseVisualStyleBackColor = True
        '
        'Btn_Nivel12
        '
        Me.Btn_Nivel12.Location = New System.Drawing.Point(145, 192)
        Me.Btn_Nivel12.Name = "Btn_Nivel12"
        Me.Btn_Nivel12.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel12.TabIndex = 7
        Me.Btn_Nivel12.UseVisualStyleBackColor = True
        '
        'Btn_Nivel11
        '
        Me.Btn_Nivel11.Location = New System.Drawing.Point(35, 192)
        Me.Btn_Nivel11.Name = "Btn_Nivel11"
        Me.Btn_Nivel11.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Nivel11.TabIndex = 6
        Me.Btn_Nivel11.UseVisualStyleBackColor = True
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(407, 353)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(126, 36)
        Me.Btn_RegreInicio.TabIndex = 12
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(90, 352)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 11
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'Menu_Nivel_Avanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(595, 401)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Controls.Add(Me.Btn_Nivel15)
        Me.Controls.Add(Me.Btn_Nivel14)
        Me.Controls.Add(Me.Btn_Nivel13)
        Me.Controls.Add(Me.Btn_Nivel12)
        Me.Controls.Add(Me.Btn_Nivel11)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_Nivel_Avanzado"
        Me.Text = "Menu_Nivel_Avanzado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Nivel15 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel14 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel13 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel12 As System.Windows.Forms.Button
    Friend WithEvents Btn_Nivel11 As System.Windows.Forms.Button
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
End Class

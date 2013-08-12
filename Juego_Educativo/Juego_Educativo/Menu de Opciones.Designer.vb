<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_de_Opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_de_Opciones))
        Me.Btn_Facil = New System.Windows.Forms.Button()
        Me.Btn_Medio = New System.Windows.Forms.Button()
        Me.Btn_Dificil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_RegreInicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Facil
        '
        Me.Btn_Facil.BackgroundImage = CType(resources.GetObject("Btn_Facil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Facil.Location = New System.Drawing.Point(71, 186)
        Me.Btn_Facil.Name = "Btn_Facil"
        Me.Btn_Facil.Size = New System.Drawing.Size(108, 37)
        Me.Btn_Facil.TabIndex = 0
        Me.Btn_Facil.UseVisualStyleBackColor = True
        '
        'Btn_Medio
        '
        Me.Btn_Medio.BackgroundImage = CType(resources.GetObject("Btn_Medio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Medio.Location = New System.Drawing.Point(235, 186)
        Me.Btn_Medio.Name = "Btn_Medio"
        Me.Btn_Medio.Size = New System.Drawing.Size(108, 37)
        Me.Btn_Medio.TabIndex = 1
        Me.Btn_Medio.UseVisualStyleBackColor = True
        '
        'Btn_Dificil
        '
        Me.Btn_Dificil.BackgroundImage = CType(resources.GetObject("Btn_Dificil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Dificil.Location = New System.Drawing.Point(393, 186)
        Me.Btn_Dificil.Name = "Btn_Dificil"
        Me.Btn_Dificil.Size = New System.Drawing.Size(113, 37)
        Me.Btn_Dificil.TabIndex = 2
        Me.Btn_Dificil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 73)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Niveles De Juego"
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(248, 335)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(126, 36)
        Me.Btn_RegreInicio.TabIndex = 4
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Menu_de_Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(604, 421)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Dificil)
        Me.Controls.Add(Me.Btn_Medio)
        Me.Controls.Add(Me.Btn_Facil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_de_Opciones"
        Me.Text = "Menu_de_Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Facil As System.Windows.Forms.Button
    Friend WithEvents Btn_Medio As System.Windows.Forms.Button
    Friend WithEvents Btn_Dificil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
End Class

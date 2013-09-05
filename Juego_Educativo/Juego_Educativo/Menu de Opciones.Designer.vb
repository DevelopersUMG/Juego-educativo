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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Facil
        '
        Me.Btn_Facil.BackgroundImage = CType(resources.GetObject("Btn_Facil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Facil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Facil.Location = New System.Drawing.Point(171, 324)
        Me.Btn_Facil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Facil.Name = "Btn_Facil"
        Me.Btn_Facil.Size = New System.Drawing.Size(212, 46)
        Me.Btn_Facil.TabIndex = 0
        Me.Btn_Facil.UseVisualStyleBackColor = True
        '
        'Btn_Medio
        '
        Me.Btn_Medio.BackgroundImage = CType(resources.GetObject("Btn_Medio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Medio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Medio.Location = New System.Drawing.Point(509, 324)
        Me.Btn_Medio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Medio.Name = "Btn_Medio"
        Me.Btn_Medio.Size = New System.Drawing.Size(212, 46)
        Me.Btn_Medio.TabIndex = 1
        Me.Btn_Medio.UseVisualStyleBackColor = True
        '
        'Btn_Dificil
        '
        Me.Btn_Dificil.BackgroundImage = CType(resources.GetObject("Btn_Dificil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Dificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Dificil.Location = New System.Drawing.Point(819, 324)
        Me.Btn_Dificil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Dificil.Name = "Btn_Dificil"
        Me.Btn_Dificil.Size = New System.Drawing.Size(212, 46)
        Me.Btn_Dificil.TabIndex = 2
        Me.Btn_Dificil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(239, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(675, 91)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Niveles De Juego"
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(541, 627)
        Me.Btn_RegreInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(51, 50)
        Me.Btn_RegreInicio.TabIndex = 4
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 681)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Volver a Inicio"
        '
        'Menu_de_Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 716)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Dificil)
        Me.Controls.Add(Me.Btn_Medio)
        Me.Controls.Add(Me.Btn_Facil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Menu_de_Opciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_de_Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Facil As System.Windows.Forms.Button
    Friend WithEvents Btn_Medio As System.Windows.Forms.Button
    Friend WithEvents Btn_Dificil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

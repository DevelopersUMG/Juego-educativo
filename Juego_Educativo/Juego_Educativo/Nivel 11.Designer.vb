<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel_11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nivel_11))
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.txtrought = New System.Windows.Forms.TextBox()
        Me.lblap = New System.Windows.Forms.Label()
        Me.imgtrougth = New System.Windows.Forms.PictureBox()
        Me.Btn_Calificar = New System.Windows.Forms.Button()
        CType(Me.imgtrougth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(69, 524)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 9
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'txtrought
        '
        Me.txtrought.Location = New System.Drawing.Point(211, 265)
        Me.txtrought.Name = "txtrought"
        Me.txtrought.Size = New System.Drawing.Size(183, 20)
        Me.txtrought.TabIndex = 16
        '
        'lblap
        '
        Me.lblap.AutoSize = True
        Me.lblap.BackColor = System.Drawing.Color.Transparent
        Me.lblap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblap.ForeColor = System.Drawing.Color.White
        Me.lblap.Location = New System.Drawing.Point(229, 9)
        Me.lblap.Name = "lblap"
        Me.lblap.Size = New System.Drawing.Size(165, 25)
        Me.lblap.TabIndex = 15
        Me.lblap.Text = "Arma la Palabra"
        '
        'imgtrougth
        '
        Me.imgtrougth.BackColor = System.Drawing.Color.Transparent
        Me.imgtrougth.Image = Global.Juego_Educativo.My.Resources.Resources.thought
        Me.imgtrougth.Location = New System.Drawing.Point(194, 49)
        Me.imgtrougth.Name = "imgtrougth"
        Me.imgtrougth.Size = New System.Drawing.Size(226, 187)
        Me.imgtrougth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgtrougth.TabIndex = 14
        Me.imgtrougth.TabStop = False
        '
        'Btn_Calificar
        '
        Me.Btn_Calificar.Location = New System.Drawing.Point(492, 538)
        Me.Btn_Calificar.Name = "Btn_Calificar"
        Me.Btn_Calificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calificar.TabIndex = 19
        Me.Btn_Calificar.Text = "Calificar"
        Me.Btn_Calificar.UseVisualStyleBackColor = True
        '
        'Nivel_11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 582)
        Me.Controls.Add(Me.Btn_Calificar)
        Me.Controls.Add(Me.txtrought)
        Me.Controls.Add(Me.lblap)
        Me.Controls.Add(Me.imgtrougth)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nivel_11"
        Me.Text = "Nivel_11"
        CType(Me.imgtrougth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
    Friend WithEvents txtrought As System.Windows.Forms.TextBox
    Friend WithEvents lblap As System.Windows.Forms.Label
    Friend WithEvents imgtrougth As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Calificar As System.Windows.Forms.Button
End Class

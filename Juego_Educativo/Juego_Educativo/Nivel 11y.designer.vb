<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel_11y
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nivel_11y))
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.txtrought = New System.Windows.Forms.TextBox()
        Me.lblap = New System.Windows.Forms.Label()
        Me.imgtrougth = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Calificar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.imgtrougth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(69, 496)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(51, 51)
        Me.Btn_RegresaMenu.TabIndex = 9
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'txtrought
        '
        Me.txtrought.Location = New System.Drawing.Point(314, 342)
        Me.txtrought.Name = "txtrought"
        Me.txtrought.Size = New System.Drawing.Size(250, 20)
        Me.txtrought.TabIndex = 16
        '
        'lblap
        '
        Me.lblap.AutoSize = True
        Me.lblap.BackColor = System.Drawing.Color.Transparent
        Me.lblap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblap.ForeColor = System.Drawing.Color.Black
        Me.lblap.Location = New System.Drawing.Point(357, 49)
        Me.lblap.Name = "lblap"
        Me.lblap.Size = New System.Drawing.Size(165, 25)
        Me.lblap.TabIndex = 15
        Me.lblap.Text = "Arma la Palabra"
        '
        'imgtrougth
        '
        Me.imgtrougth.BackColor = System.Drawing.Color.Transparent

        Me.imgtrougth.Image = Global.Juego_Educativo.My.Resources.Resources.thought
        Me.imgtrougth.Location = New System.Drawing.Point(314, 97)
        Me.imgtrougth.Name = "imgtrougth"
        Me.imgtrougth.Size = New System.Drawing.Size(250, 200)
        Me.imgtrougth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgtrougth.TabIndex = 14
        Me.imgtrougth.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 550)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Calificar"
        '
        'Btn_Calificar
        '
        Me.Btn_Calificar.BackgroundImage = CType(resources.GetObject("Btn_Calificar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Calificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Calificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Calificar.Location = New System.Drawing.Point(532, 496)
        Me.Btn_Calificar.Name = "Btn_Calificar"
        Me.Btn_Calificar.Size = New System.Drawing.Size(51, 51)
        Me.Btn_Calificar.TabIndex = 40
        Me.Btn_Calificar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Volver al Menu"
        '
        'Nivel_11y
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 582)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Calificar)
        Me.Controls.Add(Me.txtrought)
        Me.Controls.Add(Me.lblap)
        Me.Controls.Add(Me.imgtrougth)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nivel_11y"
        Me.Text = "Nivel_11"
        CType(Me.imgtrougth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
    Friend WithEvents txtrought As System.Windows.Forms.TextBox
    Friend WithEvents lblap As System.Windows.Forms.Label
    Friend WithEvents imgtrougth As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Calificar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

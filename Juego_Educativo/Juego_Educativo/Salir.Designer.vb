<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Si = New System.Windows.Forms.Button()
        Me.Btn_No = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seguro que desea Salir!!"
        '
        'Btn_Si
        '
        Me.Btn_Si.Image = CType(resources.GetObject("Btn_Si.Image"), System.Drawing.Image)
        Me.Btn_Si.Location = New System.Drawing.Point(51, 93)
        Me.Btn_Si.Name = "Btn_Si"
        Me.Btn_Si.Size = New System.Drawing.Size(88, 35)
        Me.Btn_Si.TabIndex = 1
        Me.Btn_Si.UseVisualStyleBackColor = True
        '
        'Btn_No
        '
        Me.Btn_No.Image = CType(resources.GetObject("Btn_No.Image"), System.Drawing.Image)
        Me.Btn_No.Location = New System.Drawing.Point(272, 93)
        Me.Btn_No.Name = "Btn_No"
        Me.Btn_No.Size = New System.Drawing.Size(88, 35)
        Me.Btn_No.TabIndex = 2
        Me.Btn_No.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(413, 189)
        Me.Controls.Add(Me.Btn_No)
        Me.Controls.Add(Me.Btn_Si)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Salir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salir"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Si As System.Windows.Forms.Button
    Friend WithEvents Btn_No As System.Windows.Forms.Button
End Class

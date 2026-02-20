<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.multi = New System.Windows.Forms.Button()
        Me.restar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.divi = New System.Windows.Forms.Button()
        Me.uno = New System.Windows.Forms.Button()
        Me.tres = New System.Windows.Forms.Button()
        Me.dos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cinco = New System.Windows.Forms.Button()
        Me.seis = New System.Windows.Forms.Button()
        Me.cuatro = New System.Windows.Forms.Button()
        Me.cero = New System.Windows.Forms.Button()
        Me.ocho = New System.Windows.Forms.Button()
        Me.nueve = New System.Windows.Forms.Button()
        Me.siete = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "numero1"
        '
        'Sumar
        '
        Me.Sumar.Location = New System.Drawing.Point(678, 89)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(98, 42)
        Me.Sumar.TabIndex = 1
        Me.Sumar.Text = "SUMAR"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(177, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 55)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "numero2"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(177, 208)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Tag = " "
        Me.TextBox2.Text = "0"
        '
        'multi
        '
        Me.multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multi.Location = New System.Drawing.Point(678, 185)
        Me.multi.Name = "multi"
        Me.multi.Size = New System.Drawing.Size(98, 42)
        Me.multi.TabIndex = 5
        Me.multi.Text = "MULTIPLICACION"
        Me.multi.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.Location = New System.Drawing.Point(678, 137)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(98, 42)
        Me.restar.TabIndex = 6
        Me.restar.Text = "RESTAR"
        Me.restar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 55)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "0"
        '
        'divi
        '
        Me.divi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divi.Location = New System.Drawing.Point(678, 233)
        Me.divi.Name = "divi"
        Me.divi.Size = New System.Drawing.Size(98, 42)
        Me.divi.TabIndex = 9
        Me.divi.Text = "DIVICION"
        Me.divi.UseVisualStyleBackColor = True
        '
        'uno
        '
        Me.uno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uno.Location = New System.Drawing.Point(532, 88)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(39, 62)
        Me.uno.TabIndex = 10
        Me.uno.Text = "1"
        Me.uno.UseVisualStyleBackColor = True
        '
        'tres
        '
        Me.tres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tres.Location = New System.Drawing.Point(618, 88)
        Me.tres.Name = "tres"
        Me.tres.Size = New System.Drawing.Size(39, 62)
        Me.tres.TabIndex = 18
        Me.tres.Text = "3"
        Me.tres.UseVisualStyleBackColor = True
        '
        'dos
        '
        Me.dos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dos.Location = New System.Drawing.Point(573, 89)
        Me.dos.Name = "dos"
        Me.dos.Size = New System.Drawing.Size(39, 62)
        Me.dos.TabIndex = 19
        Me.dos.Text = "2"
        Me.dos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto04.My.Resources.Resources.raton_con_queso
        Me.PictureBox1.Location = New System.Drawing.Point(95, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'cinco
        '
        Me.cinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinco.Location = New System.Drawing.Point(573, 157)
        Me.cinco.Name = "cinco"
        Me.cinco.Size = New System.Drawing.Size(39, 62)
        Me.cinco.TabIndex = 23
        Me.cinco.Text = "5"
        Me.cinco.UseVisualStyleBackColor = True
        '
        'seis
        '
        Me.seis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seis.Location = New System.Drawing.Point(618, 156)
        Me.seis.Name = "seis"
        Me.seis.Size = New System.Drawing.Size(39, 62)
        Me.seis.TabIndex = 22
        Me.seis.Text = "6"
        Me.seis.UseVisualStyleBackColor = True
        '
        'cuatro
        '
        Me.cuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuatro.Location = New System.Drawing.Point(532, 156)
        Me.cuatro.Name = "cuatro"
        Me.cuatro.Size = New System.Drawing.Size(39, 62)
        Me.cuatro.TabIndex = 21
        Me.cuatro.Text = "4"
        Me.cuatro.UseVisualStyleBackColor = True
        '
        'cero
        '
        Me.cero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cero.Location = New System.Drawing.Point(573, 290)
        Me.cero.Name = "cero"
        Me.cero.Size = New System.Drawing.Size(39, 62)
        Me.cero.TabIndex = 24
        Me.cero.Text = "0"
        Me.cero.UseVisualStyleBackColor = True
        '
        'ocho
        '
        Me.ocho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ocho.Location = New System.Drawing.Point(573, 222)
        Me.ocho.Name = "ocho"
        Me.ocho.Size = New System.Drawing.Size(39, 62)
        Me.ocho.TabIndex = 27
        Me.ocho.Text = "8"
        Me.ocho.UseVisualStyleBackColor = True
        '
        'nueve
        '
        Me.nueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nueve.Location = New System.Drawing.Point(618, 222)
        Me.nueve.Name = "nueve"
        Me.nueve.Size = New System.Drawing.Size(39, 62)
        Me.nueve.TabIndex = 26
        Me.nueve.Text = "9"
        Me.nueve.UseVisualStyleBackColor = True
        '
        'siete
        '
        Me.siete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siete.Location = New System.Drawing.Point(532, 221)
        Me.siete.Name = "siete"
        Me.siete.Size = New System.Drawing.Size(39, 62)
        Me.siete.TabIndex = 25
        Me.siete.Text = "7"
        Me.siete.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(678, 281)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(98, 42)
        Me.borrar.TabIndex = 28
        Me.borrar.Text = "BORRAR"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(440, 135)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(440, 211)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(678, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 42)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.ocho)
        Me.Controls.Add(Me.nueve)
        Me.Controls.Add(Me.siete)
        Me.Controls.Add(Me.cero)
        Me.Controls.Add(Me.cinco)
        Me.Controls.Add(Me.seis)
        Me.Controls.Add(Me.cuatro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dos)
        Me.Controls.Add(Me.tres)
        Me.Controls.Add(Me.uno)
        Me.Controls.Add(Me.divi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.multi)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Sumar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents multi As Button
    Friend WithEvents restar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents divi As Button
    Friend WithEvents uno As Button
    Friend WithEvents tres As Button
    Friend WithEvents dos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cinco As Button
    Friend WithEvents seis As Button
    Friend WithEvents cuatro As Button
    Friend WithEvents cero As Button
    Friend WithEvents ocho As Button
    Friend WithEvents nueve As Button
    Friend WithEvents siete As Button
    Friend WithEvents borrar As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
End Class

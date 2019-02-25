<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_0 = New System.Windows.Forms.RichTextBox()
        Me.txt_1 = New System.Windows.Forms.RichTextBox()
        Me.txt_2 = New System.Windows.Forms.RichTextBox()
        Me.btn_copiar1 = New System.Windows.Forms.Button()
        Me.btn_comparar = New System.Windows.Forms.Button()
        Me.btn_copiar2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_archivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_abrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_abrir1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_abrir2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_guardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_guardarc = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_herramientas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_comparar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_agregart = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_acercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_manual = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_3 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_0
        '
        Me.txt_0.Location = New System.Drawing.Point(12, 37)
        Me.txt_0.Name = "txt_0"
        Me.txt_0.Size = New System.Drawing.Size(22, 210)
        Me.txt_0.TabIndex = 5
        Me.txt_0.Text = ""
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(49, 37)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(209, 210)
        Me.txt_1.TabIndex = 6
        Me.txt_1.Text = ""
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(278, 37)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(226, 210)
        Me.txt_2.TabIndex = 7
        Me.txt_2.Text = ""
        '
        'btn_copiar1
        '
        Me.btn_copiar1.Location = New System.Drawing.Point(92, 253)
        Me.btn_copiar1.Name = "btn_copiar1"
        Me.btn_copiar1.Size = New System.Drawing.Size(75, 23)
        Me.btn_copiar1.TabIndex = 8
        Me.btn_copiar1.Text = "Copiar >>"
        Me.btn_copiar1.UseVisualStyleBackColor = True
        '
        'btn_comparar
        '
        Me.btn_comparar.Location = New System.Drawing.Point(230, 253)
        Me.btn_comparar.Name = "btn_comparar"
        Me.btn_comparar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comparar.TabIndex = 9
        Me.btn_comparar.Text = "Comparar"
        Me.btn_comparar.UseVisualStyleBackColor = True
        '
        'btn_copiar2
        '
        Me.btn_copiar2.Location = New System.Drawing.Point(373, 253)
        Me.btn_copiar2.Name = "btn_copiar2"
        Me.btn_copiar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_copiar2.TabIndex = 10
        Me.btn_copiar2.Text = "<<Copiar"
        Me.btn_copiar2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_archivo, Me.menu_herramientas, Me.menu_ayuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_archivo
        '
        Me.menu_archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_abrir, Me.menu_guardar, Me.menu_guardarc, Me.menu_salir})
        Me.menu_archivo.Name = "menu_archivo"
        Me.menu_archivo.Size = New System.Drawing.Size(60, 20)
        Me.menu_archivo.Text = "Archivo"
        '
        'menu_abrir
        '
        Me.menu_abrir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_abrir1, Me.menu_abrir2})
        Me.menu_abrir.Name = "menu_abrir"
        Me.menu_abrir.Size = New System.Drawing.Size(180, 22)
        Me.menu_abrir.Text = "Abrir"
        '
        'menu_abrir1
        '
        Me.menu_abrir1.Name = "menu_abrir1"
        Me.menu_abrir1.Size = New System.Drawing.Size(180, 22)
        Me.menu_abrir1.Text = "Archivo1"
        '
        'menu_abrir2
        '
        Me.menu_abrir2.Name = "menu_abrir2"
        Me.menu_abrir2.Size = New System.Drawing.Size(180, 22)
        Me.menu_abrir2.Text = "Archivo 2 "
        '
        'menu_guardar
        '
        Me.menu_guardar.Name = "menu_guardar"
        Me.menu_guardar.Size = New System.Drawing.Size(180, 22)
        Me.menu_guardar.Text = "Guardar"
        '
        'menu_guardarc
        '
        Me.menu_guardarc.Name = "menu_guardarc"
        Me.menu_guardarc.Size = New System.Drawing.Size(180, 22)
        Me.menu_guardarc.Text = "Guardar Como"
        '
        'menu_salir
        '
        Me.menu_salir.Name = "menu_salir"
        Me.menu_salir.Size = New System.Drawing.Size(180, 22)
        Me.menu_salir.Text = "Salir"
        '
        'menu_herramientas
        '
        Me.menu_herramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_comparar, Me.menu_agregart})
        Me.menu_herramientas.Name = "menu_herramientas"
        Me.menu_herramientas.Size = New System.Drawing.Size(90, 20)
        Me.menu_herramientas.Text = "Herramientas"
        '
        'menu_comparar
        '
        Me.menu_comparar.Name = "menu_comparar"
        Me.menu_comparar.Size = New System.Drawing.Size(147, 22)
        Me.menu_comparar.Text = "Comparar"
        '
        'menu_agregart
        '
        Me.menu_agregart.Name = "menu_agregart"
        Me.menu_agregart.Size = New System.Drawing.Size(147, 22)
        Me.menu_agregart.Text = "Agregar Texto"
        '
        'menu_ayuda
        '
        Me.menu_ayuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_acercade, Me.menu_manual})
        Me.menu_ayuda.Name = "menu_ayuda"
        Me.menu_ayuda.Size = New System.Drawing.Size(53, 20)
        Me.menu_ayuda.Text = "Ayuda"
        '
        'menu_acercade
        '
        Me.menu_acercade.Name = "menu_acercade"
        Me.menu_acercade.Size = New System.Drawing.Size(199, 22)
        Me.menu_acercade.Text = "Acerca de"
        '
        'menu_manual
        '
        Me.menu_manual.Name = "menu_manual"
        Me.menu_manual.Size = New System.Drawing.Size(199, 22)
        Me.menu_manual.Text = "Manual de la aplicación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'txt_3
        '
        Me.txt_3.Location = New System.Drawing.Point(7, 20)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(466, 60)
        Me.txt_3.TabIndex = 0
        Me.txt_3.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_copiar2)
        Me.Controls.Add(Me.btn_comparar)
        Me.Controls.Add(Me.btn_copiar1)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.txt_0)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_0 As RichTextBox
    Friend WithEvents txt_1 As RichTextBox
    Friend WithEvents txt_2 As RichTextBox
    Friend WithEvents btn_copiar1 As Button
    Friend WithEvents btn_comparar As Button
    Friend WithEvents btn_copiar2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu_archivo As ToolStripMenuItem
    Friend WithEvents menu_abrir As ToolStripMenuItem
    Friend WithEvents menu_guardar As ToolStripMenuItem
    Friend WithEvents menu_guardarc As ToolStripMenuItem
    Friend WithEvents menu_salir As ToolStripMenuItem
    Friend WithEvents menu_herramientas As ToolStripMenuItem
    Friend WithEvents menu_comparar As ToolStripMenuItem
    Friend WithEvents menu_agregart As ToolStripMenuItem
    Friend WithEvents menu_ayuda As ToolStripMenuItem
    Friend WithEvents menu_acercade As ToolStripMenuItem
    Friend WithEvents menu_manual As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_3 As RichTextBox
    Friend WithEvents menu_abrir1 As ToolStripMenuItem
    Friend WithEvents menu_abrir2 As ToolStripMenuItem
End Class

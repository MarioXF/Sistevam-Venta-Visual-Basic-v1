﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.btnasignar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbobuscar = New System.Windows.Forms.ComboBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Listado = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtflag)
        Me.Panel1.Controls.Add(Me.btnasignar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.Listado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(260, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Listado de Empleados"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(479, 119)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(58, 20)
        Me.txtflag.TabIndex = 17
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'btnasignar
        '
        Me.btnasignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnasignar.Location = New System.Drawing.Point(77, 382)
        Me.btnasignar.Name = "btnasignar"
        Me.btnasignar.Size = New System.Drawing.Size(116, 31)
        Me.btnasignar.TabIndex = 16
        Me.btnasignar.Text = "Asignar Usuario"
        Me.btnasignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnasignar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.cbobuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(77, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 68)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por..."
        '
        'txtbuscar
        '
        Me.txtbuscar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtbuscar.Location = New System.Drawing.Point(131, 29)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'cbobuscar
        '
        Me.cbobuscar.ForeColor = System.Drawing.Color.Black
        Me.cbobuscar.FormattingEnabled = True
        Me.cbobuscar.Items.AddRange(New Object() {"nombres", "apellidos"})
        Me.cbobuscar.Location = New System.Drawing.Point(21, 29)
        Me.cbobuscar.Name = "cbobuscar"
        Me.cbobuscar.Size = New System.Drawing.Size(104, 21)
        Me.cbobuscar.TabIndex = 0
        Me.cbobuscar.Text = "nombres"
        '
        'btnEditar
        '
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(637, 382)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 31)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(525, 382)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 31)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Listado
        '
        Me.Listado.AllowUserToAddRows = False
        Me.Listado.AllowUserToDeleteRows = False
        Me.Listado.AllowUserToResizeColumns = False
        Me.Listado.AllowUserToResizeRows = False
        Me.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Listado.Location = New System.Drawing.Point(77, 145)
        Me.Listado.MultiSelect = False
        Me.Listado.Name = "Listado"
        Me.Listado.ReadOnly = True
        Me.Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Listado.Size = New System.Drawing.Size(646, 231)
        Me.Listado.TabIndex = 13
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtflag As TextBox
    Friend WithEvents btnasignar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbobuscar As ComboBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Listado As DataGridView
End Class

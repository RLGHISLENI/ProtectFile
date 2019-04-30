<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfManual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.txtChaveGerada = New System.Windows.Forms.TextBox()
    Me.lblChave = New System.Windows.Forms.Label()
    Me.lblTpoCodificacao = New System.Windows.Forms.Label()
    Me.lblTamanho = New System.Windows.Forms.Label()
    Me.cboTpoCodificacao = New System.Windows.Forms.ComboBox()
    Me.cboTamanho = New System.Windows.Forms.ComboBox()
    Me.btnOk = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtChaveGerada
    '
    Me.txtChaveGerada.Location = New System.Drawing.Point(132, 58)
    Me.txtChaveGerada.MaxLength = 32
    Me.txtChaveGerada.Name = "txtChaveGerada"
    Me.txtChaveGerada.Size = New System.Drawing.Size(272, 20)
    Me.txtChaveGerada.TabIndex = 5
    '
    'lblChave
    '
    Me.lblChave.AutoSize = True
    Me.lblChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblChave.Location = New System.Drawing.Point(12, 61)
    Me.lblChave.Name = "lblChave"
    Me.lblChave.Size = New System.Drawing.Size(114, 13)
    Me.lblChave.TabIndex = 4
    Me.lblChave.Text = "Chave de codificação:"
    '
    'lblTpoCodificacao
    '
    Me.lblTpoCodificacao.AutoSize = True
    Me.lblTpoCodificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTpoCodificacao.Location = New System.Drawing.Point(9, 9)
    Me.lblTpoCodificacao.Name = "lblTpoCodificacao"
    Me.lblTpoCodificacao.Size = New System.Drawing.Size(104, 13)
    Me.lblTpoCodificacao.TabIndex = 0
    Me.lblTpoCodificacao.Text = "Tipo de codificação:"
    '
    'lblTamanho
    '
    Me.lblTamanho.AutoSize = True
    Me.lblTamanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTamanho.Location = New System.Drawing.Point(297, 9)
    Me.lblTamanho.Name = "lblTamanho"
    Me.lblTamanho.Size = New System.Drawing.Size(55, 13)
    Me.lblTamanho.TabIndex = 2
    Me.lblTamanho.Text = "Tamanho:"
    '
    'cboTpoCodificacao
    '
    Me.cboTpoCodificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTpoCodificacao.FormattingEnabled = True
    Me.cboTpoCodificacao.Items.AddRange(New Object() {"AES - Advanced Encryption Standard", "3DES - Triple Data Encryption Standard"})
    Me.cboTpoCodificacao.Location = New System.Drawing.Point(12, 25)
    Me.cboTpoCodificacao.Name = "cboTpoCodificacao"
    Me.cboTpoCodificacao.Size = New System.Drawing.Size(282, 21)
    Me.cboTpoCodificacao.TabIndex = 1
    '
    'cboTamanho
    '
    Me.cboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTamanho.FormattingEnabled = True
    Me.cboTamanho.Location = New System.Drawing.Point(300, 25)
    Me.cboTamanho.Name = "cboTamanho"
    Me.cboTamanho.Size = New System.Drawing.Size(104, 21)
    Me.cboTamanho.TabIndex = 3
    '
    'btnOk
    '
    Me.btnOk.Location = New System.Drawing.Point(268, 91)
    Me.btnOk.Name = "btnOk"
    Me.btnOk.Size = New System.Drawing.Size(65, 23)
    Me.btnOk.TabIndex = 6
    Me.btnOk.Text = "OK"
    Me.btnOk.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(339, 91)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(65, 23)
    Me.btnCancelar.TabIndex = 7
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'frmInfManual
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.ClientSize = New System.Drawing.Size(424, 131)
    Me.ControlBox = False
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnOk)
    Me.Controls.Add(Me.txtChaveGerada)
    Me.Controls.Add(Me.lblChave)
    Me.Controls.Add(Me.lblTpoCodificacao)
    Me.Controls.Add(Me.lblTamanho)
    Me.Controls.Add(Me.cboTpoCodificacao)
    Me.Controls.Add(Me.cboTamanho)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmInfManual"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Chave de codificação"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtChaveGerada As System.Windows.Forms.TextBox
  Friend WithEvents lblChave As System.Windows.Forms.Label
  Friend WithEvents lblTpoCodificacao As System.Windows.Forms.Label
  Friend WithEvents lblTamanho As System.Windows.Forms.Label
  Friend WithEvents cboTpoCodificacao As System.Windows.Forms.ComboBox
  Friend WithEvents cboTamanho As System.Windows.Forms.ComboBox
  Friend WithEvents btnOk As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

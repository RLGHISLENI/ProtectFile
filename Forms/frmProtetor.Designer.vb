<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProtetor
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProtetor))
    Me.cboTpoCodificacao = New System.Windows.Forms.ComboBox()
    Me.lblTpoCodificacao = New System.Windows.Forms.Label()
    Me.lblTamanho = New System.Windows.Forms.Label()
    Me.cboTamanho = New System.Windows.Forms.ComboBox()
    Me.tabAcoes = New System.Windows.Forms.TabControl()
    Me.tbpProteger = New System.Windows.Forms.TabPage()
    Me.lblStatusProteger = New System.Windows.Forms.Label()
    Me.lblArqProtegido = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.txtArquivo = New System.Windows.Forms.TextBox()
    Me.btnSelecionar = New System.Windows.Forms.Button()
    Me.btnProteger = New System.Windows.Forms.Button()
    Me.txtChaveGerada = New System.Windows.Forms.TextBox()
    Me.lblChave = New System.Windows.Forms.Label()
    Me.btnGerarChave = New System.Windows.Forms.Button()
    Me.tbpResgatar = New System.Windows.Forms.TabPage()
    Me.grpDadosChave = New System.Windows.Forms.GroupBox()
    Me.btnInfManual = New System.Windows.Forms.Button()
    Me.txtNomeOriginalArq = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtTamanho = New System.Windows.Forms.TextBox()
    Me.txtTpoCodificacao = New System.Windows.Forms.TextBox()
    Me.txtChaveConvertida = New System.Windows.Forms.TextBox()
    Me.lblChvCodConvertida = New System.Windows.Forms.Label()
    Me.lblTpoCodResgatada = New System.Windows.Forms.Label()
    Me.lblTamResgatado = New System.Windows.Forms.Label()
    Me.lblStatusDesproteger = New System.Windows.Forms.Label()
    Me.lblInformeKey = New System.Windows.Forms.Label()
    Me.txtKeyArqProtegido = New System.Windows.Forms.TextBox()
    Me.btnSelKeyArqProtegido = New System.Windows.Forms.Button()
    Me.lblInformeArq = New System.Windows.Forms.Label()
    Me.txtArqProtegido = New System.Windows.Forms.TextBox()
    Me.btnSelArqProtegido = New System.Windows.Forms.Button()
    Me.btnDesproteger = New System.Windows.Forms.Button()
    Me.ofdArquivo = New System.Windows.Forms.OpenFileDialog()
    Me.tabAcoes.SuspendLayout()
    Me.tbpProteger.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbpResgatar.SuspendLayout()
    Me.grpDadosChave.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboTpoCodificacao
    '
    Me.cboTpoCodificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTpoCodificacao.FormattingEnabled = True
    Me.cboTpoCodificacao.Items.AddRange(New Object() {"AES - Advanced Encryption Standard", "3DES - Triple Data Encryption Standard"})
    Me.cboTpoCodificacao.Location = New System.Drawing.Point(11, 211)
    Me.cboTpoCodificacao.Name = "cboTpoCodificacao"
    Me.cboTpoCodificacao.Size = New System.Drawing.Size(282, 21)
    Me.cboTpoCodificacao.TabIndex = 4
    '
    'lblTpoCodificacao
    '
    Me.lblTpoCodificacao.AutoSize = True
    Me.lblTpoCodificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTpoCodificacao.Location = New System.Drawing.Point(8, 195)
    Me.lblTpoCodificacao.Name = "lblTpoCodificacao"
    Me.lblTpoCodificacao.Size = New System.Drawing.Size(104, 13)
    Me.lblTpoCodificacao.TabIndex = 3
    Me.lblTpoCodificacao.Text = "Tipo de codificação:"
    '
    'lblTamanho
    '
    Me.lblTamanho.AutoSize = True
    Me.lblTamanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTamanho.Location = New System.Drawing.Point(296, 195)
    Me.lblTamanho.Name = "lblTamanho"
    Me.lblTamanho.Size = New System.Drawing.Size(55, 13)
    Me.lblTamanho.TabIndex = 5
    Me.lblTamanho.Text = "Tamanho:"
    '
    'cboTamanho
    '
    Me.cboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTamanho.FormattingEnabled = True
    Me.cboTamanho.Location = New System.Drawing.Point(299, 211)
    Me.cboTamanho.Name = "cboTamanho"
    Me.cboTamanho.Size = New System.Drawing.Size(104, 21)
    Me.cboTamanho.TabIndex = 6
    '
    'tabAcoes
    '
    Me.tabAcoes.Controls.Add(Me.tbpProteger)
    Me.tabAcoes.Controls.Add(Me.tbpResgatar)
    Me.tabAcoes.Location = New System.Drawing.Point(32, 24)
    Me.tabAcoes.Name = "tabAcoes"
    Me.tabAcoes.SelectedIndex = 0
    Me.tabAcoes.Size = New System.Drawing.Size(424, 360)
    Me.tabAcoes.TabIndex = 0
    '
    'tbpProteger
    '
    Me.tbpProteger.Controls.Add(Me.lblStatusProteger)
    Me.tbpProteger.Controls.Add(Me.lblArqProtegido)
    Me.tbpProteger.Controls.Add(Me.PictureBox1)
    Me.tbpProteger.Controls.Add(Me.txtArquivo)
    Me.tbpProteger.Controls.Add(Me.btnSelecionar)
    Me.tbpProteger.Controls.Add(Me.btnProteger)
    Me.tbpProteger.Controls.Add(Me.txtChaveGerada)
    Me.tbpProteger.Controls.Add(Me.lblChave)
    Me.tbpProteger.Controls.Add(Me.btnGerarChave)
    Me.tbpProteger.Controls.Add(Me.lblTpoCodificacao)
    Me.tbpProteger.Controls.Add(Me.lblTamanho)
    Me.tbpProteger.Controls.Add(Me.cboTpoCodificacao)
    Me.tbpProteger.Controls.Add(Me.cboTamanho)
    Me.tbpProteger.Location = New System.Drawing.Point(4, 22)
    Me.tbpProteger.Name = "tbpProteger"
    Me.tbpProteger.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpProteger.Size = New System.Drawing.Size(416, 334)
    Me.tbpProteger.TabIndex = 0
    Me.tbpProteger.Text = "Proteger Arquivo"
    Me.tbpProteger.UseVisualStyleBackColor = True
    '
    'lblStatusProteger
    '
    Me.lblStatusProteger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblStatusProteger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStatusProteger.ForeColor = System.Drawing.Color.DarkRed
    Me.lblStatusProteger.Location = New System.Drawing.Point(174, 289)
    Me.lblStatusProteger.Name = "lblStatusProteger"
    Me.lblStatusProteger.Size = New System.Drawing.Size(229, 36)
    Me.lblStatusProteger.TabIndex = 11
    Me.lblStatusProteger.Text = "Status"
    Me.lblStatusProteger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblArqProtegido
    '
    Me.lblArqProtegido.AutoSize = True
    Me.lblArqProtegido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblArqProtegido.Location = New System.Drawing.Point(8, 148)
    Me.lblArqProtegido.Name = "lblArqProtegido"
    Me.lblArqProtegido.Size = New System.Drawing.Size(167, 13)
    Me.lblArqProtegido.TabIndex = 0
    Me.lblArqProtegido.Text = "Arquivo que deverá ser protegido:"
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(392, 129)
    Me.PictureBox1.TabIndex = 10
    Me.PictureBox1.TabStop = False
    '
    'txtArquivo
    '
    Me.txtArquivo.Location = New System.Drawing.Point(11, 164)
    Me.txtArquivo.Name = "txtArquivo"
    Me.txtArquivo.ReadOnly = True
    Me.txtArquivo.Size = New System.Drawing.Size(321, 20)
    Me.txtArquivo.TabIndex = 1
    Me.txtArquivo.TabStop = False
    '
    'btnSelecionar
    '
    Me.btnSelecionar.Location = New System.Drawing.Point(338, 162)
    Me.btnSelecionar.Name = "btnSelecionar"
    Me.btnSelecionar.Size = New System.Drawing.Size(65, 23)
    Me.btnSelecionar.TabIndex = 2
    Me.btnSelecionar.Text = "Selecionar"
    Me.btnSelecionar.UseVisualStyleBackColor = True
    '
    'btnProteger
    '
    Me.btnProteger.Enabled = False
    Me.btnProteger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProteger.Location = New System.Drawing.Point(11, 289)
    Me.btnProteger.Name = "btnProteger"
    Me.btnProteger.Size = New System.Drawing.Size(157, 36)
    Me.btnProteger.TabIndex = 10
    Me.btnProteger.Text = "Proteger >>"
    Me.btnProteger.UseVisualStyleBackColor = True
    '
    'txtChaveGerada
    '
    Me.txtChaveGerada.Location = New System.Drawing.Point(174, 258)
    Me.txtChaveGerada.Name = "txtChaveGerada"
    Me.txtChaveGerada.Size = New System.Drawing.Size(229, 20)
    Me.txtChaveGerada.TabIndex = 9
    '
    'lblChave
    '
    Me.lblChave.AutoSize = True
    Me.lblChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblChave.Location = New System.Drawing.Point(171, 242)
    Me.lblChave.Name = "lblChave"
    Me.lblChave.Size = New System.Drawing.Size(222, 13)
    Me.lblChave.TabIndex = 8
    Me.lblChave.Text = "Chave de codificação gerada aleatoriamente:"
    '
    'btnGerarChave
    '
    Me.btnGerarChave.Location = New System.Drawing.Point(11, 242)
    Me.btnGerarChave.Name = "btnGerarChave"
    Me.btnGerarChave.Size = New System.Drawing.Size(157, 39)
    Me.btnGerarChave.TabIndex = 7
    Me.btnGerarChave.Text = "Gerar chave de codificação"
    Me.btnGerarChave.UseVisualStyleBackColor = True
    '
    'tbpResgatar
    '
    Me.tbpResgatar.Controls.Add(Me.grpDadosChave)
    Me.tbpResgatar.Controls.Add(Me.lblStatusDesproteger)
    Me.tbpResgatar.Controls.Add(Me.lblInformeKey)
    Me.tbpResgatar.Controls.Add(Me.txtKeyArqProtegido)
    Me.tbpResgatar.Controls.Add(Me.btnSelKeyArqProtegido)
    Me.tbpResgatar.Controls.Add(Me.lblInformeArq)
    Me.tbpResgatar.Controls.Add(Me.txtArqProtegido)
    Me.tbpResgatar.Controls.Add(Me.btnSelArqProtegido)
    Me.tbpResgatar.Controls.Add(Me.btnDesproteger)
    Me.tbpResgatar.Location = New System.Drawing.Point(4, 22)
    Me.tbpResgatar.Name = "tbpResgatar"
    Me.tbpResgatar.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpResgatar.Size = New System.Drawing.Size(416, 334)
    Me.tbpResgatar.TabIndex = 1
    Me.tbpResgatar.Text = "Resgatar Arquivo"
    Me.tbpResgatar.UseVisualStyleBackColor = True
    '
    'grpDadosChave
    '
    Me.grpDadosChave.Controls.Add(Me.btnInfManual)
    Me.grpDadosChave.Controls.Add(Me.txtNomeOriginalArq)
    Me.grpDadosChave.Controls.Add(Me.Label2)
    Me.grpDadosChave.Controls.Add(Me.txtTamanho)
    Me.grpDadosChave.Controls.Add(Me.txtTpoCodificacao)
    Me.grpDadosChave.Controls.Add(Me.txtChaveConvertida)
    Me.grpDadosChave.Controls.Add(Me.lblChvCodConvertida)
    Me.grpDadosChave.Controls.Add(Me.lblTpoCodResgatada)
    Me.grpDadosChave.Controls.Add(Me.lblTamResgatado)
    Me.grpDadosChave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpDadosChave.Location = New System.Drawing.Point(14, 106)
    Me.grpDadosChave.Name = "grpDadosChave"
    Me.grpDadosChave.Size = New System.Drawing.Size(392, 177)
    Me.grpDadosChave.TabIndex = 16
    Me.grpDadosChave.TabStop = False
    Me.grpDadosChave.Text = " Dados da chave privada "
    '
    'btnInfManual
    '
    Me.btnInfManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnInfManual.Location = New System.Drawing.Point(294, 125)
    Me.btnInfManual.Name = "btnInfManual"
    Me.btnInfManual.Size = New System.Drawing.Size(92, 39)
    Me.btnInfManual.TabIndex = 22
    Me.btnInfManual.Text = "Informar chave"
    Me.btnInfManual.UseVisualStyleBackColor = True
    '
    'txtNomeOriginalArq
    '
    Me.txtNomeOriginalArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNomeOriginalArq.Location = New System.Drawing.Point(9, 90)
    Me.txtNomeOriginalArq.Name = "txtNomeOriginalArq"
    Me.txtNomeOriginalArq.ReadOnly = True
    Me.txtNomeOriginalArq.Size = New System.Drawing.Size(377, 20)
    Me.txtNomeOriginalArq.TabIndex = 19
    Me.txtNomeOriginalArq.TabStop = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(6, 74)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(130, 13)
    Me.Label2.TabIndex = 18
    Me.Label2.Text = "Nome do arquivo original :"
    '
    'txtTamanho
    '
    Me.txtTamanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTamanho.Location = New System.Drawing.Point(294, 42)
    Me.txtTamanho.Name = "txtTamanho"
    Me.txtTamanho.ReadOnly = True
    Me.txtTamanho.Size = New System.Drawing.Size(92, 20)
    Me.txtTamanho.TabIndex = 17
    Me.txtTamanho.TabStop = False
    '
    'txtTpoCodificacao
    '
    Me.txtTpoCodificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTpoCodificacao.Location = New System.Drawing.Point(9, 42)
    Me.txtTpoCodificacao.Name = "txtTpoCodificacao"
    Me.txtTpoCodificacao.ReadOnly = True
    Me.txtTpoCodificacao.Size = New System.Drawing.Size(279, 20)
    Me.txtTpoCodificacao.TabIndex = 15
    Me.txtTpoCodificacao.TabStop = False
    '
    'txtChaveConvertida
    '
    Me.txtChaveConvertida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtChaveConvertida.Location = New System.Drawing.Point(9, 141)
    Me.txtChaveConvertida.Name = "txtChaveConvertida"
    Me.txtChaveConvertida.ReadOnly = True
    Me.txtChaveConvertida.Size = New System.Drawing.Size(279, 20)
    Me.txtChaveConvertida.TabIndex = 21
    Me.txtChaveConvertida.TabStop = False
    '
    'lblChvCodConvertida
    '
    Me.lblChvCodConvertida.AutoSize = True
    Me.lblChvCodConvertida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblChvCodConvertida.Location = New System.Drawing.Point(6, 125)
    Me.lblChvCodConvertida.Name = "lblChvCodConvertida"
    Me.lblChvCodConvertida.Size = New System.Drawing.Size(114, 13)
    Me.lblChvCodConvertida.TabIndex = 20
    Me.lblChvCodConvertida.Text = "Chave de codificação:"
    '
    'lblTpoCodResgatada
    '
    Me.lblTpoCodResgatada.AutoSize = True
    Me.lblTpoCodResgatada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTpoCodResgatada.Location = New System.Drawing.Point(6, 26)
    Me.lblTpoCodResgatada.Name = "lblTpoCodResgatada"
    Me.lblTpoCodResgatada.Size = New System.Drawing.Size(104, 13)
    Me.lblTpoCodResgatada.TabIndex = 14
    Me.lblTpoCodResgatada.Text = "Tipo de codificação:"
    '
    'lblTamResgatado
    '
    Me.lblTamResgatado.AutoSize = True
    Me.lblTamResgatado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTamResgatado.Location = New System.Drawing.Point(291, 26)
    Me.lblTamResgatado.Name = "lblTamResgatado"
    Me.lblTamResgatado.Size = New System.Drawing.Size(55, 13)
    Me.lblTamResgatado.TabIndex = 16
    Me.lblTamResgatado.Text = "Tamanho:"
    '
    'lblStatusDesproteger
    '
    Me.lblStatusDesproteger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblStatusDesproteger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStatusDesproteger.ForeColor = System.Drawing.Color.YellowGreen
    Me.lblStatusDesproteger.Location = New System.Drawing.Point(14, 289)
    Me.lblStatusDesproteger.Name = "lblStatusDesproteger"
    Me.lblStatusDesproteger.Size = New System.Drawing.Size(229, 36)
    Me.lblStatusDesproteger.TabIndex = 15
    Me.lblStatusDesproteger.Text = "Status"
    Me.lblStatusDesproteger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblInformeKey
    '
    Me.lblInformeKey.AutoSize = True
    Me.lblInformeKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblInformeKey.Location = New System.Drawing.Point(11, 59)
    Me.lblInformeKey.Name = "lblInformeKey"
    Me.lblInformeKey.Size = New System.Drawing.Size(294, 13)
    Me.lblInformeKey.TabIndex = 3
    Me.lblInformeKey.Text = "Informe o arquivo contendo a chave privada ( #KEY_*.pfk ) :"
    '
    'txtKeyArqProtegido
    '
    Me.txtKeyArqProtegido.Location = New System.Drawing.Point(14, 75)
    Me.txtKeyArqProtegido.Name = "txtKeyArqProtegido"
    Me.txtKeyArqProtegido.ReadOnly = True
    Me.txtKeyArqProtegido.Size = New System.Drawing.Size(321, 20)
    Me.txtKeyArqProtegido.TabIndex = 4
    Me.txtKeyArqProtegido.TabStop = False
    '
    'btnSelKeyArqProtegido
    '
    Me.btnSelKeyArqProtegido.Location = New System.Drawing.Point(341, 73)
    Me.btnSelKeyArqProtegido.Name = "btnSelKeyArqProtegido"
    Me.btnSelKeyArqProtegido.Size = New System.Drawing.Size(65, 23)
    Me.btnSelKeyArqProtegido.TabIndex = 5
    Me.btnSelKeyArqProtegido.Text = "Selecionar"
    Me.btnSelKeyArqProtegido.UseVisualStyleBackColor = True
    '
    'lblInformeArq
    '
    Me.lblInformeArq.AutoSize = True
    Me.lblInformeArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblInformeArq.Location = New System.Drawing.Point(11, 13)
    Me.lblInformeArq.Name = "lblInformeArq"
    Me.lblInformeArq.Size = New System.Drawing.Size(231, 13)
    Me.lblInformeArq.TabIndex = 0
    Me.lblInformeArq.Text = "Informe o arquivo protegido ( #ProtectFile_*.* ) :"
    '
    'txtArqProtegido
    '
    Me.txtArqProtegido.Location = New System.Drawing.Point(14, 29)
    Me.txtArqProtegido.Name = "txtArqProtegido"
    Me.txtArqProtegido.ReadOnly = True
    Me.txtArqProtegido.Size = New System.Drawing.Size(321, 20)
    Me.txtArqProtegido.TabIndex = 1
    Me.txtArqProtegido.TabStop = False
    '
    'btnSelArqProtegido
    '
    Me.btnSelArqProtegido.Location = New System.Drawing.Point(341, 27)
    Me.btnSelArqProtegido.Name = "btnSelArqProtegido"
    Me.btnSelArqProtegido.Size = New System.Drawing.Size(65, 23)
    Me.btnSelArqProtegido.TabIndex = 2
    Me.btnSelArqProtegido.Text = "Selecionar"
    Me.btnSelArqProtegido.UseVisualStyleBackColor = True
    '
    'btnDesproteger
    '
    Me.btnDesproteger.Enabled = False
    Me.btnDesproteger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDesproteger.Location = New System.Drawing.Point(249, 289)
    Me.btnDesproteger.Name = "btnDesproteger"
    Me.btnDesproteger.Size = New System.Drawing.Size(157, 36)
    Me.btnDesproteger.TabIndex = 14
    Me.btnDesproteger.Text = "<< Desproteger"
    Me.btnDesproteger.UseVisualStyleBackColor = True
    '
    'ofdArquivo
    '
    Me.ofdArquivo.FileName = "ofdArquivo"
    '
    'frmProtetor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(495, 410)
    Me.Controls.Add(Me.tabAcoes)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmProtetor"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ProtectFile v1.0 - Solução em Proteção de Arquivos"
    Me.tabAcoes.ResumeLayout(False)
    Me.tbpProteger.ResumeLayout(False)
    Me.tbpProteger.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbpResgatar.ResumeLayout(False)
    Me.tbpResgatar.PerformLayout()
    Me.grpDadosChave.ResumeLayout(False)
    Me.grpDadosChave.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cboTpoCodificacao As System.Windows.Forms.ComboBox
  Friend WithEvents lblTpoCodificacao As System.Windows.Forms.Label
  Friend WithEvents lblTamanho As System.Windows.Forms.Label
  Friend WithEvents cboTamanho As System.Windows.Forms.ComboBox
  Friend WithEvents tabAcoes As System.Windows.Forms.TabControl
  Friend WithEvents tbpProteger As System.Windows.Forms.TabPage
  Friend WithEvents txtArquivo As System.Windows.Forms.TextBox
  Friend WithEvents btnSelecionar As System.Windows.Forms.Button
  Friend WithEvents btnProteger As System.Windows.Forms.Button
  Friend WithEvents txtChaveGerada As System.Windows.Forms.TextBox
  Friend WithEvents lblChave As System.Windows.Forms.Label
  Friend WithEvents btnGerarChave As System.Windows.Forms.Button
  Friend WithEvents tbpResgatar As System.Windows.Forms.TabPage
  Friend WithEvents ofdArquivo As System.Windows.Forms.OpenFileDialog
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents lblArqProtegido As System.Windows.Forms.Label
  Friend WithEvents lblInformeKey As System.Windows.Forms.Label
  Friend WithEvents txtKeyArqProtegido As System.Windows.Forms.TextBox
  Friend WithEvents btnSelKeyArqProtegido As System.Windows.Forms.Button
  Friend WithEvents lblInformeArq As System.Windows.Forms.Label
  Friend WithEvents txtArqProtegido As System.Windows.Forms.TextBox
  Friend WithEvents btnSelArqProtegido As System.Windows.Forms.Button
  Friend WithEvents btnDesproteger As System.Windows.Forms.Button
  Friend WithEvents lblStatusProteger As System.Windows.Forms.Label
  Friend WithEvents lblStatusDesproteger As System.Windows.Forms.Label
  Friend WithEvents grpDadosChave As System.Windows.Forms.GroupBox
  Friend WithEvents btnInfManual As System.Windows.Forms.Button
  Friend WithEvents txtNomeOriginalArq As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtTamanho As System.Windows.Forms.TextBox
  Friend WithEvents txtTpoCodificacao As System.Windows.Forms.TextBox
  Friend WithEvents txtChaveConvertida As System.Windows.Forms.TextBox
  Friend WithEvents lblChvCodConvertida As System.Windows.Forms.Label
  Friend WithEvents lblTpoCodResgatada As System.Windows.Forms.Label
  Friend WithEvents lblTamResgatado As System.Windows.Forms.Label

End Class

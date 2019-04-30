Public Class frmInfManual

#Region "  Propriedades "
  Public ReadOnly Property IndexTipoCodificacao As Integer
    Get
      Return cboTpoCodificacao.SelectedIndex
    End Get
  End Property
  Public ReadOnly Property TipoCodificacao As String
    Get
      Return cboTpoCodificacao.Text
    End Get
  End Property
  Public ReadOnly Property ChaveCodificacao As String
    Get
      Return txtChaveGerada.Text
    End Get
  End Property
  Public ReadOnly Property TamanhoChave As String
    Get
      Return cboTamanho.Text
    End Get
  End Property
#End Region

#Region "  ComboBox "
  Private Sub cboTpoCodificacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTpoCodificacao.SelectedIndexChanged
    Me.Cursor = Cursors.WaitCursor
    Try
      If String.IsNullOrEmpty(cboTpoCodificacao.Text) Then
        Exit Try
      End If
      cboTamanho.Items.Clear()
      cboTamanho.Items.Add("128 Bits")
      Select Case CType(cboTpoCodificacao.SelectedIndex, frmProtetor.enumTipoCodificacao)
        Case frmProtetor.enumTipoCodificacao.AES
          cboTamanho.Items.Add("256 Bits")

        Case frmProtetor.enumTipoCodificacao.TripleDES
          cboTamanho.Items.Add("192 Bits")
      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
#End Region

#Region "  Botões "
  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    DialogResult = Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub
  Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
    Try
      If String.IsNullOrEmpty(cboTpoCodificacao.Text) Then
        MessageBox.Show("Escolha o Tipo de Codificação que deseja utilizar", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        cboTpoCodificacao.Focus()
        Exit Try
      End If

      If String.IsNullOrEmpty(cboTamanho.Text) Then
        MessageBox.Show("Escolha o Tamanho da Chave", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        cboTamanho.Focus()
        Exit Try
      End If

      If String.IsNullOrEmpty(txtChaveGerada.Text) Then
        MessageBox.Show("Informe a chave de codificação para resgatar o arquivo", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        txtChaveGerada.Focus()
        Exit Try
      ElseIf txtChaveGerada.Text.Length <> 32 Then
        MessageBox.Show("A chave de codificação deve conter 32 posições alfanuméricas", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        txtChaveGerada.Focus()
        Exit Try
      End If

      DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
#End Region

End Class
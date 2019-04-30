#Region "  Referências "
Imports System.IO
Imports ProtectFile.Infra
Imports ProtectFile.Tools
#End Region

Public Class frmProtetor

#Region "  Enums Públicos "
  Public Enum enumTipoCodificacao As Short
    AES = 0
    TripleDES = 1
  End Enum
#End Region

#Region "  Enums Privados "
  Private Enum enumBaseProtegida As Short
    NomeArquivoOriginal = 0
    TipoCodificacao = 1
    TamanhoChave = 2
    ChaveHexadecimal = 3
  End Enum
#End Region

#Region "  Métodos Privados "
  Private Sub LimparTelaProteger(ByVal blnNovo As Boolean)
    Try
      txtArquivo.Enabled = blnNovo
      txtChaveGerada.Enabled = blnNovo
      cboTpoCodificacao.Enabled = blnNovo
      cboTamanho.Enabled = blnNovo
      btnSelecionar.Enabled = blnNovo
      btnGerarChave.Enabled = blnNovo

      If blnNovo Then
        txtArquivo.Clear()
        txtChaveGerada.Clear()
        lblStatusProteger.Text = String.Empty
        btnProteger.Text = "Proteger >>"
        btnProteger.Enabled = False
        btnSelecionar.Focus()
      End If

    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub
  Private Sub LimparTelaResgatar()
    Try
      ' Limpa a tela 
      txtArqProtegido.Clear()
      txtKeyArqProtegido.Clear()
      txtTpoCodificacao.Clear()
      txtTamanho.Clear()
      txtNomeOriginalArq.Clear()
      txtChaveConvertida.Clear()
      lblStatusDesproteger.Text = String.Empty
      btnDesproteger.Enabled = False

    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub
#End Region

#Region "  Formulário "
  Private Sub frmProtetor_Load(sender As Object, e As EventArgs) Handles Me.Load
    Me.Cursor = Cursors.WaitCursor
    Try
      ' Inicializa labes
      lblStatusProteger.Text = String.Empty
      lblStatusDesproteger.Text = String.Empty

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
#End Region

#Region "  Guia Proteger "
  Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
    Me.Cursor = Cursors.WaitCursor
    Try
      ofdArquivo.Title = "Escolha o arquivo que deseja proteger"
      ofdArquivo.Filter = "Todos os arquivos (*.*)|*.*"
      ofdArquivo.FileName = String.Empty

      If ofdArquivo.ShowDialog = Windows.Forms.DialogResult.OK Then
        txtArquivo.Text = ofdArquivo.FileName
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      ofdArquivo.Dispose()
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub btnGerarChave_Click(sender As Object, e As EventArgs) Handles btnGerarChave.Click
    Me.Cursor = Cursors.WaitCursor
    Try
      If String.IsNullOrEmpty(txtArquivo.Text) Then
        MessageBox.Show("Selecione o arquivo que você deseja Proteger", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        btnSelecionar.Focus()
        Exit Try
      End If

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

      ' Gera uma chave randomica de 32 posições
      txtChaveGerada.Text = Util.ObterChaveRandomica(32)

      btnProteger.Enabled = True
      btnProteger.Focus()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub btnProteger_Click(sender As Object, e As EventArgs) Handles btnProteger.Click
    Me.Cursor = Cursors.WaitCursor
    Dim blnSucesso As Boolean = False
    Try
      If btnProteger.Text.ToLower = "novo" Then
        LimparTelaProteger(True)
        Exit Try
      End If

      If String.IsNullOrEmpty(cboTamanho.Text) Then
        MessageBox.Show("Escolha o Tamanho da Chave", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        cboTamanho.Focus()
        Exit Try
      End If

      lblStatusProteger.Text = "Protegendo..."
      LimparTelaProteger(False)

      ' Extrai somente o nome do arquivo xml
      Dim strNomeArqProregido() As String = Split(txtArquivo.Text, "\", , CompareMethod.Text)

      Dim swrArqKey As New StreamWriter("#Key_" & strNomeArqProregido(strNomeArqProregido.Length - 1).ToString & ".pfk", False, System.Text.Encoding.Default)

      Try
        ' Gera o arquivo chave no formato hezadecimal contendo as informações necessárias para desproteção
        swrArqKey.Write(Util.ConverterTextoParaHexadecimal(strNomeArqProregido(strNomeArqProregido.Length - 1).ToString & ";" &
                        cboTpoCodificacao.SelectedIndex.ToString & ";" &
                        cboTamanho.SelectedIndex.ToString & ";" &
                        txtChaveGerada.Text))
        btnProteger.Text = "Novo"

        Select Case CType(cboTpoCodificacao.SelectedIndex, enumTipoCodificacao)
          Case enumTipoCodificacao.AES
            Dim clsAES As New Seguranca(txtChaveGerada.Text, CInt(cboTamanho.Text.Substring(0, 3)))
            Try
              clsAES.ProtegerAES(txtArquivo.Text, "#ProtectFile_" & strNomeArqProregido(strNomeArqProregido.Length - 1).ToString)
              blnSucesso = True

            Catch ex As Exception
              Throw New Exception(ex.Message)
            Finally
              clsAES.Dispose()
            End Try

          Case enumTipoCodificacao.TripleDES
            Dim clsTripleDES As New Seguranca(txtChaveGerada.Text, CInt(cboTamanho.Text.Substring(0, 3)))
            Try
              clsTripleDES.ProtegerTripleDES(txtArquivo.Text, "#ProtectFile_" & strNomeArqProregido(strNomeArqProregido.Length - 1).ToString)
              blnSucesso = True

            Catch ex As Exception
              Throw New Exception(ex.Message)
            Finally
              clsTripleDES.Dispose()
            End Try

        End Select

      Catch ex As Exception
        Throw New Exception(ex.Message)
      Finally
        swrArqKey.Close()
        swrArqKey.Dispose()
      End Try

    Catch ex As System.IO.IOException
      lblStatusProteger.Text = "FALHA na Proteção!"
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally
      If blnSucesso Then
        lblStatusProteger.Text = "Proteção concluída"
        MessageBox.Show("Arquivo Protegido com sucesso", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub cboTpoCodificacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTpoCodificacao.SelectedIndexChanged
    Me.Cursor = Cursors.WaitCursor
    Try
      If String.IsNullOrEmpty(cboTpoCodificacao.Text) Then
        Exit Try
      End If

      cboTamanho.Items.Clear()
      cboTamanho.Items.Add("128 Bits")
      Select Case CType(cboTpoCodificacao.SelectedIndex, enumTipoCodificacao)
        Case enumTipoCodificacao.AES
          cboTamanho.Items.Add("256 Bits")

        Case enumTipoCodificacao.TripleDES
          cboTamanho.Items.Add("192 Bits")
      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
#End Region

#Region "  Guia Desproteger "
  Private Sub btnSelArqProtegido_Click(sender As Object, e As EventArgs) Handles btnSelArqProtegido.Click
    Me.Cursor = Cursors.WaitCursor
    Try
      ' Configura objeto de seleção
      ofdArquivo.Title = "Escolha o arquivo que deseja desproteger"
      ofdArquivo.Filter = "Arquivos Protegidos (#ProtectFile_*.*)|#ProtectFile_*.*"
      ofdArquivo.FileName = String.Empty

      ' Se não selecionou ninguém, cai fora
      If ofdArquivo.ShowDialog <> Windows.Forms.DialogResult.OK Then
        Exit Try
      End If

      ' Inicia a tela
      LimparTelaResgatar()

      ' Obtem o arquivo selecionado
      txtArqProtegido.Text = ofdArquivo.FileName

      ' Valida se deve habilitar ou não o botão de disparo da ação
      If Not String.IsNullOrEmpty(txtTpoCodificacao.Text) And
         Not String.IsNullOrEmpty(txtTamanho.Text) And
         Not String.IsNullOrEmpty(txtChaveConvertida.Text) And
         Not String.IsNullOrEmpty(txtNomeOriginalArq.Text) And
         Not String.IsNullOrEmpty(txtKeyArqProtegido.Text) Then
        btnDesproteger.Enabled = True
      Else
        btnDesproteger.Enabled = False
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      ' Desaloca obj da memória
      ofdArquivo.Dispose()
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub btnSelKeyArqProtegido_Click(sender As Object, e As EventArgs) Handles btnSelKeyArqProtegido.Click
    Me.Cursor = Cursors.WaitCursor
    Try
      ' Configura objeto de seleção
      ofdArquivo.Title = "Escolha o arquivo contendo a Chave Privada de proteção"
      ofdArquivo.Filter = "Chave Privada de Proteção (#Key_*.pfk)|#Key_*.pfk"
      ofdArquivo.FileName = String.Empty

      ' Se não selecionou ninguém, cai fora
      If ofdArquivo.ShowDialog <> Windows.Forms.DialogResult.OK Then
        Exit Try
      End If

      ' Obtem o arquivo selecionado
      txtKeyArqProtegido.Text = ofdArquivo.FileName
      Dim strKey As String()

      ' Abre o arquivo 
      Using smrArqKey As StreamReader = File.OpenText(txtKeyArqProtegido.Text)

        ' Lê a primeira linha do arquivo - Hexadecimal
        Dim strLinHexadecimal As String = smrArqKey.ReadLine()

        ' Converte a informação lida do arquivo em hexadecimal para texto
        Dim strTextoConvertido As String = Util.ConverterHexadecimalParaTexto(strLinHexadecimal)

        ' Desmembra a informação que foi armazenada com o separador (;)
        strKey = Split(strTextoConvertido, ";", , CompareMethod.Text)

        ' Carrega a tela com as informações contidas no arquivo de chave
        txtTpoCodificacao.Tag = CInt(strKey(enumBaseProtegida.TipoCodificacao))
        txtTpoCodificacao.Text = cboTpoCodificacao.Items(CInt(strKey(enumBaseProtegida.TipoCodificacao))).ToString
        txtChaveConvertida.Text = strKey(enumBaseProtegida.ChaveHexadecimal).ToString
        txtNomeOriginalArq.Text = strKey(enumBaseProtegida.NomeArquivoOriginal).ToString
        Dim intTamanho As Integer = 0
        If CInt(strKey(enumBaseProtegida.TamanhoChave)) = 0 Then
          intTamanho = 128
        Else
          Select Case txtTpoCodificacao.Text.Substring(0, 4).ToUpper
            Case "AES "
              intTamanho = 256
            Case "3DES"
              intTamanho = 192
          End Select
        End If
        txtTamanho.Text = intTamanho.ToString & " Bits"

        ' Fecha e desaloca
        smrArqKey.Close()
        smrArqKey.Dispose()
      End Using

      ' Valida se deve habilitar ou não o botão de disparo da ação
      If Not String.IsNullOrEmpty(txtTpoCodificacao.Text) And
         Not String.IsNullOrEmpty(txtTamanho.Text) And
         Not String.IsNullOrEmpty(txtChaveConvertida.Text) And
         Not String.IsNullOrEmpty(txtNomeOriginalArq.Text) And
         Not String.IsNullOrEmpty(txtArqProtegido.Text) Then
        btnDesproteger.Enabled = True
      Else
        btnDesproteger.Enabled = False
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      ' Desaloca obj da memória
      ofdArquivo.Dispose()
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub btnDesproteger_Click(sender As Object, e As EventArgs) Handles btnDesproteger.Click
    Me.Cursor = Cursors.WaitCursor
    Dim blnSucesso As Boolean = False
    Try
      lblStatusDesproteger.Text = "Desprotegendo..."
      Select Case CType(CInt(txtTpoCodificacao.Tag), enumTipoCodificacao)
        Case enumTipoCodificacao.AES
          Dim clsAES As New Seguranca(txtChaveConvertida.Text, CInt(txtTamanho.Text.Substring(0, 3)))
          Try
            clsAES.DesprotegerAES(txtArqProtegido.Text, txtNomeOriginalArq.Text)
            blnSucesso = True

          Catch ex As Exception
            Throw New Exception(ex.Message)
          Finally
            clsAES.Dispose()
          End Try

        Case enumTipoCodificacao.TripleDES
          Dim clsTripleDES As New Seguranca(txtChaveConvertida.Text, CInt(txtTamanho.Text.Substring(0, 3)))
          Try
            clsTripleDES.DesprotegerTripleDES(txtArqProtegido.Text, txtNomeOriginalArq.Text)
            blnSucesso = True

          Catch ex As Exception
            Throw New Exception(ex.Message)
          Finally
            clsTripleDES.Dispose()
          End Try

      End Select

    Catch ex As Exception
      lblStatusDesproteger.Text = "FALHA na Desproteção!"
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If blnSucesso Then
        lblStatusDesproteger.Text = "Desproteção concluída"
        MessageBox.Show("Arquivo Desprotegido com sucesso", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        LimparTelaResgatar()
        btnSelArqProtegido.Focus()
      End If
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub btnInfManual_Click(sender As Object, e As EventArgs) Handles btnInfManual.Click
    If String.IsNullOrEmpty(txtArqProtegido.Text) Then
      MessageBox.Show("Selecione o arquivo que você deseja Resgatar", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      btnSelArqProtegido.Focus()
      Exit Sub
    End If

    Dim frm As New frmInfManual
    Try
      frm.ShowDialog()

      ' Carrega a tela com os dados informados manualmente
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
        txtKeyArqProtegido.Text = "DADOS INFORMADOS MANUALMENTE"
        txtTpoCodificacao.Tag = frm.IndexTipoCodificacao
        txtTpoCodificacao.Text = frm.TipoCodificacao
        txtChaveConvertida.Text = frm.ChaveCodificacao
        txtTamanho.Text = frm.TamanhoChave

        ' Extrai somente o nome do arquivo original
        Dim strNomeArqProregido() As String = Split(txtArqProtegido.Text, "\", , CompareMethod.Text)
        txtNomeOriginalArq.Text = Replace(strNomeArqProregido(strNomeArqProregido.Length - 1).ToString, "#ProtectFile_", "").ToString

        btnDesproteger.Enabled = True
        btnDesproteger.Focus()
      Else
        btnSelKeyArqProtegido.Focus()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      frm.Close()
      frm.Dispose()
    End Try
  End Sub
#End Region

End Class

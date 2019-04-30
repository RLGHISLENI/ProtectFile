#Region "  Referências "
Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
#End Region

Namespace Infra

  Public Class Seguranca : Implements IDisposable

#Region "  Var. Privadas "
    Private MD5 As New MD5CryptoServiceProvider
    Private bytVetorInicializacao() As Byte = {&H12, &H44, &H16, &HEE, &H88, &H15, &HDD, &H41}
    Private bytChave As Rfc2898DeriveBytes
#End Region

#Region "  Enums Privados "
    Private Enum enumModoProcessamento As Short
      Encriptar = 0
      Decriptar = 1
    End Enum
#End Region

#Region "  Propriedades "
    Public Property TamanhoChave() As Integer
    Public Property ChaveSeguranca() As String
#End Region

#Region "  Construtor "
    Public Sub New(ByVal strChaveSeguranca As String,
                 ByVal intTamanhoChave As Integer)
      Try
        ChaveSeguranca = strChaveSeguranca
        TamanhoChave = intTamanhoChave
        bytChave = New Rfc2898DeriveBytes(ChaveSeguranca, bytVetorInicializacao)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
#End Region

#Region "  Métodos Privados "
    Private Function MD5Hash(ByVal strChave As String) As Byte()
      ' Converte a chave para um array de bytes  
      Try
        Dim bytArray() As Byte = ASCIIEncoding.ASCII.GetBytes(strChave)
        Return MD5.ComputeHash(bytArray)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function
    Private Sub ProcessarBytesAES(ByVal strOrigem As String,
                                ByVal strDestino As String,
                                ByVal shtModo As enumModoProcessamento)
      Try
        Dim bytBuffer(4096) As Byte            ' Cria um buffer
        Dim lngTotalBytesEscritos As Long = 8  ' Bytes escritos
        Dim intTamanhoPacote As Integer        ' Determina o numero de bytes escritos de uma vez

        ' Declaração dos arquivos streams. 
        Dim flsArqEntrada As New FileStream(strOrigem, FileMode.Open, FileAccess.Read)
        Dim flsArqSaida As New FileStream(strDestino, FileMode.OpenOrCreate, FileAccess.Write)
        flsArqSaida.SetLength(0)

        ' Define o tamanho do arquivo Original
        Dim lngComprimentoTotalArquivo As Long = flsArqEntrada.Length

        ' Cria um objeto de Criptografia AES
        Dim cryAES As New AesCryptoServiceProvider

        ' Configuração para transformação
        cryAES.KeySize = TamanhoChave
        cryAES.Key = bytChave.GetBytes(16)
        cryAES.IV = bytChave.GetBytes(16)

        ' Define o método de transformação
        Dim cryTransform As Security.Cryptography.ICryptoTransform
        If shtModo = enumModoProcessamento.Encriptar Then
          cryTransform = cryAES.CreateEncryptor()
        Else
          cryTransform = cryAES.CreateDecryptor()
        End If

        ' Cria stream 
        Dim crsStream As New CryptoStream(flsArqSaida, cryTransform, CryptoStreamMode.Write)

        ' Aviso
        If lngComprimentoTotalArquivo = 0 Then
          Throw New Exception("Não foi possível realizar a operação!")
        End If

        ' Fluxo de stream
        While lngTotalBytesEscritos < lngComprimentoTotalArquivo
          intTamanhoPacote = flsArqEntrada.Read(bytBuffer, 0, 4096)
          crsStream.Write(bytBuffer, 0, intTamanhoPacote)
          lngTotalBytesEscritos = Convert.ToInt32(lngTotalBytesEscritos + intTamanhoPacote / cryAES.BlockSize * cryAES.BlockSize)
        End While
        crsStream.Close()

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
    Private Sub ProcessarBytesTripleDES(ByVal strOrigem As String,
                                      ByVal strDestino As String,
                                      ByVal shtModo As enumModoProcessamento)
      Try
        Dim bytBuffer(4096) As Byte            ' Cria um buffer
        Dim lngTotalBytesEscritos As Long = 8  ' Bytes escritos
        Dim intTamanhoPacote As Integer        ' Determina o numero de bytes escritos de uma vez

        ' Declaração dos arquivos streams. 
        Dim flsArqEntrada As New FileStream(strOrigem, FileMode.Open, FileAccess.Read)
        Dim flsArqSaida As New FileStream(strDestino, FileMode.OpenOrCreate, FileAccess.Write)
        flsArqSaida.SetLength(0)

        ' Define o tamanho do arquivo Original
        Dim lngComprimentoTotalArquivo As Long = flsArqEntrada.Length

        ' Cria um objeto de Criptografia 3DES
        Dim cry3DES As New TripleDESCryptoServiceProvider

        ' Configuração para transformação
        cry3DES.KeySize = TamanhoChave
        cry3DES.Key = MD5Hash(ChaveSeguranca)

        ' Definição da chave e da cifra (que neste caso é Electronic Codebook, ou seja, encriptação individual para cada bloco) 
        cry3DES.Mode = CipherMode.ECB

        ' Define o método de transformação
        Dim cryTransform As Security.Cryptography.ICryptoTransform
        If shtModo = enumModoProcessamento.Encriptar Then
          cryTransform = cry3DES.CreateEncryptor()
        Else
          cryTransform = cry3DES.CreateDecryptor()
        End If

        ' Cria stream 
        Dim crsStream As New CryptoStream(flsArqSaida, cryTransform, CryptoStreamMode.Write)

        ' Aviso
        If lngComprimentoTotalArquivo = 0 Then
          Throw New Exception("Não foi possível realizar a operação!")
        End If

        ' Fluxo de stream
        While lngTotalBytesEscritos < lngComprimentoTotalArquivo
          intTamanhoPacote = flsArqEntrada.Read(bytBuffer, 0, 4096)
          crsStream.Write(bytBuffer, 0, intTamanhoPacote)
          lngTotalBytesEscritos = Convert.ToInt32(lngTotalBytesEscritos + intTamanhoPacote / cry3DES.BlockSize * cry3DES.BlockSize)
        End While
        crsStream.Close()

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
#End Region

#Region "  Métodos Publicos "
    Public Sub ProtegerAES(ByVal strArqOriginal As String,
                         ByVal strArqProtegido As String)
      Try
        ProcessarBytesAES(strArqOriginal, strArqProtegido, enumModoProcessamento.Encriptar)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
    Public Sub DesprotegerAES(ByVal strArqProtegido As String,
                            ByVal strArqOriginal As String)
      Try
        ProcessarBytesAES(strArqProtegido, strArqOriginal, enumModoProcessamento.Decriptar)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
    Public Sub ProtegerTripleDES(ByVal strArqOriginal As String,
                               ByVal strArqProtegido As String)
      Try
        ProcessarBytesTripleDES(strArqOriginal, strArqProtegido, enumModoProcessamento.Encriptar)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
    Public Sub DesprotegerTripleDES(ByVal strArqProtegido As String,
                                  ByVal strArqOriginal As String)
      Try
        ProcessarBytesTripleDES(strArqProtegido, strArqOriginal, enumModoProcessamento.Decriptar)

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
      bytVetorInicializacao = Nothing
      bytChave.Dispose()
      GC.Collect()
    End Sub
#End Region

  End Class

End Namespace
Namespace Tools

  Friend NotInheritable Class Util : Implements IDisposable

#Region "  Funções Públicas "
    Public Shared Function ObterChaveRandomica(ByVal intTamanho As Integer) As String
      Dim strRetorno As New System.Text.StringBuilder
      Dim strChars() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
      Dim intUpperBound As Integer = UBound(strChars)
      Try
        Dim rndPosicao As System.Random = New Random
        For intPos As Integer = 1 To intTamanho
          strRetorno.Append(strChars(rndPosicao.Next(0, intUpperBound)))
        Next
        Return strRetorno.ToString

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function
    Public Shared Function ConverterTextoParaHexadecimal(ByVal strTexto As String) As String
      Dim hex As String = String.Empty
      Try
        For i As Integer = 0 To strTexto.Length - 1
          hex &= Asc(strTexto.Substring(i, 1)).ToString("x").ToUpper
        Next
        Return hex

      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function
    Public Shared Function ConverterHexadecimalParaTexto(ByVal strHexadecimal As String) As String
      Try
        Dim strFonte As New System.Text.StringBuilder(strHexadecimal.Length \ 2)
        For intPos As Integer = 0 To strHexadecimal.Length - 2 Step 2
          strFonte.Append(Chr(Convert.ToByte(strHexadecimal.Substring(intPos, 2), 16)))
        Next intPos
        Return strFonte.ToString

      Catch ex As Exception
        Throw New Exception
      End Try
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
      GC.Collect()
    End Sub
#End Region

  End Class

End Namespace
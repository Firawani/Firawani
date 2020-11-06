Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim HrgAPCH As Integer = 25000
        Dim HrgNUP As Integer = 28000
        Dim HrgBA As Integer = 20000
        Dim HrgN As Integer = 18000
        Dim HrgBP As Integer = 25000
        Dim JlhAPCH = TxtJlhAPCH.Text
        Dim JlhNUP = TxtJlhNUP.Text
        Dim JlhBA = TxtJlhBA.Text
        Dim JlhN = TxtJlhN.Text
        Dim JlhBP = TxtJlhBP.Text
        Dim THargaAPCH As Integer
        Dim THargaNUP As Integer
        Dim THargaBA As Integer
        Dim THargaN As Integer
        Dim THargaBP As Integer
        Dim TBayar As Integer
        If CboxAPCH.Checked Then
            THargaAPCH = HrgAPCH * JlhAPCH
        Else
            THargaAPCH = 0
        End If
        If CboxNUP.Checked Then
            THargaNUP = HrgNUP * JlhNUP
        Else
            THargaNUP = 0
        End If
        If CboxBA.Checked Then
            THargaBA = HrgBA * JlhBA
        Else
            THargaBA = 0
        End If
        If CboxN.Checked Then
            THargaN = HrgN * JlhN
        Else
            THargaN = 0
        End If
        If CboxBP.Checked Then
            THargaBP = HrgBP * JlhBP
        Else
            THargaBP = 0
        End If
        TBayar = THargaAPCH + THargaNUP + THargaBA + THargaN + THargaBP
        LblTBayar.Text = TBayar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtJlhAPCH.Text = 0
        TxtJlhNUP.Text = 0
        TxtJlhBA.Text = 0
        TxtJlhN.Text = 0
        TxtJlhBP.Text = 0
        LblTBayar.Text = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Anda yakin akan keluar?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Peringatan")
        If pesan = MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

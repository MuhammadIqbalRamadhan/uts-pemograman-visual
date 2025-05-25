Imports System.Windows.Forms

Public Class FormHotel
    Private Sub FormHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKodeKamar.Items.AddRange(New String() {"A01", "A02", "A03", "B01", "B02"})
        cmbKodeKamar.SelectedIndex = 0
        txtBiayaSewa.ReadOnly = True
        txtFasilitasTambahan.ReadOnly = True
        txtTotalSewa.ReadOnly = True
        txtKembali.ReadOnly = True
    End Sub

    Private Sub rbSuperior_CheckedChanged(sender As Object, e As EventArgs) Handles rbSuperior.CheckedChanged
        If rbSuperior.Checked Then
            txtBiayaSewa.Text = "500000"
            UpdateFasilitasDanTotal()
        End If
    End Sub

    Private Sub rbDeluxe_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeluxe.CheckedChanged
        If rbDeluxe.Checked Then
            txtBiayaSewa.Text = "750000"
            UpdateFasilitasDanTotal()
        End If
    End Sub

    Private Sub rbSuite_CheckedChanged(sender As Object, e As EventArgs) Handles rbSuite.CheckedChanged
        If rbSuite.Checked Then
            txtBiayaSewa.Text = "1000000"
            UpdateFasilitasDanTotal()
        End If
    End Sub

    Private Sub cbInternet_CheckedChanged(sender As Object, e As EventArgs) Handles cbInternet.CheckedChanged
        UpdateFasilitasDanTotal()
    End Sub

    Private Sub cbTVKabel_CheckedChanged(sender As Object, e As EventArgs) Handles cbTVKabel.CheckedChanged
        UpdateFasilitasDanTotal()
    End Sub

    Private Sub UpdateFasilitasDanTotal()
        Dim biayaSewa As Integer = 0
        Integer.TryParse(txtBiayaSewa.Text, biayaSewa)

        Dim fasilitas As Integer = 0
        Dim fasilitasStr As String = ""
        If cbInternet.Checked Then
            fasilitas += 50000
            fasilitasStr &= "Internet "
        End If
        If cbTVKabel.Checked Then
            fasilitas += 30000
            fasilitasStr &= "TV Kabel "
        End If
        txtFasilitasTambahan.Text = fasilitasStr.Trim

        Dim totalSewa As Integer = biayaSewa + fasilitas
        txtTotalSewa.Text = totalSewa.ToString()
    End Sub

    ' Tombol Calculate: hitung total sewa dan kembalian sekaligus
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Hitung ulang fasilitas dan total sewa
        UpdateFasilitasDanTotal()

        ' Hitung kembalian
        Dim totalSewa As Integer = 0
        Integer.TryParse(txtTotalSewa.Text, totalSewa)
        Dim bayar As Integer = 0
        Integer.TryParse(txtBayar.Text, bayar)
        txtKembali.Text = If(bayar >= totalSewa, (bayar - totalSewa).ToString(), "0")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNamaTamu.Clear()
        cmbKodeKamar.SelectedIndex = 0
        txtNamaKamar.Clear()
        rbSuperior.Checked = False
        rbDeluxe.Checked = False
        rbSuite.Checked = False
        txtBiayaSewa.Clear()
        cbInternet.Checked = False
        cbTVKabel.Checked = False
        txtFasilitasTambahan.Clear()
        txtTotalSewa.Clear()
        txtBayar.Clear()
        txtKembali.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
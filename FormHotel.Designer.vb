Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotel
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNamaTamu = New System.Windows.Forms.Label()
        Me.txtNamaTamu = New System.Windows.Forms.TextBox()
        Me.lblKodeKamar = New System.Windows.Forms.Label()
        Me.cmbKodeKamar = New System.Windows.Forms.ComboBox()
        Me.lblNamaKamar = New System.Windows.Forms.Label()
        Me.txtNamaKamar = New System.Windows.Forms.TextBox()
        Me.lblTipeKamar = New System.Windows.Forms.Label()
        Me.rbSuperior = New System.Windows.Forms.RadioButton()
        Me.rbDeluxe = New System.Windows.Forms.RadioButton()
        Me.rbSuite = New System.Windows.Forms.RadioButton()
        Me.lblBiayaSewa = New System.Windows.Forms.Label()
        Me.txtBiayaSewa = New System.Windows.Forms.TextBox()
        Me.lblFasilitasTambahan = New System.Windows.Forms.Label()
        Me.txtFasilitasTambahan = New System.Windows.Forms.TextBox()
        Me.lblTotalSewa = New System.Windows.Forms.Label()
        Me.txtTotalSewa = New System.Windows.Forms.TextBox()
        Me.lblBayar = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.grpFasilitas = New System.Windows.Forms.GroupBox()
        Me.cbInternet = New System.Windows.Forms.CheckBox()
        Me.cbTVKabel = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpFasilitas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(180, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 30)
        Me.lblTitle.Text = "8BALL HOTEL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamaTamu
        '
        Me.lblNamaTamu.Location = New System.Drawing.Point(40, 70)
        Me.lblNamaTamu.Name = "lblNamaTamu"
        Me.lblNamaTamu.Size = New System.Drawing.Size(100, 20)
        Me.lblNamaTamu.Text = "Nama Tamu"
        '
        'txtNamaTamu
        '
        Me.txtNamaTamu.Location = New System.Drawing.Point(150, 70)
        Me.txtNamaTamu.Name = "txtNamaTamu"
        Me.txtNamaTamu.Size = New System.Drawing.Size(150, 20)
        '
        'lblKodeKamar
        '
        Me.lblKodeKamar.Location = New System.Drawing.Point(40, 100)
        Me.lblKodeKamar.Name = "lblKodeKamar"
        Me.lblKodeKamar.Size = New System.Drawing.Size(100, 20)
        Me.lblKodeKamar.Text = "Kode Kamar"
        '
        'cmbKodeKamar
        '
        Me.cmbKodeKamar.Location = New System.Drawing.Point(150, 100)
        Me.cmbKodeKamar.Name = "cmbKodeKamar"
        Me.cmbKodeKamar.Size = New System.Drawing.Size(150, 21)
        '
        'lblNamaKamar
        '
        Me.lblNamaKamar.Location = New System.Drawing.Point(40, 130)
        Me.lblNamaKamar.Name = "lblNamaKamar"
        Me.lblNamaKamar.Size = New System.Drawing.Size(100, 20)
        Me.lblNamaKamar.Text = "Nama Kamar"
        '
        'txtNamaKamar
        '
        Me.txtNamaKamar.Location = New System.Drawing.Point(150, 130)
        Me.txtNamaKamar.Name = "txtNamaKamar"
        Me.txtNamaKamar.Size = New System.Drawing.Size(150, 20)
        '
        'lblTipeKamar
        '
        Me.lblTipeKamar.Location = New System.Drawing.Point(40, 160)
        Me.lblTipeKamar.Name = "lblTipeKamar"
        Me.lblTipeKamar.Size = New System.Drawing.Size(100, 20)
        Me.lblTipeKamar.Text = "Tipe Kamar"
        '
        'rbSuperior
        '
        Me.rbSuperior.Location = New System.Drawing.Point(150, 160)
        Me.rbSuperior.Name = "rbSuperior"
        Me.rbSuperior.Size = New System.Drawing.Size(100, 20)
        Me.rbSuperior.Text = "Superior"
        '
        'rbDeluxe
        '
        Me.rbDeluxe.Location = New System.Drawing.Point(150, 185)
        Me.rbDeluxe.Name = "rbDeluxe"
        Me.rbDeluxe.Size = New System.Drawing.Size(100, 20)
        Me.rbDeluxe.Text = "Deluxe"
        '
        'rbSuite
        '
        Me.rbSuite.Location = New System.Drawing.Point(150, 210)
        Me.rbSuite.Name = "rbSuite"
        Me.rbSuite.Size = New System.Drawing.Size(100, 20)
        Me.rbSuite.Text = "Suite"
        '
        'lblBiayaSewa
        '
        Me.lblBiayaSewa.Location = New System.Drawing.Point(340, 70)
        Me.lblBiayaSewa.Name = "lblBiayaSewa"
        Me.lblBiayaSewa.Size = New System.Drawing.Size(100, 20)
        Me.lblBiayaSewa.Text = "Biaya Sewa"
        '
        'txtBiayaSewa
        '
        Me.txtBiayaSewa.Location = New System.Drawing.Point(450, 70)
        Me.txtBiayaSewa.Name = "txtBiayaSewa"
        Me.txtBiayaSewa.Size = New System.Drawing.Size(150, 20)
        '
        'lblFasilitasTambahan
        '
        Me.lblFasilitasTambahan.Location = New System.Drawing.Point(340, 100)
        Me.lblFasilitasTambahan.Name = "lblFasilitasTambahan"
        Me.lblFasilitasTambahan.Size = New System.Drawing.Size(100, 20)
        Me.lblFasilitasTambahan.Text = "Fasilitas Tambahan"
        '
        'txtFasilitasTambahan
        '
        Me.txtFasilitasTambahan.Location = New System.Drawing.Point(450, 100)
        Me.txtFasilitasTambahan.Name = "txtFasilitasTambahan"
        Me.txtFasilitasTambahan.Size = New System.Drawing.Size(150, 20)
        '
        'lblTotalSewa
        '
        Me.lblTotalSewa.Location = New System.Drawing.Point(340, 130)
        Me.lblTotalSewa.Name = "lblTotalSewa"
        Me.lblTotalSewa.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalSewa.Text = "Total Sewa"
        '
        'txtTotalSewa
        '
        Me.txtTotalSewa.Location = New System.Drawing.Point(450, 130)
        Me.txtTotalSewa.Name = "txtTotalSewa"
        Me.txtTotalSewa.Size = New System.Drawing.Size(150, 20)
        '
        'lblBayar
        '
        Me.lblBayar.Location = New System.Drawing.Point(340, 160)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(100, 20)
        Me.lblBayar.Text = "Bayar"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(450, 160)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(150, 20)
        '
        'lblKembali
        '
        Me.lblKembali.Location = New System.Drawing.Point(340, 190)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(100, 20)
        Me.lblKembali.Text = "Kembali"
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(450, 190)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(150, 20)
        '
        'grpFasilitas
        '
        Me.grpFasilitas.Controls.Add(Me.cbInternet)
        Me.grpFasilitas.Controls.Add(Me.cbTVKabel)
        Me.grpFasilitas.Location = New System.Drawing.Point(40, 250)
        Me.grpFasilitas.Name = "grpFasilitas"
        Me.grpFasilitas.Size = New System.Drawing.Size(260, 60)
        Me.grpFasilitas.Text = "Fasilitas Tambahan"
        '
        'cbInternet
        '
        Me.cbInternet.Location = New System.Drawing.Point(20, 25)
        Me.cbInternet.Name = "cbInternet"
        Me.cbInternet.Size = New System.Drawing.Size(80, 20)
        Me.cbInternet.Text = "Internet"
        '
        'cbTVKabel
        '
        Me.cbTVKabel.Location = New System.Drawing.Point(120, 25)
        Me.cbTVKabel.Name = "cbTVKabel"
        Me.cbTVKabel.Size = New System.Drawing.Size(80, 20)
        Me.cbTVKabel.Text = "TV Kabel"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(340, 270)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.Text = "CLEAR"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(460, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.Text = "EXIT"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(570, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 30)
        Me.btnCalculate.Text = "CALCULATE"
        '
        'FormHotel
        '
        Me.ClientSize = New System.Drawing.Size(700, 350)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblNamaTamu)
        Me.Controls.Add(Me.txtNamaTamu)
        Me.Controls.Add(Me.lblKodeKamar)
        Me.Controls.Add(Me.cmbKodeKamar)
        Me.Controls.Add(Me.lblNamaKamar)
        Me.Controls.Add(Me.txtNamaKamar)
        Me.Controls.Add(Me.lblTipeKamar)
        Me.Controls.Add(Me.rbSuperior)
        Me.Controls.Add(Me.rbDeluxe)
        Me.Controls.Add(Me.rbSuite)
        Me.Controls.Add(Me.lblBiayaSewa)
        Me.Controls.Add(Me.txtBiayaSewa)
        Me.Controls.Add(Me.lblFasilitasTambahan)
        Me.Controls.Add(Me.txtFasilitasTambahan)
        Me.Controls.Add(Me.lblTotalSewa)
        Me.Controls.Add(Me.txtTotalSewa)
        Me.Controls.Add(Me.lblBayar)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.lblKembali)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.grpFasilitas)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "FormHotel"
        Me.Text = "8BALL HOTEL"
        Me.grpFasilitas.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNamaTamu As Label
    Friend WithEvents txtNamaTamu As TextBox
    Friend WithEvents lblKodeKamar As Label
    Friend WithEvents cmbKodeKamar As ComboBox
    Friend WithEvents lblNamaKamar As Label
    Friend WithEvents txtNamaKamar As TextBox
    Friend WithEvents lblTipeKamar As Label
    Friend WithEvents rbSuperior As RadioButton
    Friend WithEvents rbDeluxe As RadioButton
    Friend WithEvents rbSuite As RadioButton
    Friend WithEvents lblBiayaSewa As Label
    Friend WithEvents txtBiayaSewa As TextBox
    Friend WithEvents lblFasilitasTambahan As Label
    Friend WithEvents txtFasilitasTambahan As TextBox
    Friend WithEvents lblTotalSewa As Label
    Friend WithEvents txtTotalSewa As TextBox
    Friend WithEvents lblBayar As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblKembali As Label
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents grpFasilitas As GroupBox
    Friend WithEvents cbInternet As CheckBox
    Friend WithEvents cbTVKabel As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrency
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCurrency = New System.Windows.Forms.GroupBox()
        Me.ETH = New System.Windows.Forms.RadioButton()
        Me.BTC = New System.Windows.Forms.RadioButton()
        Me.BGN = New System.Windows.Forms.RadioButton()
        Me.CHF = New System.Windows.Forms.RadioButton()
        Me.USD = New System.Windows.Forms.RadioButton()
        Me.GBP = New System.Windows.Forms.RadioButton()
        Me.grpEuro = New System.Windows.Forms.GroupBox()
        Me.txtETH = New System.Windows.Forms.TextBox()
        Me.txtBTC = New System.Windows.Forms.TextBox()
        Me.txtBGN = New System.Windows.Forms.TextBox()
        Me.txtCHF = New System.Windows.Forms.TextBox()
        Me.txtUSD = New System.Windows.Forms.TextBox()
        Me.txtGBP = New System.Windows.Forms.TextBox()
        Me.btnExchangeRateChange = New System.Windows.Forms.Button()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtSUM = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpCurrency.SuspendLayout()
        Me.grpEuro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        '
        'grpCurrency
        '
        Me.grpCurrency.Controls.Add(Me.ETH)
        Me.grpCurrency.Controls.Add(Me.BTC)
        Me.grpCurrency.Controls.Add(Me.BGN)
        Me.grpCurrency.Controls.Add(Me.CHF)
        Me.grpCurrency.Controls.Add(Me.USD)
        Me.grpCurrency.Controls.Add(Me.GBP)
        Me.grpCurrency.Location = New System.Drawing.Point(27, 68)
        Me.grpCurrency.Name = "grpCurrency"
        Me.grpCurrency.Size = New System.Drawing.Size(200, 272)
        Me.grpCurrency.TabIndex = 1
        Me.grpCurrency.TabStop = False
        Me.grpCurrency.Text = "Currency"
        '
        'ETH
        '
        Me.ETH.AutoSize = True
        Me.ETH.Location = New System.Drawing.Point(7, 248)
        Me.ETH.Name = "ETH"
        Me.ETH.Size = New System.Drawing.Size(70, 17)
        Me.ETH.TabIndex = 5
        Me.ETH.TabStop = True
        Me.ETH.Text = "Ethereum"
        Me.ETH.UseVisualStyleBackColor = True
        '
        'BTC
        '
        Me.BTC.AutoSize = True
        Me.BTC.Location = New System.Drawing.Point(7, 202)
        Me.BTC.Name = "BTC"
        Me.BTC.Size = New System.Drawing.Size(57, 17)
        Me.BTC.TabIndex = 4
        Me.BTC.TabStop = True
        Me.BTC.Text = "Bitcoin"
        Me.BTC.UseVisualStyleBackColor = True
        '
        'BGN
        '
        Me.BGN.AutoSize = True
        Me.BGN.Location = New System.Drawing.Point(7, 155)
        Me.BGN.Name = "BGN"
        Me.BGN.Size = New System.Drawing.Size(90, 17)
        Me.BGN.TabIndex = 3
        Me.BGN.TabStop = True
        Me.BGN.Text = "Bulgarian Lev"
        Me.BGN.UseVisualStyleBackColor = True
        '
        'CHF
        '
        Me.CHF.AutoSize = True
        Me.CHF.Location = New System.Drawing.Point(7, 112)
        Me.CHF.Name = "CHF"
        Me.CHF.Size = New System.Drawing.Size(82, 17)
        Me.CHF.TabIndex = 2
        Me.CHF.TabStop = True
        Me.CHF.Text = "Swiss Franc"
        Me.CHF.UseVisualStyleBackColor = True
        '
        'USD
        '
        Me.USD.AutoSize = True
        Me.USD.Location = New System.Drawing.Point(7, 65)
        Me.USD.Name = "USD"
        Me.USD.Size = New System.Drawing.Size(70, 17)
        Me.USD.TabIndex = 1
        Me.USD.TabStop = True
        Me.USD.Text = "US Dollar"
        Me.USD.UseVisualStyleBackColor = True
        '
        'GBP
        '
        Me.GBP.AutoSize = True
        Me.GBP.Location = New System.Drawing.Point(7, 20)
        Me.GBP.Name = "GBP"
        Me.GBP.Size = New System.Drawing.Size(94, 17)
        Me.GBP.TabIndex = 0
        Me.GBP.TabStop = True
        Me.GBP.Text = "Pound Sterling"
        Me.GBP.UseVisualStyleBackColor = True
        '
        'grpEuro
        '
        Me.grpEuro.Controls.Add(Me.txtETH)
        Me.grpEuro.Controls.Add(Me.txtBTC)
        Me.grpEuro.Controls.Add(Me.txtBGN)
        Me.grpEuro.Controls.Add(Me.txtCHF)
        Me.grpEuro.Controls.Add(Me.txtUSD)
        Me.grpEuro.Controls.Add(Me.txtGBP)
        Me.grpEuro.Location = New System.Drawing.Point(290, 68)
        Me.grpEuro.Name = "grpEuro"
        Me.grpEuro.Size = New System.Drawing.Size(112, 272)
        Me.grpEuro.TabIndex = 2
        Me.grpEuro.TabStop = False
        Me.grpEuro.Text = "Euro"
        '
        'txtETH
        '
        Me.txtETH.Enabled = False
        Me.txtETH.Location = New System.Drawing.Point(6, 246)
        Me.txtETH.Name = "txtETH"
        Me.txtETH.Size = New System.Drawing.Size(100, 20)
        Me.txtETH.TabIndex = 5
        Me.txtETH.Text = "144.03"
        '
        'txtBTC
        '
        Me.txtBTC.Enabled = False
        Me.txtBTC.Location = New System.Drawing.Point(6, 200)
        Me.txtBTC.Name = "txtBTC"
        Me.txtBTC.Size = New System.Drawing.Size(100, 20)
        Me.txtBTC.TabIndex = 4
        Me.txtBTC.Text = "5,125.89"
        '
        'txtBGN
        '
        Me.txtBGN.Enabled = False
        Me.txtBGN.Location = New System.Drawing.Point(6, 153)
        Me.txtBGN.Name = "txtBGN"
        Me.txtBGN.Size = New System.Drawing.Size(100, 20)
        Me.txtBGN.TabIndex = 3
        Me.txtBGN.Text = "0.51"
        '
        'txtCHF
        '
        Me.txtCHF.Enabled = False
        Me.txtCHF.Location = New System.Drawing.Point(6, 110)
        Me.txtCHF.Name = "txtCHF"
        Me.txtCHF.Size = New System.Drawing.Size(100, 20)
        Me.txtCHF.TabIndex = 2
        Me.txtCHF.Text = "0.88"
        '
        'txtUSD
        '
        Me.txtUSD.Enabled = False
        Me.txtUSD.Location = New System.Drawing.Point(6, 63)
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(100, 20)
        Me.txtUSD.TabIndex = 1
        Me.txtUSD.Text = "0.89"
        '
        'txtGBP
        '
        Me.txtGBP.Enabled = False
        Me.txtGBP.Location = New System.Drawing.Point(6, 19)
        Me.txtGBP.Name = "txtGBP"
        Me.txtGBP.Size = New System.Drawing.Size(100, 20)
        Me.txtGBP.TabIndex = 0
        Me.txtGBP.Text = "1.17"
        '
        'btnExchangeRateChange
        '
        Me.btnExchangeRateChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExchangeRateChange.Location = New System.Drawing.Point(296, 20)
        Me.btnExchangeRateChange.Name = "btnExchangeRateChange"
        Me.btnExchangeRateChange.Size = New System.Drawing.Size(100, 23)
        Me.btnExchangeRateChange.TabIndex = 3
        Me.btnExchangeRateChange.Text = "Exchange Rate"
        Me.btnExchangeRateChange.UseVisualStyleBackColor = True
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(34, 382)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(75, 16)
        Me.lblSum.TabIndex = 4
        Me.lblSum.Text = "Ammount:"
        '
        'txtSUM
        '
        Me.txtSUM.Location = New System.Drawing.Point(115, 381)
        Me.txtSUM.Name = "txtSUM"
        Me.txtSUM.Size = New System.Drawing.Size(100, 20)
        Me.txtSUM.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(296, 379)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSUM)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.btnExchangeRateChange)
        Me.Controls.Add(Me.grpEuro)
        Me.Controls.Add(Me.grpCurrency)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmCurrency"
        Me.Text = "Currency"
        Me.grpCurrency.ResumeLayout(False)
        Me.grpCurrency.PerformLayout()
        Me.grpEuro.ResumeLayout(False)
        Me.grpEuro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpCurrency As GroupBox
    Friend WithEvents ETH As RadioButton
    Friend WithEvents BTC As RadioButton
    Friend WithEvents BGN As RadioButton
    Friend WithEvents CHF As RadioButton
    Friend WithEvents USD As RadioButton
    Friend WithEvents GBP As RadioButton
    Friend WithEvents grpEuro As GroupBox
    Friend WithEvents txtETH As TextBox
    Friend WithEvents txtBTC As TextBox
    Friend WithEvents txtBGN As TextBox
    Friend WithEvents txtCHF As TextBox
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents txtGBP As TextBox
    Friend WithEvents btnExchangeRateChange As Button
    Friend WithEvents lblSum As Label
    Friend WithEvents txtSUM As TextBox
    Friend WithEvents btnCalculate As Button
End Class

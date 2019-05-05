Public Class frmCurrency

    Dim Rate As Single
    Dim CurrencyType As String

    Private Sub GBP_CheckedChanged(sender As Object, e As EventArgs) Handles GBP.CheckedChanged
        Rate = Val(txtGBP.Text)
        CurrencyType = " GBP"
    End Sub

    Private Sub USD_CheckedChanged(sender As Object, e As EventArgs) Handles USD.CheckedChanged
        Rate = Val(txtUSD.Text)
        CurrencyType = " USD"
    End Sub

    Private Sub CHF_CheckedChanged(sender As Object, e As EventArgs) Handles CHF.CheckedChanged
        Rate = Val(txtCHF.Text)
        CurrencyType = " CHF"
    End Sub

    Private Sub BGN_CheckedChanged(sender As Object, e As EventArgs) Handles BGN.CheckedChanged
        Rate = Val(txtBGN.Text)
        CurrencyType = " BGN"
    End Sub

    Private Sub BTC_CheckedChanged(sender As Object, e As EventArgs) Handles BTC.CheckedChanged
        Rate = Val(txtBTC.Text)
        CurrencyType = " BTC"
    End Sub

    Private Sub ETH_CheckedChanged(sender As Object, e As EventArgs) Handles ETH.CheckedChanged
        Rate = Val(txtETH.Text)
        CurrencyType = " ETH"
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        MsgBox("For ammount of " & txtSUM.Text & " euro, you will get " & Format(Val(txtSUM.Text) / Rate, "### ###.00") & CurrencyType, 0, "Smart Donald Trump said...")
    End Sub
End Class

Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoyaltyPoints.Text = ""
        lblCostValue.Text = ""
        radPlatter1.Checked = False
        radPlatter2.Checked = False
        radPlatter3.Checked = False
        radPlatter4.Checked = False
        radPlatter5.Checked = False
        radPrePay.Checked = False
        radPayAtPickup.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate loyalty input
        If (IsNumeric(txtLoyaltyPoints.Text) AndAlso txtLoyaltyPoints.Text < 0) Then
            MsgBox("Invalid loyalty points. Try again.")
        Else
            ' Validate a pay type was selcted
            If (radPayAtPickup.Checked = False And radPrePay.Checked = False) Then
                MsgBox("You must choose a payment type.")
            Else
                ' Determine base cost
                Dim decCost As Decimal = 0.0
                If (radPlatter1.Checked) Then
                    decCost = 28.0
                ElseIf (radPlatter2.Checked) Then
                    decCost = 30.0
                ElseIf (radPlatter3.Checked) Then
                    decCost = 40.0
                ElseIf (radPlatter4.Checked) Then
                    decCost = 40.0
                ElseIf (radPlatter5.Checked) Then
                    decCost = 50.0
                End If

                ' Calculate discount
                Dim decDiscount As Decimal = 0.0
                If (IsNumeric(txtLoyaltyPoints.Text)) Then
                    Dim decDiscountPercent As Decimal = ((txtLoyaltyPoints.Text / 10) * 5) / 100
                    decDiscount = decDiscountPercent * decCost
                End If

                ' Calculate total
                Dim decTotal As Decimal = decCost - decDiscount
                ' Handle discount > 100%
                If (decTotal < 0.0) Then
                    lblCostValue.Text = 0.0.ToString("C2")
                Else
                    lblCostValue.Text = decTotal.ToString("C2")
                End If
            End If
        End If
    End Sub
End Class

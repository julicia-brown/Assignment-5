Public Class frmComicC
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Clear()
        txtTotal.Clear()
        radSuperhero.Checked = True
        radAutograph.Checked = False
        radConvention.Checked = False
        txtGroupSize.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380
        Dim decAutograph As Decimal = 275
        Dim decConvention As Decimal = 209

        If IsNumeric(txtGroupSize.Text) Then
            intGroup = Convert.ToInt32(txtGroupSize.Text)
            If intGroup > 0 And intGroup < 20 Then
                If radSuperhero.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutograph.Checked Then
                    decRegistration = decAutograph
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                txtTotal.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a positive Number between 1 and 20", , "Invalis Number Error")
            End If
        Else
            MsgBox("Enter a resonable number between 1 and 20", , "Invalid Entry Error")
        End If
    End Sub
End Class

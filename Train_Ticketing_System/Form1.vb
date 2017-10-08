Option Strict On

Public Class Form1
    Dim num1, num2 As Decimal
    Dim operan As Integer
    Dim operanselected As Boolean = False
    Const kilburn = 23.9
    Const Brixton = 56
    Const Oxford = 67.23
    Const Preston = 78
    Const Tax = 19.75
    Dim TotalCost As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Oxford")
        ComboBox1.Items.Add("Leeds")
        ComboBox1.Items.Add("Preston")
        ComboBox1.Items.Add("Kilburn")
        ComboBox1.Items.Add("Brixton")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "7"
        Else
            lblDisplay.Text = "7"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "0"
        Else
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "1"
        Else
            lblDisplay.Text = "1"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "2"
        Else
            lblDisplay.Text = "2"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "3"
        Else
            lblDisplay.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "4"
        Else
            lblDisplay.Text = "4"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "5"
        Else
            lblDisplay.Text = "5"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "6"
        Else
            lblDisplay.Text = "6"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "8"
        Else
            lblDisplay.Text = "8"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "9"
        Else
            lblDisplay.Text = "9"
        End If
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles Button17.Click
        num1 = CDec(lblDisplay.Text)
        lblDisplay.Text = "0"
        operanselected = True
        operan = 1
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num1 = CDec(lblDisplay.Text)
        lblDisplay.Text = "0"
        operanselected = True
        operan = 2
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num1 = CDec(lblDisplay.Text)
        lblDisplay.Text = "0"
        operanselected = True
        operan = 3
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num1 = CDec(lblDisplay.Text)
        lblDisplay.Text = "0"
        operanselected = True
        operan = 4
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num1 = CDec(lblDisplay.Text)
        lblDisplay.Text = "0"
        operanselected = True
        operan = 5
    End Sub

    Private Sub BtnDot_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblDisplay.Text = ""
        lblDisplay.Text = "0"
    End Sub

    Private Sub BtnEqls_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If operanselected = True Then
            num2 = CDec(lblDisplay.Text)
            If operan = 1 Then
                lblDisplay.Text = (num1 + num2).ToString()
            ElseIf operan = 2 Then
                lblDisplay.Text = (num1 - num2).ToString()
            ElseIf operan = 3 Then
                lblDisplay.Text = (num1 * num2).ToString()
            ElseIf operan = 4 Then

                If num1 = 0 Or num2 = 0 Then
                    lblDisplay.Text = "Error"
                Else
                    lblDisplay.Text = (num1 / num2).ToString()
                End If
            ElseIf operan = 5 Then
                lblDisplay.Text = CStr(num1 Mod num2)

            End If
            operanselected = False
        End If
    End Sub

    Private Sub LabelExit_Click(sender As Object, e As EventArgs) Handles Label38.Click
        Application.Exit()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        If ComboBox1.Text = "Kilburn" And rb1.Checked And rb4.Checked And rb7.Checked Then
            lblSubtotal23.Text = FormatCurrency(kilburn.ToString())
            lblTax23.Text = FormatCurrency(Tax.ToString())
            TotalCost = (kilburn * Tax) / 100
            lblTotal23.Text = CStr(FormatCurrency(TotalCost + kilburn))


        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub


End Class

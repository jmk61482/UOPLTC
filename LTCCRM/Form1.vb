﻿'Learning Team C

'test comment
Public Class Form1

    Private Const DateFormat As String = "{0:MM/dd/yyyy}"

    ''' <summary>
    ''' Execute code upon button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        'Hard coded test insert do not use
        'CRMDATATableAdapter.Insert("Matthew", "Sessions", 139847, "08112017", "Cash", "08112017")

        AddCustomer()


    End Sub

    ''' <summary>
    ''' Execute code upon form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CRMDATATableAdapter.Fill(Me.CRMDataSet.CRMDATA)
        ListBox1.SelectedIndex = -1
        PreFillFields()

    End Sub

    ''' <summary>
    ''' This code pre fills all fields when called
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreFillFields()
        Dim todaysDate As String = String.Format(DateFormat, DateTime.Now)
        U_USERTextBox.Text = CRMDATATableAdapter.SelectMaxUserID() + 1
        D_LAST_PURCHASEDTextBox.Text = todaysDate
        D_START_DATETextBox.Text = todaysDate
    End Sub

    ''' <summary>
    ''' When method is called it calls the table adapter insert to insert form information
    ''' into the database then clears fields
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCustomer()

        Dim fullName As String = T_LAST_NAMETextBox.Text + ", " + T_FIRST_NAMETextBox.Text

        CRMDATATableAdapter.Insert(
                     T_FIRST_NAMETextBox.Text,
                     T_LAST_NAMETextBox.Text,
                     U_LAST_RECEIPTTextBox.Text,
                     D_LAST_PURCHASEDTextBox.Text,
                     T_PAY_METHTextBox.Text,
                     D_START_DATETextBox.Text,
                     fullName)

        ClearFields()
        CRMDATATableAdapter.Fill(CRMDataSet.CRMDATA)
        ListBox1.SelectedIndex = -1

    End Sub

    ''' <summary>
    ''' Clears all fields and calls the PreFillFields() method to fill in fields
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearFields()

        T_FIRST_NAMETextBox.Text = String.Empty
        T_LAST_NAMETextBox.Text = String.Empty
        U_LAST_RECEIPTTextBox.Text = String.Empty
        T_PAY_METHTextBox.Text = String.Empty

        PreFillFields()

    End Sub

    ''' <summary>
    ''' On Clear button click call ClearFields() method
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ''' <summary>
    ''' When a customer is selected from the listbox, Information will be pulled from
    ''' the database and populated in their correct field
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Dim ln As String = ListBox1.Text
            U_USERTextBox.Text = CRMDATATableAdapter.GetUserID(ln)
            T_FIRST_NAMETextBox.Text = CRMDATATableAdapter.GetFirstName(ln)
            T_LAST_NAMETextBox.Text = CRMDATATableAdapter.GetLastName(ln)
            U_LAST_RECEIPTTextBox.Text = CRMDATATableAdapter.GetReceiptID(ln)
            D_LAST_PURCHASEDTextBox.Text = CRMDATATableAdapter.GetDateLastPurchased(ln)
            T_PAY_METHTextBox.Text = CRMDATATableAdapter.GetPaymentMethod(ln)
            D_START_DATETextBox.Text = CRMDATATableAdapter.GetStartDate(ln)
        End If
    End Sub

    Private Sub U_LAST_RECEIPTTextBox_TextChanged(sender As Object, e As EventArgs) Handles U_LAST_RECEIPTTextBox.TextChanged
        

    End Sub


    Private Sub U_LAST_RECEIPTTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then _
        '   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
        'e.Handled = True
        'End If
    End Sub
End Class

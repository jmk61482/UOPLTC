'Learning Team C

Public Class Form1

    Private Const DateFormat As String = "{0:MM/dd/yyyy}"

    ''' <summary>
    ''' Execute code upon button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        CRMDATATableAdapter.Insert(
                     T_FIRST_NAMETextBox.Text,
                     T_LAST_NAMETextBox.Text,
                     U_LAST_RECEIPTTextBox.Text,
                     D_LAST_PURCHASEDTextBox.Text,
                     T_PAY_METHTextBox.Text,
                     D_START_DATETextBox.Text
                     )

        ClearFields()

    End Sub

    ''' <summary>
    ''' Clears all fields and calls the PreFillFields() method to fill in fields
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearFields()

        T_FIRST_NAMETextBox.Text = String.Empty
        T_LAST_NAMETextBox.Text = String.Empty
        U_LAST_RECEIPTTextBox.Text = String.Empty
        T_PAY_METHTextBox.SelectedIndex = -1

        PreFillFields()

    End Sub
End Class

'Learning Team C

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hard coded test insert do not use
        'CRMDATATableAdapter.Insert("Matthew", "Sessions", 139847, "08112017", "Cash", "08112017")



        'TODO: add insert in a different method after all field validation has been performed
        CRMDATATableAdapter.Insert(
                     T_FIRST_NAMETextBox.Text,
                     T_LAST_NAMETextBox.Text,
                     U_LAST_RECEIPTTextBox.Text,
                     D_LAST_PURCHASEDTextBox.Text,
                     T_PAY_METHTextBox.Text,
                     D_START_DATETextBox.Text
                     )
    End Sub

    Private Sub CRMDATABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CRMDATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CRMDATA' table. You can move, or remove it, as needed.
        'Me.CRMDATATableAdapter.Fill(Me.CRMDataSet.CRMDATA)

        PreFillFields()

    End Sub

    Private Sub PreFillFields()
        Dim todaysDate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        U_USERTextBox.Text = CRMDATATableAdapter.SelectMaxUserID() + 1
        D_LAST_PURCHASEDTextBox.Text = todaysDate
        D_START_DATETextBox.Text = todaysDate
    End Sub
End Class

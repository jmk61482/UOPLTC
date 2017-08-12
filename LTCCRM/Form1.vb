'Learning Team C

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hard coded test insert do not use
        'CRMDATATableAdapter.Insert("Matthew", "Sessions", 139847, "08112017", "Cash", "08112017")

        Dim crmTA = CRMDATATableAdapter

        crmTA.Insert(
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

    End Sub
End Class

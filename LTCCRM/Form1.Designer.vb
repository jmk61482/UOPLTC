<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim U_USERLabel As System.Windows.Forms.Label
        Dim T_FIRST_NAMELabel As System.Windows.Forms.Label
        Dim T_LAST_NAMELabel As System.Windows.Forms.Label
        Dim U_LAST_RECEIPTLabel As System.Windows.Forms.Label
        Dim D_LAST_PURCHASEDLabel As System.Windows.Forms.Label
        Dim T_PAY_METHLabel As System.Windows.Forms.Label
        Dim D_START_DATELabel As System.Windows.Forms.Label
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.CRMDataSet = New LTCCRM.CRMDataSet()
        Me.CRMDATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDATATableAdapter = New LTCCRM.CRMDataSetTableAdapters.CRMDATATableAdapter()
        Me.TableAdapterManager = New LTCCRM.CRMDataSetTableAdapters.TableAdapterManager()
        Me.T_PAY_METHTextBox = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.U_USERTextBox = New System.Windows.Forms.TextBox()
        Me.T_FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.T_LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.U_LAST_RECEIPTTextBox = New System.Windows.Forms.TextBox()
        Me.D_LAST_PURCHASEDTextBox = New System.Windows.Forms.TextBox()
        Me.D_START_DATETextBox = New System.Windows.Forms.TextBox()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        U_USERLabel = New System.Windows.Forms.Label()
        T_FIRST_NAMELabel = New System.Windows.Forms.Label()
        T_LAST_NAMELabel = New System.Windows.Forms.Label()
        U_LAST_RECEIPTLabel = New System.Windows.Forms.Label()
        D_LAST_PURCHASEDLabel = New System.Windows.Forms.Label()
        T_PAY_METHLabel = New System.Windows.Forms.Label()
        D_START_DATELabel = New System.Windows.Forms.Label()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'U_USERLabel
        '
        U_USERLabel.AutoSize = True
        U_USERLabel.Location = New System.Drawing.Point(12, 16)
        U_USERLabel.Name = "U_USERLabel"
        U_USERLabel.Size = New System.Drawing.Size(68, 13)
        U_USERLabel.TabIndex = 16
        U_USERLabel.Text = "Customer ID:"
        '
        'T_FIRST_NAMELabel
        '
        T_FIRST_NAMELabel.AutoSize = True
        T_FIRST_NAMELabel.Location = New System.Drawing.Point(12, 62)
        T_FIRST_NAMELabel.Name = "T_FIRST_NAMELabel"
        T_FIRST_NAMELabel.Size = New System.Drawing.Size(60, 13)
        T_FIRST_NAMELabel.TabIndex = 18
        T_FIRST_NAMELabel.Text = "First Name:"
        '
        'T_LAST_NAMELabel
        '
        T_LAST_NAMELabel.AutoSize = True
        T_LAST_NAMELabel.Location = New System.Drawing.Point(12, 113)
        T_LAST_NAMELabel.Name = "T_LAST_NAMELabel"
        T_LAST_NAMELabel.Size = New System.Drawing.Size(61, 13)
        T_LAST_NAMELabel.TabIndex = 20
        T_LAST_NAMELabel.Text = "Last Name:"
        '
        'U_LAST_RECEIPTLabel
        '
        U_LAST_RECEIPTLabel.AutoSize = True
        U_LAST_RECEIPTLabel.Location = New System.Drawing.Point(12, 164)
        U_LAST_RECEIPTLabel.Name = "U_LAST_RECEIPTLabel"
        U_LAST_RECEIPTLabel.Size = New System.Drawing.Size(110, 13)
        U_LAST_RECEIPTLabel.TabIndex = 22
        U_LAST_RECEIPTLabel.Text = "Last Receipt Number:"
        '
        'D_LAST_PURCHASEDLabel
        '
        D_LAST_PURCHASEDLabel.AutoSize = True
        D_LAST_PURCHASEDLabel.Location = New System.Drawing.Point(12, 210)
        D_LAST_PURCHASEDLabel.Name = "D_LAST_PURCHASEDLabel"
        D_LAST_PURCHASEDLabel.Size = New System.Drawing.Size(110, 13)
        D_LAST_PURCHASEDLabel.TabIndex = 24
        D_LAST_PURCHASEDLabel.Text = "Last Date Purchased:"
        '
        'T_PAY_METHLabel
        '
        T_PAY_METHLabel.AutoSize = True
        T_PAY_METHLabel.Location = New System.Drawing.Point(12, 256)
        T_PAY_METHLabel.Name = "T_PAY_METHLabel"
        T_PAY_METHLabel.Size = New System.Drawing.Size(90, 13)
        T_PAY_METHLabel.TabIndex = 26
        T_PAY_METHLabel.Text = "Payment Method:"
        '
        'D_START_DATELabel
        '
        D_START_DATELabel.AutoSize = True
        D_START_DATELabel.Location = New System.Drawing.Point(12, 302)
        D_START_DATELabel.Name = "D_START_DATELabel"
        D_START_DATELabel.Size = New System.Drawing.Size(102, 13)
        D_START_DATELabel.TabIndex = 28
        D_START_DATELabel.Text = "Customer Join Date:"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(341, 395)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(98, 23)
        Me.btnAddCustomer.TabIndex = 15
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRMDATABindingSource
        '
        Me.CRMDATABindingSource.DataMember = "CRMDATA"
        Me.CRMDATABindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDATATableAdapter
        '
        Me.CRMDATATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CRMDATATableAdapter = Me.CRMDATATableAdapter
        Me.TableAdapterManager.UpdateOrder = LTCCRM.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_PAY_METHTextBox
        '
        Me.T_PAY_METHTextBox.FormattingEnabled = True
        Me.T_PAY_METHTextBox.Items.AddRange(New Object() {"Cash", "Debit", "Credit", "Check", "PayPal"})
        Me.T_PAY_METHTextBox.Location = New System.Drawing.Point(136, 253)
        Me.T_PAY_METHTextBox.Name = "T_PAY_METHTextBox"
        Me.T_PAY_METHTextBox.Size = New System.Drawing.Size(100, 21)
        Me.T_PAY_METHTextBox.TabIndex = 30
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(237, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 23)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.CRMDATABindingSource
        Me.ListBox1.DisplayMember = "T_FULL_NAME"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(293, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 316)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 32
        '
        'U_USERTextBox
        '
        Me.U_USERTextBox.Location = New System.Drawing.Point(136, 13)
        Me.U_USERTextBox.Name = "U_USERTextBox"
        Me.U_USERTextBox.ReadOnly = True
        Me.U_USERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_USERTextBox.TabIndex = 33
        '
        'T_FIRST_NAMETextBox
        '
        Me.T_FIRST_NAMETextBox.Location = New System.Drawing.Point(136, 59)
        Me.T_FIRST_NAMETextBox.Name = "T_FIRST_NAMETextBox"
        Me.T_FIRST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_FIRST_NAMETextBox.TabIndex = 34
        '
        'T_LAST_NAMETextBox
        '
        Me.T_LAST_NAMETextBox.Location = New System.Drawing.Point(136, 110)
        Me.T_LAST_NAMETextBox.Name = "T_LAST_NAMETextBox"
        Me.T_LAST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_LAST_NAMETextBox.TabIndex = 35
        '
        'U_LAST_RECEIPTTextBox
        '
        Me.U_LAST_RECEIPTTextBox.Location = New System.Drawing.Point(136, 161)
        Me.U_LAST_RECEIPTTextBox.Name = "U_LAST_RECEIPTTextBox"
        Me.U_LAST_RECEIPTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_LAST_RECEIPTTextBox.TabIndex = 36
        '
        'D_LAST_PURCHASEDTextBox
        '
        Me.D_LAST_PURCHASEDTextBox.Location = New System.Drawing.Point(136, 207)
        Me.D_LAST_PURCHASEDTextBox.Name = "D_LAST_PURCHASEDTextBox"
        Me.D_LAST_PURCHASEDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_LAST_PURCHASEDTextBox.TabIndex = 37
        '
        'D_START_DATETextBox
        '
        Me.D_START_DATETextBox.Location = New System.Drawing.Point(136, 299)
        Me.D_START_DATETextBox.Name = "D_START_DATETextBox"
        Me.D_START_DATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_START_DATETextBox.TabIndex = 38
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(445, 395)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdateCustomer.TabIndex = 39
        Me.btnUpdateCustomer.Text = "Update Customer"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 471)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Controls.Add(Me.D_START_DATETextBox)
        Me.Controls.Add(Me.D_LAST_PURCHASEDTextBox)
        Me.Controls.Add(Me.U_LAST_RECEIPTTextBox)
        Me.Controls.Add(Me.T_LAST_NAMETextBox)
        Me.Controls.Add(Me.T_FIRST_NAMETextBox)
        Me.Controls.Add(Me.U_USERTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.T_PAY_METHTextBox)
        Me.Controls.Add(U_USERLabel)
        Me.Controls.Add(T_FIRST_NAMELabel)
        Me.Controls.Add(T_LAST_NAMELabel)
        Me.Controls.Add(U_LAST_RECEIPTLabel)
        Me.Controls.Add(D_LAST_PURCHASEDLabel)
        Me.Controls.Add(T_PAY_METHLabel)
        Me.Controls.Add(D_START_DATELabel)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Name = "Form1"
        Me.Text = "Learning Team C CRM"
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents CRMDataSet As LTCCRM.CRMDataSet
    Friend WithEvents CRMDATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CRMDATATableAdapter As LTCCRM.CRMDataSetTableAdapters.CRMDATATableAdapter
    Friend WithEvents TableAdapterManager As LTCCRM.CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_PAY_METHTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents U_USERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents U_LAST_RECEIPTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents D_LAST_PURCHASEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents D_START_DATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateCustomer As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Form
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
        Dim Cust_CodeLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Form))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pay_Junction_Database_Management_SysDataSet = New Pay_Junction.Pay_Junction_Database_Management_SysDataSet()
        Me.Customers_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customers_DetailsTableAdapter = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.Customers_DetailsTableAdapter()
        Me.TableAdapterManager = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager()
        Me.Customers_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customers_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cust_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Cust_CodeLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customers_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customers_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customers_DetailsBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cust_CodeLabel
        '
        Cust_CodeLabel.AutoSize = True
        Cust_CodeLabel.Location = New System.Drawing.Point(25, 72)
        Cust_CodeLabel.Name = "Cust_CodeLabel"
        Cust_CodeLabel.Size = New System.Drawing.Size(59, 13)
        Cust_CodeLabel.TabIndex = 4
        Cust_CodeLabel.Text = "Cust Code:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(25, 98)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(25, 124)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 8
        Last_NameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(25, 150)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(25, 176)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 12
        CountryLabel.Text = "Country:"
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Location = New System.Drawing.Point(25, 202)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(53, 13)
        Zip_CodeLabel.TabIndex = 14
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Location = New System.Drawing.Point(25, 228)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(58, 13)
        Phone_NoLabel.TabIndex = 16
        Phone_NoLabel.Text = "Phone No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 44)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Form"
        '
        'Pay_Junction_Database_Management_SysDataSet
        '
        Me.Pay_Junction_Database_Management_SysDataSet.DataSetName = "Pay_Junction_Database_Management_SysDataSet"
        Me.Pay_Junction_Database_Management_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customers_DetailsBindingSource
        '
        Me.Customers_DetailsBindingSource.DataMember = "Customers_Details"
        Me.Customers_DetailsBindingSource.DataSource = Me.Pay_Junction_Database_Management_SysDataSet
        '
        'Customers_DetailsTableAdapter
        '
        Me.Customers_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customers_DetailsTableAdapter = Me.Customers_DetailsTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.Payment_ModesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customers_DetailsBindingNavigator
        '
        Me.Customers_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customers_DetailsBindingNavigator.BindingSource = Me.Customers_DetailsBindingSource
        Me.Customers_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customers_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customers_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Customers_DetailsBindingNavigatorSaveItem})
        Me.Customers_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Customers_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customers_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customers_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customers_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customers_DetailsBindingNavigator.Name = "Customers_DetailsBindingNavigator"
        Me.Customers_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customers_DetailsBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.Customers_DetailsBindingNavigator.TabIndex = 4
        Me.Customers_DetailsBindingNavigator.Text = "BindingNavigator1"
        Me.Customers_DetailsBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Customers_DetailsBindingNavigatorSaveItem
        '
        Me.Customers_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Customers_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customers_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customers_DetailsBindingNavigatorSaveItem.Name = "Customers_DetailsBindingNavigatorSaveItem"
        Me.Customers_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Customers_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cust_CodeTextBox
        '
        Me.Cust_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Cust_Code", True))
        Me.Cust_CodeTextBox.Location = New System.Drawing.Point(92, 69)
        Me.Cust_CodeTextBox.Name = "Cust_CodeTextBox"
        Me.Cust_CodeTextBox.Size = New System.Drawing.Size(472, 20)
        Me.Cust_CodeTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(92, 95)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(472, 20)
        Me.First_NameTextBox.TabIndex = 7
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(92, 121)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(472, 20)
        Me.Last_NameTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(92, 147)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(472, 20)
        Me.AddressTextBox.TabIndex = 11
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(92, 173)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(472, 20)
        Me.CountryTextBox.TabIndex = 13
        '
        'Zip_CodeTextBox
        '
        Me.Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Zip_Code", True))
        Me.Zip_CodeTextBox.Location = New System.Drawing.Point(92, 199)
        Me.Zip_CodeTextBox.Name = "Zip_CodeTextBox"
        Me.Zip_CodeTextBox.Size = New System.Drawing.Size(472, 20)
        Me.Zip_CodeTextBox.TabIndex = 15
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_DetailsBindingSource, "Phone_No", True))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(92, 225)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(472, 20)
        Me.Phone_NoTextBox.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 206)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 63)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(477, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(294, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(203, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(111, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Customer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 346)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Cust_CodeLabel)
        Me.Controls.Add(Me.Cust_CodeTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeTextBox)
        Me.Controls.Add(Phone_NoLabel)
        Me.Controls.Add(Me.Phone_NoTextBox)
        Me.Controls.Add(Me.Customers_DetailsBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer_Form"
        Me.Text = "Customer Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customers_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customers_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customers_DetailsBindingNavigator.ResumeLayout(False)
        Me.Customers_DetailsBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pay_Junction_Database_Management_SysDataSet As Pay_Junction_Database_Management_SysDataSet
    Friend WithEvents Customers_DetailsBindingSource As BindingSource
    Friend WithEvents Customers_DetailsTableAdapter As Pay_Junction_Database_Management_SysDataSetTableAdapters.Customers_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customers_DetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Customers_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cust_CodeTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents Zip_CodeTextBox As TextBox
    Friend WithEvents Phone_NoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

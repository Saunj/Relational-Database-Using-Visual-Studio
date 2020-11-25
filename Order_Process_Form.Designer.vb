<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Process_Form
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
        Dim Order_CodeLabel As System.Windows.Forms.Label
        Dim Cust_CodeLabel As System.Windows.Forms.Label
        Dim Emp_CodeLabel As System.Windows.Forms.Label
        Dim Order_DtLabel As System.Windows.Forms.Label
        Dim Ship_NameLabel As System.Windows.Forms.Label
        Dim Ship_AddressLabel As System.Windows.Forms.Label
        Dim Ship_CountryLabel As System.Windows.Forms.Label
        Dim Ship_PhoneLabel As System.Windows.Forms.Label
        Dim Ship_DtLabel As System.Windows.Forms.Label
        Dim Ship_Method_IDLabel As System.Windows.Forms.Label
        Dim Freight_ChargeLabel As System.Windows.Forms.Label
        Dim Sales_TaxLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Process_Form))
        Me.Pay_Junction_Database_Management_SysDataSet = New Pay_Junction.Pay_Junction_Database_Management_SysDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager()
        Me.OrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Order_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ship_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_DtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ship_Method_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Freight_ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_TaxTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Order_CodeLabel = New System.Windows.Forms.Label()
        Cust_CodeLabel = New System.Windows.Forms.Label()
        Emp_CodeLabel = New System.Windows.Forms.Label()
        Order_DtLabel = New System.Windows.Forms.Label()
        Ship_NameLabel = New System.Windows.Forms.Label()
        Ship_AddressLabel = New System.Windows.Forms.Label()
        Ship_CountryLabel = New System.Windows.Forms.Label()
        Ship_PhoneLabel = New System.Windows.Forms.Label()
        Ship_DtLabel = New System.Windows.Forms.Label()
        Ship_Method_IDLabel = New System.Windows.Forms.Label()
        Freight_ChargeLabel = New System.Windows.Forms.Label()
        Sales_TaxLabel = New System.Windows.Forms.Label()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdersBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Order_CodeLabel
        '
        Order_CodeLabel.AutoSize = True
        Order_CodeLabel.Location = New System.Drawing.Point(53, 107)
        Order_CodeLabel.Name = "Order_CodeLabel"
        Order_CodeLabel.Size = New System.Drawing.Size(64, 13)
        Order_CodeLabel.TabIndex = 1
        Order_CodeLabel.Text = "Order Code:"
        '
        'Cust_CodeLabel
        '
        Cust_CodeLabel.AutoSize = True
        Cust_CodeLabel.Location = New System.Drawing.Point(53, 133)
        Cust_CodeLabel.Name = "Cust_CodeLabel"
        Cust_CodeLabel.Size = New System.Drawing.Size(59, 13)
        Cust_CodeLabel.TabIndex = 3
        Cust_CodeLabel.Text = "Cust Code:"
        '
        'Emp_CodeLabel
        '
        Emp_CodeLabel.AutoSize = True
        Emp_CodeLabel.Location = New System.Drawing.Point(53, 159)
        Emp_CodeLabel.Name = "Emp_CodeLabel"
        Emp_CodeLabel.Size = New System.Drawing.Size(59, 13)
        Emp_CodeLabel.TabIndex = 5
        Emp_CodeLabel.Text = "Emp Code:"
        '
        'Order_DtLabel
        '
        Order_DtLabel.AutoSize = True
        Order_DtLabel.Location = New System.Drawing.Point(53, 186)
        Order_DtLabel.Name = "Order_DtLabel"
        Order_DtLabel.Size = New System.Drawing.Size(50, 13)
        Order_DtLabel.TabIndex = 7
        Order_DtLabel.Text = "Order Dt:"
        '
        'Ship_NameLabel
        '
        Ship_NameLabel.AutoSize = True
        Ship_NameLabel.Location = New System.Drawing.Point(53, 211)
        Ship_NameLabel.Name = "Ship_NameLabel"
        Ship_NameLabel.Size = New System.Drawing.Size(62, 13)
        Ship_NameLabel.TabIndex = 9
        Ship_NameLabel.Text = "Ship Name:"
        '
        'Ship_AddressLabel
        '
        Ship_AddressLabel.AutoSize = True
        Ship_AddressLabel.Location = New System.Drawing.Point(53, 237)
        Ship_AddressLabel.Name = "Ship_AddressLabel"
        Ship_AddressLabel.Size = New System.Drawing.Size(72, 13)
        Ship_AddressLabel.TabIndex = 11
        Ship_AddressLabel.Text = "Ship Address:"
        '
        'Ship_CountryLabel
        '
        Ship_CountryLabel.AutoSize = True
        Ship_CountryLabel.Location = New System.Drawing.Point(436, 110)
        Ship_CountryLabel.Name = "Ship_CountryLabel"
        Ship_CountryLabel.Size = New System.Drawing.Size(70, 13)
        Ship_CountryLabel.TabIndex = 13
        Ship_CountryLabel.Text = "Ship Country:"
        '
        'Ship_PhoneLabel
        '
        Ship_PhoneLabel.AutoSize = True
        Ship_PhoneLabel.Location = New System.Drawing.Point(436, 136)
        Ship_PhoneLabel.Name = "Ship_PhoneLabel"
        Ship_PhoneLabel.Size = New System.Drawing.Size(65, 13)
        Ship_PhoneLabel.TabIndex = 15
        Ship_PhoneLabel.Text = "Ship Phone:"
        '
        'Ship_DtLabel
        '
        Ship_DtLabel.AutoSize = True
        Ship_DtLabel.Location = New System.Drawing.Point(436, 163)
        Ship_DtLabel.Name = "Ship_DtLabel"
        Ship_DtLabel.Size = New System.Drawing.Size(45, 13)
        Ship_DtLabel.TabIndex = 17
        Ship_DtLabel.Text = "Ship Dt:"
        '
        'Ship_Method_IDLabel
        '
        Ship_Method_IDLabel.AutoSize = True
        Ship_Method_IDLabel.Location = New System.Drawing.Point(436, 188)
        Ship_Method_IDLabel.Name = "Ship_Method_IDLabel"
        Ship_Method_IDLabel.Size = New System.Drawing.Size(84, 13)
        Ship_Method_IDLabel.TabIndex = 19
        Ship_Method_IDLabel.Text = "Ship Method ID:"
        '
        'Freight_ChargeLabel
        '
        Freight_ChargeLabel.AutoSize = True
        Freight_ChargeLabel.Location = New System.Drawing.Point(436, 214)
        Freight_ChargeLabel.Name = "Freight_ChargeLabel"
        Freight_ChargeLabel.Size = New System.Drawing.Size(79, 13)
        Freight_ChargeLabel.TabIndex = 21
        Freight_ChargeLabel.Text = "Freight Charge:"
        '
        'Sales_TaxLabel
        '
        Sales_TaxLabel.AutoSize = True
        Sales_TaxLabel.Location = New System.Drawing.Point(436, 240)
        Sales_TaxLabel.Name = "Sales_TaxLabel"
        Sales_TaxLabel.Size = New System.Drawing.Size(57, 13)
        Sales_TaxLabel.TabIndex = 23
        Sales_TaxLabel.Text = "Sales Tax:"
        '
        'Pay_Junction_Database_Management_SysDataSet
        '
        Me.Pay_Junction_Database_Management_SysDataSet.DataSetName = "Pay_Junction_Database_Management_SysDataSet"
        Me.Pay_Junction_Database_Management_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.Pay_Junction_Database_Management_SysDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customers_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.Payment_ModesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrdersBindingNavigator
        '
        Me.OrdersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdersBindingNavigator.BindingSource = Me.OrdersBindingSource
        Me.OrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrdersBindingNavigatorSaveItem})
        Me.OrdersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdersBindingNavigator.Name = "OrdersBindingNavigator"
        Me.OrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdersBindingNavigator.Size = New System.Drawing.Size(830, 25)
        Me.OrdersBindingNavigator.TabIndex = 0
        Me.OrdersBindingNavigator.Text = "BindingNavigator1"
        Me.OrdersBindingNavigator.Visible = False
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
        'OrdersBindingNavigatorSaveItem
        '
        Me.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem"
        Me.OrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OrdersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Order_CodeTextBox
        '
        Me.Order_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Order_Code", True))
        Me.Order_CodeTextBox.Location = New System.Drawing.Point(143, 104)
        Me.Order_CodeTextBox.Name = "Order_CodeTextBox"
        Me.Order_CodeTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Order_CodeTextBox.TabIndex = 2
        '
        'Cust_CodeTextBox
        '
        Me.Cust_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Cust_Code", True))
        Me.Cust_CodeTextBox.Location = New System.Drawing.Point(143, 130)
        Me.Cust_CodeTextBox.Name = "Cust_CodeTextBox"
        Me.Cust_CodeTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Cust_CodeTextBox.TabIndex = 4
        '
        'Emp_CodeTextBox
        '
        Me.Emp_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Emp_Code", True))
        Me.Emp_CodeTextBox.Location = New System.Drawing.Point(143, 156)
        Me.Emp_CodeTextBox.Name = "Emp_CodeTextBox"
        Me.Emp_CodeTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Emp_CodeTextBox.TabIndex = 6
        '
        'Order_DtDateTimePicker
        '
        Me.Order_DtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Order_Dt", True))
        Me.Order_DtDateTimePicker.Location = New System.Drawing.Point(143, 182)
        Me.Order_DtDateTimePicker.Name = "Order_DtDateTimePicker"
        Me.Order_DtDateTimePicker.Size = New System.Drawing.Size(267, 20)
        Me.Order_DtDateTimePicker.TabIndex = 8
        '
        'Ship_NameTextBox
        '
        Me.Ship_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Ship_Name", True))
        Me.Ship_NameTextBox.Location = New System.Drawing.Point(143, 208)
        Me.Ship_NameTextBox.Name = "Ship_NameTextBox"
        Me.Ship_NameTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Ship_NameTextBox.TabIndex = 10
        '
        'Ship_AddressTextBox
        '
        Me.Ship_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Ship_Address", True))
        Me.Ship_AddressTextBox.Location = New System.Drawing.Point(143, 234)
        Me.Ship_AddressTextBox.Name = "Ship_AddressTextBox"
        Me.Ship_AddressTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Ship_AddressTextBox.TabIndex = 12
        '
        'Ship_CountryTextBox
        '
        Me.Ship_CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Ship_Country", True))
        Me.Ship_CountryTextBox.Location = New System.Drawing.Point(526, 107)
        Me.Ship_CountryTextBox.Name = "Ship_CountryTextBox"
        Me.Ship_CountryTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Ship_CountryTextBox.TabIndex = 14
        '
        'Ship_PhoneTextBox
        '
        Me.Ship_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Ship_Phone", True))
        Me.Ship_PhoneTextBox.Location = New System.Drawing.Point(526, 133)
        Me.Ship_PhoneTextBox.Name = "Ship_PhoneTextBox"
        Me.Ship_PhoneTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Ship_PhoneTextBox.TabIndex = 16
        '
        'Ship_DtDateTimePicker
        '
        Me.Ship_DtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Ship_Dt", True))
        Me.Ship_DtDateTimePicker.Location = New System.Drawing.Point(526, 159)
        Me.Ship_DtDateTimePicker.Name = "Ship_DtDateTimePicker"
        Me.Ship_DtDateTimePicker.Size = New System.Drawing.Size(267, 20)
        Me.Ship_DtDateTimePicker.TabIndex = 18
        '
        'Ship_Method_IDTextBox
        '
        Me.Ship_Method_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Ship_Method_ID", True))
        Me.Ship_Method_IDTextBox.Location = New System.Drawing.Point(526, 185)
        Me.Ship_Method_IDTextBox.Name = "Ship_Method_IDTextBox"
        Me.Ship_Method_IDTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Ship_Method_IDTextBox.TabIndex = 20
        '
        'Freight_ChargeTextBox
        '
        Me.Freight_ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Freight_Charge", True))
        Me.Freight_ChargeTextBox.Location = New System.Drawing.Point(526, 211)
        Me.Freight_ChargeTextBox.Name = "Freight_ChargeTextBox"
        Me.Freight_ChargeTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Freight_ChargeTextBox.TabIndex = 22
        '
        'Sales_TaxTextBox
        '
        Me.Sales_TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Sales_Tax", True))
        Me.Sales_TaxTextBox.Location = New System.Drawing.Point(526, 237)
        Me.Sales_TaxTextBox.Name = "Sales_TaxTextBox"
        Me.Sales_TaxTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Sales_TaxTextBox.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(27, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 184)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(777, 61)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(513, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(350, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(186, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 45)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Process Form"
        '
        'Order_Process_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 360)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Order_CodeLabel)
        Me.Controls.Add(Me.Order_CodeTextBox)
        Me.Controls.Add(Cust_CodeLabel)
        Me.Controls.Add(Me.Cust_CodeTextBox)
        Me.Controls.Add(Emp_CodeLabel)
        Me.Controls.Add(Me.Emp_CodeTextBox)
        Me.Controls.Add(Order_DtLabel)
        Me.Controls.Add(Me.Order_DtDateTimePicker)
        Me.Controls.Add(Ship_NameLabel)
        Me.Controls.Add(Me.Ship_NameTextBox)
        Me.Controls.Add(Ship_AddressLabel)
        Me.Controls.Add(Me.Ship_AddressTextBox)
        Me.Controls.Add(Ship_CountryLabel)
        Me.Controls.Add(Me.Ship_CountryTextBox)
        Me.Controls.Add(Ship_PhoneLabel)
        Me.Controls.Add(Me.Ship_PhoneTextBox)
        Me.Controls.Add(Ship_DtLabel)
        Me.Controls.Add(Me.Ship_DtDateTimePicker)
        Me.Controls.Add(Ship_Method_IDLabel)
        Me.Controls.Add(Me.Ship_Method_IDTextBox)
        Me.Controls.Add(Freight_ChargeLabel)
        Me.Controls.Add(Me.Freight_ChargeTextBox)
        Me.Controls.Add(Sales_TaxLabel)
        Me.Controls.Add(Me.Sales_TaxTextBox)
        Me.Controls.Add(Me.OrdersBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Order_Process_Form"
        Me.Text = "Order_Process_Form"
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdersBindingNavigator.ResumeLayout(False)
        Me.OrdersBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pay_Junction_Database_Management_SysDataSet As Pay_Junction_Database_Management_SysDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Pay_Junction_Database_Management_SysDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersBindingNavigator As BindingNavigator
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
    Friend WithEvents OrdersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Order_CodeTextBox As TextBox
    Friend WithEvents Cust_CodeTextBox As TextBox
    Friend WithEvents Emp_CodeTextBox As TextBox
    Friend WithEvents Order_DtDateTimePicker As DateTimePicker
    Friend WithEvents Ship_NameTextBox As TextBox
    Friend WithEvents Ship_AddressTextBox As TextBox
    Friend WithEvents Ship_CountryTextBox As TextBox
    Friend WithEvents Ship_PhoneTextBox As TextBox
    Friend WithEvents Ship_DtDateTimePicker As DateTimePicker
    Friend WithEvents Ship_Method_IDTextBox As TextBox
    Friend WithEvents Freight_ChargeTextBox As TextBox
    Friend WithEvents Sales_TaxTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class

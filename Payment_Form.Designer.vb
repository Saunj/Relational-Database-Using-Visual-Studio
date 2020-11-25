<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_Form
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
        Dim Payment_CodeLabel As System.Windows.Forms.Label
        Dim Order_CodeLabel As System.Windows.Forms.Label
        Dim Payment_AmountLabel As System.Windows.Forms.Label
        Dim Payment_DtLabel As System.Windows.Forms.Label
        Dim Payment_Mode_IDLabel As System.Windows.Forms.Label
        Dim Credit_Card_IDLabel As System.Windows.Forms.Label
        Dim Card_Holder_NameLabel As System.Windows.Forms.Label
        Dim Credit_Card_Expiry_DtLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Form))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pay_Junction_Database_Management_SysDataSet = New Pay_Junction.Pay_Junction_Database_Management_SysDataSet()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.PaymentsTableAdapter()
        Me.TableAdapterManager = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager()
        Me.PaymentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PaymentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Payment_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Order_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_DtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Payment_Mode_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Credit_Card_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Card_Holder_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Credit_Card_Expiry_DtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Payment_CodeLabel = New System.Windows.Forms.Label()
        Order_CodeLabel = New System.Windows.Forms.Label()
        Payment_AmountLabel = New System.Windows.Forms.Label()
        Payment_DtLabel = New System.Windows.Forms.Label()
        Payment_Mode_IDLabel = New System.Windows.Forms.Label()
        Credit_Card_IDLabel = New System.Windows.Forms.Label()
        Card_Holder_NameLabel = New System.Windows.Forms.Label()
        Credit_Card_Expiry_DtLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Payment_CodeLabel
        '
        Payment_CodeLabel.AutoSize = True
        Payment_CodeLabel.Location = New System.Drawing.Point(31, 68)
        Payment_CodeLabel.Name = "Payment_CodeLabel"
        Payment_CodeLabel.Size = New System.Drawing.Size(79, 13)
        Payment_CodeLabel.TabIndex = 5
        Payment_CodeLabel.Text = "Payment Code:"
        '
        'Order_CodeLabel
        '
        Order_CodeLabel.AutoSize = True
        Order_CodeLabel.Location = New System.Drawing.Point(31, 94)
        Order_CodeLabel.Name = "Order_CodeLabel"
        Order_CodeLabel.Size = New System.Drawing.Size(64, 13)
        Order_CodeLabel.TabIndex = 7
        Order_CodeLabel.Text = "Order Code:"
        '
        'Payment_AmountLabel
        '
        Payment_AmountLabel.AutoSize = True
        Payment_AmountLabel.Location = New System.Drawing.Point(31, 120)
        Payment_AmountLabel.Name = "Payment_AmountLabel"
        Payment_AmountLabel.Size = New System.Drawing.Size(90, 13)
        Payment_AmountLabel.TabIndex = 9
        Payment_AmountLabel.Text = "Payment Amount:"
        '
        'Payment_DtLabel
        '
        Payment_DtLabel.AutoSize = True
        Payment_DtLabel.Location = New System.Drawing.Point(31, 147)
        Payment_DtLabel.Name = "Payment_DtLabel"
        Payment_DtLabel.Size = New System.Drawing.Size(65, 13)
        Payment_DtLabel.TabIndex = 11
        Payment_DtLabel.Text = "Payment Dt:"
        '
        'Payment_Mode_IDLabel
        '
        Payment_Mode_IDLabel.AutoSize = True
        Payment_Mode_IDLabel.Location = New System.Drawing.Point(31, 172)
        Payment_Mode_IDLabel.Name = "Payment_Mode_IDLabel"
        Payment_Mode_IDLabel.Size = New System.Drawing.Size(95, 13)
        Payment_Mode_IDLabel.TabIndex = 13
        Payment_Mode_IDLabel.Text = "Payment Mode ID:"
        '
        'Credit_Card_IDLabel
        '
        Credit_Card_IDLabel.AutoSize = True
        Credit_Card_IDLabel.Location = New System.Drawing.Point(31, 198)
        Credit_Card_IDLabel.Name = "Credit_Card_IDLabel"
        Credit_Card_IDLabel.Size = New System.Drawing.Size(76, 13)
        Credit_Card_IDLabel.TabIndex = 15
        Credit_Card_IDLabel.Text = "Credit Card ID:"
        '
        'Card_Holder_NameLabel
        '
        Card_Holder_NameLabel.AutoSize = True
        Card_Holder_NameLabel.Location = New System.Drawing.Point(31, 224)
        Card_Holder_NameLabel.Name = "Card_Holder_NameLabel"
        Card_Holder_NameLabel.Size = New System.Drawing.Size(97, 13)
        Card_Holder_NameLabel.TabIndex = 17
        Card_Holder_NameLabel.Text = "Card Holder Name:"
        '
        'Credit_Card_Expiry_DtLabel
        '
        Credit_Card_Expiry_DtLabel.AutoSize = True
        Credit_Card_Expiry_DtLabel.Location = New System.Drawing.Point(31, 251)
        Credit_Card_Expiry_DtLabel.Name = "Credit_Card_Expiry_DtLabel"
        Credit_Card_Expiry_DtLabel.Size = New System.Drawing.Size(107, 13)
        Credit_Card_Expiry_DtLabel.TabIndex = 19
        Credit_Card_Expiry_DtLabel.Text = "Credit Card Expiry Dt:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 47)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(446, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(284, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(196, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(109, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment Form"
        '
        'Pay_Junction_Database_Management_SysDataSet
        '
        Me.Pay_Junction_Database_Management_SysDataSet.DataSetName = "Pay_Junction_Database_Management_SysDataSet"
        Me.Pay_Junction_Database_Management_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.Pay_Junction_Database_Management_SysDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customers_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.Payment_ModesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Me.PaymentsTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentsBindingNavigator
        '
        Me.PaymentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentsBindingNavigator.BindingSource = Me.PaymentsBindingSource
        Me.PaymentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentsBindingNavigatorSaveItem})
        Me.PaymentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentsBindingNavigator.Name = "PaymentsBindingNavigator"
        Me.PaymentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentsBindingNavigator.Size = New System.Drawing.Size(606, 25)
        Me.PaymentsBindingNavigator.TabIndex = 5
        Me.PaymentsBindingNavigator.Text = "BindingNavigator1"
        Me.PaymentsBindingNavigator.Visible = False
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
        'PaymentsBindingNavigatorSaveItem
        '
        Me.PaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentsBindingNavigatorSaveItem.Name = "PaymentsBindingNavigatorSaveItem"
        Me.PaymentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PaymentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Payment_CodeTextBox
        '
        Me.Payment_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Payment_Code", True))
        Me.Payment_CodeTextBox.Location = New System.Drawing.Point(144, 65)
        Me.Payment_CodeTextBox.Name = "Payment_CodeTextBox"
        Me.Payment_CodeTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Payment_CodeTextBox.TabIndex = 6
        '
        'Order_CodeTextBox
        '
        Me.Order_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Order_Code", True))
        Me.Order_CodeTextBox.Location = New System.Drawing.Point(144, 91)
        Me.Order_CodeTextBox.Name = "Order_CodeTextBox"
        Me.Order_CodeTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Order_CodeTextBox.TabIndex = 8
        '
        'Payment_AmountTextBox
        '
        Me.Payment_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Payment_Amount", True))
        Me.Payment_AmountTextBox.Location = New System.Drawing.Point(144, 117)
        Me.Payment_AmountTextBox.Name = "Payment_AmountTextBox"
        Me.Payment_AmountTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Payment_AmountTextBox.TabIndex = 10
        '
        'Payment_DtDateTimePicker
        '
        Me.Payment_DtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentsBindingSource, "Payment_Dt", True))
        Me.Payment_DtDateTimePicker.Location = New System.Drawing.Point(144, 143)
        Me.Payment_DtDateTimePicker.Name = "Payment_DtDateTimePicker"
        Me.Payment_DtDateTimePicker.Size = New System.Drawing.Size(379, 20)
        Me.Payment_DtDateTimePicker.TabIndex = 12
        '
        'Payment_Mode_IDTextBox
        '
        Me.Payment_Mode_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Payment_Mode_ID", True))
        Me.Payment_Mode_IDTextBox.Location = New System.Drawing.Point(144, 169)
        Me.Payment_Mode_IDTextBox.Name = "Payment_Mode_IDTextBox"
        Me.Payment_Mode_IDTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Payment_Mode_IDTextBox.TabIndex = 14
        '
        'Credit_Card_IDTextBox
        '
        Me.Credit_Card_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Credit_Card_ID", True))
        Me.Credit_Card_IDTextBox.Location = New System.Drawing.Point(144, 195)
        Me.Credit_Card_IDTextBox.Name = "Credit_Card_IDTextBox"
        Me.Credit_Card_IDTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Credit_Card_IDTextBox.TabIndex = 16
        '
        'Card_Holder_NameTextBox
        '
        Me.Card_Holder_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Card_Holder_Name", True))
        Me.Card_Holder_NameTextBox.Location = New System.Drawing.Point(144, 221)
        Me.Card_Holder_NameTextBox.Name = "Card_Holder_NameTextBox"
        Me.Card_Holder_NameTextBox.Size = New System.Drawing.Size(379, 20)
        Me.Card_Holder_NameTextBox.TabIndex = 18
        '
        'Credit_Card_Expiry_DtDateTimePicker
        '
        Me.Credit_Card_Expiry_DtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentsBindingSource, "Credit_Card_Expiry_Dt", True))
        Me.Credit_Card_Expiry_DtDateTimePicker.Location = New System.Drawing.Point(144, 247)
        Me.Credit_Card_Expiry_DtDateTimePicker.Name = "Credit_Card_Expiry_DtDateTimePicker"
        Me.Credit_Card_Expiry_DtDateTimePicker.Size = New System.Drawing.Size(379, 20)
        Me.Credit_Card_Expiry_DtDateTimePicker.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 219)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Payment_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 345)
        Me.Controls.Add(Payment_CodeLabel)
        Me.Controls.Add(Me.Payment_CodeTextBox)
        Me.Controls.Add(Order_CodeLabel)
        Me.Controls.Add(Me.Order_CodeTextBox)
        Me.Controls.Add(Payment_AmountLabel)
        Me.Controls.Add(Me.Payment_AmountTextBox)
        Me.Controls.Add(Payment_DtLabel)
        Me.Controls.Add(Me.Payment_DtDateTimePicker)
        Me.Controls.Add(Payment_Mode_IDLabel)
        Me.Controls.Add(Me.Payment_Mode_IDTextBox)
        Me.Controls.Add(Credit_Card_IDLabel)
        Me.Controls.Add(Me.Credit_Card_IDTextBox)
        Me.Controls.Add(Card_Holder_NameLabel)
        Me.Controls.Add(Me.Card_Holder_NameTextBox)
        Me.Controls.Add(Credit_Card_Expiry_DtLabel)
        Me.Controls.Add(Me.Credit_Card_Expiry_DtDateTimePicker)
        Me.Controls.Add(Me.PaymentsBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Payment_Form"
        Me.Text = "Payment Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentsBindingNavigator.ResumeLayout(False)
        Me.PaymentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pay_Junction_Database_Management_SysDataSet As Pay_Junction_Database_Management_SysDataSet
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As Pay_Junction_Database_Management_SysDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents TableAdapterManager As Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentsBindingNavigator As BindingNavigator
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
    Friend WithEvents PaymentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Payment_CodeTextBox As TextBox
    Friend WithEvents Order_CodeTextBox As TextBox
    Friend WithEvents Payment_AmountTextBox As TextBox
    Friend WithEvents Payment_DtDateTimePicker As DateTimePicker
    Friend WithEvents Payment_Mode_IDTextBox As TextBox
    Friend WithEvents Credit_Card_IDTextBox As TextBox
    Friend WithEvents Card_Holder_NameTextBox As TextBox
    Friend WithEvents Credit_Card_Expiry_DtDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
End Class

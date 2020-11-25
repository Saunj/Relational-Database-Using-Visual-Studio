<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_Detail_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Order_Detail_IDLabel As System.Windows.Forms.Label
        Dim Order_CodeLabel As System.Windows.Forms.Label
        Dim Prod_CodeLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim Total_CostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Detail_Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Order_Detail_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pay_Junction_Database_Management_SysDataSet = New Pay_Junction.Pay_Junction_Database_Management_SysDataSet()
        Me.Order_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Prod_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Total_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DetailsTableAdapter = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.TableAdapterManager = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager()
        Me.Order_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Order_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Order_Detail_IDLabel = New System.Windows.Forms.Label()
        Order_CodeLabel = New System.Windows.Forms.Label()
        Prod_CodeLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        Total_CostLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_DetailsBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Order_Detail_IDLabel
        '
        Order_Detail_IDLabel.AutoSize = True
        Order_Detail_IDLabel.Location = New System.Drawing.Point(13, 47)
        Order_Detail_IDLabel.Name = "Order_Detail_IDLabel"
        Order_Detail_IDLabel.Size = New System.Drawing.Size(80, 13)
        Order_Detail_IDLabel.TabIndex = 0
        Order_Detail_IDLabel.Text = "Order Detail ID:"
        '
        'Order_CodeLabel
        '
        Order_CodeLabel.AutoSize = True
        Order_CodeLabel.Location = New System.Drawing.Point(13, 73)
        Order_CodeLabel.Name = "Order_CodeLabel"
        Order_CodeLabel.Size = New System.Drawing.Size(64, 13)
        Order_CodeLabel.TabIndex = 2
        Order_CodeLabel.Text = "Order Code:"
        '
        'Prod_CodeLabel
        '
        Prod_CodeLabel.AutoSize = True
        Prod_CodeLabel.Location = New System.Drawing.Point(13, 99)
        Prod_CodeLabel.Name = "Prod_CodeLabel"
        Prod_CodeLabel.Size = New System.Drawing.Size(75, 13)
        Prod_CodeLabel.TabIndex = 4
        Prod_CodeLabel.Text = "Product Code:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(13, 125)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Quantity:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(13, 151)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 8
        DiscountLabel.Text = "Discount:"
        '
        'Total_CostLabel
        '
        Total_CostLabel.AutoSize = True
        Total_CostLabel.Location = New System.Drawing.Point(13, 177)
        Total_CostLabel.Name = "Total_CostLabel"
        Total_CostLabel.Size = New System.Drawing.Size(58, 13)
        Total_CostLabel.TabIndex = 10
        Total_CostLabel.Text = "Total Cost:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Detail Form"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Order_Detail_IDLabel)
        Me.GroupBox2.Controls.Add(Me.Order_Detail_IDTextBox)
        Me.GroupBox2.Controls.Add(Order_CodeLabel)
        Me.GroupBox2.Controls.Add(Me.Order_CodeTextBox)
        Me.GroupBox2.Controls.Add(Prod_CodeLabel)
        Me.GroupBox2.Controls.Add(Me.Prod_CodeTextBox)
        Me.GroupBox2.Controls.Add(QuantityLabel)
        Me.GroupBox2.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox2.Controls.Add(DiscountLabel)
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Total_CostLabel)
        Me.GroupBox2.Controls.Add(Me.Total_CostTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 231)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Order_Detail_IDTextBox
        '
        Me.Order_Detail_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Order_Detail_ID", True))
        Me.Order_Detail_IDTextBox.Location = New System.Drawing.Point(99, 44)
        Me.Order_Detail_IDTextBox.Name = "Order_Detail_IDTextBox"
        Me.Order_Detail_IDTextBox.Size = New System.Drawing.Size(307, 20)
        Me.Order_Detail_IDTextBox.TabIndex = 1
        '
        'Order_DetailsBindingSource
        '
        Me.Order_DetailsBindingSource.DataMember = "Order_Details"
        Me.Order_DetailsBindingSource.DataSource = Me.Pay_Junction_Database_Management_SysDataSet
        '
        'Pay_Junction_Database_Management_SysDataSet
        '
        Me.Pay_Junction_Database_Management_SysDataSet.DataSetName = "Pay_Junction_Database_Management_SysDataSet"
        Me.Pay_Junction_Database_Management_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_CodeTextBox
        '
        Me.Order_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Order_Code", True))
        Me.Order_CodeTextBox.Location = New System.Drawing.Point(99, 70)
        Me.Order_CodeTextBox.Name = "Order_CodeTextBox"
        Me.Order_CodeTextBox.Size = New System.Drawing.Size(307, 20)
        Me.Order_CodeTextBox.TabIndex = 3
        '
        'Prod_CodeTextBox
        '
        Me.Prod_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Prod_Code", True))
        Me.Prod_CodeTextBox.Location = New System.Drawing.Point(99, 96)
        Me.Prod_CodeTextBox.Name = "Prod_CodeTextBox"
        Me.Prod_CodeTextBox.Size = New System.Drawing.Size(307, 20)
        Me.Prod_CodeTextBox.TabIndex = 5
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(99, 122)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(307, 20)
        Me.QuantityTextBox.TabIndex = 7
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(99, 148)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(307, 20)
        Me.DiscountTextBox.TabIndex = 9
        '
        'Total_CostTextBox
        '
        Me.Total_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_DetailsBindingSource, "Total_Cost", True))
        Me.Total_CostTextBox.Location = New System.Drawing.Point(99, 174)
        Me.Total_CostTextBox.Name = "Total_CostTextBox"
        Me.Total_CostTextBox.Size = New System.Drawing.Size(307, 20)
        Me.Total_CostTextBox.TabIndex = 11
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customers_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Me.Order_DetailsTableAdapter
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.Payment_ModesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Order_DetailsBindingNavigator
        '
        Me.Order_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Order_DetailsBindingNavigator.BindingSource = Me.Order_DetailsBindingSource
        Me.Order_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Order_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Order_DetailsBindingNavigatorSaveItem})
        Me.Order_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order_DetailsBindingNavigator.Name = "Order_DetailsBindingNavigator"
        Me.Order_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order_DetailsBindingNavigator.Size = New System.Drawing.Size(530, 25)
        Me.Order_DetailsBindingNavigator.TabIndex = 2
        Me.Order_DetailsBindingNavigator.Text = "BindingNavigator1"
        Me.Order_DetailsBindingNavigator.Visible = False
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
        'Order_DetailsBindingNavigatorSaveItem
        '
        Me.Order_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Order_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Order_DetailsBindingNavigatorSaveItem.Name = "Order_DetailsBindingNavigatorSaveItem"
        Me.Order_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Order_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(473, 67)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(391, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(238, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(159, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Order_Detail_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 379)
        Me.Controls.Add(Me.Order_DetailsBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Order_Detail_Form"
        Me.Text = "Order_Detail_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_DetailsBindingNavigator.ResumeLayout(False)
        Me.Order_DetailsBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Pay_Junction_Database_Management_SysDataSet As Pay_Junction_Database_Management_SysDataSet
    Friend WithEvents Order_DetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Pay_Junction_Database_Management_SysDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_DetailsBindingNavigator As BindingNavigator
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
    Friend WithEvents Order_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Order_Detail_IDTextBox As TextBox
    Friend WithEvents Order_CodeTextBox As TextBox
    Friend WithEvents Prod_CodeTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents Total_CostTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shipment_Method_Form
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
        Dim Ship_Method_IDLabel As System.Windows.Forms.Label
        Dim Ship_MethodLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shipment_Method_Form))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pay_Junction_Database_Management_SysDataSet = New Pay_Junction.Pay_Junction_Database_Management_SysDataSet()
        Me.Shipment_MethodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shipment_MethodsTableAdapter = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.Shipment_MethodsTableAdapter()
        Me.TableAdapterManager = New Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager()
        Me.Shipment_MethodsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Shipment_MethodsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Ship_Method_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_MethodTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Ship_Method_IDLabel = New System.Windows.Forms.Label()
        Ship_MethodLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipment_MethodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipment_MethodsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Shipment_MethodsBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ship_Method_IDLabel
        '
        Ship_Method_IDLabel.AutoSize = True
        Ship_Method_IDLabel.Location = New System.Drawing.Point(27, 86)
        Ship_Method_IDLabel.Name = "Ship_Method_IDLabel"
        Ship_Method_IDLabel.Size = New System.Drawing.Size(84, 13)
        Ship_Method_IDLabel.TabIndex = 4
        Ship_Method_IDLabel.Text = "Ship Method ID:"
        '
        'Ship_MethodLabel
        '
        Ship_MethodLabel.AutoSize = True
        Ship_MethodLabel.Location = New System.Drawing.Point(27, 112)
        Ship_MethodLabel.Name = "Ship_MethodLabel"
        Ship_MethodLabel.Size = New System.Drawing.Size(70, 13)
        Ship_MethodLabel.TabIndex = 6
        Ship_MethodLabel.Text = "Ship Method:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(532, 44)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shipment Method Form"
        '
        'Pay_Junction_Database_Management_SysDataSet
        '
        Me.Pay_Junction_Database_Management_SysDataSet.DataSetName = "Pay_Junction_Database_Management_SysDataSet"
        Me.Pay_Junction_Database_Management_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Shipment_MethodsBindingSource
        '
        Me.Shipment_MethodsBindingSource.DataMember = "Shipment_Methods"
        Me.Shipment_MethodsBindingSource.DataSource = Me.Pay_Junction_Database_Management_SysDataSet
        '
        'Shipment_MethodsTableAdapter
        '
        Me.Shipment_MethodsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customers_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.Payment_ModesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_MethodsTableAdapter = Me.Shipment_MethodsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pay_Junction.Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Shipment_MethodsBindingNavigator
        '
        Me.Shipment_MethodsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Shipment_MethodsBindingNavigator.BindingSource = Me.Shipment_MethodsBindingSource
        Me.Shipment_MethodsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Shipment_MethodsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Shipment_MethodsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Shipment_MethodsBindingNavigatorSaveItem})
        Me.Shipment_MethodsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Shipment_MethodsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Shipment_MethodsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Shipment_MethodsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Shipment_MethodsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Shipment_MethodsBindingNavigator.Name = "Shipment_MethodsBindingNavigator"
        Me.Shipment_MethodsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Shipment_MethodsBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.Shipment_MethodsBindingNavigator.TabIndex = 4
        Me.Shipment_MethodsBindingNavigator.Text = "BindingNavigator1"
        Me.Shipment_MethodsBindingNavigator.Visible = False
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
        'Shipment_MethodsBindingNavigatorSaveItem
        '
        Me.Shipment_MethodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Shipment_MethodsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Shipment_MethodsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Shipment_MethodsBindingNavigatorSaveItem.Name = "Shipment_MethodsBindingNavigatorSaveItem"
        Me.Shipment_MethodsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Shipment_MethodsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Ship_Method_IDTextBox
        '
        Me.Ship_Method_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipment_MethodsBindingSource, "Ship_Method_ID", True))
        Me.Ship_Method_IDTextBox.Location = New System.Drawing.Point(117, 83)
        Me.Ship_Method_IDTextBox.Name = "Ship_Method_IDTextBox"
        Me.Ship_Method_IDTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Ship_Method_IDTextBox.TabIndex = 5
        '
        'Ship_MethodTextBox
        '
        Me.Ship_MethodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipment_MethodsBindingSource, "Ship_Method", True))
        Me.Ship_MethodTextBox.Location = New System.Drawing.Point(117, 109)
        Me.Ship_MethodTextBox.Name = "Ship_MethodTextBox"
        Me.Ship_MethodTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Ship_MethodTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 75)
        Me.GroupBox1.TabIndex = 8
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 63)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(444, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(282, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(191, 19)
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
        Me.Button2.Location = New System.Drawing.Point(21, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Shipment_Method_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 224)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Ship_Method_IDLabel)
        Me.Controls.Add(Me.Ship_Method_IDTextBox)
        Me.Controls.Add(Ship_MethodLabel)
        Me.Controls.Add(Me.Ship_MethodTextBox)
        Me.Controls.Add(Me.Shipment_MethodsBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Shipment_Method_Form"
        Me.Text = "Shipment Method Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Pay_Junction_Database_Management_SysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipment_MethodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipment_MethodsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Shipment_MethodsBindingNavigator.ResumeLayout(False)
        Me.Shipment_MethodsBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pay_Junction_Database_Management_SysDataSet As Pay_Junction_Database_Management_SysDataSet
    Friend WithEvents Shipment_MethodsBindingSource As BindingSource
    Friend WithEvents Shipment_MethodsTableAdapter As Pay_Junction_Database_Management_SysDataSetTableAdapters.Shipment_MethodsTableAdapter
    Friend WithEvents TableAdapterManager As Pay_Junction_Database_Management_SysDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Shipment_MethodsBindingNavigator As BindingNavigator
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
    Friend WithEvents Shipment_MethodsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Ship_Method_IDTextBox As TextBox
    Friend WithEvents Ship_MethodTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

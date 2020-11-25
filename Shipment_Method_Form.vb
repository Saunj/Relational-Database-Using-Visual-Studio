Public Class Shipment_Method_Form
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Shipment_MethodsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Shipment_MethodsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Shipment_MethodsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Shipment_Methods' table. You can move, or remove it, as needed.
        Me.Shipment_MethodsTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Shipment_Methods)
        Ship_Method_IDTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Shipment_MethodsBindingSource.AddNew()
        Ship_Method_IDTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Shipment_MethodsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Shipment_MethodsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Shipment_MethodsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Shipment_MethodsBindingSource.EndEdit()
        Me.Shipment_MethodsTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Shipment_Methods)
    End Sub
End Class
Public Class Order_Detail_Form
    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Order_DetailsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Order_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Order_Details)
        Order_Detail_IDTextBox.Enabled = False
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Order_DetailsBindingSource.AddNew()
        Order_Detail_IDTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Order_DetailsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Order_DetailsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Order_DetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.Order_DetailsTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Order_Details)
    End Sub
End Class
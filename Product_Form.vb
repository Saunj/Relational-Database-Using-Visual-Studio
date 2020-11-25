Public Class Product_Form
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Products)
        Prod_CodeTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductsBindingSource.AddNew()
        Prod_CodeTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ProductsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ProductsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ProductsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.ProductsTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Products)
    End Sub
End Class
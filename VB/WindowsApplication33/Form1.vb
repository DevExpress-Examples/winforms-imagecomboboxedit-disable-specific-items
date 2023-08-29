Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace WindowsApplication33
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private disabledItems As New List(Of String)(New String() {"Left", "Right"})
		Dim selectionCancelled As Boolean = False
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			imageComboBoxEdit1.Properties.SmallImages = imageList1
			imageComboBoxEdit1.Properties.LargeImages = imageList2

			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Left", 0))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Right", 1))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Save", 2))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Cancel", 3))

			AddHandler imageComboBoxEdit1.Properties.DrawItem, AddressOf Properties_DrawItem
			AddHandler imageComboBoxEdit1.Properties.QueryCloseUp, AddressOf Properties_QueryCloseUp
			AddHandler imageComboBoxEdit1.Properties.CloseUp, AddressOf Properties_CloseUp

			Dim i As New ImageComboBoxItem()
		End Sub
		Private Sub Properties_CloseUp(ByVal sender As Object, ByVal e As CloseUpEventArgs)
			e.AcceptValue = Not selectionCancelled
		End Sub

		Private Sub Properties_QueryCloseUp(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
			If edit.GetPopupEditForm() IsNot Nothing Then
				Dim selectedItemIndex As Integer = edit.GetPopupEditForm().SelectedItemIndex
				Dim selectedItem As String = edit.Properties.Items(selectedItemIndex).ToString()
				If disabledItems.Contains(selectedItem) Then
					e.Cancel = True
				End If
			End If

			selectionCancelled = e.Cancel
		End Sub

		Private Sub Properties_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs)
			If disabledItems.Contains(e.Item.ToString()) Then
				e.Appearance.ForeColor = Color.Gray
			End If
		End Sub
	End Class
End Namespace
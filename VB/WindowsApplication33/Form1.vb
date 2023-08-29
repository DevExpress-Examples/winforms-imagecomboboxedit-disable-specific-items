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


		Private disabledItems As New List(Of String)(New String() { "Left", "Right" })
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			imageComboBoxEdit1.Properties.SmallImages = imageList1
			imageComboBoxEdit1.Properties.LargeImages = imageList2

			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Left", 0))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Right", 1))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Save", 2))
			imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Cancel", 3))

			AddHandler imageComboBoxEdit1.Properties.DrawItem, AddressOf Properties_DrawItem
			AddHandler imageComboBoxEdit1.Properties.EditValueChanging, AddressOf Properties_EditValueChanging

			Dim i As New ImageComboBoxItem()
		End Sub

		Private Sub Properties_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
			If e.NewValue IsNot Nothing AndAlso disabledItems.Contains(e.NewValue.ToString()) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub Properties_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs)
			If disabledItems.Contains(e.Item.ToString()) Then
				e.Appearance.ForeColor = Color.Gray
			End If
		End Sub
	End Class
End Namespace
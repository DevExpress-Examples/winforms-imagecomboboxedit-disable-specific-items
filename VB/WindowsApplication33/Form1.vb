Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace WindowsApplication33

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private disabledItems As List(Of String) = New List(Of String)(New String() {"Left", "Right"})

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            imageComboBoxEdit1.Properties.SmallImages = imageList1
            imageComboBoxEdit1.Properties.LargeImages = imageList2
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Left", 0))
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Right", 1))
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Save", 2))
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Cancel", 3))
            AddHandler imageComboBoxEdit1.Properties.DrawItem, New ListBoxDrawItemEventHandler(AddressOf Properties_DrawItem)
            AddHandler imageComboBoxEdit1.Properties.EditValueChanging, New ChangingEventHandler(AddressOf Properties_EditValueChanging)
            Dim i As ImageComboBoxItem = New ImageComboBoxItem()
        End Sub

        Private Sub Properties_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
            If e.NewValue IsNot Nothing AndAlso disabledItems.Contains(e.NewValue.ToString()) Then e.Cancel = True
        End Sub

        Private Sub Properties_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            If disabledItems.Contains(e.Item.ToString()) Then
                e.Appearance.ForeColor = Color.Gray
            End If
        End Sub
    End Class
End Namespace

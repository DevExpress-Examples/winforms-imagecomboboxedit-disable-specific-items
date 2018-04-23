Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication33
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageComboBoxEdit1
			' 
			Me.imageComboBoxEdit1.Location = New System.Drawing.Point(12, 12)
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit1.Size = New System.Drawing.Size(186, 20)
			Me.imageComboBoxEdit1.TabIndex = 0
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "arrowleft_green16.bmp")
			Me.imageList1.Images.SetKeyName(1, "arrowright_green16.bmp")
			Me.imageList1.Images.SetKeyName(2, "save16.bmp")
			Me.imageList1.Images.SetKeyName(3, "stop16.bmp")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList2.Images.SetKeyName(0, "arrowleft_green_32.bmp")
			Me.imageList2.Images.SetKeyName(1, "arrowright_green_32.bmp")
			Me.imageList2.Images.SetKeyName(2, "save_32.bmp")
			Me.imageList2.Images.SetKeyName(3, "stop_32.bmp")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(485, 317)
			Me.Controls.Add(Me.imageComboBoxEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
	End Class
End Namespace


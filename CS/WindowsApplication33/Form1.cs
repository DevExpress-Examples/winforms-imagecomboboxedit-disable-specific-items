using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace WindowsApplication33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<String> disabledItems = new List<string>(new string[] { "Left", "Right" });
        bool selectionCancelled = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            imageComboBoxEdit1.Properties.SmallImages = imageList1;
            imageComboBoxEdit1.Properties.LargeImages = imageList2;

            imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Left", 0) );
            imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Right", 1));
            imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Save", 2));
            imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Cancel", 3));

            imageComboBoxEdit1.Properties.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Properties_DrawItem);
            imageComboBoxEdit1.Properties.CloseUp += new CloseUpEventHandler(Properties_CloseUp);
            imageComboBoxEdit1.Properties.QueryCloseUp += new CancelEventHandler(Properties_QueryCloseUp);

            ImageComboBoxItem i = new ImageComboBoxItem();
        }

        private void Properties_CloseUp(object sender, CloseUpEventArgs e) {
            e.AcceptValue = !selectionCancelled;
        }

        private void Properties_QueryCloseUp(object sender, CancelEventArgs e) {
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit;
            if(edit.GetPopupEditForm() != null) {
                int selectedItemIndex = edit.GetPopupEditForm().SelectedItemIndex;
                string selectedItem = edit.Properties.Items[selectedItemIndex].ToString();
                if (disabledItems.Contains(selectedItem)) {
                    e.Cancel = true;
                }
            }

            selectionCancelled = e.Cancel;
        }

        void Properties_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            if (disabledItems.Contains(e.Item.ToString()))
            {
                e.Appearance.ForeColor = Color.Gray;
            }
        }
    }
}
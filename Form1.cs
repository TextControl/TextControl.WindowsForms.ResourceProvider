using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;
using static TXTextControl.Windows.Forms.ResourceProvider;

namespace tx_resource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // array of used types to retrieve resources
        private Type[] RibbonTabs = new Type[] {
            typeof(RibbonInsertTab),
            typeof(RibbonChartLayoutTab),
            typeof(RibbonFormattingTab),
            typeof(RibbonFormulaTab),
            typeof(RibbonFrameLayoutTab),
            typeof(RibbonInsertTab),
            typeof(RibbonPageLayoutTab),
            typeof(RibbonPermissionsTab),
            typeof(RibbonProofingTab),
            typeof(RibbonReportingTab),
            typeof(RibbonTableLayoutTab),
            typeof(RibbonViewTab),
            typeof(ResourceProvider.BarcodeItem),
            typeof(ResourceProvider.ChartItem),
            typeof(ResourceProvider.FileMenuItem),
            typeof(ResourceProvider.GeneralItem),
            typeof(ResourceProvider.ShapeItem)
        };

        // default settings
        private int m_Dpi = 96;
        private string m_SelectedResource;
        private ImageSourceSettings m_ImageSourceSettings = new ImageSourceSettings();

        // this method retrieves the resources from the selected type
        // and calls the CreateImage method to display the icon
        private void UpdatePreview()
        {
            flowLayoutPanel1.Controls.Clear();

            // loop through all public static members to retrieve all item names
            foreach (MemberInfo fi in ((Type)cbRibbonTabs.SelectedItem).GetMembers(BindingFlags.Public | BindingFlags.Static))
            {
                Type myType = ((Type)cbRibbonTabs.SelectedItem).GetNestedType(fi.Name);

                if (myType != null)
                {
                    // loop through all items and create preview images
                    foreach (string ribbonItem in Enum.GetNames(myType))
                    {
                        CreateImage(ribbonItem);
                    }
                }
                else
                    CreateImage(fi.Name);
            }
        }

        // this method retrieves the actual resource and creates
        // a PictureBox that is used to preview the icon
        private void CreateImage(string ribbonItem)
        {
            Bitmap bmp;

            // retrieve the icons from the provider

            // if 16px is selected
            if (rb16.Checked == true)
                bmp = GetSmallIcon(ribbonItem, m_Dpi, m_ImageSourceSettings);
            else // 32px
                bmp = GetLargeIcon(ribbonItem, m_Dpi, m_ImageSourceSettings);

            if (bmp != null)
            {
                // create a new PictureBox
                ResourcePicture box = new ResourcePicture();
                box.Image = bmp; // set the image
                box.Tag = ribbonItem; // store the item
                box.MouseEnter += Box_MouseEnter;
                flowLayoutPanel1.Controls.Add(box); // add to panel
            }
        }

        // this method updates the display of the selected resource
        // including description and tooltip text resources
        private void UpdateResource()
        {
            if (rb16.Checked == true) // 16px
                pictureBox1.Image = GetSmallIcon(m_SelectedResource, 1440, m_ImageSourceSettings);
            else //32px
                pictureBox1.Image = GetLargeIcon(m_SelectedResource, 720, m_ImageSourceSettings);

            // display the name
            lblSelectedResource.Text = m_SelectedResource;

            // display all resources
            tbKeyTip.Text = TXTextControl.Windows.Forms.ResourceProvider.GetKeyTip(m_SelectedResource);
            tbText.Text = TXTextControl.Windows.Forms.ResourceProvider.GetText(m_SelectedResource);
            tbToolTipDescription.Text = TXTextControl.Windows.Forms.ResourceProvider.GetToolTipDescription(m_SelectedResource);
            tbToolTipTitle.Text = TXTextControl.Windows.Forms.ResourceProvider.GetToolTipTitle(m_SelectedResource);
        }

        #region "Event Handling"

        private void Form1_Load(object sender, EventArgs e)
        {
            // add the type array to the combo box and show the name
            cbRibbonTabs.Items.AddRange(RibbonTabs);
            cbRibbonTabs.DisplayMember = "Name";

            cbRibbonTabs.SelectedIndex = 0;
            cbDpi.SelectedIndex = 0;
            cbCulture.SelectedIndex = 0;
        }

        private void cbRibbonTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void Box_MouseEnter(object sender, EventArgs e)
        {
            m_SelectedResource = (string)((ResourcePicture)sender).Tag;
            UpdateResource();
        }

        private void cbDpi_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse(cbDpi.SelectedItem.ToString(), out m_Dpi);
            UpdatePreview();
        }

        private void rb32_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ImageSourceSettings.Culture = new System.Globalization.CultureInfo(cbCulture.Text);
            UpdatePreview();
        }

        private void btnChangeFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                m_ImageSourceSettings.FillColor = colorDialog1.Color;
                panelFillColor.BackColor = (Color)m_ImageSourceSettings.FillColor;
            }

            UpdatePreview();
        }

        private void btnChangeStrokeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                m_ImageSourceSettings.StrokeColor = colorDialog1.Color;
                panelStrokeColor.BackColor = (Color)m_ImageSourceSettings.StrokeColor;
            }

            UpdatePreview();
        }

        #endregion

    }
}


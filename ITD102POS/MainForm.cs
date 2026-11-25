using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITD102POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubProduct.Visible = false;
            panelSubStock.Visible = false;
            panelSubRecord.Visible = false;
            panelSubSetting.Visible = false;
        }

        private void hideSubmenu()
        {
            //SubProduct
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            
            //SubStock
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;

            //SubRecord
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;

            //SubSetting
            if (panelSubSetting.Visible == true)
                panelSubSetting.Visible = false;
                
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class formOwner : Form
    {
        public formOwner()
        {
            InitializeComponent();
        }

        public void loadform(object Form) // Multiple forms in one panel
        {
            if (panelMain.Controls.Count > 0) { panelMain.Controls.Clear(); }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            panelMain.Tag = f;
            f.Show();
        }

        #region EVENTS

        private void formOwner_Load(object sender, EventArgs e)
        {
            btnLogoHome_Click(null, e);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerProducts());
        }

        private void btnShippingPrices_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerShippingPrices());
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerBrands());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerCustomers());
        }

        private void btnPaymentTypes_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerPaymentTypes());
        }

        private void btnLogoHome_Click(object sender, EventArgs e)
        {
            loadform(new formOwnerHome());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}

//silvermannroberto@techstore.com
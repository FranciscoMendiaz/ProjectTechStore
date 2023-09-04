using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntitiesLayer;


namespace UserInterfaceLayer
{
    public partial class formAddPT : Form
    {
        private BusinessLogic logic;
        private PaymentType paymentType;

        public formAddPT()
        {
            InitializeComponent();
            logic = new BusinessLogic();

        }

        private void btnAcceptNewPT_Click(object sender, EventArgs e)
        {
            SavePaymentType();
            this.Close();
        }

        private void SavePaymentType()
        {
            PaymentType paymentType = new PaymentType();
            paymentType.Description = txtNewPT.Text;
            logic.SavePaymentType(paymentType);
        }

        public void LoadPaymentType(PaymentType pt)
        {
            paymentType = pt;
            if (pt != null) 
            {
                clearTxts();
                txtNewPT.Text = pt.Description;
            }
        }

        private void clearTxts()
        {
            txtNewPT.Text = string.Empty;
        }













        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

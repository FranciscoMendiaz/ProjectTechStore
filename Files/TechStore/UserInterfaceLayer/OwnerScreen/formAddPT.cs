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
        private PaymentType _paymentType;

        public formAddPT()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private void clearTxts()
        {
            txtNewPT.Text = string.Empty;
        }

        public void LoadPaymentType(PaymentType paymentType)
        {
            _paymentType = paymentType;
            if (paymentType != null)
            {
                clearTxts();
                txtNewPT.Text = paymentType.Description;
            }
        }

        #region EVENTS
        private void btnSavePT_Click(object sender, EventArgs e)
        {
            savePaymentType();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region HANDLERS
        private void savePaymentType()
        {
            PaymentType paymentType = new PaymentType();
            if (txtNewPT.Text != string.Empty)
            {
                paymentType.Description = txtNewPT.Text;
                paymentType.Id = _paymentType != null ? _paymentType.Id : 0;
                logic.savePaymentType(paymentType);
            }

            else
            {
                MessageBox.Show("Debe ingresar todos los campos solicitados", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion






    }
}

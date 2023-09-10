using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntitiesLayer;

namespace UserInterfaceLayer
{
    public partial class formOwnerPaymentTypes : Form
    {
        private BusinessLogic logic;

        public formOwnerPaymentTypes()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private PaymentType getSelectedPaymentType()
        {
            int index = gridPaymentTypes.CurrentCell.RowIndex; //returns the row of the datagridview that is being clicked
            PaymentType paymentType = new PaymentType();
            paymentType.Id = int.Parse(gridPaymentTypes.Rows[index].Cells[0].Value.ToString());
            paymentType.Description = gridPaymentTypes.Rows[index].Cells[1].Value.ToString();
            return paymentType;
        }

        #region EVENTS
        private void formOwnerPaymentTypes_Load(object sender, EventArgs e)
        {
            getAllPaymentTypes();
        }
        private void btnAddPT_Click(object sender, EventArgs e)
        {
            addPaymentType();
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            updatePaymentType();
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            deletePaymentType();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllPaymentTypes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterPaymentTypes();
        }
        #endregion

        #region HANDLERS
        private void addPaymentType()
        {
            formAddPT addPT = new formAddPT();
            addPT.ShowDialog();
        }

        private void getAllPaymentTypes()
        {
            List<PaymentType> paymentTypes = logic.getAllPaymentTypes();
            gridPaymentTypes.DataSource = paymentTypes;
        }

        private void updatePaymentType()
        {
            if (gridPaymentTypes.SelectedRows.Count == 1)
            {
                PaymentType paymentType = getSelectedPaymentType();
                formAddPT formUpdatePT = new formAddPT();
                formUpdatePT.LoadPaymentType(paymentType);
                formUpdatePT.ShowDialog();
            }
        }

        private void deletePaymentType()
        {
            if (gridPaymentTypes.SelectedRows.Count == 1)
            {
                logic.deletePaymentType(getSelectedPaymentType());
            }
        }

        public void filterPaymentTypes()
        {
            List<PaymentType> paymentTypes = logic.filterPaymentTypes(txtSearch.Text);
            gridPaymentTypes.DataSource = paymentTypes;
        }
        #endregion

    }
}





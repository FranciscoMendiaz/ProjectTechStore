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
    public partial class formOwnerPaymentTypes : Form
    {
        private BusinessLogic logic;


        public formOwnerPaymentTypes()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private void btnAddPT_Click(object sender, EventArgs e)
        {
            OpenAddPaymentTypeDialog();
        }

        private void OpenAddPaymentTypeDialog()
        {
            formAddPT addPaymentType = new formAddPT();
            addPaymentType.ShowDialog();
        }

        private void formOwnerPaymentTypes_Load(object sender, EventArgs e)
        {
            PopulatePaymentTypes();
        }

        public void PopulatePaymentTypes()
        {
            List<PaymentType> paymentTypes = logic.getAllPaymentTypes();
            gridPaymentTypes.DataSource = paymentTypes;
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            formAddPT formUpdatePT = new formAddPT();
            formUpdatePT.LoadPaymentType(new PaymentType 
            { 
                Id = int.Parse(gridPaymentTypes.Rows[e.RowIndex].Cells[0].Value.ToString()),
                Description = gridPaymentTypes.Rows[e.RowIndex].Cells[1].Value.ToString(),
            });

        }
    }
}

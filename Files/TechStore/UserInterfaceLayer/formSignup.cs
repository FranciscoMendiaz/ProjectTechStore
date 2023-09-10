using BusinessLogicLayer;
using EntitiesLayer;
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
    public partial class formSignup : Form
    {
        private BusinessLogic logic;
        private User user;

        public formSignup()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private void clearTxts()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        #region EVENTS
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            onBtnCreateAccountClicked();
        }
        #endregion

        #region HANDLERS
        private void onBtnCreateAccountClicked()
        {
            if (txtEmail.Text != string.Empty && txtAddress.Text != string.Empty && txtFirstName.Text != string.Empty
                && txtLastName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                validateUserEmail();
            }

            else
            {
                MessageBox.Show("Debe ingresar todos los campos solicitados", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void validateUserEmail()
        {
            user = logic.getOneUser(txtEmail.Text); // validates that there isn´t already an account with the entered email

            if (user == null)
            {
                userSignUp();
            }

            else
            {
                MessageBox.Show("El email ingresado ya tiene asignada una cuenta de Usuario", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userSignUp() // calls the business logic method in order to create the new user
        {
            user = logic.userSignUp(txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text, txtAddress.Text);
            MessageBox.Show(("Usuario: " + user.FirstName + " " + user.FirstName + ", " + user.Role.Description + " creado correctamente"), "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxts();
        }
        #endregion


















    }
}

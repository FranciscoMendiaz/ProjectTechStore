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
        public formSignup()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private User user;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text!=string.Empty && txtAdress.Text != string.Empty && txtFirstName.Text != string.Empty 
                && txtLastName.Text!= string.Empty && txtPassword.Text!=string.Empty) 
            {
                getOne();
            }
        
            else
            {
                MessageBox.Show("Debe ingresar todos los campos solicitados", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }



        private void getOne()
        {
            user = logic.getOne(txtEmail.Text);
            if (user == null)
            {
                createUser();
            }

            else
            {
                MessageBox.Show("El email ingresado ya tiene asignada una cuenta de Usuario", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createUser()
        {
            user = new User();
            user.Email = txtEmail.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Password = txtPassword.Text;
            user.Address = txtAdress.Text;
            logic.createUser(user);
            MessageBox.Show("Cuenta de Usuario creada correctamente", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.clearTxts();
        }

        private void clearTxts()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtAdress.Text = string.Empty;
            txtFirstName.Text = string.Empty;   
            txtLastName.Text = string.Empty;
        }

      
















    }
}

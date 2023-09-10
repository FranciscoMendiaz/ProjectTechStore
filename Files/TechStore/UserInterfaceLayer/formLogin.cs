using BusinessLogicLayer;
using EntitiesLayer;

namespace UserInterfaceLayer
{
    public partial class formLogin : Form
    {
        private BusinessLogic logic;
        private User user;

        public formLogin()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private void clearTxts()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        #region EVENTS  
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userLogin();
        }
        private void lnkSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            onLnkSingUpClicked();
        }
        #endregion

        #region HANDLERS
        private void userLogin()
        {
            user = logic.userLogin(txtEmail.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(("Bienvenido al sistema: " + user.FirstName + " " + user.LastName + ", " + user.Role.Description), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (user.Role.Description == "Owner")
                {
                    Hide(); //Hides the dialog from formLogin
                    formOwner ownerPanel = new formOwner(); // New instance for the Owner panel 
                    ownerPanel.Closed += (s, args) => this.Visible = true; // formLogin dialog reappears when the Owner panel is closed (lambda)
                    ownerPanel.ShowDialog(); // Shows the dialog for the Owner panel 
                }
                clearTxts();
            }
        }

        private void onLnkSingUpClicked()
        {
            formSignup signup = new formSignup();
            signup.ShowDialog();
        }
        #endregion


    }
}
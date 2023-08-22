using BusinessLogicLayer;
using EntitiesLayer;

namespace UserInterfaceLayer
{
    public partial class formLogin : Form
    {
        private BusinessLogic logic;

        public formLogin()
        {
            InitializeComponent();
            logic = new BusinessLogic();
        }

        private User user;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = userLog();
            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTxts();
            }

            else
            {
                MessageBox.Show(("Bienvenido al sistema: " + user.FirstName + "" + user.LastName + user.Role.Description), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTxts();
            }

        }

        private User userLog()
        {
            user = logic.validateUser(txtEmail.Text, txtPassword.Text);
            return user;
        }

        private void clearTxts()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void lnkSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignup signup = new formSignup();
            signup.ShowDialog();
        }
    }
}
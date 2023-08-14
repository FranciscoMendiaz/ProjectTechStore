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

            }

            else
            {
                MessageBox.Show(("Bienvenido al sistema: " + user.FirstName + "" + user.LastName + user.Role.Description), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private User userLog()
        {
            user = logic.validateUser(txtEmail.Text, txtPassword.Text);
            return user;

        }










    }
}
using LibraryManagement.Entities;
using LibraryManagement.BusinessLogic;

namespace LibraryManagement.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminMode_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void userMode_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                name = name.Text,
                surname = surname.Text
            };

            // check if user exists
            var userService = new UserService();
            var existingUser = userService.GetUser(user.name, user.surname);
            if (existingUser != null)
            {
                user = existingUser;
            }
            else
            {
                // add new user
                userService.AddUser(user);
            }
            UserForm userForm = new UserForm(user);
            userForm.Show();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

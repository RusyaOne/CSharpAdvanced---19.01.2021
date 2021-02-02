using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformEventsExample
{
    public partial class CreateUserForm : Form
    {
        private readonly IUserManager _userManager;

        public CreateUserForm(IUserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CommonUser commonUser = new CommonUser();
            commonUser.FirstName = textBoxFirstName.Text;
            commonUser.LastName = textBoxLastName.Text;
            commonUser.Address = textBoxAddress.Text;
            _userManager.CreateUser(commonUser);
        }
    }
}

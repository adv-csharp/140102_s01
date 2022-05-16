using Session01.Model;
using Session01.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session01.UI
{
    public partial class FormUsers : Form
    {
        UserService userService = new UserService();
        int currentIndex = 0;
        bool isEditing = false;
        public FormUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //1. create User from ui
            //2. new userService
            //3. userService.add
            //4. form reset

            var user = new User
            {
                Id = Convert.ToInt32(txtId.Text),
                FirstName = txtFisrtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Tel = txtTel.Text
            };
            userService.AddUser(user);

            resetForm();
        }

        private void resetForm()
        {
            txtId.Clear();
            txtFisrtName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtTel.Clear();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            showCurrentIndex();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if(currentIndex > userService.Length - 1)
            {
                currentIndex = userService.Length - 1;
            }
            showCurrentIndex();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = userService.Length - 1;
            showCurrentIndex();
        }

        private void brnPrev_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = 0;
            }
            showCurrentIndex();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            showCurrentIndex();
        }


        private void showCurrentIndex()
        {
            var user = userService.GetByIndex(currentIndex);

            txtId.Text = user.Id.ToString();
            txtFisrtName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtTel.Text = user.Tel;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("مطمئن هستید؟", "حدف!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //?
                MessageBox.Show("OK!");
            }
        }
    }
}

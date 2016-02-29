using System;
using System.Windows.Forms;

namespace loginaccess {
    public partial class MainForm : Form {
        public string CurrentUser;
        public MainForm() {

            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            Hide();
            loginForm frm = new loginForm();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e) {

            ChangePassword frm = new ChangePassword();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void NewUserToolStripMenuItem_Click(object sender, EventArgs e) {
            NewUser frm = new NewUser();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void AllUsersToolStripMenuItem_Click(object sender, EventArgs e) {
            AllUsers frm = new AllUsers();
            frm.Owner = this;
            frm.ShowDialog();
        }

    }
}

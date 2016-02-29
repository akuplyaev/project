using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace loginaccess {
    public partial class loginForm : Form {

        public loginForm() {

            InitializeComponent();
        }

        public string Login {
            get { return textLogin.Text; }
        }
        public string Password {
            get { return textPassword.Text; }
        }

        private void btnOk_Click(object sender, EventArgs e) {                          
           if (autorizated()) {
                if (block()) {
                    MessageBox.Show("Ваша запись заблокирована", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MainForm form = (MainForm)this.Owner;
                    form.CurrentUser = Login;
                    if (admin()) {

                        form.Text = "Вы зашли как:" + Login;
                        form.btnEnter.Visible = false;
                        form.ChangePasswordToolStripMenuItem.Enabled = true;
                        form.NewUserToolStripMenuItem.Enabled = true;
                        form.AllUsersToolStripMenuItem.Enabled = true;
                        form.Show();

                    }
                    else {

                        form.Text = "Вы зашли как:" + Login;
                        form.btnEnter.Visible = false;
                        form.ChangePasswordToolStripMenuItem.Enabled = true;
                        form.Show();
                    }
                    this.Hide();
                }
            }
            else {
                MessageBox.Show("Неверный пароль или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Проверка на админа
        private bool admin() {          
            return (Login == "admin" )? true : false;
        }
        //Авторизация
        private bool autorizated() {
            bool Result = false;
            XDocument xdoc = XDocument.Load("users.xml");
            foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                XElement loginElement = userElement.Element("login");
                XElement passwordnElement = userElement.Element("password");
                if (loginElement.Value == Login && passwordnElement.Value == Password) {
                    Result = true;
                }

            }
            return Result;
        }
        //Проверка на блокирование учетки
        private bool block() {
            bool block = false;
            XDocument xdoc = XDocument.Load("users.xml");
            foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                XElement blockElement = userElement.Element("block");
                XElement loginElement = userElement.Element("login");
                if (Convert.ToInt32(blockElement.Value) == 1 && loginElement.Value == Login) {
                    block = true;
                    break;
                }

            }
            return block;
        }
    }
}




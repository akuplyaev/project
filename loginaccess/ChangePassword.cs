using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace loginaccess {
    public partial class ChangePassword : Form {
        public ChangePassword() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (textBox1.Text != textBox2.Text) {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                ChangePwd();
            }
            Close();

        }
      //Функция смены пароля
        private void ChangePwd() {
            int limitpoint = 5; //переделать
            if (limit()) {
                if (textBox1.TextLength > limitpoint) {
                    MessageBox.Show("Пароль должен содержать не более " + limitpoint + " символов", "Ограничение по колличеству символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else {
                MainForm form = (MainForm)this.Owner;
                string login = form.CurrentUser;
                XDocument xdoc = XDocument.Load("users.xml");
                foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                    XElement loginElement = userElement.Element("login");

                    if (loginElement.Value == login) {
                        userElement.Element("password").SetValue(textBox1.Text);
                        break;
                    }

                }
                xdoc.Save("users.xml");
                MessageBox.Show("Пароль сменен", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    //Проверка на ограничения
        private bool limit() {
            MainForm form = (MainForm)this.Owner;
            string login = form.CurrentUser;
            bool lm = false;
            XDocument xdoc = XDocument.Load("users.xml");
            foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                XElement limitElement = userElement.Element("limitation");
                XElement loginElement = userElement.Element("login");
                if (loginElement.Value == login) {
                    if (Convert.ToInt32(limitElement.Value) == 1) {
                        lm = true;
                        break;
                    }

                }
            }
            return lm;
        }
    }
}

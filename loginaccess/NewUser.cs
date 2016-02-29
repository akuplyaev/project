using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace loginaccess {
    public partial class NewUser : Form {
        public NewUser() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (control()) {
                MessageBox.Show("Пользователь с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text != "" && textBox2.Text != "") {
                XDocument xdoc = XDocument.Load("users.xml");
                XElement user = new XElement("user",
                    new XElement("login", textBox1.Text),
                    new XElement("password", textBox2.Text),
                    new XElement("block", 0),
                    new XElement("limitation", 0));
                xdoc.Root.Add(user);
                xdoc.Save("users.xml");
                MessageBox.Show("Пользователь добавлен", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка на существование пользователя
        private bool control() {
            bool cl = false;
            XDocument xdoc = XDocument.Load("users.xml");
            foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                XElement loginElement = userElement.Element("login");
                if (loginElement.Value == textBox1.Text) {
                    cl = true;
                    break;
                }

            }

            return cl;
        }
    }
}

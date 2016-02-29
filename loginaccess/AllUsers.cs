using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace loginaccess {
    public partial class AllUsers : Form {
        public AllUsers() {
            InitializeComponent();
        }
        //Отметка checkbox при вызове формы
        private void Checked() {
            XDocument xdoc = XDocument.Load("users.xml");
            XElement firstlogin = xdoc.Descendants("login").First();
            textBox1.Text = firstlogin.Value;
            XElement firstblock = xdoc.Descendants("block").First();
            int block = Convert.ToInt32(firstblock.Value);
            if (block == 1) {
                checkBox1.Checked = true;
            }
            else {
                checkBox1.Checked = false;
            }
            XElement firstlimition = xdoc.Descendants("limitation").First();
            int limition = Convert.ToInt32(firstlimition.Value);
            if (limition == 1) {
                checkBox2.Checked = true;
            }
            else {
                checkBox2.Checked = false;
            }
        }
        //Отметка checkbox при перелистывании пользователей
        private void Checked(XElement element) {
            textBox1.Text = element.Element("login").Value;
            int block = Convert.ToInt32(element.Element("block").Value);
            if (block == 1) {
                checkBox1.Checked = true;
            }
            else {
                checkBox1.Checked = false;
            }
            int limition = Convert.ToInt32(element.Element("limitation").Value);
            if (limition == 1) {
                checkBox2.Checked = true;
            }
            else {
                checkBox2.Checked = false;
            }
        }


        private void AllUsers_Load(object sender, EventArgs e) {
            this.Checked();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            string currentuser = textBox1.Text;
            XDocument xdoc = XDocument.Load("users.xml");
            IEnumerable<XElement> elements = xdoc.Element("users").Elements("user");
            foreach (XElement el in elements) {

                if (el.Element("login").Value == currentuser) {

                    XElement node = (XElement)el.NextNode;
                    if (node != null) {
                        this.Checked(node);
                    }
                    else {
                        this.Checked();
                    }
                    return;
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string UserName = textBox1.Text;
            XDocument xdoc = XDocument.Load("users.xml");
            foreach (XElement userElement in xdoc.Element("users").Elements("user")) {
                XElement loginElement = userElement.Element("login");
                if (loginElement.Value == UserName) {
                    userElement.Element("block").SetValue(Convert.ToInt32(checkBox1.Checked));
                    userElement.Element("limitation").SetValue(Convert.ToInt32(checkBox2.Checked));
                    break;
                }

            }
            xdoc.Save("users.xml");
            MessageBox.Show("Данные изменены", "Смена данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
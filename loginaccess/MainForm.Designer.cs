namespace loginaccess
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePasswordToolStripMenuItem,
            this.NewUserToolStripMenuItem,
            this.AllUsersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.UsersToolStripMenuItem.Text = "Пользователи";
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Enabled = false;
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ChangePasswordToolStripMenuItem.Text = "Смена пароля";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // NewUserToolStripMenuItem
            // 
            this.NewUserToolStripMenuItem.Enabled = false;
            this.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem";
            this.NewUserToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.NewUserToolStripMenuItem.Text = "Новый пользователь";
            this.NewUserToolStripMenuItem.Click += new System.EventHandler(this.NewUserToolStripMenuItem_Click);
            // 
            // AllUsersToolStripMenuItem
            // 
            this.AllUsersToolStripMenuItem.Enabled = false;
            this.AllUsersToolStripMenuItem.Name = "AllUsersToolStripMenuItem";
            this.AllUsersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.AllUsersToolStripMenuItem.Text = "Все пользователи";
            this.AllUsersToolStripMenuItem.Click += new System.EventHandler(this.AllUsersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.AboutToolStripMenuItem.Text = "Справка";
            // 
            // btnEnter
            // 
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnter.Location = new System.Drawing.Point(83, 108);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Вход в систему";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEnter;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem NewUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AllUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        public System.Windows.Forms.Button btnEnter;
    }
}


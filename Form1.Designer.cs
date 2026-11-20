namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label role_NameLabel;
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.usersBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.first_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.role_NameComboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            first_NameLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            role_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1BindingNavigator)).BeginInit();
            this.usersBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataSource = typeof(WindowsFormsApp1.pr3.Users);
            // 
            // usersBindingSource1BindingNavigator
            // 
            this.usersBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.usersBindingSource1BindingNavigator.BindingSource = this.usersBindingSource1;
            this.usersBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.usersBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.usersBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.usersBindingSource1BindingNavigatorSaveItem});
            this.usersBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.usersBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.usersBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.usersBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.usersBindingSource1BindingNavigator.Name = "usersBindingSource1BindingNavigator";
            this.usersBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.usersBindingSource1BindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.usersBindingSource1BindingNavigator.TabIndex = 0;
            this.usersBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Переместить в начало";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить вперед";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Добавить";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Удалить";
            // 
            // usersBindingSource1BindingNavigatorSaveItem
            // 
            this.usersBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingSource1BindingNavigatorSaveItem.Enabled = false;
            this.usersBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingSource1BindingNavigatorSaveItem.Image")));
            this.usersBindingSource1BindingNavigatorSaveItem.Name = "usersBindingSource1BindingNavigatorSaveItem";
            this.usersBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingSource1BindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usersDataGridView.DataSource = this.usersBindingSource1;
            this.usersDataGridView.Location = new System.Drawing.Point(259, 52);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(542, 353);
            this.usersDataGridView.TabIndex = 1;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(25, 89);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox1
            // 
            this.first_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "First_Name", true));
            this.first_NameTextBox1.Location = new System.Drawing.Point(94, 86);
            this.first_NameTextBox1.Name = "first_NameTextBox1";
            this.first_NameTextBox1.Size = new System.Drawing.Size(121, 20);
            this.first_NameTextBox1.TabIndex = 3;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(25, 115);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "Login", true));
            this.loginTextBox1.Location = new System.Drawing.Point(94, 112);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(121, 20);
            this.loginTextBox1.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(25, 141);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "Password", true));
            this.passwordTextBox1.Location = new System.Drawing.Point(94, 138);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox1.TabIndex = 7;
            // 
            // role_NameLabel
            // 
            role_NameLabel.AutoSize = true;
            role_NameLabel.Location = new System.Drawing.Point(25, 167);
            role_NameLabel.Name = "role_NameLabel";
            role_NameLabel.Size = new System.Drawing.Size(63, 13);
            role_NameLabel.TabIndex = 8;
            role_NameLabel.Text = "Role Name:";
            // 
            // role_NameComboBox1
            // 
            this.role_NameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "Role_Name", true));
            this.role_NameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "Role_Name", true));
            this.role_NameComboBox1.DataSource = this.usersBindingSource1;
            this.role_NameComboBox1.FormattingEnabled = true;
            this.role_NameComboBox1.Location = new System.Drawing.Point(94, 164);
            this.role_NameComboBox1.Name = "role_NameComboBox1";
            this.role_NameComboBox1.Size = new System.Drawing.Size(121, 21);
            this.role_NameComboBox1.TabIndex = 9;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.pr3.Users);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Role_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Role_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(821, 426);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(role_NameLabel);
            this.Controls.Add(this.role_NameComboBox1);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.usersBindingSource1BindingNavigator);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1BindingNavigator)).EndInit();
            this.usersBindingSource1BindingNavigator.ResumeLayout(false);
            this.usersBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox role_NameComboBox;
        private System.Windows.Forms.BindingSource model1BindingSource1;
        private System.Windows.Forms.BindingSource model1BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingNavigator usersBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton usersBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox first_NameTextBox1;
        private System.Windows.Forms.TextBox loginTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.ComboBox role_NameComboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


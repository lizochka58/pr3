using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.pr3;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        pr3.Roles model = new pr3.Roles();
        private void MainForm_Load(object sender, EventArgs e)
        {
            StartLoadData();
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            role_NameComboBox.SelectedIndex = 0;
        }
        
        private void StartLoadData()
        {
            model.Users.Load();

            usersBindingSource.DataSource = model.Users.Local.ToBindingList();
        }
        
        private void SaveData()
        {
            try
            {
                Validate();
                usersBindingSource.EndEdit();
                usersBindingSource.ResetBindings(true);
                model.SaveChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();

            }   
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}

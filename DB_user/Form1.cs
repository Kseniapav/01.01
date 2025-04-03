using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_user
{
    public partial class Form1 : Form
    {
        Database sqlreader = new Database();
        private BindingList<User> usersList;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<User> users = sqlreader.ReadUsers();
                usersList = new BindingList<User>(users);
                dataGridView1.DataSource = usersList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления");
                return;
            }

            User selectedUser = (User)dataGridView1.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить пользователя {selectedUser.name} {selectedUser.surname}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool deleted = sqlreader.DeleteUser(selectedUser.id_user);

                if (deleted)
                {
                    usersList.Remove(selectedUser);
                    MessageBox.Show("Пользователь успешно удален");
                 
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить пользователя");
                }
            }
        }
    }
}

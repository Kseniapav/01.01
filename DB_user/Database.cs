using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_user
{
    public class Database
    {
        public List<User> ReadUsers()
        {
            List<User> result = new List<User>();

            string myConnectionString = "server=127.0.0.1;uid=root;pwd=vertrigo;database=users;"; /// строка соединения с БД
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    const string query = "SELECT id_user, name, surname, number, birthday FROM user;";
                    MySqlCommand command = new MySqlCommand(query, conn); /// объект команды
                    using (MySqlDataReader reader = command.ExecuteReader()) /// запуск исполнения команды на сервере
                    {
                        while (reader.Read()) /// пока  есть данные в результате
                        {
                            int id_user = reader.GetInt32("id_user");

                            User st = new User(id_user);
                            st.id_user = reader.GetInt32("id_user");
                            st.name = reader.GetString("name");
                            st.surname = reader.GetString("surname");
                            st.number = reader.GetString("number");
                            st.birthday = reader.GetDateTime("birthday");
                            result.Add(st);
                        }
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }

            return result;
        }


        public bool DeleteUser(int userId)
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=vertrigo;database=users;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM user WHERE id_user = @id;";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                return false;
            }
        }



    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace OOP_Final_Project
{
    public class UserRepository
    {
        private readonly ISQLiteConnection _connection;

        public UserRepository()
        {
            var databasePath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "userdata.db");


            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<User>();


        }
        public bool Add(User user)
        {

            _connection.Insert(user);
            return true;
        }

        public List<User> GetAll()
        {

            return _connection.Table<User>().ToList();
        }

        public User Get(int id)
        {
            return _connection.Find<User>(id);
        }
    }
}

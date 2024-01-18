namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo(){Id = 1, Name = "Mutalib", Phone="0555101010", Email="mutu@gmail.com", WillAttend=true });
            _users.Add(new UserInfo(){Id = 2, Name = "Kamal", Phone="0555151510", Email="kamal@gmail.com", WillAttend=true });
            _users.Add(new UserInfo(){Id = 3,Name = "Leyla", Phone="050544444", Email="leyla@gmail.com", WillAttend=true });
        }

        public static List<UserInfo> Users
        {
            get{return _users;}
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count +1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id ==id);
        }
    }
}
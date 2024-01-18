namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo(){Name = "Mutalib", Phone="0555101010", Email="mutu@gmail.com", WillAttend=true });
            _users.Add(new UserInfo(){Name = "Kamal", Phone="0555151510", Email="kamal@gmail.com", WillAttend=true });
            _users.Add(new UserInfo(){Name = "Leyla", Phone="050544444", Email="leyla@gmail.com", WillAttend=true });
        }

        public static List<UserInfo> Users
        {
            get{return _users;}
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
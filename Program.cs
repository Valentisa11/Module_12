namespace Module_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>//список пользователей
            {
                new User { Login = "login11", Name = "Миша Браун", IsPremium = true },
                new User { Login = "MrSkobka", Name = "Сергей Костин", IsPremium = true },
                new User { Login = "Pool", Name = "Mark Grin",  IsPremium = false}
            };


            Console.Write("Для входа в систему введите ваш логин: ");
            string login = Console.ReadLine();//ввод логина

            foreach (User u in users)
            {
                if (u.Login == login)
                {
                    Console.WriteLine($"Приветствуем, {u.Name}");//вывод приветствия с именем
                    if (u.IsPremium == false)
                    {
                        User.ShowAds();
                    }
                }
            }
        }
    }
}
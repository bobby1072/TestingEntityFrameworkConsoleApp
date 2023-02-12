namespace Core
{
    public class Account
    {
        public readonly string Name;
        public float Balance;
        public Account(string name, float balance)
        {
            Name= name;
            Balance= balance;
        }
    }
}

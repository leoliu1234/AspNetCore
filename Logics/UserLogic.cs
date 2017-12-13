namespace demo
{
    public class UserLogic : IUserLogic
    {
        public string GetSenderName()
        {
            return "Leo";
        }
    }

    public interface IUserLogic
    {
        string GetSenderName();
    }

}
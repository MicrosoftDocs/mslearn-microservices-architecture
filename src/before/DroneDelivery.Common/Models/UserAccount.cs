namespace DroneDelivery.Common.Models
{
    public class UserAccount
    {
        public UserAccount(string userid, string accountid)
        {
            UserId = userid;
            AccountId = accountid;
        }
        public string UserId { get; }
        public string AccountId { get; }
    }
}

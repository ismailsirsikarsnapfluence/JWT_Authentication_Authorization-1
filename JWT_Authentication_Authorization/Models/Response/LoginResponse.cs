namespace JWT_Authentication_Authorization.Models.Response
{
    public class LoginResponse
    {
        public User User { get; set; }
        public string Token { get; set; }
        public bool isSucesss { get; set; }



    }
}

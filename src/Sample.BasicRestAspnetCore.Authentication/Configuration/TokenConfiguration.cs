namespace Sample.BasicRestAspnetCore.Authentication.Configuration
{
    public class TokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
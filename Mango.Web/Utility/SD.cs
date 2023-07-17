namespace Mango.Web.Utility
{
    public class SD
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public const string RoleAdmin = "Administrator";
        public const string RoleUser = "User";

        public static string CouponAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
    }
}

namespace proyecto_biblioteca.BusinessLogic.Models
{
    public class LoginData
    {
        public bool validator ()
        {
            
            if (string.IsNullOrEmpty (this.Password)) return false;
            if (string.IsNullOrEmpty (this.User)) return false;
            return true;
        }
        public string User { get; set; }
        public string Password { get; set; }
    }
}

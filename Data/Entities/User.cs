namespace testASP.Data.Entities
{
    public class User
    {

        //Guid - ГЛОБАЛЬНО УНІКАЛЬНА ІДЕНТИФІКАЦІЯ
        public Guid Id { get; set; }
        public String Login { get; set; } = null!;
        public String? Name { get; set; }
        public String Email { get; set; } = null!;
        public String PasswordSalt { get; set; } = null!;
        public String PasswordDk { get; set; } = null!;  
        public String? Avatar { get; set; }  
        public DateTime RegisterDt { get; set; }
        public DateTime? DeleteDt { get; set; }
    }
}

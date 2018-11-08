namespace EM.Calc.DB
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string connectionString) : base(connectionString)
        {

        }
        public override string TableName => "Users";
        public override string Fields => "Login, BirthDay, Sex";
    }
}
using LoginApp.Models;
namespace LoginApp.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly ApplicationDBContext _context; //this is the instance of ApplicationDBContext that will be used to
                                                        //access the database
                                                        


        public LoginRepository(ApplicationDBContext context) //dependency injection of ApplicationDBContext
        {
            _context = context;     //assigning the injected context to the private field
        }

        public LoginA ValidateUser(string username, string password) //this method will validate the user by checking if the
                                                                     //username and password exist in the database
                                                                     
        {
            //this method will return the user if the username and password match, otherwise it will return null
            return _context.LoginAs.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}

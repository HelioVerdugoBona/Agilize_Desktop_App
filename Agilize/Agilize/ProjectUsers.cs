using System;

namespace Agilize
{
    internal class ProjectUsers
    {
        String Nickname {  get; set; }

        String Email { get; set; }

        String Password { get; set; }

        ProjectUsers() { }

        ProjectUsers(String Nickname, String Email, String Password) 
        {
            this.Nickname = Nickname;
            this.Email = Email;
            this.Password = Password;
        }

    }
}

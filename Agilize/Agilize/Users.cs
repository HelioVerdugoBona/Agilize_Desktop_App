using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agilize
{
    public class Users
    {
        public String name {  get; set; }

        public String surname { get; set; }

        public String password { get; set; }

        public String email { get; set; }

        public String nickname {  get; set; }

        public BindingList<String> projectsList { get; set; }
        public Users() { }

        public Users(string email, string nickname, string password)
        {
            this.email = email;
            this.nickname = nickname;
            this.password = password;
        }

        public Users(string name, string surname, string password, string email, string nickname, BindingList<String> projectsList)
        {
            this.projectsList = new BindingList<String>();
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.nickname = nickname;
            this.projectsList = projectsList;
        }

        override public String ToString()
        {
            return nickname.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Users otherUser)
            {
                return this.nickname == otherUser.nickname;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nickname?.GetHashCode() ?? 0;
        }

        public Users Clone()
        {
            return new Users
            {
                name = this.name,
                surname = this.surname,
                password = this.password,
                email = this.email,
                nickname = this.nickname,
                projectsList = this.projectsList
            };
        }
    }
}

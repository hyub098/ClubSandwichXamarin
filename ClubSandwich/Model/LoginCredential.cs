using System;
using Realms;

namespace ClubSandwich.Model
{
    public class LoginCredential : RealmObject
    {
        public string Token { get; set; }
    }
}

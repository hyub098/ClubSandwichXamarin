using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSandwich.Service
{
    public class RealmConnection
    {
        public static Realm GetInstance()
        {
            var realm = Realm.GetInstance(new RealmConfiguration() { SchemaVersion = 0 });

            return realm;
        }

        private RealmConnection() { }
    }
}

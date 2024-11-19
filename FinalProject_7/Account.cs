using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal abstract class Account
    {
        public abstract string ID { get; protected set; }
        public abstract void LoginPassIn();
        public abstract void LogIn();
    }
}

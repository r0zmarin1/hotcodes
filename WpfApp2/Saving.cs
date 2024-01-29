using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Saving
    {
            private Saving() { }
            public string Login { get; set; }
            public string Password { get; set; }
            static Saving instance;
            static object locker = new object();
            public static Saving GetInstance()
            {
                lock (locker)
                {
                    if (instance == null) instance = new Saving();
                    return instance;
                }
            }       
    }
    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Csharp.Part1.RandomPassword
{
    interface IPasswordRepository
    {
        void Show();
        void Create();
        int Number { get; set; }
    }
}

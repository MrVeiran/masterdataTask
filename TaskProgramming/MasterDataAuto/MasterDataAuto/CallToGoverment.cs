using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto
{
    class CallToGoverment
    {

        const string AllChar = "1234567890abcdefghijklmnopqrstuvwxyz";
        public string GenerateVinNumber()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 17; i++)
            {
                Random rand = new Random();
                builder.Append(AllChar[rand.Next(1, 31)]);
            }
            return builder.ToString();
        }
    }
}

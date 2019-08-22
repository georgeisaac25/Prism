using System;
namespace MyPrismApp.Repository
{
    public class Repo : IRepo
    {
        IDB dB;
        public Repo(IDB dB)
        {
            this.dB = dB;
        }

        public int GetNum()
        {
            return dB.GetNum();
        }
    }
}

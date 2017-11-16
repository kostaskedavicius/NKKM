using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    enum Prizes
    {
        None,
        BackPack,
        CPU,
        Socks,
        Umbrella,
        T_Shirt
    }
    class Guest
    {
        private string Name;
        private string LastName;
        private string Company;
        private bool Winner;
        private Prizes Prize;

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public void SetCompany(string Company)
        {
            this.Company = Company;
        }
        public string GetCompany()
        {
            return Company;
        }
        public void SetWinner(bool Winner)
        {
            this.Winner = Winner;
            if (Winner == false)
            {
                Prize = Prizes.None;
            }
        }
        public bool GetWinner()
        {
            return Winner;
        }
        public void SetPrize()
        {
            if(Winner == true)
            {
                Random rnd = new Random();
                int count = Enum.GetNames(typeof(Prizes)).Length;
                // get random prize name
                string name = Enum.GetName(typeof(Prizes), rnd.Next(1, count));
                //convert name to Prizes enum
                Prize = (Prizes)Enum.Parse(typeof(Prizes), name);
            }
        }
        public Prizes GetPrize()
        {
            return Prize;
        }
    }
}

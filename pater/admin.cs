using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pater
{
    interface IAdmin
    {
        void AddSite(ISite site);

        void Checkallsites();
    }

    class Admin : IAdmin
    {
        List <ISite> sites;

        public Admin()
        {
            sites = new List <ISite>();
        }
        public void AddSite(ISite sit)
        {
            sites.Add(sit);
        }

        public void Checkallsites()
        {
            foreach (ISite site in sites)
            {
                site.CheckSite();
            }
        }
    }

    interface ISite
    {
        void CheckSite();
    }

    class Site : ISite
    {
        public string Link { get; set; }
        public Site(string l)
        {
            Link = l;
        }
        public void CheckSite()
        {
            if (Link.Contains('@'))
            {
                MessageBox.Show($"{Link} не работает");
            }
            else
            {
                MessageBox.Show($"{Link} работает");
            }
        }
    }
}

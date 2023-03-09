using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pater
{
    interface IAport
    {
        void AddChel(IBag chel);
        void RemoveChel(IBag chel);
        void NotifyChels();

        void GiveBags();
    }

    class AportReal : IAport
    {
        public List<IBag> chelList;

        public AportReal()
        {
            chelList = new List<IBag>();
        }

        public void AddChel(IBag chelik)
        {
            chelList.Add(chelik);
        }

        public void RemoveChel(IBag chelik)
        {
            chelList.Remove(chelik);
        }

        public void GiveBags()
        {
            foreach (IBag chel in chelList)
            {
                chel.GetBag();
            }
            NotifyChels();
        }

        public void NotifyChels()
        {
            foreach (IBag chel in chelList)
            {
                chel.Update();
            }
        }

    }

    interface IBag
    {
        void Update();
        void GetBag();
    }

    class Chel : IBag
    {
        public string Name { get; set; }

        public Chel(string name, bool bage)
        {
            Name = name;
            baghaving = bage;
        }
        public bool baghaving;
        public void Update()
        {
            if (baghaving)
                MessageBox.Show($"{Name} получил свое");
            else
                MessageBox.Show($"{Name} еще не получил свое");
        }

        public void GetBag()
        {
            baghaving = true;
        }
    }

}

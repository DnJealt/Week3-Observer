using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcObserver
{
    public abstract class Subject
    {

       protected List<Observer> observerList = new List<Observer>();

       public void attach(Observer o)
       {
           observerList.Add(o);
       }

       public void detach(Observer o)
       {
           observerList.Remove(o);
       }

       public void notify()
       {
           for (int i = 0; i < observerList.Count; i++)
           {
               observerList[i].update();
           }
       }

    }
}

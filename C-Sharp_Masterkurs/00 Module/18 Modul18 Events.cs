using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*                                                                              //mit Event
namespace C_Sharp_Masterkurs.Module
{
    public class Modul18
    {
        public Modul18()
        {
        }
        public void Events()
        {
            BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Emanuel");
            names.Add("Miriam");
            names.Add("Herbert");
            names.Add("Markus");
            names.Add("Michael");

        }

        static void OnAdded()
        {
            Console.WriteLine("Ein Objekt wurde zur Liste hinzugefügt...");
        }
    }

    public delegate void AddedEventHandler();   //delegat für event

    public class BetterList<T> : List<T>
    {
        public new void Add(T item) //new nur um die Meldung zu entfernen
        {
            base.Add(item);

            if (Added != null)
            {
                Added();            // Eventname "Added" zum abfeuern von einem event
            }
        }

        public event AddedEventHandler Added; // Eventname

        private void OnAdded()
        {
            if (Added != null)
                Added();
        }
    }
}
*/
                                                                                //mit EventArgs
namespace C_Sharp_Masterkurs.Module
{
    public class Modul18
    {
        public Modul18()
        {
        }
        public void Events()
        {
            BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Emanuel");
            names.Add("Miriam");
            names.Add("Herbert");
            names.Add("Markus");
            names.Add("Michael");

        }

        static void OnAdded(object sender, AddedEventArgs args)
        {
            Console.WriteLine("Das Objekt " + args.AddedItem.ToString() + " wurde hinzugefügt!");
        }
    }

    public delegate void AddedEventHandler(object sender, AddedEventArgs args);   //delegat für event

    public class BetterList<T> : List<T>
    {
        public new void Add(T item) //new nur um die Meldung zu entfernen
        {
            base.Add(item);
            OnAdded(item);
            
        }

        public event AddedEventHandler Added; // Eventname

        private void OnAdded(T item)
        {
            if (Added != null)
            {
                Added(this, new AddedEventArgs(item));
            }
        }
    }

    public class AddedEventArgs : EventArgs
    {
        public Object AddedItem { get; set; }

        public AddedEventArgs(object addedItem)
        {
            AddedItem = addedItem;
        }
    }
}
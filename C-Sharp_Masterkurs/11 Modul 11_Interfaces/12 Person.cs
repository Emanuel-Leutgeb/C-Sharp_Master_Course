using System;
namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                logger.Log("Der Getter von Namen wurde aufgefrufen!");
                return name;
            }
            set
            {
                logger.Log("Der Setter von Namen wurde aufgefrufen!");
                name = value;
            }
        }

        private ILogger logger = new ConsoleLogger(); //ConsoleLoggerOderOutputlogger
    }
}

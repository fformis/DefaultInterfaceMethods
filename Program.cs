using System;

namespace DefaultInterfaceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IDefaultInterface i = new Implementacao();

            Console.WriteLine(i.Nome());
        }
    }

    interface IDefaultInterface
    {        
        string Nome(){
            return "Meu nome padrão";
        }
    }

    class Implementacao : IDefaultInterface
    {
        /*Descomentando o método abaixo, deixaremos de utilizar o método default da interface
        e passaremos utilizar o método específico da classe."*/

        /*public string Nome()
        {
            return "teste";
        }*/
    }
    
}

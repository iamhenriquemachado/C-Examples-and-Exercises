using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSetDictionary
{
    public class Box<T>
    {
        // Generics: Os generics são um recurso que permite criar classes, métodos, interfaces e delegates que
        // funcionam com tipos de dados parametrizados. 
        public T Item { get; set; }

        Box<int> intBox = new Box<int> { Item = 10 };
        Box<string> strBox = new Box<string> { Item = "Henrique" };

    }
}

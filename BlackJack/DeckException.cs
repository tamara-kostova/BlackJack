using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class DeckException : Exception
    {
        public DeckException() { }
        public DeckException(string message) : base(message){ }
        public DeckException(string message, Exception innerException) : base(message,innerException) { }
        public DeckException(SerializationInfo info, StreamingContext context) : base(info,context) { }


    }
}

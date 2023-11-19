using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _7.MyException
{
    public class StudentDateBirthException : Exception
    {
        private string _messageInfo = String.Empty;

        public StudentDateBirthException(string message)
        {
            _messageInfo = message;
        }

        public override string Message => $"Student error: {_messageInfo}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tv.Business.Error
{
    public class BusinessException : Exception
    {
        public BusinessException() : base("İş katmanında hata oluştu.") { }
        public BusinessException(string message) : base(message) { }
    }
    public class UsernameAlreadyExistsException : BusinessException
    {
        public UsernameAlreadyExistsException() : base("Kullanıcı adı alınmış.") { }
        public UsernameAlreadyExistsException(string message) : base(message) { }
    }
    public class EmailAlreadyExistsException : BusinessException
    {
        public EmailAlreadyExistsException() : base("Bu mail adresi kullanımda.") { }
        public EmailAlreadyExistsException(string message) : base(message) { }
    }
}

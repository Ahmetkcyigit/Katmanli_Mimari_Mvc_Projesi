using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Burayı Boş Geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Burayı Boş Geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Burayı Boş Geçemezsiniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Burayı Boş Geçemezsiniz");
            RuleFor(x => x.ReceiverMail).MinimumLength(3).WithMessage("Burayı Boş Geçemezsiniz");
          
        }
    }
}

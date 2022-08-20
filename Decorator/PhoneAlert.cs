using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PhoneAlert : AbstractAlertDecorator
    {
        public PhoneAlert(AbstractAlert alert) : base(alert)
        {
        }

        public override void Send()
        {
            base.Send();

            // the logic to send Phone
            Console.WriteLine("Send alert via Phone");
        }
    }
}

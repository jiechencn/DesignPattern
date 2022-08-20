using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SmsAlert : AbstractAlertDecorator
    {
        public SmsAlert(AbstractAlert alert) : base(alert)
        {
        }

        public override void Send()
        {
            base.Send();

            // the logic to send SMS
            Console.WriteLine("Send alert via SMS");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class AbstractAlertDecorator : AbstractAlert
    {
        protected AbstractAlert alert;
        public AbstractAlertDecorator(AbstractAlert alert)
        {
            this.alert = alert;
        }

        public override void Send()
        {
            if (alert != null)
            {
                alert.Send();
            }
            
        }
    }
}

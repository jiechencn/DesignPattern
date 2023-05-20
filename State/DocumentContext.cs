using StatePattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class DocumentContext
    {
        public State State { get; private set; }
  
        public DocumentContext()
        {
            State = new EditState();
        }

        public void Next()
        {
            State.SetNext(this);
        }

        public void SetState(State state)
        {
            this.State = state;
        }
        public void Edit()
        {
            if (State != null )
            {
                State.Edit(this);
            }
        }
        public void Review()
        {
            if (State != null)
            {
                State.Review(this);
            }
        }

        public void Approve()
        {
            if (State != null)
            {
                State.Approve(this);
            }
        }

        public void Publish()
        {
            if (State != null)
            {
                State.Publish(this);
            }
        }
    }
}

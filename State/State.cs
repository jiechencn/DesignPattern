using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StatePattern
{
    public abstract class State
    {
        private string Name { get; }
        public State(string name)
        {
            this.Name = name;

            Console.WriteLine(name);
        }

        public abstract void SetNext(DocumentContext context);

        public abstract void Edit(DocumentContext context);

        public abstract void Review(DocumentContext context);

        public abstract void Approve(DocumentContext context);

        public abstract void Publish(DocumentContext context);
    }

    public class EditState : State
    {
        public EditState() : base("Editing")
        {
        }

        public override void SetNext(DocumentContext context)
        {
            context.SetState(new ReviewState());
        }
        public override void Edit(DocumentContext context)
        {
            Console.WriteLine("It is editing");
        }

        public override void Review(DocumentContext context)
        {
            SetNext(context);
        }

        public override void Approve(DocumentContext context)
        {
            Console.WriteLine("Cannot approve because not reviewed");
        }

        public override void Publish(DocumentContext context)
        {
            Console.WriteLine("Cannot publish because not approved");
        }
    }

    public class ReviewState : State
    {

        public ReviewState() : base("Reviewing")
        {
        }

        public override void SetNext(DocumentContext context)
        {
            context.SetState(new ApproveState());
        }
        public override void Edit(DocumentContext context)
        {
            Console.WriteLine("Cannot edit because reviewing");
        }

        public override void Review(DocumentContext context)
        {
            Console.WriteLine("It is reviewing");
        }

        public override void Approve(DocumentContext context)
        {
            SetNext(context);
        }

        public override void Publish(DocumentContext context)
        {
            Console.WriteLine("Cannot publish because not approved");
        }
    }

    public class ApproveState : State
    {
        public ApproveState() : base("Approved")
        {
        }

        public override void SetNext(DocumentContext context)
        {
            context.SetState(new PublishState());
        }
        public override void Edit(DocumentContext context)
        {
            Console.WriteLine("Cannot edit because approved");
        }

        public override void Review(DocumentContext context)
        {
            Console.WriteLine("Cannot review because approved");
        }

        public override void Approve(DocumentContext context)
        {
            Console.WriteLine("Already approved");
        }

        public override void Publish(DocumentContext context)
        {
            SetNext(context);
        }
    }

    public class PublishState : State
    {
        public PublishState() : base("Published")
        {
        }

        public override void SetNext(DocumentContext context)
        {
            // no next state
        }
        public override void Edit(DocumentContext context)
        {
            Console.WriteLine("Cannot edit because published");
        }

        public override void Review(DocumentContext context)
        {
            Console.WriteLine("Cannot review because published");
        }

        public override void Approve(DocumentContext context)
        {
            Console.WriteLine("Cannot approve because published");
        }

        public override void Publish(DocumentContext context)
        {
            Console.WriteLine("Already published");
        }
    }
}

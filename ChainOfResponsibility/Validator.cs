namespace ChainOfResponsibility;

public interface IValidator<T> where T : class
{
    IValidator<T> SetNext(IValidator<T> next);
    void Handle(T request);
}

public abstract class AbstractValidator<T> : IValidator<T> where T : class
{
    public AbstractValidator(IList<Exception> exceptions)
    {
        this.exceptions = exceptions;
    }
    protected IList<Exception> exceptions;
    private IValidator<T>? Next { get; set; }
    public virtual void Handle(T request)
    {
        Next?.Handle(request);  // 如果 Next == null，就停止执行
    }

    public IValidator<T> SetNext(IValidator<T> next)
    {
        Next = next;
        return Next;
    }
}

public class AgeValidator : AbstractValidator<User>
{
    public AgeValidator(IList<Exception> exceptions) : base(exceptions)
    {
    }

    public override void Handle(User request)
    {
        if (request.Age<18)
        {
            exceptions.Add(new Exception("illegal age"));
        }
        base.Handle(request);
    }
}

public class CountryValidator : AbstractValidator<User>
{
    public CountryValidator(IList<Exception> exceptions) : base(exceptions)
    {
    }

    public override void Handle(User request)
    {
        if (request.Country == "USA")
        {
            exceptions.Add(new Exception("illegal country"));
        }
        base.Handle(request);
    }
}

public class GendarValidator : AbstractValidator<User>
{
    public GendarValidator(IList<Exception> exceptions) : base(exceptions)
    {
    }

    public override void Handle(User request)
    {
        if (request.Gendar != 'M' && request.Gendar != 'F')
        {
            exceptions.Add(new Exception("illegal gendar"));
        }
        base.Handle(request);
    }
}

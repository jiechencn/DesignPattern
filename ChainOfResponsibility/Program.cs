
namespace ChainOfResponsibility;
class Program
{
    static void Main(string[] args)
    {
        User user = new User()
        {
            Name = "Tom",
            Age = 10,
            Country = "USA",
            Gendar = 'X'
        };
        IList<Exception> exceptions = new List<Exception>{ };

        AbstractValidator<User> ageValidator = new AgeValidator(exceptions);
        AbstractValidator<User> countryValidator = new CountryValidator(exceptions);
        AbstractValidator<User> gendarValidator = new GendarValidator(exceptions);

        ageValidator.SetNext(countryValidator).SetNext(gendarValidator);

        ageValidator.Handle(user);

        foreach(Exception ex in exceptions)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}
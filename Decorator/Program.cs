namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractAlert email = new EmailAlert();
            AbstractAlertDecorator sms = new SmsAlert(email);
            AbstractAlertDecorator phone = new PhoneAlert(sms);

            phone.Send();
        }
    }
}
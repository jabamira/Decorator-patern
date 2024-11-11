 namespace Wrapper 
{
    class Program
    {
        static void Main(string[] args)
        {

            INotify notifier = new Notifyer();

            notifier = new SMSNotifyer(notifier);

            notifier = new FacebookNotifyer(notifier);

            notifier.Send("Сообщение рассылаемое всем");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            INotify notifier_ = new Notifyer();
            notifier_ = new FacebookNotifyer(notifier_);

            notifier_.Send("Сообщение рассылаемое Email и в Facebook");
            Console.Read();
        }
    }
}

namespace PhoneFactory.Factories
{
    public class SmartphoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone()
        {
            return new Smartphone();
        }
    }
}

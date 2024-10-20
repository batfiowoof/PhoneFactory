namespace PhoneFactory.Factories
{
    public class FeaturePhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone()
        {
            return new FeaturePhone();
        }
    }
}


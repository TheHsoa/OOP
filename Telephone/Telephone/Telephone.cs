namespace Telephone
{
    class Telephone
    {
        private readonly int CityCode;
        private readonly int PhoneNumber;

        public Telephone(int cityCode, int phoneNumber)
        {
            CityCode = cityCode;
            PhoneNumber = phoneNumber;
        }

        public Telephone(int phoneNumber)
        {
            PhoneNumber = phoneNumber;
            CityCode = -1;
        }

        public string GetCityCode()
        {
            return CityCode == -1 ? PhoneNumber.ToString() : $"({CityCode}) {PhoneNumber}";
        }
    }
}
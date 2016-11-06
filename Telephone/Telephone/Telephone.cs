namespace Telephone
{
    class Telephone
    {
        private readonly int _cityCode;
        private readonly int _phoneNumber;

        public Telephone(int cityCode, int phoneNumber)
        {
            _cityCode = cityCode;
            _phoneNumber = phoneNumber;
        }

        public Telephone(int phoneNumber)
        {
            _phoneNumber = phoneNumber;
            _cityCode = -1;
        }

        public string Phone => _cityCode == -1 ? _phoneNumber.ToString() : $"({_cityCode}) {_phoneNumber}";
    }
}
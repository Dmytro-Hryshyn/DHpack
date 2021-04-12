using System;
using System.Collections.Generic;

namespace DHpack.DataGenerator
{
    public interface IDataGenerator
    {
        public List<string> GenerateName(int numberofNames = 1);
        public List<string> GenerateSurname(int numberOfSurnames = 1);
        public List<string> GenerateFullName(int numberOfPeople = 1);
        public List<string> GenerateEmail(int numberOfEmails = 1);
        public List<string> GenerateCountry(int numberOfCountries = 1);
        public List<string> GeneratePhoneNumber(int numberOfPhoneNumbers = 1);
        public List<string> GeneratePhoneNumber(Enum countryCode, int numberofPhoneNumbers = 1);
    }
}

namespace National_ID
{
    struct CitizenData
    {
        // 299 03 11    02 007 9 9
        public int YearOfBirth { get; }
        public byte MonthOfBirth { get; }
        public byte DayOfBirth { get; }
        public string Governorate { get; }
        public string Gender { get; }


        public CitizenData(int yearOfBirth, byte monthOfBirth, byte dayOfBirth, string governorate, string gender)
        {
            YearOfBirth = yearOfBirth;
            MonthOfBirth = monthOfBirth;
            DayOfBirth = dayOfBirth;
            Governorate = governorate;
            Gender = gender;
        }
    }
}
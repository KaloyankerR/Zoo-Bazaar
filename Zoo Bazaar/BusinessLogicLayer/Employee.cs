using System.Reflection.Metadata.Ecma335;

namespace BusinessLogicLayer
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string BSN { get; set; }
        public string IBAN { get; set; }
        public string EmergancyFirstName { get; set; }
        public string EmergancyLastName { get; set; }
        public string EmergancyPhone { get; set; }
        public ContractType ContractType { get; set; }
        public Position Position { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public string DivingLevel { get; set; }



        public Employee()
        {

        }

        public Employee(int id, string firstName, string lastName, string email, string password, string phone, string address, string gender,
            DateOnly dateOfBirth, string bsn, string iban, string emergancyFirstName, string emergancyLastName, string emergancyPhone,
            ContractType contractType, Position position, int minHours, int maxHours)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            BSN = bsn;
            IBAN = iban;
            EmergancyFirstName = emergancyFirstName;
            EmergancyLastName = emergancyLastName;
            EmergancyPhone = emergancyPhone;
            ContractType = contractType;
            Position = position;
            MinHours = minHours;
            MaxHours = maxHours;
            DivingLevel = "Not a diver";
        }



    }
}
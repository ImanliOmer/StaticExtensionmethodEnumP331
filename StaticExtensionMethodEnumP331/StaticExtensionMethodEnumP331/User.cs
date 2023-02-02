namespace StaticExtensionMethodEnumP331
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }

        private string pin;
        public string Pin
        {
            get
            {
                return Pin;
            }


            set
            {
                if (value.CheckPin())
                {
                    value = pin;
                }

            }



        }

        public User(string Name, string SurName, int RegistrationMonth)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.RegistrationMonth = (RegistrationMonth)RegistrationMonth;
        }

        public string GetDetails()
        {
            string details = $"{Name} {SurName} {RegistrationMonth}";
            return details;
        }
    }



}

namespace mis221_rakern_composition_lab
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail) {
            name = tempName;
            gender = tempGender;
            email = tempEmail;
        }

        public string GetName() {
            return name;
        }

        public char GetGender() {
            return gender;
        }
        public string GetEmail() {
            return email;
        }

        public void SetName(string tempName) {
            name = tempName;
        }

        public void SetGender(char tempGender) {
            gender = tempGender;
        }

        public void SetEmail(string tempEmail) {
            email = tempEmail;
        }

        public override string ToString() {
            return "name = " + name + ", email = " + email + ", gender = " + gender;
        }
    }
}
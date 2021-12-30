namespace DIO.Series
{
    public class Series : GlobalEntity
    {
        private int gender;
        private string desription;

        private Gender Gender {get; set;}
        private string Title {get; set;}
        private string Description {get; set;}
        private int Year {get;set;}


        

        public Series(int id, Gender gender, string title, string desription, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = desription;
            this.Year = year;
        }

        public override string ToString(){
            string result = "";
            result += "Gênero: " + this.Gender + Environment.NewLine;
            result += "Título: " + this.Title + Environment.NewLine;
            result += "Descrição: " + this.Description+ Environment.NewLine;
            result += "Ano de lançamento: " + this.Year;
            return result;
        }

        

        public string ReturnTitle(){
            return this.Title;
        }

        public int ReturnId(){
            return this.Id;
        }

        public void ToDelete() => IsDeleted = true;
    }

    
}
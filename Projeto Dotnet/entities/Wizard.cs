namespace Projeto_Dotnet.entities
{
    public class Wizard : Hero
    {
       public Wizard(string Name, int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

       public override string Attack()
        {
           return this.Name + " a "+ this.HeroType + " Lançou Magia";
        }
        public string Attack(int Bonus)
        {
           if (Bonus >6)
           {
              return this.Name + " a "+ this.HeroType + " Lançou Magia super efetiva com Bonus de "+ " " + Bonus;
           }
           else
           {
              return this.Name + " a "+ this.HeroType + " Lançou Magia com força fraca com Bonus de "+ " " + Bonus;
           }    
                
        }

    }
}
namespace Projeto_Dotnet.entities
{
    public class Knight :  Hero
    {
        public Knight(string Name, int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " o "+ this.HeroType + " Ataque com sua Espada";
        }

        public string Attack(int Bonus)
        {
           if (Bonus >6)
           {
              return this.Name + " o "+ this.HeroType + " Lançou ataque mortal com sua Espada com Bonus de "+ " " + Bonus;
           }
           else
           {
              return this.Name + " o "+ this.HeroType + " Se defendeu com seu Escudo com Bonus de "+ " " + Bonus;
           }    
                
        }
   

    }
}
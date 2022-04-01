namespace JogoRPGDIO.src.Entitities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public string Attack(int bonus)
        {
            return this.Name + " Causou um acerto crítico com " + bonus + " de bonus atacando por trás";
        }
    }
}
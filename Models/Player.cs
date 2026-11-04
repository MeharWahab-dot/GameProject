namespace GameProject.Models
{
    // A model represents information used by the application.
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int HealingPotions { get; private set; }
        public int Score { get; private set; }
      

        public Player(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 20;
            HealingPotions = 3;
            
        }

        public void TakeDamage(int damage)
        {
            Health = Health - damage;
            if (Health < 0) Health = 0;
        }

        public bool UseHealingPotion()
        {
            if (HealingPotions <= 0) return false;
            Health = Health + 25;
            if (Health > 100) Health = 100;
            HealingPotions--;
            return true;
        }

        public void AddScore(int bonus)
        {
            if (Health > 50 && Health < 100)
            {
                Score = Score + 10;

            }
            else if (Health > 0 && Health < 50)
            {
                Score = Score + 5;
            }
            else if (HealingPotions == 1)
            {
                Score = Score + 10;
            }
            else if (HealingPotions == 2)
            {
                Score = Score + 20;
            }
            else if (HealingPotions == 3)
            {
                Score = Score + 30;
            }
        }
   
        public bool IsAlive() { return Health > 0; }
    }
}

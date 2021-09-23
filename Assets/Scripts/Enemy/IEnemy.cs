public interface IEnemy 
{
    public int HP { get; set; }
    public float Speed { get; set; }
    public int Defence { get; set; }
    public int BuildingDamage { get; set; }
    public int GoldForDeath { get; set; }
    public int ExpForDeath { get; set; }

    public void GetDamge(int damage);
    public void Die();
    public void Walk();

}

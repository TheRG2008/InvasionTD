
public interface ITower
{
    public int Damage { get; set; }
    public float DamageSpeed { get; set; }
    public float RadiusAtack { get; set; }
    public int GoldForUpgrade { get; set; }
    public int GoldForBuilding { get; set; }
    public bool IsOpen { get; set; }

    public void Atack(IEnemy enemy);
    public void Upgrade();
    public void Build();
}

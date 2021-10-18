
public interface ITower
{
    public int Damage { get; set; }
    public float ProjectileSpeed { get; set; }
    public int RadiusAtack { get; set; }
    public int GoldForUpgrade { get; set; }
    public int GoldForBuilding { get; set; }
    public bool IsOpen { get; set; }

    public void Build();
}

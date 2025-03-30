using UnityEngine;

public class ExplodingShotUpgrade : Upgrade
{

    public void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.AddOnSpawnAction(ExplodingShotAction);
    }

    private void ExplodingShotAction(GameObject proj)
    {
        var component = proj.GetComponent<DamageOnHit>();
        if (component)
            Destroy(component);
        proj.AddComponent<ExplodeOnHit>();
    }
}
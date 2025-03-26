using UnityEngine;
public class PiercingShotUpgrade : Upgrade
{
    public void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.AddOnSpawnAction(PiercingShotAction);
    }

    private void PiercingShotAction(GameObject proj)
    {
        var component = proj.GetComponent<DeleteOnHit>();
        if (component)
            Destroy(component);
    }
}
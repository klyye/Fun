
using UnityEngine;

public class DoubleShot : Upgrade
{
    public void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.AddOnSpawnAction(DoubleShotAction);
    }

    private void DoubleShotAction(GameObject proj)
    {
        if (proj)
            Instantiate(proj);
    }
}
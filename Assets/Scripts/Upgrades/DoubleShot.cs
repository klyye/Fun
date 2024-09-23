using System.Collections;
using UnityEngine;

public class DoubleShot: Upgrade
{
    public void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.AddOnSpawnAction(DoubleShotAction);
    }

    private void DoubleShotAction(Projectile proj)
    {
        StartCoroutine(DoubleShotCoroutine(proj));
    }

    private IEnumerator DoubleShotCoroutine(Projectile proj)
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(proj);
    }
}
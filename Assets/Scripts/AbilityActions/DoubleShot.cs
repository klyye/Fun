using System.Collections;
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
        StartCoroutine(DoubleShotCoroutine(proj));
    }

    private IEnumerator DoubleShotCoroutine(GameObject proj)
    {
        yield return new WaitForSeconds(0.2f);
        if (proj)
            Instantiate(proj);
    }
}
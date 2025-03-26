using System.Collections;
using UnityEngine;

public class DoubleShotUpgrade : Upgrade
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
        yield return new WaitForSeconds(0.3f);
        if (proj)
            Instantiate(proj);
    }
}
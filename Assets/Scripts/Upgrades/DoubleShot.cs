using UnityEngine;

[CreateAssetMenu(fileName = "DoubleShotUpgrade", menuName = "ScriptableObjects/DoubleShotUpgrade")]
public class DoubleShot : Upgrade
{
    public override void apply(Projectile proj)
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        // TODO: PROBLEM: WE WANT TO TRIGGER ANOTHER SHOT WITH ALL THE UPGRADES, BUT DONT WANT TO INFINITE LOOP
        Instantiate(proj);
    }
}

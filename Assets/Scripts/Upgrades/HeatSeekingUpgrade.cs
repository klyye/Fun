using UnityEngine;

/// <summary>
/// note that this only TURNS the object towards the targets, it doesn't MOVE it
/// </summary>
public class HeatSeekingUpgrade : Upgrade
{
    [SerializeField] private float _refreshDuration;

    public void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.AddOnSpawnAction(AddHeatSeeking);
    }

    private void AddHeatSeeking(GameObject proj)
    {
        var component = proj.AddComponent<SeekingMovement>();
        component.refreshDuration = _refreshDuration;
    }
}
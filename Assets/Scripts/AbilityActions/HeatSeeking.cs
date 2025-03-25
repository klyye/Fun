using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO
public class HeatSeeking : Upgrade
{
    // Start is called before the first frame update
    void Start()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
        shooter.proj.AddComponent<SeekingMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

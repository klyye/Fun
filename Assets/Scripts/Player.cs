using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Player : MonoBehaviour
{
    private ISet<Upgrade> upgrades = new HashSet<Upgrade>();
    public Health Health { get; private set; }

    private void Awake()
    {
        Health = GetComponent<Health>();
        Health.OnDeath += QuitGame;
    }

    public void UpgradePlayer(Upgrade upgrade)
    {
        if (!upgrades.Contains(upgrade))
        {
            Instantiate(upgrade, transform);
            upgrades.Add(upgrade);
        }
    }


    /// <summary>
    ///     https://discussions.unity.com/t/application-quit-not-working/130493/6
    /// </summary>
    private static void QuitGame()
    {
        // save any game data here
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
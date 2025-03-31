using UnityEngine;

/// <summary>
///		unfortunately i tried scriptableobjects and having a one-field abstract class somehow turned out to be less
///		jank than that lmao
/// </summary>
public abstract class Upgrade: MonoBehaviour
{
	public int cost;
	public string name;
}
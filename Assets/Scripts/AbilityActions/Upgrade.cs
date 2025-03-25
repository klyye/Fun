using UnityEngine;

// TODO: split upgrades (data bundles that contain cost + list of actions + behaviors) and actions
// TODO: ?????? only the cost? is this necessary? refactor into scriptableobjects
public abstract class Upgrade: MonoBehaviour
{
	public int cost;
}
using UnityEngine;

[CreateAssetMenu]

public class DamageBoost : ScriptableObject
{
    public float damageBoost;

    public void IncreaseDamage(float num)
    {
        damageBoost += num;
    }
}

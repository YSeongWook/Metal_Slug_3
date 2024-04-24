using System;
using UnityEngine;

public class AttackGrenade : MonoBehaviour, IAttack
{
    public ObjectPool projectilePool;
    public AnimationManager animManager;
    private Vector3 initialPosition;
    public string victimTag = "untagged";

    public void Execute(string victimTag, Vector3 dirUnused, Vector3 projInitialPos)
    {
        animManager.StartGrenadeAnim(ThrowItAway);
        initialPosition = projInitialPos;
        this.victimTag = victimTag;
    }

    private void ThrowItAway()
    {
        GameObject grenadeGameObject = projectilePool.GetPooledObject();
        IProjectile grenade = grenadeGameObject.GetComponent<IProjectile>();
        grenadeGameObject.transform.position = initialPosition;
        grenadeGameObject.transform.right = PlayerController.Instance.LookingDirection;
        grenade.Launch(this.victimTag);
    }
}
using UnityEngine;

public class Skeleton : Enemy
{
    #region Constructor

    public Skeleton(string _name, int _health) : base(_name, _health) { }

    #endregion

    #region Methods

    public override void ReceiveDamage(int _damage)
    {
        base.ReceiveDamage(_damage);
        Debug.Log("Skeleton cruje al recibir daño");
    }

    public override void ReceiveDamage(int _damage, string _type)
    {
        Debug.Log("Skeleton fue atacado con tipo " + _type);
        ReceiveDamage(_damage);
    }

    #endregion
}

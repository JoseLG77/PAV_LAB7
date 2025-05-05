using UnityEngine;
using System.Collections.Generic;

public class Goblin : Enemy
{
    #region Constructor

    public Goblin(string _name, int _health) : base(_name, _health) { }

    #endregion

    #region Methods

    public override void ReceiveDamage(int _damage)
    {
        int reducedDamage = (_damage * 8) / 10;
        base.ReceiveDamage(reducedDamage);
        Debug.Log("Goblin redujo el daño a " + reducedDamage);
    }

    public override void ReceiveDamage(int _damage, string _type)
    {
        Debug.Log("Goblin fue atacado con tipo " + _type);
        ReceiveDamage(_damage);
    }

    #endregion
}

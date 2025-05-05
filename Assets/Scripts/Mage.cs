using UnityEngine;

public class Mage : Enemy
{
    #region Constructor

    public Mage(string _name, int _health) : base(_name, _health) { }

    #endregion

    #region Methods

    public override void ReceiveDamage(int _damage)
    {
        int finalDamage = _damage - 5;
        if (finalDamage < 0) finalDamage = 0;

        base.ReceiveDamage(finalDamage);
        Debug.Log("Mage us� barrera m�gica y redujo el da�o a " + finalDamage);
    }

    public override void ReceiveDamage(int _damage, string _type)
    {
        Debug.Log("Mage fue atacado con magia de tipo " + _type);
        ReceiveDamage(_damage);
    }

    #endregion
}

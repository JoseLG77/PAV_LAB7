using UnityEngine;
using System.Collections.Generic;

#region Interfaces

public interface IDamage
{
    void ReceiveDamage(int _damage);
}

#endregion

public class Enemy : MonoBehaviour, IDamage
{
    #region Attributes

    private string enemyName;
    private int health;

    #endregion

    #region Constructor

    public Enemy(string _enemyName, int _health)
    {
        enemyName = _enemyName;
        health = _health;
    }

    #endregion

    #region Getters and Setters

    public string EnemyName => enemyName;
    public int Health => health;

    public void SetHealth(int _health)
    {
        health = _health;
    }

    #endregion

    #region Methods

    public virtual void ReceiveDamage(int _damage)
    {
        if (_damage < 0) _damage = -_damage;

        health = (health - _damage) <= 0 ? 0 : health - _damage;
        Debug.Log(enemyName + " recibió " + _damage + " de daño. Vida restante: " + health);
    }

    public virtual void ReceiveDamage(int _damage, string _type)
    {
        Debug.Log(enemyName + " fue atacado con tipo " + _type);
        ReceiveDamage(_damage);
    }

    #endregion
}
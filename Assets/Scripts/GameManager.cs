using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    #region Attributes

    private Goblin goblin1 = new Goblin("Goblin1", 100);
    private Skeleton skeleton1 = new Skeleton("Skeleton1", 80);
    private Mage mage1 = new Mage("Mage1", 120);

    private List<IDamage> enemyList = new List<IDamage>();

    #endregion

    #region Unity Methods

    void Start()
    {
        AddEnemiesToList();

        SimpleAttacks();
        SpecialAttacks();
    }

    #endregion

    #region Methods

    private void AddEnemiesToList()
    {
        enemyList.Add(goblin1);
        enemyList.Add(skeleton1);
        enemyList.Add(mage1);

        Debug.Log("Enemigos añadidos a la lista.");
    }

    private void SimpleAttacks()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].ReceiveDamage(30);
        }
    }

    private void SpecialAttacks()
    {
        goblin1.ReceiveDamage(25, "Físico");
        skeleton1.ReceiveDamage(40, "Cortante");
        mage1.ReceiveDamage(50, "Fuego");
    }

    #endregion
}
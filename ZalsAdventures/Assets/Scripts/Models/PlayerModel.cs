using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{

    public float hp, mp;
    public int currentLevel, maxLevel;
    public float currentXp;
    public Dictionary<string, WeaponModel> weapons;
    public Dictionary<string, ItemModel> items;
    public int inventoryCount, inventorySize;
    public float movementSpeed;


    public PlayerModel()
    {
        currentLevel = 1;
        currentXp = 0.0f;
        hp = 100 * (currentLevel * 1.2f);
        mp = 20 * (currentLevel * 1.2f);
        //inventoryCount = items.Count;
        inventorySize = 20;
        movementSpeed = 5.0f;
        //weapons.Add("Sword", )
    }



}

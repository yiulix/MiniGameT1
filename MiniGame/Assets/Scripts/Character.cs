using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public bool isPlayer = false;
    public int ID;
    public int health;
    public int defense;
    public int attack;

    public int[] relationships;

    // initialize character attributes by its ID
    public void Init(int ID)
    {
        
    }

    public void TakeDamage()
    {

    }
}

public static class CharactersData
{
    public static Character c0;
    public static Character c1;
    public static Character c2;

}

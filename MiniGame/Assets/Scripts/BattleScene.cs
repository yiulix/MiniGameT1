using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene : MonoBehaviour
{
    int turn = -1; // 0 for c0, 2 for c1, 4 for c2, 1,3,5 for monster
    public Monster monster;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartBattle()
    {
        turn = 0;
    }

    void NextTurn()
    {
        turn += 1;
        if (turn == 6)
        {
            turn = 0;
        }
    }

    void OneTurn()
    {
        if (turn == 0)
        {
            monster.health -= GameData.c0.attack;
        }
        if (turn == 2)
        {
            monster.health -= GameData.c1.attack;
        }
        if (turn == 4)
        {
            monster.health -= GameData.c2.attack;
        }
        //monster attack
        else
        {

        }

        if (monster.health <= 0)
        {
            BattleWin();
        }
        NextTurn();
    }

    void GenerateMonster()
    {

    }

    void BattleWin()
    {

    }

    void BattleLose()
    {

    }
}

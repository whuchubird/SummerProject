using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testWeapon2 : Weapon
{
    private void Awake() // 무기 스탯 초기화
    {
        name = "test weapon 2";
        attackSpeed = 1.5f;
        attackNum = 3;

        curAttackSpeed = attackSpeed;
        curAttackNum = attackNum;
    }
}

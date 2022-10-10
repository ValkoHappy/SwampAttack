using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        for(int i = 0; i < Bullet.Count; i++)
        {
            Instantiate(Bullet[i], shootPoint.position, Quaternion.identity);
        }
    }
}

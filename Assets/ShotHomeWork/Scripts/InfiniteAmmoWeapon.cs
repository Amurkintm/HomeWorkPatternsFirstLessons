using System.Collections.Generic;
using UnityEngine;

public class InfiniteAmmoWeapon : Weapon
{    
    [SerializeField] private List<Transform> _bulletPoints;    
    public override void Shoot()
    {
        CreateBullet(_bulletPoints);        
        Debug.Log("Выстрел! Патроны бесконечны.");
    }
    protected override void CreateBullet(List<Transform> transforms)
    {
        base.CreateBullet(transforms);
    }
}

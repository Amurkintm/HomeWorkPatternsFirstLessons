using System.Collections.Generic;
using UnityEngine;

public class InfiniteAmmoWeapon : Weapon
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private List<Transform> _bulletPoints;    
    public override void Shoot()
    {
        CreateBullet(_bullet, _bulletPoints);        
        Debug.Log("Выстрел! Патроны бесконечны.");
    }
    protected override void CreateBullet(Bullet bullet, List<Transform> transforms)
    {
        base.CreateBullet(bullet, transforms);
    }
}

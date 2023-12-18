using System.Collections.Generic;
using UnityEngine;

public class MultiShotWeapon : Weapon
{
    [SerializeField] private int _ammo;    
    [SerializeField] private List<Transform> _bulletPoints;
    public override void Shoot()
    {
        if (_ammo >= 3)
        {
            _ammo -= 3;
            CreateBullet(_bulletPoints);
            Debug.Log("Три выстрела! Осталось патронов: " + _ammo);
        }
        else
        {
            Debug.Log("Недостаточно патронов для мультивыстрела!");
        }
    }
    protected override void CreateBullet(List<Transform> transforms)
    {
        base.CreateBullet(transforms);
    }
}

using System.Collections.Generic;
using UnityEngine;

public class SingleShotWeapon : Weapon
{
    [SerializeField] private int _ammo;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private List<Transform> _bulletPoints;
    public override void Shoot()
    {
        if (_ammo > 0)
        {
            _ammo--;
            CreateBullet(_bullet, _bulletPoints);
            Debug.Log("Выстрел! Осталось патронов: " + _ammo);
        }
        else
        {
            Debug.Log("Нет патронов!");
        }
    }
    protected override void CreateBullet(Bullet bullet, List<Transform> transforms)
    {
        base.CreateBullet(bullet, transforms);
    }
}

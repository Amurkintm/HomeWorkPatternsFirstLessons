using System.Collections.Generic;
using UnityEngine;

public class MultiShotWeapon : Weapon
{
    [SerializeField] private int _ammo;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private List<Transform> _bulletPoints;
    public override void Shoot()
    {
        if (_ammo >= 3)
        {
            _ammo -= 3;
            CreateBullet(_bullet, _bulletPoints);
            Debug.Log("��� ��������! �������� ��������: " + _ammo);
        }
        else
        {
            Debug.Log("������������ �������� ��� ��������������!");
        }
    }
    protected override void CreateBullet(Bullet bullet, List<Transform> transforms)
    {
        base.CreateBullet(bullet, transforms);
    }
}

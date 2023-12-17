using System.Collections.Generic;
using UnityEngine;

public class MultiShotWeapon : Weapon
{
    [SerializeField] private int Ammo;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private List<Transform> _bulletPoints;
    public override void Shoot()
    {
        if (Ammo >= 3)
        {
            Ammo -= 3;
            CreateBullet();
            Debug.Log("Три выстрела! Осталось патронов: " + Ammo);
        }
        else
        {
            Debug.Log("Недостаточно патронов для мультивыстрела!");
        }
    }
    private void CreateBullet()
    {
        for (int i = 0; i < _bulletPoints.Count; i++)
        {
            Instantiate(_bullet, _bulletPoints[i].position, Quaternion.identity);
        }
    }
}

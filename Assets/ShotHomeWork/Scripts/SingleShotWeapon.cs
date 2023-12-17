using UnityEngine;

public class SingleShotWeapon : Weapon
{
    [SerializeField] private int Ammo;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletPoints;
    public override void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
            CreateBullet();
            Debug.Log("Выстрел! Осталось патронов: " + Ammo);
        }
        else
        {
            Debug.Log("Нет патронов!");
        }
    }
    private void CreateBullet()
    {
        Instantiate(_bullet, _bulletPoints.position, Quaternion.identity);
    }
}

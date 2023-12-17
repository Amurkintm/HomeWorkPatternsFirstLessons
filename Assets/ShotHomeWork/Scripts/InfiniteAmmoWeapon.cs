using UnityEngine;

public class InfiniteAmmoWeapon : Weapon
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletPoints;
    public override void Shoot()
    {
        CreateBullet();
        Debug.Log("Выстрел! Патроны бесконечны.");
    }
    private void CreateBullet()
    {        
        Instantiate(_bullet, _bulletPoints.position, Quaternion.identity);        
    }
}

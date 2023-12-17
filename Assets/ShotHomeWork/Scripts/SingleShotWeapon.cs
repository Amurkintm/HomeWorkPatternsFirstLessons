using UnityEngine;

public class SingleShotWeapon : Weapon
{
    [SerializeField] private int _ammo;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletPoints;
    public override void Shoot()
    {
        if (_ammo > 0)
        {
            _ammo--;
            CreateBullet();
            Debug.Log("�������! �������� ��������: " + _ammo);
        }
        else
        {
            Debug.Log("��� ��������!");
        }
    }
    private void CreateBullet()
    {
        Instantiate(_bullet, _bulletPoints.position, Quaternion.identity);
    }
}

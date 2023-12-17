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
            Debug.Log("�������! �������� ��������: " + Ammo);
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

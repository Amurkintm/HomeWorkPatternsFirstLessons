using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _weaponModel;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _destroyBulletTimer;
    [SerializeField] protected Bullet _bullet;
    public abstract void Shoot();
    public void Equip(Transform hand)
    {
        _weaponModel.transform.SetParent(hand);
        _weaponModel.transform.localPosition = Vector3.zero;
        _weaponModel.transform.localRotation = Quaternion.identity;       
    }
    protected virtual void CreateBullet(List<Transform> transforms)
    {       
        for (int i = 0; i < transforms.Count; i++)
        {
            Bullet newBullet = Instantiate(_bullet, transforms[i].position, Quaternion.identity);
            newBullet.Launch(_bulletSpeed, _destroyBulletTimer);
        }
    }
}


using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _weaponModel;    
    public abstract void Shoot();
    public void Equip(Transform hand)
    {
        _weaponModel.transform.SetParent(hand);
        _weaponModel.transform.localPosition = Vector3.zero;
        _weaponModel.transform.localRotation = Quaternion.identity;       
    }
}

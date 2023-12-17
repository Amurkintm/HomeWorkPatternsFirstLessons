using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject WeaponModel;    
    public abstract void Shoot();
    public void Equip(Transform hand)
    {
        WeaponModel.transform.SetParent(hand);
        WeaponModel.transform.localPosition = Vector3.zero;
        WeaponModel.transform.localRotation = Quaternion.identity;       
    }
}

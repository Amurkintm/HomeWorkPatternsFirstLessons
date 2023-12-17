using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _handTransform;
    [SerializeField] private Weapon[] _weapons;
    private int _currentWeaponIndex;

    private void Start()
    {
        _currentWeaponIndex = 0;
        foreach (Weapon weapon in _weapons)
        {
            weapon.Equip(_handTransform);
            weapon.gameObject.SetActive(false);
        }
        _weapons[_currentWeaponIndex].Equip(_handTransform);
        _weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _weapons[_currentWeaponIndex].Shoot();
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            SwitchWeaponForword();
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            SwitchWeaponBackward();
        }

    }

    private void SwitchWeaponForword()
    {
        _weapons[_currentWeaponIndex].gameObject.SetActive(false);
        _currentWeaponIndex = (_currentWeaponIndex + 1) % _weapons.Length;
        _weapons[_currentWeaponIndex].Equip(_handTransform);
        _weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }
    private void SwitchWeaponBackward()
    {
        _weapons[_currentWeaponIndex].gameObject.SetActive(false);
        _currentWeaponIndex--;
        if (_currentWeaponIndex < 0)
        {
            _currentWeaponIndex = _weapons.Length - 1;
        }
        _weapons[_currentWeaponIndex].Equip(_handTransform);
        _weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }
}

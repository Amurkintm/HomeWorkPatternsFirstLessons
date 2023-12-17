using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform HandTransform;
    [SerializeField] private Weapon[] Weapons;
    private int _currentWeaponIndex;

    private void Start()
    {
        _currentWeaponIndex = 0;
        foreach (Weapon weapon in Weapons)
        {
            weapon.Equip(HandTransform);
            weapon.gameObject.SetActive(false);
        }
        Weapons[_currentWeaponIndex].Equip(HandTransform);
        Weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Weapons[_currentWeaponIndex].Shoot();
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
        Weapons[_currentWeaponIndex].gameObject.SetActive(false);
        _currentWeaponIndex = (_currentWeaponIndex + 1) % Weapons.Length;
        Weapons[_currentWeaponIndex].Equip(HandTransform);
        Weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }
    private void SwitchWeaponBackward()
    {
        Weapons[_currentWeaponIndex].gameObject.SetActive(false);
        _currentWeaponIndex--;
        if (_currentWeaponIndex < 0)
        {
            _currentWeaponIndex = Weapons.Length - 1;
        }
        Weapons[_currentWeaponIndex].Equip(HandTransform);
        Weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }
}

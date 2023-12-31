using UnityEngine;

public class Bullet : MonoBehaviour
{
    //[SerializeField] private float _bulletSpeed = 200f; 
    //private void Start()
    //{
    //    gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * _bulletSpeed, ForceMode.Impulse);
    //    Destroy(gameObject,1.5f);
    //}
    public void Launch(float bulletSpeed,float timerToDestroy)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, timerToDestroy);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float i = 0.05f; // projectile destruction delay
    private float _speed;

    public float Speed { get => _speed; set => _speed = value; }
    public GameObject Target;
    public Tower Tower;
    

    void Update() // переделаю в корутин позже
    {
        if (Target)
        {
            transform.LookAt(Target.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * _speed);
        }
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Target)
        {
            other.GetComponent<IEnemy>().GetDamge(Tower.Damage);
            Destroy(gameObject, i);
        }    
    }
}

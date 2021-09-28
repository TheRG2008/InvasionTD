using UnityEngine;
using System.Collections;

public class EnemyVitaly : MonoBehaviour, IDamageable 
{

    public float Speed;
    public Transform[] waypoints;
    int curWaypointIndex = 0;
    private int hp;
    public int Hp 
    {
        get => hp;
        set 
        {
            hp = value;
            if (hp <= 0) 
            {
                Speed = 0;
                Destroy(gameObject, 5f);
  
            } 
        } 
    }
    

    void Start()
    {
        //StartCoroutine(MoveFromTo(1f));
    }  

    public void GetDamage(int damage)
    {
        Hp -= damage;
    }
    


    //Пока функция движения находится в апдейте
    void Update () 
	{
         if (curWaypointIndex < waypoints.Length)
         {
            transform.position = Vector3.MoveTowards(transform.position,waypoints[curWaypointIndex].position,Time.deltaTime*Speed);

            transform.LookAt(waypoints[curWaypointIndex].position);

            if (Vector3.Distance(transform.position,waypoints[curWaypointIndex].position) < 0.5f)
             {
                 curWaypointIndex++;
             }    
         }          
    }


    //Также сделал 2 функции движения через корутин, но работают как то криво. Движение не равномерное и ускоряется к концу

    IEnumerator Move1()
    {
        if (curWaypointIndex < waypoints.Length)
        {
            for (float i = 0; i < 1f; i += Time.deltaTime)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[curWaypointIndex].position, i);

                transform.LookAt(waypoints[curWaypointIndex].position);
                
                if (Vector3.Distance(transform.position, waypoints[curWaypointIndex].position) < 0.5f)
                {
                    curWaypointIndex++;
                }

                yield return null;
            }
        }  
    }


    IEnumerator Move2()
    {
        float step = Speed / (transform.position - waypoints[curWaypointIndex].position).magnitude * Time.fixedDeltaTime;
        float t = 0;
        while (t <= 1.0f)
        {
            t += step; // Goes from 0 to 1, incrementing by step each time
            transform.position = Vector3.MoveTowards(transform.position, waypoints[curWaypointIndex].position, t); // Move objectToMove closer to b
            transform.LookAt(waypoints[curWaypointIndex].position);
            if (Vector3.Distance(transform.position, waypoints[curWaypointIndex].position) < 0.5f)
            {
                curWaypointIndex++;
                t = 0;
            }
            yield return new WaitForFixedUpdate();         // Leave the routine and return here in the next frame
        }
    
    }


    

}


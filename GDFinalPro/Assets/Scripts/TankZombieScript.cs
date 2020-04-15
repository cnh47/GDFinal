using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankZombieScript : MonoBehaviour
{
    private Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;

    private int HitCount = 0;
    public int HP = 5;
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>()){
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            Debug.Log("T Found Target");
        }else{
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        Destroy(collision.gameObject);
        HitCount++;
        if (HitCount == HP){
            Destroy(gameObject);
            ScoreScript.scoreValue += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.PlayerAlive){
            //rotate to look at the player
            transform.LookAt(target.position);
            //correcting the original rotation
            transform.Rotate(new Vector3(0,-90,0),Space.Self);

            //move towards the player if distance from target is greater than 1
            if (Vector3.Distance(transform.position,target.position)>1f) {
              transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
            }
        }else{
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D bounce;
    
    void Start()
    {
        bounce = GetComponent<Rigidbody2D>();
        bounce.AddForce(Vector3.up * 320);
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.CompareTag("ball")){
            GameState.Instance.IncreaseScore(1); 
            Destroy(other.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("end")){
            GameState.Instance.InititateGameOver();
        }
    }
    // Update is called once per frame
    
}

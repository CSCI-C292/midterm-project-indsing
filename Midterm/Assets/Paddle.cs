using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float _speed;
    public float _maxVal; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // need to stop the paddle from leaving the screen 
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * direction  * Time.deltaTime * _speed);
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -_maxVal, _maxVal);
        transform.position = position;
            
    

    }
}

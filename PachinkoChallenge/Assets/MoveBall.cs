using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    //public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Vector3 position = this.transform.position; 
            position.x--; 
            this.transform.position = position; 
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Vector3 position = this.transform.position; 
            position.x++; 
            this.transform.position = position; 
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Physics2D.gravity = new Vector2(0,-9.8f);
        }
    }
}

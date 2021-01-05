using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPBoxmove : MonoBehaviour
{
    Rigidbody2D Boxs;
    


    // Start is called before the first frame update
    void Start()
    {
        
        Boxs = GetComponent<Rigidbody2D>();        

    }

    public void Leftmove()
    {
        transform.Translate(Vector2.left * 2 * Time.deltaTime);        
    }

    public void Restart()
    {
        transform.position = new Vector3(0, 0 , -1);
    }
    
     

    // Update is called once per frame
    void Update()
    {
        Leftmove();

        if (transform.position.x <= -4f)            
        {
            transform.position = new Vector2(9, 0);
        }

    }
}

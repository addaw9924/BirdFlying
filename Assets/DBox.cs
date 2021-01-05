using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBox : MonoBehaviour
{
    //테스트용 코드 입니다 
    Rigidbody2D Boxs;
    // Start is called before the first frame update
    void Start()
    {
        Boxs = GetComponent<Rigidbody2D>();
    }


    public void Restart()
    {
        transform.position = new Vector3(3, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

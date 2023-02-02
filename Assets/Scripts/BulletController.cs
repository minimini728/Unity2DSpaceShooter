using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {   
        if(this.transform.position.y >= 2)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(this.transform.up * 1f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Ãæµ¹");
            Destroy(this.gameObject);
        }
    }

}

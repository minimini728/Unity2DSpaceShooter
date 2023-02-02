using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumEnemyController : MonoBehaviour
{
    Animator anim;
    private bool isDie = false;
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (isDie == false)
        {
            StartCoroutine("Move");
        }
        else
        {
            StopAllCoroutines();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Debug.Log("Ãæµ¹");
            isDie = true;
            anim.SetBool("isDie", true);
            Invoke("Destory", 0.5f);

        }
    }

    void Destory()
    {
        //Debug.Log("ÆÄ±«µÊ");
        Destroy(this.gameObject);
    }
    IEnumerator Move()
    {
        yield return null;

        if (this.transform.position.y <= -2)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(-this.transform.up * 1f * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    public GameObject bulletPrefab;
    private float bulletSpeed = 5f;
    public bool isDie;
    Animator anim;
    public System.Action onDie;


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

    void Shoot()
    {
        //총알발사
        var go = Instantiate(this.bulletPrefab, this.transform.position, this.bulletPrefab.transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("충돌");
            onDie();
            isDie = true;
            anim.SetBool("isDie", true);
            Invoke("Destory", 0.5f);
        }
    }
    void Destory()
    {
        //Debug.Log("파괴됨");
        Destroy(this.gameObject);
    }
    IEnumerator Move()
    {
        yield return null;

        var dirx = Input.GetAxisRaw("Horizontal");
        var diry = Input.GetAxisRaw("Vertical");
        var dir = new Vector3(dirx, diry, 0);

        //이동: 방향 * 속도 * 시간
        this.transform.Translate(dir.normalized * 1f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

}

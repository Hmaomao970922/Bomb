using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody rBody;
    private Animation ani;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        ani = GetComponent<Animation>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player==null)
        {
            return;
        }
        float dis = Vector3.Distance(transform.position, player.position);
        if(dis<2f)
        {
            //杀死玩家
            Destroy(player.gameObject);
            //站立
            ani.Play("idle");
        }
        else if(dis<5)
        {
            //朝向玩家
            transform.LookAt(player.position);
            //追击玩家
            rBody.velocity = transform.forward * 2;
            ani.Play("move");       
        }
        else
        {
            //待机
            ani.Play("idle");
        }
    }
}

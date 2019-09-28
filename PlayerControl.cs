using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rBody;
    private Animation ani;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //垂直轴
        float vertical = Input.GetAxis("Vertical");
        //水平轴
        float horizontal = Input.GetAxis("Horizontal");
        //方向
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if(dir != Vector3.zero)
        {
            //改变方向
            transform.rotation = Quaternion.LookRotation(dir);
            //移动
            rBody.velocity = dir * 3;
            //移动动画
            ani.Play("run");

        }
        else
        {
            ani.Play("idle");
        }
    }
}

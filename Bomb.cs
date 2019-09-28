using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //爆炸效果
    public GameObject BombEffectpre;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //爆炸触发
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="enemy"||other.tag=="Player")
        {
            //播放爆炸声音
            AudioManager.Instance.PlayBomb();
            //爆炸效果
            Instantiate(BombEffectpre,transform.position,Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public PlayerView BirdScript;
    
    public GameObject Borular;

    public float height;

    public float time;

    private float _Pozitiveheight = 0.6f;

    private float _Negativeheight = -0.5f;
    private void Start()
    {

        StartCoroutine(SpawnObject(time));
       
    }

    
    



    public IEnumerator SpawnObject(float time)
    {
        //borularýn aralýk yüksekliklerinin random çýkmasýný saðlýyor
        while (!BirdScript.isDead)
        {
            Instantiate(Borular, new Vector3(1.5f, Random.Range(_Negativeheight, _Pozitiveheight), 0), Quaternion.identity);
            
            yield return new WaitForSeconds(time);
        }
        
    }
}

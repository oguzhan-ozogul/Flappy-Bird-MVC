using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float BoruSpeed;

    private void Start()
    {
        //7 saniye sonra ilk ��kan boruyu yok etme
        Destroy(gameObject, 7);
    }

    private void FixedUpdate()
    {
        //Borunun sola do�ru gitmesi
        transform.position += Vector3.left * BoruSpeed * Time.deltaTime;
    }
}

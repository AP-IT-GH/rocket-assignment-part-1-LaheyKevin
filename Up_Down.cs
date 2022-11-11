using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Down : MonoBehaviour
{
    public float speed = 1f;
    public float heigtdif = 1f;
    private float i = 0;
    private float startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        i = Mathf.PingPong(Time.time * speed, 1)*heigtdif+startpos;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, i, gameObject.transform.position.z);
    }
}

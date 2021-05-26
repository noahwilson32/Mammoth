using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rg;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        if(Input.GetAxisRaw("Horizontal") > 0.1f || Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            pos.x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
            transform.Translate(pos);
        }
    }
}

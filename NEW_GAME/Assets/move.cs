using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed ;
    public AudioClip run;
    public AudioSource Daudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    ///移動///
    void Movement()
    { float horizontalmove= Input.GetAxis("Horizontal");
  float facedircetion =Input.GetAxisRaw("Horizontal");
if (horizontalmove !=0)
{
    rb.velocity = new Vector2(horizontalmove*speed,rb.velocity.y);
     this.gameObject.transform.position +=new Vector3(0.1f,0,0);
    transform.localScale =new Vector3(5,5,5);
    }
  
else
{
    this.gameObject.transform.position +=new Vector3(0.1f,0,0);
transform.localScale =new Vector3(-5,5,5);
}
 }
}

    



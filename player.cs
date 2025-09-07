using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody _rb;

    

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            gameObject.SetActive(false);
        }
        if (other.CompareTag("collectible"))
        {
            other.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5; 
        }
        else
            speed = 2;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if(Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        _rb.linearVelocity = direction.normalized * speed;
        







    }


    }


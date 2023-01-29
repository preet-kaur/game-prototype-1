using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    private float horizontal;
    private float speed = 16f;
    Vector3 defaultPos;

    [SerializeField] private Rigidbody2D rb;        //rigid body comp of player

    void Start()
    {
        defaultPos = transform.position;
    }

    // Update is called once per frame
    public void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //returns 1,0,-1 depending on direction the player is moving

    }

    private void FixedUpdate()
    {
        //Smooth left & right movement - use speed
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);   //set speed of rigid body of player for horizontal mvmt
    }

    public GameObject[] playerGameObjList;

    void Awake()
    {
        playerGameObjList = GameObject.FindGameObjectsWithTag("Player");
        if (playerGameObjList.Length > 1)
        {
            Destroy(this.gameObject);
        }
        Debug.Log("length: " + playerGameObjList.Length);
        DontDestroyOnLoad(this.gameObject);
    }

    public void resetPosition()
    {
        transform.position = defaultPos;
    }


}

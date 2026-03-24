using UnityEngine;

public class PlayerMovemont : MonoBehaviour
{
    public float moveSpeed = 5.0f;             //이속변수 설정
    public float jumpForce = 5.0f;

    public Rigidbody rb;                       // 플레이어 강체 선언

    public bool isGrounded = true;

    public int coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //움직임 입력
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveHortical = Input.GetAxis("Vetical");


        rb.linearVelocity = new Vector3(moveHorizontal * moveSpeed, rb.linearVelocity.y, moveHortical * moveSpeed);

        if (Input.GetButtonDown("Jump") &&  isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded =  false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

    }




    private void OnTriggerEnter(Collider cther)
    {
        if (cther.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(cther.gameObject);
        }
    }

    
}

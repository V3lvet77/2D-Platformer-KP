using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMotor : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rigidbody2D;
    public float speed = 6;
    public float jumpForce = 7;
    private bool canJump = true;
    public float maxSpeed = 14;
    public float stoppingForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        // Dodaæ prêdkoœæ poruszania sie
        rigidbody2D.AddForce(new Vector2(direction.x * speed, 0));
        //   transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * speed;

        ZatrzymywanieAndMaxSpeed();

    }

    private void ZatrzymywanieAndMaxSpeed()
    {
        if (direction.x != 0)
        {
            rigidbody2D.AddForce(new Vector2(direction.x * speed, 0));
        }
        else if (rigidbody2D.linearVelocityX != 0)
        {
            //zatrzymywanie
            rigidbody2D.AddForce(new Vector2(-rigidbody2D.linearVelocityX * stoppingForce, 0));
        }

        if (rigidbody2D.linearVelocityX >= maxSpeed)
        {
            rigidbody2D.linearVelocityX = maxSpeed;
        }
        else if (rigidbody2D.linearVelocityX <= -maxSpeed)
        {
            rigidbody2D.linearVelocityX = -maxSpeed;
        }
    }

    private void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }

    private void OnJump()
    {
        CzyMozeSkakac();
    }

    private void CzyMozeSkakac()
    {
        if (canJump)
        {
            //w=0,1
            //Vector2.up=0,1
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //stworzyæ now¹ zmienn¹ o typie float (podobnie jak speed)
            //podmieniæ 10 na wasz¹ zmienn¹
            canJump = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;

    }
}

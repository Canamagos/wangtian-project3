using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 6f;
    public float sprintSpeed = 10f;
    public float jumpHeight = 1.2f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    private int jumpCount = 0;
    private int maxJumpCount = 2; // ������

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. ������
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            jumpCount = 0; // ������Ծ����
        }

        // 2. �����ƶ�����
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // 3. �ж��Ƿ�ס��̼���Shift��
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;

        controller.Move(move * currentSpeed * Time.deltaTime);

        // 4. ��Ծ
        if (Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpCount++;
        }

        // 5. Ӧ������
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}

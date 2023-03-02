using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool canRun = true;
    public bool isRunning;
    public float runSpeed = 9f;
    float targetMovingSpeed;

    public KeyCode runningKey = KeyCode.LeftShift;

    private Rigidbody playerRigidbody;

    void Awake()
    {
        //��������� ������ �� ��������� Rigidbody �������, � �������� ��������� ���� ������ 
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        //�������� ������ � ������ ����
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        //�������� ����, ��� �������� ���� �������� � ����� ����� Shift
        //�������� ������: IsRunning = canRun && Input.GetKey(runningKey);
        if (canRun && Input.GetKey(runningKey))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        //���������� ������� �������� � ����������� �� ������������ �������
        //�������� ������: targetMovingSpeed = isRunning ? runSpeed : speed;
        if (isRunning)
        {
            targetMovingSpeed = runSpeed;
        }
        else
        {
            targetMovingSpeed = speed;
        }

        //���������� ��������
        playerRigidbody.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y,
             Input.GetAxis("Vertical") * targetMovingSpeed);

        //������� ������� �� �����
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
    }
}
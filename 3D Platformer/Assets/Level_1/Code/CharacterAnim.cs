using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash;

    void Start()
    {
        //�������� id ������ ���������� � ��� �� ��������� ����� �� �� �����
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        //�������� �� id ���������� �� ������ ��������
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        //�������� ������ �������� ���������� �������� ����� ������
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        //���� ����� �� ��� � ������ ������� W, �� �������� �������� ������
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        //���� ����� ��� � �� ������ ������� W, �� ��������� �������� ������
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        //���� ����� �� ����� � ������ ����� ���� � W, �� �������� �������� ����
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        //���� ����� ����� � �� ����� ����� ���� ��� W, �� ��������� �������� ����
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}

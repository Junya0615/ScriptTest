using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // �̗�
    private int power = 25; // �U����
    private int mp = 53; // �}�W�b�N�|�C���g

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // ���@�U���p�̊֐�
    public void Magic()
    {
        if (this.mp >= 5)
        {
            // �c��mp��5���炷
            this.mp -= 5;

            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        } else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        // �v�f��5�̔z���錾
        int[] array = new int[5];

        // �z���������
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        // ���Ԃɕ\��
        for (int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }

        // �t���ɕ\��
        for (int i = array.Length - 1; i >= 0;i--)
        {
            Debug.Log(array[i]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        // ���@�U����11��Ăяo��
        for (int i = 0;i < 11;i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
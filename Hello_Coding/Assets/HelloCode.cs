using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // ĳ������ �������� ������ �����
        string characterName = "���";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;

        // ������ ������ �ֿܼ� ���
        Debug.Log("ĳ���� �̸� : " + characterName);
        Debug.Log("������ : " + bloodType);
        Debug.Log("���� : " + age);
        Debug.Log("Ű : " + height);
        Debug.Log("�����ΰ�? : " + isFemale);
    }

}

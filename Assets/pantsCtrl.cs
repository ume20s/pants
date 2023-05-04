using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantsCtrl : MonoBehaviour
{
    // �^�b�v�\�t���O
    static bool isTappable;

    // �����֘A
    AudioSource audioSource;
    public AudioClip sePants;

    // �Q�[���I�u�W�F�N�g
    GameObject pants;
    GameObject click;

    // Start is called before the first frame update
    void Start()
    {
        // �����̃R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();

        // �I�u�W�F�N�g�̎擾
        pants = GameObject.Find("pants");
        click = GameObject.Find("click");

        // �^�b�v�\�ɂ��ďI��
        isTappable = true;
    }

    // �^�b�v������
    public void onClick()
    {
        // �^�b�v�\��������
        if (isTappable)
        {
            // click���\����
            click.SetActive(false);

            // ���ʉ�
            audioSource.PlayOneShot(sePants);

            // �p���c�̈ړ��֐��R�[��
            StartCoroutine("pantsMove");

            // �^�b�v�s�ɂ��ďI��
            isTappable = false;
        }
    }

    // �p���c�̈ړ�
    IEnumerator pantsMove()
    {
        for (int i = 0; i < 10; i++)
        {
            pants.transform.Translate(-0.752f, -0.05f, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
}

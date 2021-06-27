using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region//�C���X�y�N�^�[�Őݒ肷��
    [Header("�ړ����x")] public float speed;
    #endregion
    //�v���C�x�[�g�ϐ�
    private Animator anim = null;       //�A�j���[�V�������䎞�ɕK�v
    private Rigidbody2D rb = null;
    private string enemyTag = "Enemy";
    private string itemTag = "Item";    //�A�C�e���ƐڐG�������ɃA�C�e�����������p

    void Start()
    {
        //�R���|�[�l���g�̃C���X�^���X��߂܂���
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //�L�[���͂��ꂽ��s������
        float verticalKey = Input.GetAxis("Vertical");
        float xSpeed = GetXSpeed();
        float ySpeed = 0.0f;

        //�ړ�
        if (verticalKey > 0)
        {
            ySpeed = speed;
        }
        else if (verticalKey < 0)
        {
            ySpeed = -speed;
        }
        else
        {
            ySpeed = 0.0f;
        }
        rb.velocity = new Vector2(xSpeed, ySpeed);
    }

    /// <summary> 
    /// X�����ŕK�v�Ȍv�Z�����A���x��Ԃ��B 
    /// </summary> 
    /// <returns>X���̑���</returns> 
    private float GetXSpeed()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float xSpeed;

        if (horizontalKey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);    //�摜�̌���
            xSpeed = speed;
        }
        else if (horizontalKey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);   //�摜�̌������]
            xSpeed = -speed;
        }
        else
        {
            xSpeed = 0.0f;
        }
        return xSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == itemTag)
        {
            Debug.Log("�A�C�e���ƐڐG�����I");
            //�����ŁASaveData��

            //���A�C�e����������Ƃ�������̓A�C�e�����g�ɂ���Ă��炤
            ObjectCollision o = collision.gameObject.GetComponent<ObjectCollision>();

            if(o != null)
            {
                //���Վ�
                //saveData�ɒ��ڋL������
                GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().save.playerStatus.HP += 100;

                //�A�C�e���폜�w��
                o.playerTouchOn = true;

                //
                GameObject.FindWithTag("GameManager").GetComponent<SceneStage1>().Reload();
            }
            else
            {
                Debug.Log("�A�C�e���ɐG��Ă邯�ǁAObjectCollision�����݂��Ȃ�");
            }
        }
    }
}

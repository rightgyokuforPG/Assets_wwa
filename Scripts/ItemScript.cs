using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] Item.Type itemType;

    [SerializeField]
    int ItemID;
    void Start()
    {
        //itemType�ɉ�����Item�𐶐�����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�擾���������
    public void OnTouchObj()
    {
        //�A�C�e�����擾�ς݂ɂ���
        //�v���C���[�̃X�e�[�^�X��ʂ��ĕ\������

        this.gameObject.SetActive(false);
    }
}

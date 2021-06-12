using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    // �񋓌^�F��ނ�񋓂���
    public enum Type
    {
        One,    //�ő�HP�̏�����㏸������A�C�e��
        Two,    //HP���񕜂�����A�C�e��
        Three,  //ATK�𑝉�������A�C�e��
        Four,   //DEF�𑝉�������A�C�e��

    }

    public Type type;       //���
    public Sprite sprite;   //Slot�ɕ\������摜

    [SerializeField]
    int ItemID;

    /// <summary>
    /// �A�C�e���������Ȃ���
    /// </summary>
    public Item()
    {

    }

    /// <summary>
    /// �A�C�e���������K��Type��sprite���擾����
    /// </summary>
    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}









//��WeaponListEntity ����̎�ނ��Ǘ�����z
//��PlayerListEntity �v���C���[���������Ă��镨���Ǘ�����z
//��EnemyListEntity  �G�̏����Ǘ�����z�i�Ȃ񂩎�ނ��Ǘ����邾���ł���/���Ȃ��Ǘ��o���Ȃ������j
//��FlagListEntity   �V�i���I�i�s�t���O�₨�ז�NPC�̏o���t���O���Ǘ�����z

//��EnemyExistFlagListEntity �G�̓|�������ǂ������Ǘ�����z
//  {�ǂ̃X�e�[�W�� �ǂ̎�ނ� �ǂ�ID��}

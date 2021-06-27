using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �t���O�N���X�̐e�N���X
/// EnemyFlag��ItemFlag�AProgressParamFlag�ɔh������ <-�H�������Ă邩�s��w
/// </summary>
[System.Serializable]
public class Flag 
{
    // �񋓌^�F��ނ�񋓂���
    public enum Type
    {
        _bool,    //bool�^�̃t���O
        _int,    //int�^�̃t���O
        _string,  //string�^�̃t���O

    }

    public Type type;       //���

    bool _boolFlag;
    int _intFlag;
    string _stringFlag;

    /// <summary>
    /// �A�C�e���������Ȃ���
    /// </summary>
    public Flag()
    {

    }

    /// <summary>
    /// �A�C�e���������K��Type���擾����
    /// </summary>
    public Flag(Type type)
    {
        this.type = type;
    }
}


//Flag.cs�́A�����̃N���X�݌v�}
//�C���X�^���X��������Type�ɂ���ĕϐ��̌^��ύX������
//�������炭�A�f�[�^get,set���ɂǂ̕ϐ��Ɋi�[���邩��type�ŕ�����΍s����͂�
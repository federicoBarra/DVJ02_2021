using System;
using DVJ02.Semana11;
using UnityEngine;

public class TestSerialization : MonoBehaviour
{
    [Serializable]
    public class AlgunaData
    {
        public ItemSO itemData;
        public Sprite spriteLoco;

        public int spriteID;
    }

    public AlgunaData data;

    // Start is called before the first frame update
    void Start()
    {
        string pepe = JsonUtility.ToJson(data);

        Debug.Log(pepe);
    }

}

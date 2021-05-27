using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseChaibon : ClaseEntity
{
    public class ClaseLoca
    {
        private int a;

        //public static ClaseLoca operator !(ClaseLoca b)
        //{
        //    
        //}
    }

    private Vector2 GetPosition
    {
        get { return transform.position; }
    }

    public ClaseLoca cl;

    [SerializeField]
    private Rigidbody rig;
    private BoxCollider col;
    void Start()
    {
        Debug.Log("Layer: " + gameObject.layer);

        //10
        //00000000000000000000000000001010 >> 1
        //5
        //00000000000000000000000000000101
        //2
        //00000000000000000000000000000010

        int valor = 10;

        valor = valor >> 1;

        //GameManagerSingletonizado.Get()

        Validate();
    }

    void Validate()
    {
        //if (!cl)
        //{
        //    Debug.Log("Pepe");
        //}

        if (!rig) // es igual a -> if (rig == null)
            rig = GetComponent<Rigidbody>();

        //if (!rig)
        //{
        //    Debug.LogError("NO hay rigidbody, todo mal che");
        //    Debug.Break();
        //}

        if (!col)
            col = GetComponent<BoxCollider>();
    }

    public override void MeMori()
    {
        base.MeMori();
    }

    //Esto se llamo antes de que se llame el start de este Game Object, supongamos que se llama desde el Awake del GameManager
    public void InicializarPersonaje(int peso) 
    {
        Validate();
        rig.mass = peso;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //asjkd asd  + 
            //as dasd 
            Move(1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //asjkd asd  - 
            //as dasd 
            Move(-1);
        }
    }

    public LayerMask layer;

    void Move(int direction)
    {
        //gameObject.layer = 1<<3;



        //asjkd asd * Math.sign(direction)
        ////as dasd 
    }
}

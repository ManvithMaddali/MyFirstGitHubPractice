

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_items : MonoBehaviour
{
    public GameObject pen;

    private bool is_created = false;

    private bool compare = true;

    public static int DiamondCount;

    private int My_Gem_Count = 0;

    private GameObject InstantiatedObj;

    private float GEMS;

    private int compare_value = 0;

    // Start is called before the first frame update
    void Start()
    {
        DiamondCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnGem", 2f, 4f);
        //AliveOrDead();

    }
    void SpawnGem()
    {
        GEMS = Random.Range(-42.67f, 42.67f);
        GEMS += 2;
        if (!is_created)
        {
            Instantiate(pen, new Vector3(GEMS, 0, 0), Quaternion.identity);
            My_Gem_Count += 1;
            is_created = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            Debug.Log("Collided");
        }
    }
}

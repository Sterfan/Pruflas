using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChange : MonoBehaviour
{

    private SpriteRenderer spriteRenderer; 
    public Sprite ShipFire;
    public Sprite ShipWind;
    public Sprite ShipEarth;
    public Sprite ShipWater;
    int spriteVersion = 0;

    private Sprite[] sprites = new Sprite[4];

    void Start()
    {

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        sprites[0] = ShipFire;
        sprites[1] = ShipWind;
        sprites[2] = ShipEarth;
        sprites[3] = ShipWater;

    }

    void Update()
    {
        Debug.Log(sprites[spriteVersion].name);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteVersion++;
            if (spriteVersion > 3)
                spriteVersion = 0;
            spriteRenderer.sprite = sprites[spriteVersion];

        }
    }
}

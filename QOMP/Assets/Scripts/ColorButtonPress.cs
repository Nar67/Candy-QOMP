using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ColorButtonPress : MonoBehaviour
{

    public Tilemap blueTilemap;
    public Tilemap redTilemap;
    public Tile redTile;
    public Tile blueTile;
    public Sprite blueFrame;
    public Sprite blueSquare;
    public Sprite redFrame;
    public Sprite redSquare;
    private bool isRedFilled = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        
        redTile.sprite = redSquare; //change red square for red frame
        blueTile.sprite = blueFrame; //chage blue frame for blue square
        redTilemap.GetComponent<Collider2D>().enabled = true;
        blueTilemap.GetComponent<Collider2D>().enabled = false;
        redTilemap.RefreshAllTiles();
        blueTilemap.RefreshAllTiles();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("test");
        if(isRedFilled)
        {
            redTile.sprite = redFrame; //change red square for red frame

            blueTile.sprite = blueSquare; //chage blue frame for blue square
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else
        {
            redTile.sprite = redSquare; //change red frame for red square

            blueTile.sprite = blueFrame; //chage blue square for blue frame
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        redTilemap.GetComponent<Collider2D>().enabled = !redTilemap.GetComponent<Collider2D>().enabled;
        blueTilemap.GetComponent<Collider2D>().enabled = !blueTilemap.GetComponent<Collider2D>().enabled;
        isRedFilled = !isRedFilled;
        redTilemap.RefreshAllTiles();
        blueTilemap.RefreshAllTiles();
    }
}

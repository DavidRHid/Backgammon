using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    //Variables
   public Vector3[,] locations = new Vector3[24, 6];
   public GameObject[] p1pieces = new GameObject[16];
   public GameObject[] p2pieces = new GameObject[16];
    public bool[,] loctaken = new bool[25, 6];
    public Button RollDiceButton;
    public Canvas MyCanvas;
    public GameObject Player1Piece;
    public GameObject Player2Piece;
   public int DieOne;
   public int DieTwo;
  public  int HighDice;
    public int LowDice;
    // Use this for initialization
    void Start()
    {
        //Player1 Home
        for (int i = 0; i < 6; i++)
        {

            locations[i, 1] = new Vector3(-34f + (i * 5.8f), 1.0f, 27f);
            locations[i, 2] = new Vector3(-34f + (i * 5.8f), 1.0f, 22.75f);
            locations[i, 3] = new Vector3(-34f + (i * 5.8f), 1.0f, 18.5f);
            locations[i, 4] = new Vector3(-34f + (i * 5.8f), 1.0f, 14.25f);
            locations[i, 5] = new Vector3(-34f + (i * 5.8f), 1.0f, 10f);

        }


        //Plyer One Outer Home
        for (int i = 6; i < 12; i++)
        {

            locations[i, 1] = new Vector3(-30 + (i * 5.8f), 1.0f, 27f);
            locations[i, 2] = new Vector3(-30 + (i * 5.8f), 1.0f, 22.75f);
            locations[i, 3] = new Vector3(-30 + (i * 5.8f), 1.0f, 18.5f);
            locations[i, 4] = new Vector3(-30 + (i * 5.8f), 1.0f, 14.25f);
            locations[i, 5] = new Vector3(-30 + (i * 5.8f), 1.0f, 10f);
        }

        //Player Two Outer Home
        for (int i = 12; i < 18; i++)
        {

            locations[i, 1] = new Vector3(104 - (i * 5.8f), 1.0f, -27f);
            locations[i, 2] = new Vector3(104 - (i * 5.8f), 1.0f, -22.75f);
            locations[i, 3] = new Vector3(104 - (i * 5.8f), 1.0f, -18.5f);
            locations[i, 4] = new Vector3(104 - (i * 5.8f), 1.0f, -14.25f);
            locations[i, 5] = new Vector3(104 - (i * 5.8f), 1.0f, -10f);
        }

        //Player Two Home
        for (int i = 18; i < 24; i++)
        {

            locations[i, 1] = new Vector3(100 - (i * 5.8f), 1.0f, -27f);
            locations[i, 2] = new Vector3(100 - (i * 5.8f), 1.0f, -22.75f);
            locations[i, 3] = new Vector3(100 - (i * 5.8f), 1.0f, -18.5f);
            locations[i, 4] = new Vector3(100 - (i * 5.8f), 1.0f, -14.25f);
            locations[i, 5] = new Vector3(100 - (i * 5.8f), 1.0f, -10f);
        }
        for (int i = 0; i < 5; i++)
        {
            // Start Position W
            p1pieces[i] = Instantiate(Player1Piece, locations[5, i + 1], Quaternion.identity);
            p1pieces[i].GetComponent<GamePieces>().Position = locations[5, i + 1];
            loctaken[5, i + 1] = true;
            p1pieces[i].GetComponent<GamePieces>().Location = new Vector2(5, i + 1);
            

        }
        for (int i = 0; i < 25; i++) {
            for (int j = 0; j < 6; j++) {
                loctaken [i, j] = false;
            }
        }
        for (int i = 5; i < 8; i++)
        {
            p1pieces[i] = Instantiate(Player1Piece, locations[7, i - 4], Quaternion.identity);
            p1pieces[i].GetComponent<GamePieces>().Position = locations[7, i - 4];
            loctaken[7, i - 4] = true;
            p1pieces[i].GetComponent<GamePieces>().Location = new Vector2(7, i - 4);
        }

        for (int i = 8; i < 13; i++)
        {
            p1pieces[i] = Instantiate(Player1Piece, locations[12, i - 7], Quaternion.identity);
            p1pieces[i].GetComponent<GamePieces>().Position = locations[12, i - 7];
            loctaken[12, i - 7] = true;
            p1pieces[i].GetComponent<GamePieces>().Location = new Vector2(12, i - 7);
        }
        for (int i = 13; i < 15; i++)
        {
            p1pieces[i] = Instantiate(Player1Piece, locations[23, i - 12], Quaternion.identity);
            p1pieces[i].GetComponent<GamePieces>().Position = locations[23, i - 12];
            loctaken[23, i -12] = true;
            p1pieces[i].GetComponent<GamePieces>().Location = new Vector2(23, i - 12);
        }
        // Start Position B
        for (int i = 13; i < 15; i++)
        {
            p2pieces[i] = Instantiate(Player2Piece, locations[0, i - 12], Quaternion.identity);
            p2pieces[i].GetComponent<GamePieces>().Position = locations[0, i - 12];
            loctaken[0, i - 12] = true;
            p2pieces[i].GetComponent<GamePieces>().Location = new Vector2(0, i - 12);

        }
        for (int i = 8; i < 13; i++)
        {
            p2pieces[i] = Instantiate(Player2Piece, locations[11, i - 7], Quaternion.identity);
            p2pieces[i].GetComponent<GamePieces>().Position = locations[11, i - 7];
            loctaken[11, i - 7] = true;
            p2pieces[i].GetComponent<GamePieces>().Location = new Vector2(11, i - 7);
        }

        for (int i = 5; i < 8; i++)
        {
            p2pieces[i] = Instantiate(Player2Piece, locations[16, i - 4], Quaternion.identity);
            p2pieces[i].GetComponent<GamePieces>().Position = locations[16, i - 4];
            loctaken[16, i - 4] = true;
            p2pieces[i].GetComponent<GamePieces>().Location = new Vector2(16, i - 4);
        }
        for (int i = 0; i < 5; i++)
        {
            p2pieces[i] = Instantiate(Player2Piece, locations[18, i + 1], Quaternion.identity);
            p2pieces[i].GetComponent<GamePieces>().Position = locations[18, i + 1];
            loctaken[18, i + 1] = true;
            p2pieces[i].GetComponent<GamePieces>().Location = new Vector2(18, i + 1);
        }


        Button btn =  Instantiate(RollDiceButton, new Vector3(0f, 10f, 0f),
            Quaternion.AngleAxis(90, Vector3.right) * (Quaternion.AngleAxis(180, Vector3.forward)));
        btn.transform.SetParent(MyCanvas.transform);
        btn.onClick.AddListener(VarDice);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(DieOne > DieTwo)
        {
             HighDice = DieOne;
             LowDice = DieTwo;
        }
        else
        {
            HighDice = DieTwo;
            LowDice = DieOne;
        }
    }

    void VarDice()
    {
        DieOne = RollDice();
        DieTwo = RollDice();
        Debug.Log(DieOne);
        Debug.Log(DieTwo);
    }
    int First() {
        if (DieOne > DieTwo) {
            return 1;
        }

        else if (DieOne == DieTwo) {
            return First();
        }
        else
        {
            return 0;
        }
 
    }

    int RollDice()
    {
        return Random.Range(1, 7);
    }
}
/* if (WRow5 is cliked) {
            highlight WRow5 +DieOne;
            highlight WRow5 +DieTwo;
            highlight WRow5 +DieTwo + DieOne;
        }
        if (WRow5 + DieOne is clicked) {
            transform.position(WRow5 Top key to WRow5 +DieOne Top Key);
        }*/
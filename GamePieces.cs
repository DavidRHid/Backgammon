using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieces : MonoBehaviour {
    public GameScript GS;
    public Vector3 Position;
    public Vector2 Location;
    public bool white;

    // Use this for initialization
    void Start() {
        GS = GameObject.Find("Main Camera").GetComponent<GameScript>();
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        for (int i = 0; i < 5; i++)
        {
            if (white == true)
            {
                if (Input.GetMouseButton(0))
                {
                    if (GS.loctaken[(int)Location.x - GS.HighDice, i] == false)
                    {
                        MoveHighBack();
                        return;

                    }
                }
                else if (Input.GetMouseButton(1))
                {
                    if (GS.loctaken[(int)Location.x - GS.LowDice, i] == false)
                    {
                        MoveLowBack();
                        return;

                    }
                }
            }

            else if (white == false)
            {

                if (Input.GetMouseButton(0))
                {
                    if (GS.loctaken[(int)Location.x + GS.HighDice, i] == false)
                    {

                        MoveHigh();
                        return;
                    }
                }

                else if (Input.GetMouseButton(1))
                {
                    if (GS.loctaken[(int)Location.x + GS.LowDice, i] == false)
                    {
                        MoveLow();
                        return;
                    }
                }
        }
    }
        if (white == true) {

        }
    }
    

    public void MoveHigh()
    {
        // moves piece using high roll to high spot
        if (GS.loctaken[GS.HighDice + (int)Location.x, 1] == false)
        {
            transform.position = (GS.locations[GS.HighDice + (int)Location.x, 1]);
            GS.loctaken[GS.HighDice + (int)Location.x, 1] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.HighDice + (int)Location.x, 1);
        }
        else if (GS.loctaken[GS.HighDice + (int)Location.x, 2] == false)
        {
            transform.position = (GS.locations[GS.HighDice + (int)Location.x, 2]);
            GS.loctaken[GS.HighDice + (int)Location.x, 2] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.HighDice + (int)Location.x, 2);
        }
        else if (GS.loctaken[GS.HighDice + (int)Location.x, 3] == false)
        {
            transform.position = (GS.locations[GS.HighDice + (int)Location.x, 3]);
            GS.loctaken[GS.HighDice + (int)Location.x, 3] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.HighDice + (int)Location.x, 3);
        }
        else if (GS.loctaken[GS.HighDice + (int)Location.x, 4] == false)
        {
            transform.position = (GS.locations[GS.HighDice + (int)Location.x, 4]);
            GS.loctaken[GS.HighDice + (int)Location.x, 4] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.HighDice + (int)Location.x, 4);
        }
        else if (GS.loctaken[GS.HighDice + (int)Location.x, 5] == false)
        {
            transform.position = (GS.locations[GS.HighDice + (int)Location.x, 5]);
            GS.loctaken[GS.HighDice + (int)Location.x, 5] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.HighDice + (int)Location.x, 5);
        }
        else
        {
            Debug.Log("B H Over");
            return;
        }
    }

       public void MoveHighBack(){
            if (GS.loctaken[(int)Location.x - GS.HighDice, 1] == false)
            {
                transform.position = (GS.locations[(int)Location.x - GS.HighDice, 1]);
                GS.loctaken[(int)Location.x - GS.HighDice, 1] = true;
                GS.loctaken[(int)Location.x, (int)Location.y] = false;
                Location = new Vector2( (int)Location.x - GS.HighDice, 1);
            }
            else if (GS.loctaken[(int)Location.x - GS.HighDice, 2] == false)
            {
                transform.position = (GS.locations[(int)Location.x - GS.HighDice, 2]);
                GS.loctaken[(int)Location.x - GS.HighDice, 2] = true;
                GS.loctaken[(int)Location.x, (int)Location.y] = false;
                Location = new Vector2( (int)Location.x - GS.HighDice, 2);
            }
            else if (GS.loctaken[(int)Location.x - GS.HighDice, 3] == false)
            {
                transform.position = (GS.locations[(int)Location.x - GS.HighDice, 3]);
                GS.loctaken[(int)Location.x - GS.HighDice, 3] = true;
                GS.loctaken[(int)Location.x, (int)Location.y] = false;
                Location = new Vector2((int)Location.x - GS.HighDice, 3);
            }
            else if (GS.loctaken[(int)Location.x - GS.HighDice, 4] == false)
            {
                transform.position = (GS.locations[(int)Location.x - GS.HighDice, 4]);
                GS.loctaken[(int)Location.x - GS.HighDice, 4] = true;
                GS.loctaken[(int)Location.x, (int)Location.y] = false;
                Location = new Vector2((int)Location.x - GS.HighDice, 4);
            }
            else if (GS.loctaken[(int)Location.x - GS.HighDice, 5] == false)
            {
                transform.position = (GS.locations[(int)Location.x - GS.HighDice, 5]);
                GS.loctaken[(int)Location.x - GS.HighDice, 5] = true;
                GS.loctaken[(int)Location.x, (int)Location.y] = false;
                Location = new Vector2(Location.x - GS.HighDice, 5);
            }
        else
        {
            Debug.Log("W H Over");
            return;
        }
    }
    public void MoveLow()
    {
        if (GS.loctaken[GS.LowDice + (int)Location.x, 1] == false)
        {
            transform.position = (GS.locations[GS.LowDice + (int)Location.x, 1]);
            GS.loctaken[GS.LowDice + (int)Location.x, 1] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.LowDice + (int)Location.x, 1);
        }
        else if (GS.loctaken[GS.LowDice + (int)Location.x, 2] == false)
        {
            transform.position = (GS.locations[GS.LowDice + (int)Location.x, 2]);
            GS.loctaken[GS.LowDice + (int)Location.x, 2] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.LowDice + (int)Location.x, 2);
        }
        else if (GS.loctaken[GS.LowDice + (int)Location.x, 3] == false)
        {
            transform.position = (GS.locations[GS.LowDice + (int)Location.x, 3]);
            GS.loctaken[GS.LowDice + (int)Location.x, 3] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.LowDice + (int)Location.x, 3);
        }
        else if (GS.loctaken[GS.LowDice + (int)Location.x, 4] == false)
        {
            transform.position = (GS.locations[GS.LowDice + (int)Location.x, 4]);
            GS.loctaken[GS.LowDice + (int)Location.x, 4] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.LowDice + (int)Location.x, 4);
        }
        else if (GS.loctaken[GS.LowDice + (int)Location.x, 5] == false)
        {
            transform.position = (GS.locations[GS.LowDice + (int)Location.x, 5]);
            GS.loctaken[GS.LowDice + (int)Location.x, 5] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(GS.LowDice + (int)Location.x, 5);
        }
        else
        {
            Debug.Log("B B Over");
            return;
        }
    }
     public void MoveLowBack()
    {
        if (GS.loctaken[(int)Location.x - GS.LowDice, 1] == false)
        {
            transform.position = (GS.locations[(int)Location.x - GS.LowDice, 1]);
            GS.loctaken[(int)Location.x - GS.LowDice, 1] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2((int)Location.x - GS.LowDice, 1);
        }
        else if (GS.loctaken[(int)Location.x - GS.LowDice, 2] == false)
        {
            transform.position = (GS.locations[(int)Location.x - GS.LowDice, 2]);
            GS.loctaken[(int)Location.x - GS.LowDice, 2] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2((int)Location.x - GS.LowDice, 2);
        }
        else if (GS.loctaken[(int)Location.x - GS.LowDice, 3] == false)
        {
            transform.position = (GS.locations[(int)Location.x - GS.LowDice, 3]);
            GS.loctaken[(int)Location.x - GS.LowDice, 3] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2((int)Location.x - GS.LowDice, 3);
        }
        else if (GS.loctaken[(int)Location.x - GS.LowDice, 4] == false)
        {
            transform.position = (GS.locations[(int)Location.x - GS.LowDice, 4]);
            GS.loctaken[(int)Location.x - GS.LowDice, 4] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2((int)Location.x - GS.LowDice, 4);
        }
        else if (GS.loctaken[(int)Location.x - GS.LowDice, 5] == false)
        {
            transform.position = (GS.locations[(int)Location.x - GS.LowDice, 5]);
            GS.loctaken[(int)Location.x - GS.LowDice, 5] = true;
            GS.loctaken[(int)Location.x, (int)Location.y] = false;
            Location = new Vector2(Location.x - GS.LowDice, 5);
        }
        else
        {
            Debug.Log("B W Over");
            return;
        }
    }

}



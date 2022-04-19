using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Game
{
    private static Game instance;
    private List<GameObject> trashCans = new List<GameObject>();
    public List<GameObject> TrashCan { get { return trashCans; } }
    public static Game Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Game();

            }
            return instance;
        }
    }
}

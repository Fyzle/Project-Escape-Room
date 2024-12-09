

using UnityEngine;

public class NewEmptyCSharpScript
{
    public int currentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 7)
                currentWall = 1;
            else if (value == 0)
                currentWall = 6
            else
                currentWall = value;

        }
    }
    private int currentWall;
    private int previousWall;

    void Start()
    {
        previousWall = 0;
        currentWall = 1
    }

    void Update()
    {
        if(currentWall != previousWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall" + currentWall.ToString());
        }

        previousWall = currentWall
    }

}

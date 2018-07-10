using System;

public int score;

void Update()
{
    if (score == 50)
    {
        Debug.Log("GREAT!");

    }

    else if (score == 25)
    {
        Debug.Log("GOOD");

    }

    else
    {
        Debug.Log("POOR");
    }

}

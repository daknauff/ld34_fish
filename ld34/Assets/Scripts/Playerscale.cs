using UnityEngine;
using System.Collections;

public static class Playerscale {
	public static float Scale=0.25f;
	public static int level=1;
    public static string scene = "Level1";

    public static void reset()
    {
        Scale = 0.25f;
        level = 1;
        scene = "Level1";
    }
    public static void swapscene()
    {
        if (scene=="Level1")
        {
            scene = "Level2";
        }
        else
        {
            scene = "Level1";
        }
    }

}

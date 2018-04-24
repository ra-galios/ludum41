
using UnityEngine;

namespace DefaultNamespace
{
    public static class Data
    {
        public static int CurrentLevel;
        public static int currGirl = -1;
        public static Sprite[] Girl = new Sprite[3];
        
        public static Sprite[] allGirls = new Sprite[9];

        public static void NextGirl()
        {
            currGirl++;
            for (int i = currGirl * 3, j = 0; j < 3 && i < allGirls.Length; i++, j++)
                Girl[j] = allGirls[i];
        }

        public static Sprite sad()
        {
            return Girl[1];
        }
        
        public static Sprite angry()
        {
            return Girl[0];
        }
        
        public static Sprite happy()
        {
            return Girl[2];
        }
    }
}
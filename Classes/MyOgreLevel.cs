﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{
    public class MyOgreLevel
    {
       static int MAP_WIDTH = 20;        // Map Width
       static int MAP_HEIGHT = 20;   // Map Height

        int[] mMap = new int[MAP_WIDTH * MAP_HEIGHT];	// Our map data array
        public MyOgreLevel() 
        {
            int[] tempMap = new int[]
            {
		// 0001020304050607080910111213141516171819
		1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,   // 00
		1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1,   // 01
		1,9,9,1,1,9,9,9,1,9,1,9,1,9,1,9,9,9,1,1,   // 02
		1,9,9,1,1,9,9,9,1,9,1,9,1,9,1,9,9,9,1,1,   // 03
		1,9,1,1,1,1,9,9,1,9,1,9,1,1,1,1,9,9,1,1,   // 04
		1,9,1,1,9,1,1,1,1,9,1,1,1,1,9,1,1,1,1,1,   // 05
		1,9,9,9,9,1,1,1,1,1,1,9,9,9,9,1,1,1,1,1,   // 06
		1,9,9,9,9,9,9,9,9,1,1,1,9,9,9,9,9,9,9,1,   // 07
		1,9,1,1,1,1,1,1,1,1,1,9,1,1,1,1,1,1,1,1,   // 08
		1,9,1,9,9,9,9,9,9,9,1,1,9,9,9,9,9,9,9,1,   // 09
		1,9,1,1,1,1,9,1,1,9,1,1,1,1,1,1,1,1,1,1,   // 10
		1,9,9,9,9,9,1,9,1,9,1,9,9,9,9,9,1,1,1,1,   // 11
		1,9,1,9,1,9,9,9,1,9,1,9,1,9,1,9,9,9,1,1,   // 12
		1,9,1,9,1,9,9,9,1,9,1,9,1,9,1,9,9,9,1,1,   // 13
		1,9,1,1,1,1,9,9,1,9,1,9,1,1,1,1,9,9,1,1,   // 14
		1,9,1,1,9,1,1,1,1,9,1,1,1,1,9,1,1,1,1,1,   // 15
		1,9,9,9,9,1,1,1,1,1,1,9,9,9,9,1,1,1,1,1,   // 16
		1,1,9,9,9,9,9,9,9,1,1,1,9,9,9,1,9,9,9,9,   // 17
		1,9,1,1,1,1,1,1,1,1,1,9,1,1,1,1,1,1,1,1,   // 18
		1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,   // 19
	};

            // assign our world to our member array
            for (int i = 0; i < MAP_WIDTH * MAP_HEIGHT; i++)
            {
                mMap[i] = tempMap[i];
            }
        }
        // Return the width of the map
        public int GetWidth()            
        {
            return MAP_WIDTH;
        }
        // Return the height of the map
        public int GetHeight()
        {
            return MAP_HEIGHT;
        }
        // Return a tile at the specified coordinates
        public int GetTile(int x, int y)
        {
            if (x >= MAP_WIDTH)
                x = MAP_WIDTH - 1;
            if (x < 0)
                x = 0;
            if (y >= MAP_HEIGHT)
                y = MAP_HEIGHT - 1;
            if (y < 0)
                y = 0;

            return mMap[(y * MAP_WIDTH) + x];
        }
    }
}

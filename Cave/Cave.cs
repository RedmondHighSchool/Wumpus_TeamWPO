using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cave
{
    class Cave
    {
        // instance variables
        // Note to self - will need to have an array of rooms here
        private String fileName; // to open or save a cave
        
        // constructor
        public Cave(String name)
        {
            fileName = name;
        }

        // getNeighbors - returns an integer array of length
        // 6. The content of each element in that array
        // is the number of each room adjacent to roomNumber,
        // whether or not there is an open passageway to get 
        // there.
        // The order, clockwise beginning with the room
        // directly above is Top, Top Right, Bottom Right,
        // Bottom, Bottom left, Top Left
        public int[] getNeighbors(int roomNumber)
        {
            int[] neighbors = { 25, 26, 2, 7, 6 };
            return neighbors;  // stub for room 1

            // alternate stub would be
            // return null;
        }

        // getPassageways - returns an integer array of length
        // 6. The content of each element is the room number 
        // of a room that can be accessed or zero, if there is
        // no open door in that direction.
        public int[] getDoors(int roomNumber)
        {
            // stub - doors open Bottom Right and Bottom
            int[] doors = { 0, 0, 2, 7, 0, 0 };
            return doors;
        }

    }
}

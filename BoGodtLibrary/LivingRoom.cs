﻿using BoGodtLibrary.BoGodtExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoGodtLibrary
{
    public class LivingRoom : MasterRoom
    {
        private const int MAX_WINDOWS = 5;
        private const int EXACT_DOORS = 1;
        public override void AddWindows(IMasterWindow livingroomwindow)
        {
            if (windows.Count + 1 > MAX_WINDOWS)
            {
                throw new BoGodtExceptions.OnlyFiveWindowsException();
            }

            Console.WriteLine("windows.Count: " + (windows.Count));
            livingroomwindow.windowFrosted = false;
            livingroomwindow.windowOpen = true;
            windows.Add(livingroomwindow);
            Console.WriteLine("New window were added to the room!");
        }

        public override void AddDoors(IMasterDoor livingroomdoor)
        {
            if (doors.Count + 1 >= EXACT_DOORS)
            {
                throw new BoGodtExceptions.OnlyOneRoomDoorException();
            }

            Console.WriteLine("doors.Count: " + (doors.Count));
            doors.Add(livingroomdoor);
            Console.WriteLine("A door was added!");
        }

        public override void AddFloor(IMasterFloor livingroomfloor)
        {
            floors.Add(livingroomfloor);
            Console.WriteLine("Floor was added!");
        }

        public override ERoomType GetRoomType()
        {
            return ERoomType.LivingRoom;
        }




    }
}

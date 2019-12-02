﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
    //    public List<FullInventory> fullIventory;

        // constructor (SPAWNER)
        public Inventory()
        {
        //    fullInventory = new List<FullInventory>();
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }
        // member methods (CAN DO)

        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i--)
            {
                Lemon lemon = new Lemon();
                lemons.Remove(lemon);
            }
        }
        public void RemoveSugarCubesFromInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i--)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Remove(sugarCube);
            }
        }
        public void RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i--)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Remove(iceCube);
            }
        }
        public void RemoveCupsFromInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i--)
            {
                Cup cup = new Cup();
                cups.Remove(cup);
            }
        }
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }
        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }
        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }
        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}

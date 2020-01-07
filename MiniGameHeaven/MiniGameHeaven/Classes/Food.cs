﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameHeaven
{
    public class Food
    {
        public PictureBox[,] FoodImage = new PictureBox[30,27];
        public int Amount = 0;

        private const int FoodScore = 10;
        private const int SuperFoodScore = 50;

        public void CreateFoodImages(Form formInstance)
        {
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    if (pac_man.gameboard.Matrix[y,x] == 1 || pac_man.gameboard.Matrix[y, x] == 2)
                    {
                        FoodImage[y, x] = new PictureBox();
                        FoodImage[y, x].Name = "FoodImage" + Amount.ToString();
                        FoodImage[y, x].SizeMode = PictureBoxSizeMode.AutoSize;
                        FoodImage[y, x].Location = new Point(x * 16 - 1, y * 16 + 47);
                        if (pac_man.gameboard.Matrix[y,x] == 1)
                        {
                            FoodImage[y, x].Image = Properties.Resources.Block_1;
                            Amount++;
                        }
                        else
                        {
                            FoodImage[y, x].Image = Properties.Resources.Block_2;
                        }
                        formInstance.Controls.Add(FoodImage[y, x]);
                        FoodImage[y, x].BringToFront();
                        
                    }
                }
            }
        }

        public void EatFood(int x, int y)
        {
            // Eat food
            FoodImage[x, y].Visible = false;
            pac_man.gameboard.Matrix[x, y] = 0;
            pac_man.player.UpdateScore(FoodScore);
            Amount--;
            if (Amount < 1) { pac_man.player.LevelComplete(); }
            //Form1.audio.Play(1);
        }

        public void EatSuperFood(int x, int y)
        {
            // Eat food
            FoodImage[x, y].Visible = false;
            pac_man.gameboard.Matrix[x, y] = 0;
            pac_man.player.UpdateScore(SuperFoodScore);
            pac_man.ghost.ChangeGhostState();
        }
    }
}
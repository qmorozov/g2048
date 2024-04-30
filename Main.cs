﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace g2048 {
    public partial class Main : Form {
        private Game oGame;

        private Graphics gGraphics, gG;
        private Bitmap bBackground;

        public Main() {
            InitializeComponent();
            /* ------ РОЗМІРИ ФОНОВОГО ЗОБРАЖЕННЯ ----- */
            bBackground = new Bitmap(396, 600);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            /* ------- ВІДКЛЮЧЕННЯ КНОПКИ "РОЗГОРНУТИ" ------- */
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            gGraphics = this.CreateGraphics();
            /* ------ ФОНОВЕ ЗОБРАЖЕННЯ ----- */
            gG = Graphics.FromImage(bBackground);

            oGame = new Game();
            CFG.getInstance();
        }

        /* ------- ОНОВЛЕННЯ ГРИ ------- */

        public void UpdateGame() {
            oGame.Update();
        }
        /* ------- МАЛЮВАННЯ ФОНА ГРИ ------- */
        public void Draw(Graphics g) {
            g.Clear(Color.FromArgb(28, 108, 146));
            oGame.Draw(g);
        }

        /* ******************************************** */

        private void timer1_Tick(object sender, EventArgs e) {
            UpdateGame();
            if (oGame.bRender) {
                Draw(gG);

                gGraphics.DrawImage(bBackground, new Point(0, 0));
            }
        }

        /* ------- ВІДСТЕЖЕННЯ НАТИСКАННЯ КНОПОК WSDA ------- */

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            
            if (!oGame.kTOP && !oGame.kRIGHT && !oGame.kBOTTOM && (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)) {
                oGame.kLEFT = true;
                oGame.moveBoard(Game.Direction.eLEFT);
            } else if (!oGame.kLEFT && !oGame.kRIGHT && !oGame.kBOTTOM && (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)) {
                oGame.kTOP = true;
                oGame.moveBoard(Game.Direction.eTOP);
            } else if (!oGame.kTOP && !oGame.kLEFT && !oGame.kBOTTOM && (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)) {
                oGame.kRIGHT = true;
                oGame.moveBoard(Game.Direction.eRIGHT);
            } else if (!oGame.kTOP && !oGame.kRIGHT && !oGame.kLEFT && (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)) {
                oGame.kBOTTOM = true;
                oGame.moveBoard(Game.Direction.eBOTTOM);
            }
        }
        /* ------ НАТИСКАННЯ КНОПОК WASD ------ */
        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if (oGame.kLEFT && (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)) {
                oGame.kLEFT = false;
            }

            if (oGame.kTOP && (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)) {
                oGame.kTOP = false;
            }

            if (oGame.kRIGHT && (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)) {
                oGame.kRIGHT = false;
            }

            if (oGame.kBOTTOM && (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)) {
                oGame.kBOTTOM = false;
            }
        }

        private void Main_Load(object sender, EventArgs e) {

        }

        private void Main_MouseClick(object sender, MouseEventArgs e) {
            oGame.checkButton(e.X, e.Y);
        }
    }
}

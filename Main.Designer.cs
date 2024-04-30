namespace g2048 {
    partial class Main {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // <summary>
        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        // </summary>
        /* ----- ІНІЦІЛІЗАЦІЯ КОМПОНЕНТІВ ПРОГРАММИ ----- */
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            /* ---- КОНТРОЛЮЄ РОЗМІР ВІКНА ---- */
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            /* ---- ФОТО ФОНУ ГРИ ---- */
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            /* ---- РОЗМІР ВІКНА ---- */
            this.ClientSize = new System.Drawing.Size(396, 540);
            /* ---- ВІГЛЯД КУРСОРА ---- */
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            /* ---- ІКОНКА ЗВЕРХУ НАД ГРОЮ ---- */
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            /* ---- ГОЛОВНИЙ ФАЙЛ ---- */
            this.Name = "Main";
            /* ---- НАПИС ЗВЕРХУ НА ФОРМІ ---- */
            this.Text = "Курсовий проект 'ГРА 2048'";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}


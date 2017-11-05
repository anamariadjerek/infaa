namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel_pocetak = new System.Windows.Forms.Panel();
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.pb_restoran = new System.Windows.Forms.PictureBox();
            this.pb_apartman = new System.Windows.Forms.PictureBox();
            this.pb_things = new System.Windows.Forms.PictureBox();
            this.lbl_hotel = new System.Windows.Forms.Label();
            this.lbl_apartman = new System.Windows.Forms.Label();
            this.lbl_restaurant = new System.Windows.Forms.Label();
            this.lbl_things = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_pocetak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restoran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_things)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(190, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(201, 226);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(195, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(402, 226);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 20);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_pocetak
            // 
            this.panel_pocetak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_pocetak.BackgroundImage")));
            this.panel_pocetak.Controls.Add(this.lbl_things);
            this.panel_pocetak.Controls.Add(this.lbl_restaurant);
            this.panel_pocetak.Controls.Add(this.lbl_apartman);
            this.panel_pocetak.Controls.Add(this.lbl_hotel);
            this.panel_pocetak.Controls.Add(this.pb_things);
            this.panel_pocetak.Controls.Add(this.pb_apartman);
            this.panel_pocetak.Controls.Add(this.pb_restoran);
            this.panel_pocetak.Controls.Add(this.pb_hotel);
            this.panel_pocetak.Location = new System.Drawing.Point(1, 252);
            this.panel_pocetak.Name = "panel_pocetak";
            this.panel_pocetak.Size = new System.Drawing.Size(670, 156);
            this.panel_pocetak.TabIndex = 4;
            this.panel_pocetak.Visible = false;
            // 
            // pb_hotel
            // 
            this.pb_hotel.Image = ((System.Drawing.Image)(resources.GetObject("pb_hotel.Image")));
            this.pb_hotel.Location = new System.Drawing.Point(61, 18);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(107, 107);
            this.pb_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hotel.TabIndex = 0;
            this.pb_hotel.TabStop = false;
            // 
            // pb_restoran
            // 
            this.pb_restoran.Image = ((System.Drawing.Image)(resources.GetObject("pb_restoran.Image")));
            this.pb_restoran.Location = new System.Drawing.Point(365, 18);
            this.pb_restoran.Name = "pb_restoran";
            this.pb_restoran.Size = new System.Drawing.Size(118, 107);
            this.pb_restoran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_restoran.TabIndex = 1;
            this.pb_restoran.TabStop = false;
            // 
            // pb_apartman
            // 
            this.pb_apartman.Image = ((System.Drawing.Image)(resources.GetObject("pb_apartman.Image")));
            this.pb_apartman.Location = new System.Drawing.Point(214, 20);
            this.pb_apartman.Name = "pb_apartman";
            this.pb_apartman.Size = new System.Drawing.Size(106, 105);
            this.pb_apartman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_apartman.TabIndex = 2;
            this.pb_apartman.TabStop = false;
            // 
            // pb_things
            // 
            this.pb_things.Image = ((System.Drawing.Image)(resources.GetObject("pb_things.Image")));
            this.pb_things.Location = new System.Drawing.Point(521, 20);
            this.pb_things.Name = "pb_things";
            this.pb_things.Size = new System.Drawing.Size(112, 97);
            this.pb_things.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_things.TabIndex = 3;
            this.pb_things.TabStop = false;
            this.pb_things.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lbl_hotel
            // 
            this.lbl_hotel.AutoSize = true;
            this.lbl_hotel.Location = new System.Drawing.Point(94, 112);
            this.lbl_hotel.Name = "lbl_hotel";
            this.lbl_hotel.Size = new System.Drawing.Size(32, 13);
            this.lbl_hotel.TabIndex = 4;
            this.lbl_hotel.Text = "Hotel";
            // 
            // lbl_apartman
            // 
            this.lbl_apartman.AutoSize = true;
            this.lbl_apartman.Location = new System.Drawing.Point(239, 112);
            this.lbl_apartman.Name = "lbl_apartman";
            this.lbl_apartman.Size = new System.Drawing.Size(55, 13);
            this.lbl_apartman.TabIndex = 5;
            this.lbl_apartman.Text = "Apartment";
            // 
            // lbl_restaurant
            // 
            this.lbl_restaurant.AutoSize = true;
            this.lbl_restaurant.Location = new System.Drawing.Point(398, 112);
            this.lbl_restaurant.Name = "lbl_restaurant";
            this.lbl_restaurant.Size = new System.Drawing.Size(59, 13);
            this.lbl_restaurant.TabIndex = 6;
            this.lbl_restaurant.Text = "Restaurant";
            // 
            // lbl_things
            // 
            this.lbl_things.AutoSize = true;
            this.lbl_things.Location = new System.Drawing.Point(546, 112);
            this.lbl_things.Name = "lbl_things";
            this.lbl_things.Size = new System.Drawing.Size(66, 13);
            this.lbl_things.TabIndex = 7;
            this.lbl_things.Text = "Things to do";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 420);
            this.Controls.Add(this.panel_pocetak);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_pocetak.ResumeLayout(false);
            this.panel_pocetak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restoran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_things)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel_pocetak;
        private System.Windows.Forms.PictureBox pb_things;
        private System.Windows.Forms.PictureBox pb_apartman;
        private System.Windows.Forms.PictureBox pb_restoran;
        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Label lbl_hotel;
        private System.Windows.Forms.Label lbl_things;
        private System.Windows.Forms.Label lbl_restaurant;
        private System.Windows.Forms.Label lbl_apartman;
    }
}


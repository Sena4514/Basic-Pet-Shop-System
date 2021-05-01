
namespace odev6
{
    partial class frmPetShopSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetShopSystem));
            this.lblExistInPetShop = new System.Windows.Forms.Label();
            this.lblAbsentInPetShop = new System.Windows.Forms.Label();
            this.lbxExistInPetShop = new System.Windows.Forms.ListBox();
            this.lbxAbsentInPetShop = new System.Windows.Forms.ListBox();
            this.btnRemoveFromPetShop = new System.Windows.Forms.Button();
            this.btnRemoveFromCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddAnimalToExistInPetShop = new System.Windows.Forms.TextBox();
            this.btnAddToExistInPetShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExistInPetShop
            // 
            this.lblExistInPetShop.AutoSize = true;
            this.lblExistInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistInPetShop.Location = new System.Drawing.Point(48, 465);
            this.lblExistInPetShop.Name = "lblExistInPetShop";
            this.lblExistInPetShop.Size = new System.Drawing.Size(178, 25);
            this.lblExistInPetShop.TabIndex = 0;
            this.lblExistInPetShop.Text = "Exist In Pet Shop";
            // 
            // lblAbsentInPetShop
            // 
            this.lblAbsentInPetShop.AutoSize = true;
            this.lblAbsentInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsentInPetShop.Location = new System.Drawing.Point(634, 465);
            this.lblAbsentInPetShop.Name = "lblAbsentInPetShop";
            this.lblAbsentInPetShop.Size = new System.Drawing.Size(199, 25);
            this.lblAbsentInPetShop.TabIndex = 1;
            this.lblAbsentInPetShop.Text = "Absent In Pet Shop";
            // 
            // lbxExistInPetShop
            // 
            this.lbxExistInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExistInPetShop.FormattingEnabled = true;
            this.lbxExistInPetShop.ItemHeight = 25;
            this.lbxExistInPetShop.Location = new System.Drawing.Point(12, 528);
            this.lbxExistInPetShop.Name = "lbxExistInPetShop";
            this.lbxExistInPetShop.Size = new System.Drawing.Size(307, 254);
            this.lbxExistInPetShop.TabIndex = 2;
            // 
            // lbxAbsentInPetShop
            // 
            this.lbxAbsentInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAbsentInPetShop.FormattingEnabled = true;
            this.lbxAbsentInPetShop.ItemHeight = 25;
            this.lbxAbsentInPetShop.Location = new System.Drawing.Point(579, 528);
            this.lbxAbsentInPetShop.Name = "lbxAbsentInPetShop";
            this.lbxAbsentInPetShop.Size = new System.Drawing.Size(307, 254);
            this.lbxAbsentInPetShop.TabIndex = 3;
            // 
            // btnRemoveFromPetShop
            // 
            this.btnRemoveFromPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromPetShop.Location = new System.Drawing.Point(363, 465);
            this.btnRemoveFromPetShop.Name = "btnRemoveFromPetShop";
            this.btnRemoveFromPetShop.Size = new System.Drawing.Size(140, 65);
            this.btnRemoveFromPetShop.TabIndex = 4;
            this.btnRemoveFromPetShop.Text = "Remove From Pet Shop";
            this.btnRemoveFromPetShop.UseVisualStyleBackColor = true;
            this.btnRemoveFromPetShop.Click += new System.EventHandler(this.btnRemoveFromPetShop_Click);
            // 
            // btnRemoveFromCard
            // 
            this.btnRemoveFromCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCard.Location = new System.Drawing.Point(911, 465);
            this.btnRemoveFromCard.Name = "btnRemoveFromCard";
            this.btnRemoveFromCard.Size = new System.Drawing.Size(140, 65);
            this.btnRemoveFromCard.TabIndex = 5;
            this.btnRemoveFromCard.Text = "Remove From Card";
            this.btnRemoveFromCard.UseVisualStyleBackColor = true;
            this.btnRemoveFromCard.Click += new System.EventHandler(this.btnRemoveFromCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::odev6.Properties.Resources.pet_shop;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1039, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddAnimalToExistInPetShop
            // 
            this.txtAddAnimalToExistInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAnimalToExistInPetShop.Location = new System.Drawing.Point(363, 579);
            this.txtAddAnimalToExistInPetShop.Multiline = true;
            this.txtAddAnimalToExistInPetShop.Name = "txtAddAnimalToExistInPetShop";
            this.txtAddAnimalToExistInPetShop.Size = new System.Drawing.Size(140, 57);
            this.txtAddAnimalToExistInPetShop.TabIndex = 7;
            // 
            // btnAddToExistInPetShop
            // 
            this.btnAddToExistInPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToExistInPetShop.Location = new System.Drawing.Point(363, 681);
            this.btnAddToExistInPetShop.Name = "btnAddToExistInPetShop";
            this.btnAddToExistInPetShop.Size = new System.Drawing.Size(140, 65);
            this.btnAddToExistInPetShop.TabIndex = 8;
            this.btnAddToExistInPetShop.Text = "Add To Exist In Pet Shop";
            this.btnAddToExistInPetShop.UseVisualStyleBackColor = true;
            this.btnAddToExistInPetShop.Click += new System.EventHandler(this.btnAddToExistInPetShop_Click);
            // 
            // frmPetShopSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1065, 842);
            this.Controls.Add(this.btnAddToExistInPetShop);
            this.Controls.Add(this.txtAddAnimalToExistInPetShop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoveFromCard);
            this.Controls.Add(this.btnRemoveFromPetShop);
            this.Controls.Add(this.lbxAbsentInPetShop);
            this.Controls.Add(this.lbxExistInPetShop);
            this.Controls.Add(this.lblAbsentInPetShop);
            this.Controls.Add(this.lblExistInPetShop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPetShopSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Pet Shop System";
            this.Load += new System.EventHandler(this.frmPetShopSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExistInPetShop;
        private System.Windows.Forms.Label lblAbsentInPetShop;
        private System.Windows.Forms.ListBox lbxExistInPetShop;
        private System.Windows.Forms.ListBox lbxAbsentInPetShop;
        private System.Windows.Forms.Button btnRemoveFromPetShop;
        private System.Windows.Forms.Button btnRemoveFromCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAddAnimalToExistInPetShop;
        private System.Windows.Forms.Button btnAddToExistInPetShop;
    }
}


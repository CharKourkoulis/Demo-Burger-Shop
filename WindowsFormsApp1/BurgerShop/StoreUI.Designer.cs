namespace BurgerShop
{
    partial class StoreUI
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
            this.addToCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.cartListbox = new System.Windows.Forms.ListBox();
            this.burgerListbox = new System.Windows.Forms.ListBox();
            this.totalpricebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addToCartButton
            // 
            this.addToCartButton.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(238, 252);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(125, 42);
            this.addToCartButton.TabIndex = 7;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(649, 349);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(112, 44);
            this.checkoutButton.TabIndex = 6;
            this.checkoutButton.Text = "CheckOut";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // cartListbox
            // 
            this.cartListbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cartListbox.FormattingEnabled = true;
            this.cartListbox.Location = new System.Drawing.Point(631, 140);
            this.cartListbox.Name = "cartListbox";
            this.cartListbox.Size = new System.Drawing.Size(148, 134);
            this.cartListbox.TabIndex = 5;
            // 
            // burgerListbox
            // 
            this.burgerListbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.burgerListbox.FormattingEnabled = true;
            this.burgerListbox.Location = new System.Drawing.Point(26, 140);
            this.burgerListbox.Name = "burgerListbox";
            this.burgerListbox.Size = new System.Drawing.Size(175, 238);
            this.burgerListbox.TabIndex = 4;
            this.burgerListbox.SelectedIndexChanged += new System.EventHandler(this.BurgerListbox_SelectedIndexChanged);
            // 
            // totalpricebox
            // 
            this.totalpricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalpricebox.Location = new System.Drawing.Point(631, 294);
            this.totalpricebox.Name = "totalpricebox";
            this.totalpricebox.Size = new System.Drawing.Size(148, 29);
            this.totalpricebox.TabIndex = 8;
            // 
            // StoreUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BurgerShop.Properties.Resources.burgershop;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.totalpricebox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.cartListbox);
            this.Controls.Add(this.burgerListbox);
            this.Name = "StoreUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ListBox cartListbox;
        private System.Windows.Forms.ListBox burgerListbox;
        private System.Windows.Forms.TextBox totalpricebox;
    }
}


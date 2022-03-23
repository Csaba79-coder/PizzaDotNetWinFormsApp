
namespace PizzaDotNetWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMenu = new System.Windows.Forms.CheckBox();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxMenu);
            this.panel1.Controls.Add(this.btnCola);
            this.panel1.Controls.Add(this.btnPizza);
            this.panel1.Controls.Add(this.txtBoxPrice);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBoxMenu
            // 
            this.checkBoxMenu.AutoSize = true;
            this.checkBoxMenu.Location = new System.Drawing.Point(258, 262);
            this.checkBoxMenu.Name = "checkBoxMenu";
            this.checkBoxMenu.Size = new System.Drawing.Size(71, 19);
            this.checkBoxMenu.TabIndex = 3;
            this.checkBoxMenu.Text = "as Menu";
            this.checkBoxMenu.UseVisualStyleBackColor = true;
            // 
            // btnCola
            // 
            this.btnCola.Location = new System.Drawing.Point(254, 205);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(75, 23);
            this.btnCola.TabIndex = 2;
            this.btnCola.Text = "CocaCola";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(254, 150);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(75, 23);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(254, 81);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(258, 23);
            this.txtBoxPrice.TabIndex = 0;
            this.txtBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxMenu;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnPizza;
    }
}


namespace Integradora.Products.Inventory
{
    partial class Products_Inventory_ModifyPrice
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
            CurrentProductLBL = new Label();
            OvrPriceBTN = new Button();
            OvrPriceTXT = new TextBox();
            OvrPriceLBL = new Label();
            SuspendLayout();
            // 
            // CurrentProductLBL
            // 
            CurrentProductLBL.AutoSize = true;
            CurrentProductLBL.Font = new Font("Segoe UI", 24F);
            CurrentProductLBL.Location = new Point(12, 9);
            CurrentProductLBL.Name = "CurrentProductLBL";
            CurrentProductLBL.Size = new Size(105, 45);
            CurrentProductLBL.TabIndex = 0;
            CurrentProductLBL.Text = "label1";
            // 
            // OvrPriceBTN
            // 
            OvrPriceBTN.Font = new Font("Segoe UI", 16F);
            OvrPriceBTN.Location = new Point(12, 87);
            OvrPriceBTN.Name = "OvrPriceBTN";
            OvrPriceBTN.Size = new Size(183, 45);
            OvrPriceBTN.TabIndex = 2;
            OvrPriceBTN.Text = "Modificar";
            OvrPriceBTN.UseVisualStyleBackColor = true;
            OvrPriceBTN.Click += OvrPriceBTN_Click;
            // 
            // OvrPriceTXT
            // 
            OvrPriceTXT.Font = new Font("Segoe UI", 16F);
            OvrPriceTXT.Location = new Point(201, 91);
            OvrPriceTXT.Name = "OvrPriceTXT";
            OvrPriceTXT.Size = new Size(100, 36);
            OvrPriceTXT.TabIndex = 3;
            OvrPriceTXT.TextChanged += this.OvrPriceTXT_TextChanged;
            // 
            // OvrPriceLBL
            // 
            OvrPriceLBL.AutoSize = true;
            OvrPriceLBL.Font = new Font("Segoe UI", 16F);
            OvrPriceLBL.Location = new Point(12, 54);
            OvrPriceLBL.Name = "OvrPriceLBL";
            OvrPriceLBL.Size = new Size(551, 30);
            OvrPriceLBL.TabIndex = 4;
            OvrPriceLBL.Text = "Ingrese el precio (en numero) a establecer como precio";
            // 
            // Products_Inventory_ModifyPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OvrPriceLBL);
            Controls.Add(OvrPriceTXT);
            Controls.Add(OvrPriceBTN);
            Controls.Add(CurrentProductLBL);
            Name = "Products_Inventory_ModifyPrice";
            Text = "Products_Inventory_ModifyPrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentProductLBL;
        private Button OvrPriceBTN;
        private TextBox OvrPriceTXT;
        private Label OvrPriceLBL;
    }
}
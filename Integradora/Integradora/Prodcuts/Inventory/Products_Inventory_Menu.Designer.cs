namespace Integradora.Products.Inventory
{
    partial class Products_Inventory_Menu
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
            ProductsCMBOX = new ComboBox();
            ProductLBL = new Label();
            MainText = new RichTextBox();
            SuspendLayout();
            // 
            // ProductsCMBOX
            // 
            ProductsCMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductsCMBOX.Font = new Font("Segoe UI", 16F);
            ProductsCMBOX.FormattingEnabled = true;
            ProductsCMBOX.Location = new Point(130, 6);
            ProductsCMBOX.Name = "ProductsCMBOX";
            ProductsCMBOX.Size = new Size(367, 38);
            ProductsCMBOX.TabIndex = 0;
            ProductsCMBOX.SelectedIndexChanged += ProductsCMBOX_SelectedIndexChanged;
            // 
            // ProductLBL
            // 
            ProductLBL.AutoSize = true;
            ProductLBL.Font = new Font("Segoe UI", 16F);
            ProductLBL.Location = new Point(12, 9);
            ProductLBL.Name = "ProductLBL";
            ProductLBL.Size = new Size(112, 30);
            ProductLBL.TabIndex = 1;
            ProductLBL.Text = "Producto: ";
            // 
            // MainText
            // 
            MainText.Enabled = false;
            MainText.Font = new Font("Segoe UI", 16F);
            MainText.ForeColor = SystemColors.WindowFrame;
            MainText.Location = new Point(12, 50);
            MainText.Name = "MainText";
            MainText.Size = new Size(485, 156);
            MainText.TabIndex = 2;
            MainText.Text = "";
            // 
            // Products_Inventory_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainText);
            Controls.Add(ProductLBL);
            Controls.Add(ProductsCMBOX);
            Name = "Products_Inventory_Menu";
            Text = "Products_Inventory_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// What stores all the <see cref="Products.Manager.Products_Manager.Product"/> in a easy to manage way
        /// </summary>
        private ComboBox ProductsCMBOX;
        /// <summary>
        /// The <see cref="Label"/> use to indicate what <see cref="ProductsCMBOX"/> does
        /// </summary>
        private Label ProductLBL;
        /// <summary>
        /// The Main text area that displays the information of the current <see cref="Products.Manager.Products_Manager.Product"/> selected in <see cref="ProductsCMBOX"/>
        /// </summary>
        private RichTextBox MainText;
    }
}
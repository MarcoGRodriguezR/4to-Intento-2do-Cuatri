namespace Integradora.Products.Inventory
{
    partial class Products_Inventory_AddProduct
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
            NameLabel = new Label();
            UnitsLabel = new Label();
            SalesText = new TextBox();
            SalesLabel = new Label();
            PriceText = new TextBox();
            PriceLabel = new Label();
            AddProductBTN = new Button();
            StatusLabel = new Label();
            NameText = new TextBox();
            UnitsText = new TextBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16F);
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(99, 30);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Nombre:";
            // 
            // UnitsLabel
            // 
            UnitsLabel.AutoSize = true;
            UnitsLabel.Font = new Font("Segoe UI", 16F);
            UnitsLabel.Location = new Point(139, 9);
            UnitsLabel.Name = "UnitsLabel";
            UnitsLabel.Size = new Size(108, 30);
            UnitsLabel.TabIndex = 3;
            UnitsLabel.Text = "Unidades:";
            // 
            // SalesText
            // 
            SalesText.Font = new Font("Segoe UI", 16F);
            SalesText.Location = new Point(266, 55);
            SalesText.Name = "SalesText";
            SalesText.Size = new Size(121, 36);
            SalesText.TabIndex = 4;
            SalesText.TextChanged += SalesText_TextChanged;
            // 
            // SalesLabel
            // 
            SalesLabel.AutoSize = true;
            SalesLabel.Font = new Font("Segoe UI", 16F);
            SalesLabel.Location = new Point(266, 9);
            SalesLabel.Name = "SalesLabel";
            SalesLabel.Size = new Size(82, 30);
            SalesLabel.TabIndex = 5;
            SalesLabel.Text = "Ventas:";
            // 
            // PriceText
            // 
            PriceText.Font = new Font("Segoe UI", 16F);
            PriceText.Location = new Point(393, 55);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(121, 36);
            PriceText.TabIndex = 6;
            PriceText.TextChanged += PriceText_TextChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 16F);
            PriceLabel.Location = new Point(393, 9);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(78, 30);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Precio:";
            // 
            // AddProductBTN
            // 
            AddProductBTN.Font = new Font("Segoe UI", 24F);
            AddProductBTN.Location = new Point(12, 97);
            AddProductBTN.Name = "AddProductBTN";
            AddProductBTN.Size = new Size(275, 62);
            AddProductBTN.TabIndex = 8;
            AddProductBTN.Text = "Agregar";
            AddProductBTN.UseVisualStyleBackColor = true;
            AddProductBTN.Click += AddProductBTN_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 24F);
            StatusLabel.Location = new Point(293, 106);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 45);
            StatusLabel.TabIndex = 9;
            // 
            // NameText
            // 
            NameText.Font = new Font("Segoe UI", 16F);
            NameText.Location = new Point(12, 55);
            NameText.Name = "NameText";
            NameText.Size = new Size(121, 36);
            NameText.TabIndex = 10;
            // 
            // UnitsText
            // 
            UnitsText.Font = new Font("Segoe UI", 16F);
            UnitsText.Location = new Point(139, 55);
            UnitsText.Name = "UnitsText";
            UnitsText.Size = new Size(121, 36);
            UnitsText.TabIndex = 11;
            // 
            // Products_Inventory_AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 161);
            Controls.Add(UnitsText);
            Controls.Add(NameText);
            Controls.Add(StatusLabel);
            Controls.Add(AddProductBTN);
            Controls.Add(PriceLabel);
            Controls.Add(PriceText);
            Controls.Add(SalesLabel);
            Controls.Add(SalesText);
            Controls.Add(UnitsLabel);
            Controls.Add(NameLabel);
            Name = "Products_Inventory_AddProduct";
            Text = "Products_Inventory_AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NameLabel;
        private Label UnitsLabel;
        private TextBox SalesText;
        private Label SalesLabel;
        private TextBox PriceText;
        private Label PriceLabel;
        private Button AddProductBTN;
        private Label StatusLabel;
        private TextBox NameText;
        private TextBox UnitsText;
    }
}
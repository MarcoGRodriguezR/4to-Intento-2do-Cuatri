using Integradora.Products.Manager;

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
            AddProductBTN = new Button();
            RemoveProductBTN = new Button();
            ModifyUnitsBTN = new Button();
            ModPriceBTN = new Button();
            ModNameBTN = new Button();
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
            // AddProductBTN
            // 
            AddProductBTN.Font = new Font("Segoe UI", 16F);
            AddProductBTN.Location = new Point(12, 212);
            AddProductBTN.Name = "AddProductBTN";
            AddProductBTN.Size = new Size(210, 40);
            AddProductBTN.TabIndex = 3;
            AddProductBTN.Text = "Añadir Producto";
            AddProductBTN.UseVisualStyleBackColor = true;
            AddProductBTN.Click += AddProductBTN_Click;
            // 
            // RemoveProductBTN
            // 
            RemoveProductBTN.Font = new Font("Segoe UI", 16F);
            RemoveProductBTN.Location = new Point(228, 212);
            RemoveProductBTN.Name = "RemoveProductBTN";
            RemoveProductBTN.Size = new Size(210, 40);
            RemoveProductBTN.TabIndex = 4;
            RemoveProductBTN.Text = "Eliminar Producto";
            RemoveProductBTN.UseVisualStyleBackColor = true;
            RemoveProductBTN.Click += RemoveProductBTN_Click;
            // 
            // ModifyUnitsBTN
            // 
            ModifyUnitsBTN.Font = new Font("Segoe UI", 16F);
            ModifyUnitsBTN.Location = new Point(503, 50);
            ModifyUnitsBTN.Name = "ModifyUnitsBTN";
            ModifyUnitsBTN.Size = new Size(210, 40);
            ModifyUnitsBTN.TabIndex = 5;
            ModifyUnitsBTN.Text = "Modificar Unidades";
            ModifyUnitsBTN.UseVisualStyleBackColor = true;
            ModifyUnitsBTN.Click += ModifyUnitsBTN_Click;
            // 
            // ModPriceBTN
            // 
            ModPriceBTN.Font = new Font("Segoe UI", 16F);
            ModPriceBTN.Location = new Point(503, 96);
            ModPriceBTN.Name = "ModPriceBTN";
            ModPriceBTN.Size = new Size(210, 40);
            ModPriceBTN.TabIndex = 6;
            ModPriceBTN.Text = "Modificar Precio";
            ModPriceBTN.UseVisualStyleBackColor = true;
            ModPriceBTN.Click += ModPriceBTN_Click;
            // 
            // ModNameBTN
            // 
            ModNameBTN.Font = new Font("Segoe UI", 16F);
            ModNameBTN.Location = new Point(503, 142);
            ModNameBTN.Name = "ModNameBTN";
            ModNameBTN.Size = new Size(210, 40);
            ModNameBTN.TabIndex = 7;
            ModNameBTN.Text = "Modificar Nombre";
            ModNameBTN.UseVisualStyleBackColor = true;
            ModNameBTN.Click += ModNameBTN_Click;
            // 
            // Products_Inventory_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModNameBTN);
            Controls.Add(ModPriceBTN);
            Controls.Add(ModifyUnitsBTN);
            Controls.Add(RemoveProductBTN);
            Controls.Add(AddProductBTN);
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
        /// What stores all the <see cref="Products_Manager.Product"/> in a easy to manage way
        /// </summary>
        private ComboBox ProductsCMBOX;
        /// <summary>
        /// The <see cref="Label"/> use to indicate what <see cref="ProductsCMBOX"/> does
        /// </summary>
        private Label ProductLBL;
        /// <summary>
        /// The Main text area that displays the information of the current <see cref="Products_Manager.Product"/> selected in <see cref="ProductsCMBOX"/>
        /// </summary>
        private RichTextBox MainText;
        private Button AddProductBTN;
        private Button RemoveProductBTN;
        private Button ModifyUnitsBTN;
        private Button ModPriceBTN;
        private Button ModNameBTN;
    }
}
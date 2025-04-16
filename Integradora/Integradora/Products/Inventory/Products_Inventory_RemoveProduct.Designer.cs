namespace Integrator.Products.Inventory
{
    partial class Products_Inventory_RemoveProduct
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
            RemoveProductBTN = new Button();
            ProductsCOMBOX = new ComboBox();
            StatusLBL = new Label();
            SuspendLayout();
            // 
            // RemoveProductBTN
            // 
            RemoveProductBTN.Font = new Font("Segoe UI", 24F);
            RemoveProductBTN.Location = new Point(12, 86);
            RemoveProductBTN.Name = "RemoveProductBTN";
            RemoveProductBTN.Size = new Size(315, 62);
            RemoveProductBTN.TabIndex = 9;
            RemoveProductBTN.Text = "Eliminar";
            RemoveProductBTN.UseVisualStyleBackColor = true;
            RemoveProductBTN.Click += RemoveProductBTN_Click;
            // 
            // ProductsCOMBOX
            // 
            ProductsCOMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductsCOMBOX.Font = new Font("Segoe UI", 16F);
            ProductsCOMBOX.FormattingEnabled = true;
            ProductsCOMBOX.Location = new Point(12, 42);
            ProductsCOMBOX.Name = "ProductsCOMBOX";
            ProductsCOMBOX.Size = new Size(315, 38);
            ProductsCOMBOX.TabIndex = 10;
            // 
            // StatusLBL
            // 
            StatusLBL.AutoSize = true;
            StatusLBL.Font = new Font("Segoe UI", 16F);
            StatusLBL.Location = new Point(12, 9);
            StatusLBL.Name = "StatusLBL";
            StatusLBL.Size = new Size(315, 30);
            StatusLBL.TabIndex = 11;
            StatusLBL.Text = "Eliga un producto para eliminar";
            // 
            // Products_Inventory_RemoveProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 158);
            Controls.Add(StatusLBL);
            Controls.Add(ProductsCOMBOX);
            Controls.Add(RemoveProductBTN);
            Name = "Products_Inventory_RemoveProduct";
            Text = "Products_Inventory_RemoveProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveProductBTN;
        private ComboBox ProductsCOMBOX;
        private Label StatusLBL;
    }
}
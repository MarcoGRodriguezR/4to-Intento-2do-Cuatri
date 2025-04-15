namespace Integradora.Electronics.Inventory
{
    partial class Electronics_Capacitor_AddElement
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
            UnitsTXT = new TextBox();
            NameTXT = new TextBox();
            AddResistanceBTN = new Button();
            PriceLBL = new Label();
            PriceTXT = new TextBox();
            SalesLBL = new Label();
            SalesTXT = new TextBox();
            UnitsLBL = new Label();
            NameLBL = new Label();
            CapacitanceTXT = new TextBox();
            CapacitanceLBL = new Label();
            StatusLBL = new Label();
            SuspendLayout();
            // 
            // UnitsTXT
            // 
            UnitsTXT.Font = new Font("Segoe UI", 16F);
            UnitsTXT.Location = new Point(139, 58);
            UnitsTXT.Name = "UnitsTXT";
            UnitsTXT.Size = new Size(121, 36);
            UnitsTXT.TabIndex = 20;
            UnitsTXT.TextChanged += UnitsTXT_TextChanged;
            // 
            // NameTXT
            // 
            NameTXT.Font = new Font("Segoe UI", 16F);
            NameTXT.Location = new Point(12, 58);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(121, 36);
            NameTXT.TabIndex = 19;
            NameTXT.TextChanged += NameTXT_TextChanged;
            // 
            // AddResistanceBTN
            // 
            AddResistanceBTN.Font = new Font("Segoe UI", 24F);
            AddResistanceBTN.Location = new Point(12, 100);
            AddResistanceBTN.Name = "AddResistanceBTN";
            AddResistanceBTN.Size = new Size(275, 62);
            AddResistanceBTN.TabIndex = 18;
            AddResistanceBTN.Text = "Agregar";
            AddResistanceBTN.UseVisualStyleBackColor = true;
            AddResistanceBTN.Click += AddResistanceBTN_Click;
            // 
            // PriceLBL
            // 
            PriceLBL.AutoSize = true;
            PriceLBL.Font = new Font("Segoe UI", 16F);
            PriceLBL.Location = new Point(393, 12);
            PriceLBL.Name = "PriceLBL";
            PriceLBL.Size = new Size(78, 30);
            PriceLBL.TabIndex = 17;
            PriceLBL.Text = "Precio:";
            // 
            // PriceTXT
            // 
            PriceTXT.Font = new Font("Segoe UI", 16F);
            PriceTXT.Location = new Point(393, 58);
            PriceTXT.Name = "PriceTXT";
            PriceTXT.Size = new Size(121, 36);
            PriceTXT.TabIndex = 16;
            PriceTXT.TextChanged += PriceTXT_TextChanged;
            // 
            // SalesLBL
            // 
            SalesLBL.AutoSize = true;
            SalesLBL.Font = new Font("Segoe UI", 16F);
            SalesLBL.Location = new Point(266, 12);
            SalesLBL.Name = "SalesLBL";
            SalesLBL.Size = new Size(82, 30);
            SalesLBL.TabIndex = 15;
            SalesLBL.Text = "Ventas:";
            // 
            // SalesTXT
            // 
            SalesTXT.Font = new Font("Segoe UI", 16F);
            SalesTXT.Location = new Point(266, 58);
            SalesTXT.Name = "SalesTXT";
            SalesTXT.Size = new Size(121, 36);
            SalesTXT.TabIndex = 14;
            SalesTXT.TextChanged += SalesTXT_TextChanged;
            // 
            // UnitsLBL
            // 
            UnitsLBL.AutoSize = true;
            UnitsLBL.Font = new Font("Segoe UI", 16F);
            UnitsLBL.Location = new Point(139, 12);
            UnitsLBL.Name = "UnitsLBL";
            UnitsLBL.Size = new Size(108, 30);
            UnitsLBL.TabIndex = 13;
            UnitsLBL.Text = "Unidades:";
            // 
            // NameLBL
            // 
            NameLBL.AutoSize = true;
            NameLBL.Font = new Font("Segoe UI", 16F);
            NameLBL.Location = new Point(12, 12);
            NameLBL.Name = "NameLBL";
            NameLBL.Size = new Size(99, 30);
            NameLBL.TabIndex = 12;
            NameLBL.Text = "Nombre:";
            // 
            // CapacitanceTXT
            // 
            CapacitanceTXT.Font = new Font("Segoe UI", 16F);
            CapacitanceTXT.Location = new Point(520, 58);
            CapacitanceTXT.Name = "CapacitanceTXT";
            CapacitanceTXT.Size = new Size(121, 36);
            CapacitanceTXT.TabIndex = 21;
            CapacitanceTXT.TextChanged += CapacitanceTXT_TextChanged;
            // 
            // CapacitanceLBL
            // 
            CapacitanceLBL.AutoSize = true;
            CapacitanceLBL.Font = new Font("Segoe UI", 16F);
            CapacitanceLBL.Location = new Point(520, 12);
            CapacitanceLBL.Name = "CapacitanceLBL";
            CapacitanceLBL.Size = new Size(122, 30);
            CapacitanceLBL.TabIndex = 22;
            CapacitanceLBL.Text = "Capacitancia:";
            // 
            // StatusLBL
            // 
            StatusLBL.AutoSize = true;
            StatusLBL.Font = new Font("Segoe UI", 16F);
            StatusLBL.Location = new Point(293, 121);
            StatusLBL.Name = "StatusLBL";
            StatusLBL.Size = new Size(61, 30);
            StatusLBL.TabIndex = 23;
            StatusLBL.Text = "Error";
            // 
            // Electronics_Resistance_AddElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 170);
            Controls.Add(StatusLBL);
            Controls.Add(CapacitanceLBL);
            Controls.Add(CapacitanceTXT);
            Controls.Add(UnitsTXT);
            Controls.Add(NameTXT);
            Controls.Add(AddResistanceBTN);
            Controls.Add(PriceLBL);
            Controls.Add(PriceTXT);
            Controls.Add(SalesLBL);
            Controls.Add(SalesTXT);
            Controls.Add(UnitsLBL);
            Controls.Add(NameLBL);
            Name = "Electronics_Resistance_AddElement";
            Text = "Electronics_Resistance_AddElemente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UnitsTXT;
        private TextBox NameTXT;
        private Button AddResistanceBTN;
        private Label PriceLBL;
        private TextBox PriceTXT;
        private Label SalesLBL;
        private TextBox SalesTXT;
        private Label UnitsLBL;
        private Label NameLBL;
        private TextBox CapacitanceTXT;
        private Label CapacitanceLBL;
        private Label StatusLBL;
    }
}
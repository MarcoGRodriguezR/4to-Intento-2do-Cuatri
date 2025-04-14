namespace Integradora.Products.Inventory
{
    partial class Products_Inventory_ModifyUnits
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
            AddUnitsLBL = new Label();
            AddUnitsBTN = new Button();
            AddUnitsTXT = new TextBox();
            CurrentProductLBL = new Label();
            SubUnitsLBL = new Label();
            SubUnitsBTN = new Button();
            SubUnitsTXT = new TextBox();
            SuspendLayout();
            // 
            // AddUnitsLBL
            // 
            AddUnitsLBL.AutoSize = true;
            AddUnitsLBL.Font = new Font("Segoe UI", 16F);
            AddUnitsLBL.Location = new Point(12, 68);
            AddUnitsLBL.Name = "AddUnitsLBL";
            AddUnitsLBL.Size = new Size(397, 30);
            AddUnitsLBL.TabIndex = 0;
            AddUnitsLBL.Text = "Ingrese las unidades que desea agregar";
            // 
            // AddUnitsBTN
            // 
            AddUnitsBTN.Font = new Font("Segoe UI", 16F);
            AddUnitsBTN.Location = new Point(12, 101);
            AddUnitsBTN.Name = "AddUnitsBTN";
            AddUnitsBTN.Size = new Size(183, 45);
            AddUnitsBTN.TabIndex = 1;
            AddUnitsBTN.Text = "Agregar";
            AddUnitsBTN.UseVisualStyleBackColor = true;
            AddUnitsBTN.Click += AddUnitsBTN_Click;
            // 
            // AddUnitsTXT
            // 
            AddUnitsTXT.Font = new Font("Segoe UI", 16F);
            AddUnitsTXT.Location = new Point(201, 105);
            AddUnitsTXT.Name = "AddUnitsTXT";
            AddUnitsTXT.Size = new Size(100, 36);
            AddUnitsTXT.TabIndex = 2;
            AddUnitsTXT.TextChanged += AddUnitsTXT_TextChanged;
            // 
            // CurrentProductLBL
            // 
            CurrentProductLBL.AutoSize = true;
            CurrentProductLBL.Font = new Font("Segoe UI", 24F);
            CurrentProductLBL.Location = new Point(12, 9);
            CurrentProductLBL.Name = "CurrentProductLBL";
            CurrentProductLBL.Size = new Size(37, 45);
            CurrentProductLBL.TabIndex = 3;
            CurrentProductLBL.Text = "e";
            // 
            // SubUnitsLBL
            // 
            SubUnitsLBL.AutoSize = true;
            SubUnitsLBL.Font = new Font("Segoe UI", 16F);
            SubUnitsLBL.Location = new Point(12, 149);
            SubUnitsLBL.Name = "SubUnitsLBL";
            SubUnitsLBL.Size = new Size(398, 30);
            SubUnitsLBL.TabIndex = 4;
            SubUnitsLBL.Text = "Ingrese las unidades que desea eliminar";
            // 
            // SubUnitsBTN
            // 
            SubUnitsBTN.Font = new Font("Segoe UI", 16F);
            SubUnitsBTN.Location = new Point(12, 182);
            SubUnitsBTN.Name = "SubUnitsBTN";
            SubUnitsBTN.Size = new Size(183, 45);
            SubUnitsBTN.TabIndex = 5;
            SubUnitsBTN.Text = "Remover";
            SubUnitsBTN.UseVisualStyleBackColor = true;
            SubUnitsBTN.Click += SubUnitsBTN_Click;
            // 
            // SubUnitsTXT
            // 
            SubUnitsTXT.Font = new Font("Segoe UI", 16F);
            SubUnitsTXT.Location = new Point(201, 186);
            SubUnitsTXT.Name = "SubUnitsTXT";
            SubUnitsTXT.Size = new Size(100, 36);
            SubUnitsTXT.TabIndex = 6;
            SubUnitsTXT.TextChanged += SubUnitsTXT_TextChanged;
            // 
            // Products_Inventory_ModifyUnits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 230);
            Controls.Add(SubUnitsTXT);
            Controls.Add(SubUnitsBTN);
            Controls.Add(SubUnitsLBL);
            Controls.Add(CurrentProductLBL);
            Controls.Add(AddUnitsTXT);
            Controls.Add(AddUnitsBTN);
            Controls.Add(AddUnitsLBL);
            Name = "Products_Inventory_ModifyUnits";
            Text = "Products_Inventory_ModifyUnits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddUnitsLBL;
        private Button AddUnitsBTN;
        private TextBox AddUnitsTXT;
        private Label CurrentProductLBL;
        private Label SubUnitsLBL;
        private Button SubUnitsBTN;
        private TextBox SubUnitsTXT;
    }
}
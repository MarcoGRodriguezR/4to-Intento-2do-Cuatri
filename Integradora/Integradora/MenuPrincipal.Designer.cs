namespace Integradora
{
    partial class MasterMind
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
            ProductsBTN = new Button();
            ElectronicsBTN = new Button();
            ErrorBTN = new Button();
            Inventory = new Button();
            SuspendLayout();
            // 
            // ProductsBTN
            // 
            ProductsBTN.Enabled = false;
            ProductsBTN.Font = new Font("Segoe UI", 16F);
            ProductsBTN.Location = new Point(12, 12);
            ProductsBTN.Name = "ProductsBTN";
            ProductsBTN.Size = new Size(138, 44);
            ProductsBTN.TabIndex = 0;
            ProductsBTN.Text = "Productos";
            ProductsBTN.UseVisualStyleBackColor = true;
            ProductsBTN.Click += ProductsBTN_Click;
            // 
            // ElectronicsBTN
            // 
            ElectronicsBTN.Font = new Font("Segoe UI", 16F);
            ElectronicsBTN.Location = new Point(156, 12);
            ElectronicsBTN.Name = "ElectronicsBTN";
            ElectronicsBTN.Size = new Size(138, 44);
            ElectronicsBTN.TabIndex = 1;
            ElectronicsBTN.Text = "Electronicos";
            ElectronicsBTN.UseVisualStyleBackColor = true;
            ElectronicsBTN.Click += ElectronicsBTN_Click;
            // 
            // ErrorBTN
            // 
            ErrorBTN.Font = new Font("Segoe UI", 16F);
            ErrorBTN.Location = new Point(300, 12);
            ErrorBTN.Name = "ErrorBTN";
            ErrorBTN.Size = new Size(138, 44);
            ErrorBTN.TabIndex = 2;
            ErrorBTN.Text = "Error";
            ErrorBTN.UseVisualStyleBackColor = true;
            ErrorBTN.Click += Error_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Segoe UI", 24F);
            Inventory.Location = new Point(12, 85);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(201, 59);
            Inventory.TabIndex = 3;
            Inventory.Text = "Inventario";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inventory);
            Controls.Add(ErrorBTN);
            Controls.Add(ElectronicsBTN);
            Controls.Add(ProductsBTN);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button ProductsBTN;
        private Button ElectronicsBTN;
        private Button ErrorBTN;
        private Button Inventory;
    }
}

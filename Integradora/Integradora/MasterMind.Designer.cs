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
            InventoryBTN = new Button();
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
            // InventoryBTN
            // 
            InventoryBTN.Font = new Font("Segoe UI", 24F);
            InventoryBTN.Location = new Point(12, 85);
            InventoryBTN.Name = "InventoryBTN";
            InventoryBTN.Size = new Size(201, 59);
            InventoryBTN.TabIndex = 3;
            InventoryBTN.Text = "Inventario";
            InventoryBTN.UseVisualStyleBackColor = true;
            InventoryBTN.Click += InventoryBTN_Click;
            // 
            // MasterMind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InventoryBTN);
            Controls.Add(ErrorBTN);
            Controls.Add(ElectronicsBTN);
            Controls.Add(ProductsBTN);
            Name = "MasterMind";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button ProductsBTN;
        private Button ElectronicsBTN;
        private Button ErrorBTN;
        private Button InventoryBTN;
    }
}

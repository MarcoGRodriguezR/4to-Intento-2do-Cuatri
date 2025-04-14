namespace Integradora.Products.Inventory
{
    partial class Products_Inventory_ModifyName
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
            OvrNameLBL = new Label();
            OvrNameBTN = new Button();
            OvrNameTXT = new TextBox();
            SuspendLayout();
            // 
            // CurrentProductLBL
            // 
            CurrentProductLBL.AutoSize = true;
            CurrentProductLBL.Font = new Font("Segoe UI", 24F);
            CurrentProductLBL.Location = new Point(12, 9);
            CurrentProductLBL.Name = "CurrentProductLBL";
            CurrentProductLBL.Size = new Size(105, 45);
            CurrentProductLBL.TabIndex = 1;
            CurrentProductLBL.Text = "label1";
            // 
            // OvrNameLBL
            // 
            OvrNameLBL.AutoSize = true;
            OvrNameLBL.Font = new Font("Segoe UI", 16F);
            OvrNameLBL.Location = new Point(12, 54);
            OvrNameLBL.Name = "OvrNameLBL";
            OvrNameLBL.Size = new Size(419, 30);
            OvrNameLBL.TabIndex = 5;
            OvrNameLBL.Text = "Escriba el nuevo nombre para el producto";
            // 
            // OvrNameBTN
            // 
            OvrNameBTN.Font = new Font("Segoe UI", 16F);
            OvrNameBTN.Location = new Point(12, 87);
            OvrNameBTN.Name = "OvrNameBTN";
            OvrNameBTN.Size = new Size(183, 45);
            OvrNameBTN.TabIndex = 6;
            OvrNameBTN.Text = "Modificar";
            OvrNameBTN.UseVisualStyleBackColor = true;
            OvrNameBTN.Click += OvrNameBTN_Click;
            // 
            // OvrNameTXT
            // 
            OvrNameTXT.Font = new Font("Segoe UI", 16F);
            OvrNameTXT.Location = new Point(201, 91);
            OvrNameTXT.Name = "OvrNameTXT";
            OvrNameTXT.Size = new Size(230, 36);
            OvrNameTXT.TabIndex = 7;
            OvrNameTXT.TextChanged += OvrNameTXT_TextChanged;
            // 
            // Products_Inventory_ModifyName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 136);
            Controls.Add(OvrNameTXT);
            Controls.Add(OvrNameBTN);
            Controls.Add(OvrNameLBL);
            Controls.Add(CurrentProductLBL);
            Name = "Products_Inventory_ModifyName";
            Text = "Products_Inventory_ModifyName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentProductLBL;
        private Label OvrNameLBL;
        private Button OvrNameBTN;
        private TextBox OvrNameTXT;
    }
}
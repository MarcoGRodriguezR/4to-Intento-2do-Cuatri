namespace Integradora.Electronics.Inventory
{
    partial class Electronics_Generic_ModifyPrice
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
            OvrPriceLBL = new Label();
            OvrPriceTXT = new TextBox();
            OvrPriceBTN = new Button();
            CurrentElectronicLBL = new Label();
            SuspendLayout();
            // 
            // OvrPriceLBL
            // 
            OvrPriceLBL.AutoSize = true;
            OvrPriceLBL.Font = new Font("Segoe UI", 16F);
            OvrPriceLBL.Location = new Point(12, 62);
            OvrPriceLBL.Name = "OvrPriceLBL";
            OvrPriceLBL.Size = new Size(551, 30);
            OvrPriceLBL.TabIndex = 8;
            OvrPriceLBL.Text = "Ingrese el precio (en numero) a establecer como precio";
            // 
            // OvrPriceTXT
            // 
            OvrPriceTXT.Font = new Font("Segoe UI", 16F);
            OvrPriceTXT.Location = new Point(201, 99);
            OvrPriceTXT.Name = "OvrPriceTXT";
            OvrPriceTXT.Size = new Size(100, 36);
            OvrPriceTXT.TabIndex = 7;
            OvrPriceTXT.TextChanged += OvrPriceTXT_TextChanged;
            // 
            // OvrPriceBTN
            // 
            OvrPriceBTN.Font = new Font("Segoe UI", 16F);
            OvrPriceBTN.Location = new Point(12, 95);
            OvrPriceBTN.Name = "OvrPriceBTN";
            OvrPriceBTN.Size = new Size(183, 45);
            OvrPriceBTN.TabIndex = 6;
            OvrPriceBTN.Text = "Modificar";
            OvrPriceBTN.UseVisualStyleBackColor = true;
            OvrPriceBTN.Click += OvrPriceBTN_Click;
            // 
            // CurrentElectronicLBL
            // 
            CurrentElectronicLBL.AutoSize = true;
            CurrentElectronicLBL.Font = new Font("Segoe UI", 24F);
            CurrentElectronicLBL.Location = new Point(12, 17);
            CurrentElectronicLBL.Name = "CurrentElectronicLBL";
            CurrentElectronicLBL.Size = new Size(105, 45);
            CurrentElectronicLBL.TabIndex = 5;
            CurrentElectronicLBL.Text = "label1";
            // 
            // Electronics_Generic_ModifyPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 154);
            Controls.Add(OvrPriceLBL);
            Controls.Add(OvrPriceTXT);
            Controls.Add(OvrPriceBTN);
            Controls.Add(CurrentElectronicLBL);
            Name = "Electronics_Generic_ModifyPrice";
            Text = "Elecetronics_Generic_ModifyPrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OvrPriceLBL;
        private TextBox OvrPriceTXT;
        private Button OvrPriceBTN;
        private Label CurrentElectronicLBL;
    }
}
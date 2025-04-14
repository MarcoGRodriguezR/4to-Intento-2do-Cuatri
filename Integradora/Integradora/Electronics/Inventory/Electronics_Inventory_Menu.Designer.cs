namespace Integradora.Electronics.Inventory
{
    partial class Electronics_Inventory_Menu
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
            ElectronicTypesLBL = new Label();
            ElectronicTypesCMBOX = new ComboBox();
            ElectronicsLBL = new Label();
            ElectronicsCMBOX = new ComboBox();
            MainText = new RichTextBox();
            SuspendLayout();
            // 
            // ElectronicTypesLBL
            // 
            ElectronicTypesLBL.AutoSize = true;
            ElectronicTypesLBL.Font = new Font("Segoe UI", 16F);
            ElectronicTypesLBL.Location = new Point(12, 9);
            ElectronicTypesLBL.Name = "ElectronicTypesLBL";
            ElectronicTypesLBL.Size = new Size(199, 30);
            ElectronicTypesLBL.TabIndex = 0;
            ElectronicTypesLBL.Text = "Tipo de Electronico";
            // 
            // ElectronicTypesCMBOX
            // 
            ElectronicTypesCMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ElectronicTypesCMBOX.Font = new Font("Segoe UI", 16F);
            ElectronicTypesCMBOX.FormattingEnabled = true;
            ElectronicTypesCMBOX.Location = new Point(217, 6);
            ElectronicTypesCMBOX.Name = "ElectronicTypesCMBOX";
            ElectronicTypesCMBOX.Size = new Size(280, 38);
            ElectronicTypesCMBOX.TabIndex = 1;
            ElectronicTypesCMBOX.SelectedIndexChanged += ElectronicTypeCMBOX_SelectedIndexChanged;
            // 
            // ElectronicsLBL
            // 
            ElectronicsLBL.AutoSize = true;
            ElectronicsLBL.Font = new Font("Segoe UI", 16F);
            ElectronicsLBL.Location = new Point(10, 58);
            ElectronicsLBL.Name = "ElectronicsLBL";
            ElectronicsLBL.Size = new Size(67, 30);
            ElectronicsLBL.TabIndex = 2;
            ElectronicsLBL.Text = "Hmm";
            // 
            // ElectronicsCMBOX
            // 
            ElectronicsCMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ElectronicsCMBOX.Font = new Font("Segoe UI", 16F);
            ElectronicsCMBOX.FormattingEnabled = true;
            ElectronicsCMBOX.Location = new Point(83, 55);
            ElectronicsCMBOX.Name = "ElectronicsCMBOX";
            ElectronicsCMBOX.Size = new Size(233, 38);
            ElectronicsCMBOX.TabIndex = 3;
            ElectronicsCMBOX.SelectedIndexChanged += ElectronicsCMBOX_SelectedIndexChanged;
            // 
            // MainText
            // 
            MainText.Enabled = false;
            MainText.Font = new Font("Segoe UI", 16F);
            MainText.ForeColor = SystemColors.WindowFrame;
            MainText.Location = new Point(12, 99);
            MainText.Name = "MainText";
            MainText.Size = new Size(485, 156);
            MainText.TabIndex = 4;
            MainText.Text = "";
            // 
            // Electronics_Inventory_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainText);
            Controls.Add(ElectronicsCMBOX);
            Controls.Add(ElectronicsLBL);
            Controls.Add(ElectronicTypesCMBOX);
            Controls.Add(ElectronicTypesLBL);
            Name = "Electronics_Inventory_Menu";
            Text = "Electronics_Inventory_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ElectronicTypesLBL;
        private ComboBox ElectronicTypesCMBOX;
        private Label ElectronicsLBL;
        private ComboBox ElectronicsCMBOX;
        private RichTextBox MainText;
    }
}
namespace Integrator.Electronics.Inventory
{
    partial class Electronics_Generic_RemElement
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
            StatusLBL = new Label();
            ElectronicsCOMBOX = new ComboBox();
            RemoveElectronicBTN = new Button();
            SuspendLayout();
            // 
            // StatusLBL
            // 
            StatusLBL.AutoSize = true;
            StatusLBL.Font = new Font("Segoe UI", 16F);
            StatusLBL.Location = new Point(12, 9);
            StatusLBL.Name = "StatusLBL";
            StatusLBL.Size = new Size(315, 30);
            StatusLBL.TabIndex = 14;
            StatusLBL.Text = "Eliga un producto para eliminar";
            // 
            // ElectronicsCOMBOX
            // 
            ElectronicsCOMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ElectronicsCOMBOX.Font = new Font("Segoe UI", 16F);
            ElectronicsCOMBOX.FormattingEnabled = true;
            ElectronicsCOMBOX.Location = new Point(12, 42);
            ElectronicsCOMBOX.Name = "ElectronicsCOMBOX";
            ElectronicsCOMBOX.Size = new Size(315, 38);
            ElectronicsCOMBOX.TabIndex = 13;
            // 
            // RemoveElectronicBTN
            // 
            RemoveElectronicBTN.Font = new Font("Segoe UI", 24F);
            RemoveElectronicBTN.Location = new Point(12, 86);
            RemoveElectronicBTN.Name = "RemoveElectronicBTN";
            RemoveElectronicBTN.Size = new Size(315, 62);
            RemoveElectronicBTN.TabIndex = 12;
            RemoveElectronicBTN.Text = "Eliminar";
            RemoveElectronicBTN.UseVisualStyleBackColor = true;
            RemoveElectronicBTN.Click += RemoveElectronicBTN_Click;
            // 
            // Electronics_Generic_RemElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 160);
            Controls.Add(StatusLBL);
            Controls.Add(ElectronicsCOMBOX);
            Controls.Add(RemoveElectronicBTN);
            Name = "Electronics_Generic_RemElement";
            Text = "Electronics_Generic_RemElement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatusLBL;
        private ComboBox ElectronicsCOMBOX;
        private Button RemoveElectronicBTN;
    }
}
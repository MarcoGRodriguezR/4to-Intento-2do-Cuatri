namespace Integrator.Electronics.Inventory
{
    partial class Electronics_Resistance_ModifyResistance
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
            OvrResistanceLBL = new Label();
            OvrResistanceTXT = new TextBox();
            OvrResistanceBTN = new Button();
            CurrentElectronicLBL = new Label();
            SuspendLayout();
            // 
            // OvrResistanceLBL
            // 
            OvrResistanceLBL.AutoSize = true;
            OvrResistanceLBL.Font = new Font("Segoe UI", 16F);
            OvrResistanceLBL.Location = new Point(12, 55);
            OvrResistanceLBL.Name = "OvrResistanceLBL";
            OvrResistanceLBL.Size = new Size(405, 30);
            OvrResistanceLBL.TabIndex = 12;
            OvrResistanceLBL.Text = "Ingrese el nuevo valor para la resistencia";
            // 
            // OvrResistanceTXT
            // 
            OvrResistanceTXT.Font = new Font("Segoe UI", 16F);
            OvrResistanceTXT.Location = new Point(201, 92);
            OvrResistanceTXT.Name = "OvrResistanceTXT";
            OvrResistanceTXT.Size = new Size(100, 36);
            OvrResistanceTXT.TabIndex = 11;
            OvrResistanceTXT.TextChanged += OvrResistanceTXT_TextChanged;
            // 
            // OvrResistanceBTN
            // 
            OvrResistanceBTN.Font = new Font("Segoe UI", 16F);
            OvrResistanceBTN.Location = new Point(12, 88);
            OvrResistanceBTN.Name = "OvrResistanceBTN";
            OvrResistanceBTN.Size = new Size(183, 45);
            OvrResistanceBTN.TabIndex = 10;
            OvrResistanceBTN.Text = "Modificar";
            OvrResistanceBTN.UseVisualStyleBackColor = true;
            OvrResistanceBTN.Click += OvrResistanceBTN_Click;
            // 
            // CurrentElectronicLBL
            // 
            CurrentElectronicLBL.AutoSize = true;
            CurrentElectronicLBL.Font = new Font("Segoe UI", 24F);
            CurrentElectronicLBL.Location = new Point(12, 10);
            CurrentElectronicLBL.Name = "CurrentElectronicLBL";
            CurrentElectronicLBL.Size = new Size(105, 45);
            CurrentElectronicLBL.TabIndex = 9;
            CurrentElectronicLBL.Text = "label1";
            // 
            // Electronics_Resistance_ModifyResistance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 140);
            Controls.Add(OvrResistanceLBL);
            Controls.Add(OvrResistanceTXT);
            Controls.Add(OvrResistanceBTN);
            Controls.Add(CurrentElectronicLBL);
            Name = "Electronics_Resistance_ModifyResistance";
            Text = "Electronics_Resistance_ModifyResistance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OvrResistanceLBL;
        private TextBox OvrResistanceTXT;
        private Button OvrResistanceBTN;
        private Label CurrentElectronicLBL;
    }
}
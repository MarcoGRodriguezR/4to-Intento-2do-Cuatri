namespace Integrator.Electronics.Inventory
{
    partial class Electronics_Capacitor_ModifyCapacitance
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
            OverrrideLBL = new Label();
            OverrideTXT = new TextBox();
            OverrideBTN = new Button();
            CurrentElectronicLBL = new Label();
            SuspendLayout();
            // 
            // OverrrideLBL
            // 
            OverrrideLBL.AutoSize = true;
            OverrrideLBL.Font = new Font("Segoe UI", 16F);
            OverrrideLBL.Location = new Point(12, 59);
            OverrrideLBL.Name = "OverrrideLBL";
            OverrrideLBL.Size = new Size(405, 30);
            OverrrideLBL.TabIndex = 16;
            OverrrideLBL.Text = "Ingrese el nuevo valor para la resistencia";
            // 
            // OverrideTXT
            // 
            OverrideTXT.Font = new Font("Segoe UI", 16F);
            OverrideTXT.Location = new Point(201, 96);
            OverrideTXT.Name = "OverrideTXT";
            OverrideTXT.Size = new Size(100, 36);
            OverrideTXT.TabIndex = 15;
            OverrideTXT.TextChanged += OverrideTXT_TextChanged;
            // 
            // OverrideBTN
            // 
            OverrideBTN.Font = new Font("Segoe UI", 16F);
            OverrideBTN.Location = new Point(12, 92);
            OverrideBTN.Name = "OverrideBTN";
            OverrideBTN.Size = new Size(183, 45);
            OverrideBTN.TabIndex = 14;
            OverrideBTN.Text = "Modificar";
            OverrideBTN.UseVisualStyleBackColor = true;
            OverrideBTN.Click += OverrideBTN_Click;
            // 
            // CurrentElectronicLBL
            // 
            CurrentElectronicLBL.AutoSize = true;
            CurrentElectronicLBL.Font = new Font("Segoe UI", 24F);
            CurrentElectronicLBL.Location = new Point(12, 14);
            CurrentElectronicLBL.Name = "CurrentElectronicLBL";
            CurrentElectronicLBL.Size = new Size(105, 45);
            CurrentElectronicLBL.TabIndex = 13;
            CurrentElectronicLBL.Text = "label1";
            // 
            // Electronics_Capacitor_ModifyCapacitance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 144);
            Controls.Add(OverrrideLBL);
            Controls.Add(OverrideTXT);
            Controls.Add(OverrideBTN);
            Controls.Add(CurrentElectronicLBL);
            Name = "Electronics_Capacitor_ModifyCapacitance";
            Text = "Electronics_Capacitor_ModifyCapacitance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OverrrideLBL;
        private TextBox OverrideTXT;
        private Button OverrideBTN;
        private Label CurrentElectronicLBL;
    }
}
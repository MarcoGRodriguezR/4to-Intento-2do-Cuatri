namespace Integrator.Electronics.Inventory
{
    partial class Electronics_Generic_ModifyUnits
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
            SubUnitsTXT = new TextBox();
            SubUnitsBTN = new Button();
            SubUnitsLBL = new Label();
            CurrentElemenLBL = new Label();
            AddUnitsTXT = new TextBox();
            AddUnitsBTN = new Button();
            AddUnitsLBL = new Label();
            SuspendLayout();
            // 
            // SubUnitsTXT
            // 
            SubUnitsTXT.Font = new Font("Segoe UI", 16F);
            SubUnitsTXT.Location = new Point(201, 186);
            SubUnitsTXT.Name = "SubUnitsTXT";
            SubUnitsTXT.Size = new Size(100, 36);
            SubUnitsTXT.TabIndex = 13;
            SubUnitsTXT.TextChanged += SubUnitsTXT_TextChanged;
            // 
            // SubUnitsBTN
            // 
            SubUnitsBTN.Font = new Font("Segoe UI", 16F);
            SubUnitsBTN.Location = new Point(12, 182);
            SubUnitsBTN.Name = "SubUnitsBTN";
            SubUnitsBTN.Size = new Size(183, 45);
            SubUnitsBTN.TabIndex = 12;
            SubUnitsBTN.Text = "Remover";
            SubUnitsBTN.UseVisualStyleBackColor = true;
            SubUnitsBTN.Click += SubUnitsBTN_Click;
            // 
            // SubUnitsLBL
            // 
            SubUnitsLBL.AutoSize = true;
            SubUnitsLBL.Font = new Font("Segoe UI", 16F);
            SubUnitsLBL.Location = new Point(12, 149);
            SubUnitsLBL.Name = "SubUnitsLBL";
            SubUnitsLBL.Size = new Size(398, 30);
            SubUnitsLBL.TabIndex = 11;
            SubUnitsLBL.Text = "Ingrese las unidades que desea eliminar";
            // 
            // CurrentElemenLBL
            // 
            CurrentElemenLBL.AutoSize = true;
            CurrentElemenLBL.Font = new Font("Segoe UI", 24F);
            CurrentElemenLBL.Location = new Point(12, 9);
            CurrentElemenLBL.Name = "CurrentElemenLBL";
            CurrentElemenLBL.Size = new Size(37, 45);
            CurrentElemenLBL.TabIndex = 10;
            CurrentElemenLBL.Text = "e";
            // 
            // AddUnitsTXT
            // 
            AddUnitsTXT.Font = new Font("Segoe UI", 16F);
            AddUnitsTXT.Location = new Point(201, 105);
            AddUnitsTXT.Name = "AddUnitsTXT";
            AddUnitsTXT.Size = new Size(100, 36);
            AddUnitsTXT.TabIndex = 9;
            AddUnitsTXT.TextChanged += AddUnitsTXT_TextChanged;
            // 
            // AddUnitsBTN
            // 
            AddUnitsBTN.Font = new Font("Segoe UI", 16F);
            AddUnitsBTN.Location = new Point(12, 101);
            AddUnitsBTN.Name = "AddUnitsBTN";
            AddUnitsBTN.Size = new Size(183, 45);
            AddUnitsBTN.TabIndex = 8;
            AddUnitsBTN.Text = "Agregar";
            AddUnitsBTN.UseVisualStyleBackColor = true;
            AddUnitsBTN.Click += AddUnitsBTN_Click;
            // 
            // AddUnitsLBL
            // 
            AddUnitsLBL.AutoSize = true;
            AddUnitsLBL.Font = new Font("Segoe UI", 16F);
            AddUnitsLBL.Location = new Point(12, 68);
            AddUnitsLBL.Name = "AddUnitsLBL";
            AddUnitsLBL.Size = new Size(397, 30);
            AddUnitsLBL.TabIndex = 7;
            AddUnitsLBL.Text = "Ingrese las unidades que desea agregar";
            // 
            // Electronics_Generic_ModifyUnits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubUnitsTXT);
            Controls.Add(SubUnitsBTN);
            Controls.Add(SubUnitsLBL);
            Controls.Add(CurrentElemenLBL);
            Controls.Add(AddUnitsTXT);
            Controls.Add(AddUnitsBTN);
            Controls.Add(AddUnitsLBL);
            NameToUse = "Electronics_Generic_ModifyUnits";
            Text = "Electronics_Generic_ModifyUnits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubUnitsTXT;
        private Button SubUnitsBTN;
        private Label SubUnitsLBL;
        private Label CurrentElemenLBL;
        private TextBox AddUnitsTXT;
        private Button AddUnitsBTN;
        private Label AddUnitsLBL;
    }
}
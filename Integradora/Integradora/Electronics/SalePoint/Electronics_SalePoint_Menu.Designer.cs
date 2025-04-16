namespace Integrator.Electronics.SalePoint
{
    partial class Electronics_SalePoint_Menu
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
            ElementsCOMBOX = new ComboBox();
            SectionsCOMBOX = new ComboBox();
            SuspendLayout();
            // 
            // ElementsCOMBOX
            // 
            ElementsCOMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            ElementsCOMBOX.Font = new Font("Segoe UI", 16F);
            ElementsCOMBOX.FormattingEnabled = true;
            ElementsCOMBOX.Location = new Point(12, 56);
            ElementsCOMBOX.Name = "ElementsCOMBOX";
            ElementsCOMBOX.Size = new Size(440, 38);
            ElementsCOMBOX.TabIndex = 1;
            // 
            // SectionsCOMBOX
            // 
            SectionsCOMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionsCOMBOX.Font = new Font("Segoe UI", 16F);
            SectionsCOMBOX.FormattingEnabled = true;
            SectionsCOMBOX.Location = new Point(12, 12);
            SectionsCOMBOX.Name = "SectionsCOMBOX";
            SectionsCOMBOX.Size = new Size(440, 38);
            SectionsCOMBOX.TabIndex = 2;
            SectionsCOMBOX.SelectedIndexChanged += SectionsCOMBOX_SelectedIndexChanged;
            // 
            // Electronics_SalePoint_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(SectionsCOMBOX);
            Controls.Add(ElementsCOMBOX);
            Name = "Electronics_SalePoint_Menu";
            Text = "Electronics_SalePoint_Menu";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ElementsCOMBOX;
        private ComboBox SectionsCOMBOX;
    }
}
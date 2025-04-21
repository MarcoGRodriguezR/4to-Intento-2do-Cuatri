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
            MainTable = new TableLayoutPanel();
            AddElementBTN = new Button();
            TotalAmoutTextLBL = new Label();
            ActualTotalPriceLBL = new Label();
            ResetTableBTN = new Button();
            PayUpBTN = new Button();
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
            // MainTable
            // 
            MainTable.ColumnCount = 3;
            MainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.4964542F));
            MainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.50355F));
            MainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainTable.Location = new Point(12, 186);
            MainTable.Name = "MainTable";
            MainTable.RowCount = 1;
            MainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 58.064518F));
            MainTable.Size = new Size(303, 62);
            MainTable.TabIndex = 3;
            // 
            // AddElementBTN
            // 
            AddElementBTN.Font = new Font("Segoe UI", 16F);
            AddElementBTN.Location = new Point(458, 55);
            AddElementBTN.Name = "AddElementBTN";
            AddElementBTN.Size = new Size(271, 38);
            AddElementBTN.TabIndex = 4;
            AddElementBTN.Text = "Agregar Elemento";
            AddElementBTN.UseVisualStyleBackColor = true;
            AddElementBTN.Click += AddElementBTN_Click;
            // 
            // TotalAmoutTextLBL
            // 
            TotalAmoutTextLBL.AutoSize = true;
            TotalAmoutTextLBL.Font = new Font("Segoe UI", 16F);
            TotalAmoutTextLBL.Location = new Point(12, 128);
            TotalAmoutTextLBL.Name = "TotalAmoutTextLBL";
            TotalAmoutTextLBL.Size = new Size(136, 30);
            TotalAmoutTextLBL.TabIndex = 5;
            TotalAmoutTextLBL.Text = "Total a Pagar";
            // 
            // ActualTotalPriceLBL
            // 
            ActualTotalPriceLBL.AutoSize = true;
            ActualTotalPriceLBL.Font = new Font("Segoe UI", 24F);
            ActualTotalPriceLBL.Location = new Point(366, 116);
            ActualTotalPriceLBL.Name = "ActualTotalPriceLBL";
            ActualTotalPriceLBL.Size = new Size(86, 45);
            ActualTotalPriceLBL.TabIndex = 6;
            ActualTotalPriceLBL.Text = "$?.??";
            ActualTotalPriceLBL.TextAlign = ContentAlignment.TopRight;
            // 
            // ResetTableBTN
            // 
            ResetTableBTN.Font = new Font("Segoe UI", 16F);
            ResetTableBTN.Location = new Point(321, 186);
            ResetTableBTN.Name = "ResetTableBTN";
            ResetTableBTN.Size = new Size(271, 38);
            ResetTableBTN.TabIndex = 7;
            ResetTableBTN.Text = "Reiniciar";
            ResetTableBTN.UseVisualStyleBackColor = true;
            ResetTableBTN.Click += ResetTableBTN_Click;
            // 
            // PayUpBTN
            // 
            PayUpBTN.Font = new Font("Segoe UI", 24F);
            PayUpBTN.Location = new Point(458, 109);
            PayUpBTN.Name = "PayUpBTN";
            PayUpBTN.Size = new Size(207, 58);
            PayUpBTN.TabIndex = 8;
            PayUpBTN.Text = "Pagar";
            PayUpBTN.UseVisualStyleBackColor = true;
            PayUpBTN.Click += PayUpBTN_Click;
            // 
            // Electronics_SalePoint_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(PayUpBTN);
            Controls.Add(ResetTableBTN);
            Controls.Add(ActualTotalPriceLBL);
            Controls.Add(TotalAmoutTextLBL);
            Controls.Add(AddElementBTN);
            Controls.Add(MainTable);
            Controls.Add(SectionsCOMBOX);
            Controls.Add(ElementsCOMBOX);
            Name = "Electronics_SalePoint_Menu";
            Text = "Electronics_SalePoint_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ElementsCOMBOX;
        private ComboBox SectionsCOMBOX;
        private TableLayoutPanel MainTable;
        private Button AddElementBTN;
        private Label TotalAmoutTextLBL;
        private Label ActualTotalPriceLBL;
        private Button ResetTableBTN;
        private Button PayUpBTN;
    }
}
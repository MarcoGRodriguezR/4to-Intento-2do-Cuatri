namespace Integrator
{
    partial class LoadingScreenBecauseWeDefinitelyNeedThat
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
            Status = new Label();
            Progress = new ProgressBar();
            SuspendLayout();
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 32F);
            Status.Location = new Point(12, 9);
            Status.Name = "Status";
            Status.Size = new Size(137, 59);
            Status.TabIndex = 0;
            Status.Text = "label1";
            // 
            // Progress
            // 
            Progress.Location = new Point(12, 71);
            Progress.Name = "Progress";
            Progress.Size = new Size(457, 35);
            Progress.TabIndex = 1;
            // 
            // LoadingScreenBecauseWeDefinitelyNeedThat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 119);
            Controls.Add(Progress);
            Controls.Add(Status);
            Name = "LoadingScreenBecauseWeDefinitelyNeedThat";
            Text = "PantallaDeCarga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Status;
        private ProgressBar Progress;
    }
}
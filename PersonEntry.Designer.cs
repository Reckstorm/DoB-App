namespace DoB_App
{
    partial class PersonEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IDVal_lb = new Label();
            FNameVal_lb = new Label();
            LNameVal_lb = new Label();
            DoBVal_lb = new Label();
            SuspendLayout();
            // 
            // IDVal_lb
            // 
            IDVal_lb.AutoSize = true;
            IDVal_lb.Location = new Point(70, 25);
            IDVal_lb.Name = "IDVal_lb";
            IDVal_lb.Size = new Size(17, 20);
            IDVal_lb.TabIndex = 0;
            IDVal_lb.Text = "0";
            // 
            // FNameVal_lb
            // 
            FNameVal_lb.AutoSize = true;
            FNameVal_lb.Location = new Point(184, 25);
            FNameVal_lb.Name = "FNameVal_lb";
            FNameVal_lb.Size = new Size(33, 20);
            FNameVal_lb.TabIndex = 1;
            FNameVal_lb.Text = "null";
            // 
            // LNameVal_lb
            // 
            LNameVal_lb.AutoSize = true;
            LNameVal_lb.Location = new Point(349, 25);
            LNameVal_lb.Name = "LNameVal_lb";
            LNameVal_lb.Size = new Size(33, 20);
            LNameVal_lb.TabIndex = 2;
            LNameVal_lb.Text = "null";
            // 
            // DoBVal_lb
            // 
            DoBVal_lb.AutoSize = true;
            DoBVal_lb.Location = new Point(499, 25);
            DoBVal_lb.Name = "DoBVal_lb";
            DoBVal_lb.Size = new Size(33, 20);
            DoBVal_lb.TabIndex = 3;
            DoBVal_lb.Text = "null";
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DoBVal_lb);
            Controls.Add(LNameVal_lb);
            Controls.Add(FNameVal_lb);
            Controls.Add(IDVal_lb);
            Name = "PersonEntry";
            Size = new Size(675, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label IDVal_lb;
        public Label FNameVal_lb;
        public Label LNameVal_lb;
        public Label DoBVal_lb;
    }
}

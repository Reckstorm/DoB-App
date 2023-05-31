namespace DoB_App
{
    partial class PersonControl
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
            ID_lb = new Label();
            FName_lb = new Label();
            LName_lb = new Label();
            DoB_lb = new Label();
            Remove = new Button();
            Save = new Button();
            Res_lb = new Label();
            DoB_pkr = new DateTimePicker();
            LName_tb = new TextBox();
            FName_tb = new TextBox();
            IDVal_lb = new Label();
            Clear_btn = new Button();
            SuspendLayout();
            // 
            // ID_lb
            // 
            ID_lb.AutoSize = true;
            ID_lb.Location = new Point(70, 11);
            ID_lb.Name = "ID_lb";
            ID_lb.Size = new Size(24, 20);
            ID_lb.TabIndex = 0;
            ID_lb.Text = "ID";
            // 
            // FName_lb
            // 
            FName_lb.AutoSize = true;
            FName_lb.Location = new Point(205, 11);
            FName_lb.Name = "FName_lb";
            FName_lb.Size = new Size(80, 20);
            FName_lb.TabIndex = 1;
            FName_lb.Text = "First Name";
            // 
            // LName_lb
            // 
            LName_lb.AutoSize = true;
            LName_lb.Location = new Point(369, 11);
            LName_lb.Name = "LName_lb";
            LName_lb.Size = new Size(79, 20);
            LName_lb.TabIndex = 2;
            LName_lb.Text = "Last Name";
            // 
            // DoB_lb
            // 
            DoB_lb.AutoSize = true;
            DoB_lb.Location = new Point(527, 11);
            DoB_lb.Name = "DoB_lb";
            DoB_lb.Size = new Size(38, 20);
            DoB_lb.TabIndex = 3;
            DoB_lb.Text = "DoB";
            // 
            // Remove
            // 
            Remove.Location = new Point(420, 91);
            Remove.Name = "Remove";
            Remove.Size = new Size(94, 29);
            Remove.TabIndex = 4;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Save
            // 
            Save.Location = new Point(520, 91);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Res_lb
            // 
            Res_lb.AutoSize = true;
            Res_lb.ForeColor = Color.Red;
            Res_lb.Location = new Point(70, 95);
            Res_lb.Name = "Res_lb";
            Res_lb.Size = new Size(32, 20);
            Res_lb.TabIndex = 6;
            Res_lb.Text = "Res";
            // 
            // DoB_pkr
            // 
            DoB_pkr.Format = DateTimePickerFormat.Short;
            DoB_pkr.Location = new Point(499, 45);
            DoB_pkr.Name = "DoB_pkr";
            DoB_pkr.Size = new Size(115, 27);
            DoB_pkr.TabIndex = 7;
            // 
            // LName_tb
            // 
            LName_tb.Location = new Point(349, 47);
            LName_tb.Name = "LName_tb";
            LName_tb.Size = new Size(125, 27);
            LName_tb.TabIndex = 8;
            // 
            // FName_tb
            // 
            FName_tb.Location = new Point(184, 47);
            FName_tb.Name = "FName_tb";
            FName_tb.Size = new Size(125, 27);
            FName_tb.TabIndex = 9;
            // 
            // IDVal_lb
            // 
            IDVal_lb.AutoSize = true;
            IDVal_lb.Location = new Point(70, 50);
            IDVal_lb.Name = "IDVal_lb";
            IDVal_lb.Size = new Size(17, 20);
            IDVal_lb.TabIndex = 10;
            IDVal_lb.Text = "0";
            // 
            // Clear_btn
            // 
            Clear_btn.Location = new Point(320, 91);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(94, 29);
            Clear_btn.TabIndex = 11;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // PersonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Clear_btn);
            Controls.Add(IDVal_lb);
            Controls.Add(FName_tb);
            Controls.Add(LName_tb);
            Controls.Add(DoB_pkr);
            Controls.Add(Res_lb);
            Controls.Add(Save);
            Controls.Add(Remove);
            Controls.Add(DoB_lb);
            Controls.Add(LName_lb);
            Controls.Add(FName_lb);
            Controls.Add(ID_lb);
            Name = "PersonControl";
            Size = new Size(675, 135);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID_lb;
        private Label FName_lb;
        private Label LName_lb;
        private Label DoB_lb;
        private Button Remove;
        private Button Save;
        private Label Res_lb;
        private DateTimePicker DoB_pkr;
        private TextBox LName_tb;
        private TextBox FName_tb;
        private Label IDVal_lb;
        private Button Clear_btn;
    }
}

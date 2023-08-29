namespace CalendarManagemenrSystem
{
    partial class Monthly_Events_Form
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
            this.MonthList = new System.Windows.Forms.ListBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.EventList = new System.Windows.Forms.ListBox();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthList
            // 
            this.MonthList.FormattingEnabled = true;
            this.MonthList.ItemHeight = 31;
            this.MonthList.Location = new System.Drawing.Point(64, 134);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(221, 500);
            this.MonthList.TabIndex = 0;
            this.MonthList.SelectedIndexChanged += new System.EventHandler(this.MonthList_SelectedIndexChanged);
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(104, 36);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(151, 46);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "Months";
            // 
            // EventList
            // 
            this.EventList.FormattingEnabled = true;
            this.EventList.ItemHeight = 31;
            this.EventList.Location = new System.Drawing.Point(413, 134);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(656, 500);
            this.EventList.TabIndex = 2;
            this.EventList.SelectedIndexChanged += new System.EventHandler(this.EventList_SelectedIndexChanged);
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsLabel.Location = new System.Drawing.Point(692, 36);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(141, 46);
            this.EventsLabel.TabIndex = 3;
            this.EventsLabel.Text = "Events";
            this.EventsLabel.Click += new System.EventHandler(this.EventsLabel_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(723, 680);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(201, 75);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(150, 680);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(177, 75);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Monthly_Events_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 808);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.EventList);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.MonthList);
            this.Name = "Monthly_Events_Form";
            this.Text = "Monthly_Events_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MonthList;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ListBox EventList;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
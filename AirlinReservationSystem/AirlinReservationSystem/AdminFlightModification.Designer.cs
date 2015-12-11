namespace AirlinReservationSystem
{
    partial class AdminFlightModification
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
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.crewDataGrid = new System.Windows.Forms.DataGridView();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.AddCrewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteCrewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flightDataGrid
            // 
            this.flightDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGrid.Location = new System.Drawing.Point(29, 27);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.Size = new System.Drawing.Size(240, 150);
            this.flightDataGrid.TabIndex = 0;
            this.flightDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDataGrid_CellContentClick);
            // 
            // crewDataGrid
            // 
            this.crewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewDataGrid.Location = new System.Drawing.Point(410, 27);
            this.crewDataGrid.Name = "crewDataGrid";
            this.crewDataGrid.Size = new System.Drawing.Size(240, 150);
            this.crewDataGrid.TabIndex = 1;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(29, 226);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(75, 23);
            this.addFlightButton.TabIndex = 2;
            this.addFlightButton.Text = "Add";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(194, 226);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFlightButton.TabIndex = 3;
            this.deleteFlightButton.Text = "Delete";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // AddCrewButton
            // 
            this.AddCrewButton.Location = new System.Drawing.Point(410, 226);
            this.AddCrewButton.Name = "AddCrewButton";
            this.AddCrewButton.Size = new System.Drawing.Size(75, 23);
            this.AddCrewButton.TabIndex = 4;
            this.AddCrewButton.Text = "Add";
            this.AddCrewButton.UseVisualStyleBackColor = true;
            this.AddCrewButton.Click += new System.EventHandler(this.AddCrewButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteCrewButton
            // 
            this.DeleteCrewButton.Location = new System.Drawing.Point(555, 226);
            this.DeleteCrewButton.Name = "DeleteCrewButton";
            this.DeleteCrewButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCrewButton.TabIndex = 5;
            this.DeleteCrewButton.Text = "Delete";
            this.DeleteCrewButton.UseVisualStyleBackColor = true;
            this.DeleteCrewButton.Click += new System.EventHandler(this.DeleteCrewButton_Click);
            // 
            // AdminFlightModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteCrewButton);
            this.Controls.Add(this.AddCrewButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.crewDataGrid);
            this.Controls.Add(this.flightDataGrid);
            this.Name = "AdminFlightModification";
            this.Text = "AdminFlightModification";
            this.Load += new System.EventHandler(this.AdminFlightModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flightDataGrid;
        private System.Windows.Forms.DataGridView crewDataGrid;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button AddCrewButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteCrewButton;
    }
}
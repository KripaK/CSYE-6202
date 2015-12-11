namespace AirlinReservationSystem
{
    partial class AddFlight
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
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flightDataGrid
            // 
            this.flightDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGrid.Location = new System.Drawing.Point(38, 46);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.Size = new System.Drawing.Size(253, 266);
            this.flightDataGrid.TabIndex = 0;
            this.flightDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDataGrid_CellContentClick);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(95, 346);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(134, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Add Passenger";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(342, 46);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(278, 266);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(375, 345);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(126, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Passenger";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.flightDataGrid);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flightDataGrid;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button1;
    }
}
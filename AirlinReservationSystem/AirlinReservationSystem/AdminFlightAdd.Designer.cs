namespace AirlinReservationSystem
{
    partial class AdminFlightAdd
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
            this.submitButton = new System.Windows.Forms.Button();
            this.arrivalText = new System.Windows.Forms.TextBox();
            this.destText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.flightText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.classText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carrierText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(259, 290);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // arrivalText
            // 
            this.arrivalText.Location = new System.Drawing.Point(328, 171);
            this.arrivalText.Name = "arrivalText";
            this.arrivalText.Size = new System.Drawing.Size(100, 20);
            this.arrivalText.TabIndex = 16;
            // 
            // destText
            // 
            this.destText.Location = new System.Drawing.Point(328, 136);
            this.destText.Name = "destText";
            this.destText.Size = new System.Drawing.Size(100, 20);
            this.destText.TabIndex = 15;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(328, 101);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(100, 20);
            this.dateText.TabIndex = 14;
            // 
            // flightText
            // 
            this.flightText.Location = new System.Drawing.Point(328, 69);
            this.flightText.Name = "flightText";
            this.flightText.Size = new System.Drawing.Size(100, 20);
            this.flightText.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arrival";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Flight Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Class";
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(328, 232);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(100, 20);
            this.classText.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Carrier";
            // 
            // carrierText
            // 
            this.carrierText.Location = new System.Drawing.Point(328, 204);
            this.carrierText.Name = "carrierText";
            this.carrierText.Size = new System.Drawing.Size(100, 20);
            this.carrierText.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminFlightAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carrierText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.arrivalText);
            this.Controls.Add(this.destText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.flightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminFlightAdd";
            this.Text = "AdminFlightAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox arrivalText;
        private System.Windows.Forms.TextBox destText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.TextBox flightText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carrierText;
        private System.Windows.Forms.Button button1;
    }
}
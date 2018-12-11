namespace RentPrice
{
    partial class frmRentPrice
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
            this.txtFloors = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.lblFloorLocation = new System.Windows.Forms.Label();
            this.lblNumberRooms = new System.Windows.Forms.Label();
            this.btnCalculateRooms = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFloors
            // 
            this.txtFloors.Location = new System.Drawing.Point(133, 12);
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.Size = new System.Drawing.Size(100, 20);
            this.txtFloors.TabIndex = 0;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(133, 66);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(100, 20);
            this.txtRooms.TabIndex = 1;
            // 
            // lblFloorLocation
            // 
            this.lblFloorLocation.AutoSize = true;
            this.lblFloorLocation.Location = new System.Drawing.Point(6, 12);
            this.lblFloorLocation.Name = "lblFloorLocation";
            this.lblFloorLocation.Size = new System.Drawing.Size(74, 13);
            this.lblFloorLocation.TabIndex = 2;
            this.lblFloorLocation.Text = "Floor Location";
            // 
            // lblNumberRooms
            // 
            this.lblNumberRooms.AutoSize = true;
            this.lblNumberRooms.Location = new System.Drawing.Point(9, 66);
            this.lblNumberRooms.Name = "lblNumberRooms";
            this.lblNumberRooms.Size = new System.Drawing.Size(92, 13);
            this.lblNumberRooms.TabIndex = 3;
            this.lblNumberRooms.Text = "Number of Rooms";
            // 
            // btnCalculateRooms
            // 
            this.btnCalculateRooms.Location = new System.Drawing.Point(85, 101);
            this.btnCalculateRooms.Name = "btnCalculateRooms";
            this.btnCalculateRooms.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRooms.TabIndex = 4;
            this.btnCalculateRooms.Text = "Calculate";
            this.btnCalculateRooms.UseVisualStyleBackColor = true;
            this.btnCalculateRooms.Click += new System.EventHandler(this.btnCalculateRooms_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(39, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(158, 46);
            this.lblResult.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(85, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmRentPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 265);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateRooms);
            this.Controls.Add(this.lblNumberRooms);
            this.Controls.Add(this.lblFloorLocation);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.txtFloors);
            this.Name = "frmRentPrice";
            this.Text = "Rent Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label lblFloorLocation;
        private System.Windows.Forms.Label lblNumberRooms;
        private System.Windows.Forms.Button btnCalculateRooms;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace lab2
{
    partial class RoomForm
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
            this.groupBoxKitchen = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxKitchen
            // 
            this.groupBoxKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxKitchen.Location = new System.Drawing.Point(34, 27);
            this.groupBoxKitchen.Name = "groupBoxKitchen";
            this.groupBoxKitchen.Size = new System.Drawing.Size(222, 226);
            this.groupBoxKitchen.TabIndex = 0;
            this.groupBoxKitchen.TabStop = false;
            this.groupBoxKitchen.Text = "Кухня";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(464, 527);
            this.Controls.Add(this.groupBoxKitchen);
            this.Name = "RoomForm";
            this.Text = "Информация о комнате";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitchen;
    }
}